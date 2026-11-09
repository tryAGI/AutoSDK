#!/usr/bin/env bash
# Commit and push the completion change regenerate-cli-completion.sh prepared, one repo at a time.
#
# The review is mechanical and so it is done here rather than by eye 47 times: the change must be
# exactly three paths under src/cli/<Project>/ — Program.cs, README.md and a new CliCompletion.cs — and
# nothing else. Anything more and this refuses, because then the working tree holds something that is
# not this change: a spec refresh, generated-model drift, or another agent's work.
#
# Usage: commit-cli-completion.sh [--dry-run] <SdkName>...
set -euo pipefail

PARENT="$(cd "$(dirname "${BASH_SOURCE[0]}")/../.." && pwd)"
DRY_RUN=false

if [[ "${1:-}" == "--dry-run" ]]; then
  DRY_RUN=true
  shift
fi

[[ $# -gt 0 ]] || { echo "usage: $0 [--dry-run] <SdkName>..." >&2; exit 2; }

read -r -d '' MESSAGE <<'TEXT' || true
feat(cli): shell completion for the generated CLI

`autosdk cli-project` emits a `completion` command and wires it into the
generated `Program.cs`; this CLI had not been regenerated since AutoSDK gained
that. The script is built by walking the live command tree at request time, so it
describes this CLI as assembled and cannot go stale the way a checked-in word
list would.

Produced by running only this repo's own `cli-project` invocation against the
spec already committed here, not `generate.sh`, which would re-download the spec
and mix upstream drift into the diff. Three files, with the spec and `Generated/`
untouched.

Verified: `dotnet build` succeeds and the tests pass.

Co-Authored-By: Claude Opus 5 <noreply@anthropic.com>
TEXT

committed=()
refused=()

for sdk in "$@"; do
  repo="$PARENT/$sdk"
  status="$(git -C "$repo" status --porcelain 2>/dev/null || true)"

  if [[ -z "$status" ]]; then
    echo "SKIP  $sdk: nothing to commit"
    continue
  fi

  paths="$(printf '%s\n' "$status" | awk '{print $NF}')"
  unexpected="$(printf '%s\n' "$paths" | grep -vE '^src/cli/[^/]+/(Program\.cs|README\.md|CliCompletion\.cs)$' || true)"
  if [[ -n "$unexpected" ]]; then
    echo "REFUSE $sdk: the tree holds more than the completion change:"
    printf '         %s\n' $unexpected
    refused+=("$sdk")
    continue
  fi
  if ! printf '%s\n' "$paths" | grep -q 'CliCompletion\.cs$'; then
    echo "REFUSE $sdk: no new CliCompletion.cs, so this is not the completion change"
    refused+=("$sdk")
    continue
  fi

  if [[ "$DRY_RUN" == true ]]; then
    echo "WOULD $sdk: commit $(printf '%s\n' "$paths" | wc -l | tr -d ' ') file(s) and push"
    continue
  fi

  cli_dir="$(printf '%s\n' "$paths" | sed -n '1p' | cut -d/ -f1-3)"
  if git -C "$repo" add $paths && git -C "$repo" commit -m "$MESSAGE" -- "$cli_dir" >/dev/null &&
     git -C "$repo" push origin main >/dev/null 2>&1; then
    echo "OK    $sdk: committed and pushed"
    committed+=("$sdk")
  else
    echo "FAIL  $sdk: commit or push failed; left for inspection" >&2
    refused+=("$sdk")
  fi
done

echo
echo "committed: ${#committed[@]}  refused: ${#refused[@]}"
for entry in "${refused[@]:-}"; do [[ -n "$entry" ]] && echo "  refused: $entry"; done
[[ ${#refused[@]} -eq 0 ]]
