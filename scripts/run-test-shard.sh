#!/usr/bin/env bash

set -euo pipefail

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

if ! [[ $shard_index =~ ^[0-9]+$ && $shard_count =~ ^[1-9][0-9]*$ ]]; then
  echo "Shard index and count must be non-negative integers, with a positive count." >&2
  exit 2
fi

if (( shard_index >= shard_count )); then
  echo "Shard index $shard_index is outside the $shard_count available shards." >&2
  exit 2
fi

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

filters=()
selected_tests=()
for test_index in "${!tests[@]}"; do
  if (( test_index % shard_count == shard_index )); then
    selected_tests+=("${tests[$test_index]}")
    filters+=("Name=${tests[$test_index]}")
  fi
done

if (( ${#filters[@]} == 0 )); then
  echo "Shard $shard_index has no tests." >&2
  exit 1
fi

filter=$(IFS='|'; printf '%s' "${filters[*]}")
mkdir -p "$shard_artifacts"
rm -f \
  "$shard_artifacts/membership.txt" \
  "$shard_artifacts/metadata.tsv" \
  "$shard_artifacts/results.trx"
printf '%s\n' "${selected_tests[@]}" > "$shard_artifacts/membership.txt"
printf 'key\tvalue\nproject\t%s\nshard_index\t%s\nshard_count\t%s\ndiscovered_tests\t%s\nselected_tests\t%s\n' \
  "$project" \
  "$shard_index" \
  "$shard_count" \
  "${#tests[@]}" \
  "${#selected_tests[@]}" > "$shard_artifacts/metadata.tsv"
printf 'Running shard %d of %d with %d of %d tests.\n' \
  "$((shard_index + 1))" \
  "$shard_count" \
  "${#filters[@]}" \
  "${#tests[@]}"

dotnet test "$project" \
  --configuration "$configuration" \
  --nologo \
  --logger GitHubActions \
  --logger 'trx;LogFileName=results.trx' \
  --results-directory "$shard_artifacts" \
  --no-build \
  --filter "$filter"
