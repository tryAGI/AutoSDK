#!/usr/bin/env bash
# Commit and push what enable-enum-rejection.sh prepared, one repo at a time.
#
# Enforces the shape rather than trusting it: exactly one src/libs/<Lib>/generate.sh plus any number of
# files under src/libs/<Lib>/Generated/, and nothing else. In particular the spec must be untouched —
# a changed spec means the regeneration re-downloaded it and the diff is no longer about the flag.
#
# Deliberately does NOT try to judge whether the right converters hardened. Reading intent off a
# generated type's name does not work: AI21 hardens ModifyAssistantRequestResponseLanguage, which is a
# `responseLanguage` field inside a request, so a name-based check flags it wrongly. The generator's
# own rule — request-reachable and not response-reachable — is what decides that, and it has tests.
#
# Usage: commit-enum-rejection.sh [--dry-run] <SdkName>...
set -euo pipefail

PARENT="$(cd "$(dirname "${BASH_SOURCE[0]}")/../.." && pwd)"
DRY_RUN=false

if [[ "${1:-}" == "--dry-run" ]]; then
  DRY_RUN=true
  shift
fi

[[ $# -gt 0 ]] || { echo "usage: $0 [--dry-run] <SdkName>..." >&2; exit 2; }

committed=()
refused=()

for sdk in "$@"; do
  repo="$PARENT/$sdk"

  if ! status="$(git -C "$repo" status --porcelain 2>/dev/null)"; then
    echo "REFUSE $sdk: not a git checkout"
    refused+=("$sdk (not a git checkout)")
    continue
  fi
  if [[ -z "$status" ]]; then
    echo "SKIP  $sdk: nothing to commit"
    continue
  fi

  paths="$(printf '%s\n' "$status" | awk '{print $NF}')"
  unexpected="$(printf '%s\n' "$paths" | grep -vE '^src/libs/[^/]+/(generate\.sh|Generated/)' || true)"
  if [[ -n "$unexpected" ]]; then
    echo "REFUSE $sdk: the tree holds more than the flag change:"
    printf '         %s\n' $unexpected
    refused+=("$sdk")
    continue
  fi
  if printf '%s\n' "$paths" | grep -qE 'openapi\.(json|ya?ml)$'; then
    echo "REFUSE $sdk: the spec changed, so this regeneration re-downloaded it"
    refused+=("$sdk (spec changed)")
    continue
  fi
  if ! printf '%s\n' "$paths" | grep -qE 'generate\.sh$'; then
    echo "REFUSE $sdk: generate.sh is unchanged, so the flag was not enabled"
    refused+=("$sdk (no generate.sh change)")
    continue
  fi

  converters="$(printf '%s\n' "$paths" | grep -cE '/Generated/' || true)"

  if [[ "$DRY_RUN" == true ]]; then
    echo "WOULD $sdk: commit generate.sh + $converters generated file(s) and push"
    continue
  fi

  lib_dir="$(printf '%s\n' "$paths" | grep -E 'generate\.sh$' | sed -n '1p' | xargs dirname)"
  message="feat: fail on an out-of-spec enum value instead of coercing it

The CLI passes user input straight into enum-typed options and the generated
converters read \`ToEnum(value) ?? default\`, so a typo became the alphabetically
first member rather than an error. \`generate.sh\` now passes
\`--reject-unknown-enum-values\`, and $converters converter(s) harden here.

AutoSDK applies the flag only where it can prove the value is caller input:
request-reachable and not response-reachable, with webhook and callback payloads
counted as inbound, so a status or model id the service ships ahead of the spec
still deserializes.

\`generate.sh\` also refuses to run unless the installed autosdk.cli reports
\`behavior:request-scoped-enum-rejection\`. An older CLI accepts the flag and
hardens response enums too, and asking the build what it does is fail-closed.

Verified: regenerated from the spec committed here rather than by re-running
\`generate.sh\`, which would re-download it, so the diff carries no upstream
drift; the build succeeds and the tests pass.

Co-Authored-By: Claude Opus 5 <noreply@anthropic.com>"

  if git -C "$repo" add $paths && git -C "$repo" commit -m "$message" -- "$lib_dir" >/dev/null &&
     git -C "$repo" push origin main >/dev/null 2>&1; then
    echo "OK    $sdk: committed ($converters converter(s)) and pushed"
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
