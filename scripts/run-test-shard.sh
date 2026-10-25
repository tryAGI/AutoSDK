#!/usr/bin/env bash

set -euo pipefail

shard_started_at=$SECONDS

if [[ $# -lt 3 || $# -gt 4 ]]; then
  echo "Usage: $0 <project> <zero-based-shard-index> <shard-count> [configuration]" >&2
  exit 2
fi

project=$1
shard_index=$2
shard_count=$3
configuration=${4:-Release}
artifacts_root=${TEST_SHARD_ARTIFACTS_DIR:-artifacts/test-shards}
shard_artifacts="$artifacts_root/shard-$shard_index"
timings_file=${TEST_SHARD_TIMINGS_FILE:-"$(dirname "$project")/test-timings.tsv"}

if ! [[ $shard_index =~ ^[0-9]+$ && $shard_count =~ ^[1-9][0-9]*$ ]]; then
  echo "Shard index and count must be non-negative integers, with a positive count." >&2
  exit 2
fi

if (( shard_index >= shard_count )); then
  echo "Shard index $shard_index is outside the $shard_count available shards." >&2
  exit 2
fi

python3 -m unittest discover -s scripts -p 'test_test_shards.py'

dotnet build "$project" --configuration "$configuration" --nologo

tests=()
while IFS= read -r test_name; do
  tests+=("$test_name")
done < <(
  dotnet test "$project" \
    --configuration "$configuration" \
    --nologo \
    --no-build \
    --list-tests |
    awk '
      /The following Tests are available:/ { capture = 1; next }
      capture && /^    / {
        sub(/^[[:space:]]+/, "")
        sub(/[[:space:]]+$/, "")
        print
      }
    '
)

if (( ${#tests[@]} == 0 )); then
  echo "No tests were discovered in $project." >&2
  exit 1
fi

duplicate_names=$(printf '%s\n' "${tests[@]}" | sort | uniq -d)
if [[ -n $duplicate_names ]]; then
  echo "Test names must be unique for name-based sharding. Duplicates:" >&2
  echo "$duplicate_names" >&2
  exit 1
fi

mkdir -p "$shard_artifacts"
rm -f \
  "$shard_artifacts/discovered-tests.txt" \
  "$shard_artifacts/membership.txt" \
  "$shard_artifacts/metadata.tsv" \
  "$shard_artifacts/plan.tsv" \
  "$shard_artifacts/results.trx"
printf '%s\n' "${tests[@]}" > "$shard_artifacts/discovered-tests.txt"
estimate_arguments=()
if [[ -n ${TEST_SHARD_INITIAL_ESTIMATES_FILE:-} ]]; then
  estimate_arguments+=(--initial-estimates "$TEST_SHARD_INITIAL_ESTIMATES_FILE")
fi
python3 scripts/plan-test-shards.py \
  "$shard_artifacts/discovered-tests.txt" \
  "$timings_file" \
  "$shard_count" \
  "$shard_artifacts/plan.tsv" --max-elapsed-seconds 720 --reserve-seconds 120 "${estimate_arguments[@]}"

selected_tests=()
while IFS=$'\t' read -r planned_shard _ test_name; do
  if [[ $planned_shard == "$shard_index" ]]; then
    selected_tests+=("$test_name")
  fi
done < <(sed '1d' "$shard_artifacts/plan.tsv")

if (( ${#selected_tests[@]} == 0 )); then
  echo "Shard $shard_index has no tests." >&2
  exit 1
fi

printf '%s\n' "${selected_tests[@]}" > "$shard_artifacts/membership.txt"
filter=$(python3 scripts/build-test-filter.py "$shard_artifacts/membership.txt")
printf 'key\tvalue\nproject\t%s\nshard_index\t%s\nshard_count\t%s\ndiscovered_tests\t%s\nselected_tests\t%s\n' \
  "$project" \
  "$shard_index" \
  "$shard_count" \
  "${#tests[@]}" \
  "${#selected_tests[@]}" > "$shard_artifacts/metadata.tsv"
printf 'Running shard %d of %d with %d of %d tests.\n' \
  "$((shard_index + 1))" \
  "$shard_count" \
  "${#selected_tests[@]}" \
  "${#tests[@]}"

set +e
dotnet test "$project" \
  --configuration "$configuration" \
  --nologo \
  --logger GitHubActions \
  --logger 'console;verbosity=normal' \
  --logger 'trx;LogFileName=results.trx' \
  --results-directory "$shard_artifacts" \
  --no-build \
  --filter "$filter"
test_exit_code=$?
set -e

printf 'elapsed_seconds\t%s\n' "$((SECONDS - shard_started_at))" >> "$shard_artifacts/metadata.tsv"
exit "$test_exit_code"
