#!/usr/bin/env bash
# Enable --reject-unknown-enum-values in sibling SDKs that ship a CLI.
#
# Prepares the change and proves it: patches generate.sh, regenerates, builds, runs the tests, and
# reports. It never commits and never pushes — the diff is for a person to look at, because the flag
# changes how every enum in the SDK deserializes.
#
# Order matters. Run it in small batches: each patched repo's generate.sh refuses to run until the
# installed autosdk.cli reports behavior:request-scoped-enum-rejection, so a repo patched before that
# version reaches NuGet has a red auto-update job until it does.
#
# Usage: scripts/enable-enum-rejection.sh [--dry-run] <SdkName>...
set -euo pipefail

PARENT="$(cd "$(dirname "${BASH_SOURCE[0]}")/../.." && pwd)"
CAPABILITY="behavior:request-scoped-enum-rejection"
DRY_RUN=false

if [[ "${1:-}" == "--dry-run" ]]; then
  DRY_RUN=true
  shift
fi

if [[ $# -eq 0 ]]; then
  echo "usage: $0 [--dry-run] <SdkName>..." >&2
  exit 2
fi

if ! autosdk capabilities --require "$CAPABILITY" >/dev/null 2>&1; then
  echo "error: the installed autosdk.cli does not report $CAPABILITY." >&2
  echo "       Patching repositories now would leave each one unable to regenerate." >&2
  echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
  exit 1
fi

GUARD_SOURCE="$PARENT/Runway/src/libs/Runway/generate.sh"
if [[ ! -f "$GUARD_SOURCE" ]]; then
  echo "error: cannot find the reference guard at $GUARD_SOURCE" >&2
  exit 1
fi

failed=()
skipped=()
done_list=()

for sdk in "$@"; do
  repo="$PARENT/$sdk"
  # Globbed, not assumed: the library directory is not always the repo name — tryAGI/OpenAI keeps its
  # spec under src/libs/tryAGI.OpenAI, and assuming otherwise silently skipped it.
  script=""
  for candidate in "$repo"/src/libs/*/generate.sh; do
    if [[ -f "$candidate" ]]; then
      if [[ -n "$script" ]]; then
        script="AMBIGUOUS"
        break
      fi
      script="$candidate"
    fi
  done

  if [[ "$script" == "AMBIGUOUS" ]]; then
    echo "SKIP  $sdk: more than one generate.sh; patch it by hand"
    skipped+=("$sdk (several generate.sh)")
    continue
  fi

  if [[ -z "$script" || ! -f "$script" ]]; then
    echo "SKIP  $sdk: no generate.sh under src/libs/*/"
    skipped+=("$sdk (no generate.sh)")
    continue
  fi
  if grep -q 'reject-unknown-enum-values' "$script"; then
    echo "SKIP  $sdk: already enabled"
    skipped+=("$sdk (already enabled)")
    continue
  fi
  # A dirty checkout is someone else's work in progress; never regenerate over it.
  if [[ -n "$(git -C "$repo" status --porcelain 2>/dev/null)" ]]; then
    echo "SKIP  $sdk: checkout is dirty"
    skipped+=("$sdk (dirty)")
    continue
  fi

  if [[ "$DRY_RUN" == true ]]; then
    echo "WOULD $sdk: patch $script, regenerate, build, test"
    done_list+=("$sdk (dry run)")
    continue
  fi

  echo "==> $sdk"
  if python3 "$(dirname "${BASH_SOURCE[0]}")/_patch_enum_rejection.py" "$script" "$GUARD_SOURCE"; then
    if (cd "$(dirname "$script")" && ./generate.sh >/dev/null 2>&1) &&
       (cd "$repo" && dotnet build ./*.slnx -p:UseSharedCompilation=false >/dev/null 2>&1) &&
       (cd "$repo" && dotnet test src/tests/IntegrationTests --no-build >/dev/null 2>&1); then
      echo "    ok: regenerated, built, tests pass — review and commit by hand"
      done_list+=("$sdk")
    else
      echo "    FAILED: generate/build/test — left in place for inspection" >&2
      failed+=("$sdk")
    fi
  else
    echo "    FAILED: could not patch generate.sh" >&2
    failed+=("$sdk")
  fi
done

echo
echo "prepared: ${#done_list[@]}  skipped: ${#skipped[@]}  failed: ${#failed[@]}"
for entry in "${skipped[@]:-}"; do [[ -n "$entry" ]] && echo "  skipped: $entry"; done
for entry in "${failed[@]:-}"; do [[ -n "$entry" ]] && echo "  failed:  $entry"; done
[[ ${#failed[@]} -eq 0 ]]
