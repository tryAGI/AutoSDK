#!/usr/bin/env bash
# Bring a generated CLI up to date with `autosdk cli-project`, without touching anything else.
#
# Most of these CLIs were last generated before AutoSDK emitted a `completion` command, so the next
# regeneration for any reason sweeps it in alongside. That is how it first arrived: bundled into a
# commit about enum rejection. This separates it.
#
# It runs only the `cli-project` invocation out of the repo's own generate.sh, against the spec already
# committed there. Running generate.sh instead would re-download the spec, and the diff would then carry
# upstream drift that has nothing to do with the CLI — AI21 picked up 775 changed files that way.
#
# Prepares and proves; never commits. Usage: regenerate-cli-completion.sh [--dry-run] <SdkName>...
set -euo pipefail

PARENT="$(cd "$(dirname "${BASH_SOURCE[0]}")/../.." && pwd)"
DRY_RUN=false

if [[ "${1:-}" == "--dry-run" ]]; then
  DRY_RUN=true
  shift
fi

if [[ $# -eq 0 ]]; then
  echo "usage: $0 [--dry-run] <SdkName>..." >&2
  exit 2
fi

prepared=()
skipped=()
failed=()

for sdk in "$@"; do
  repo="$PARENT/$sdk"

  script=""
  for candidate in "$repo"/src/libs/*/generate.sh; do
    [[ -f "$candidate" ]] || continue
    if [[ -n "$script" ]]; then script="AMBIGUOUS"; break; fi
    script="$candidate"
  done
  if [[ -z "$script" || "$script" == "AMBIGUOUS" ]]; then
    echo "SKIP  $sdk: no single generate.sh under src/libs/*/"
    skipped+=("$sdk (no single generate.sh)")
    continue
  fi
  if ! grep -q 'cli-project' "$script"; then
    echo "SKIP  $sdk: generate.sh does not build a CLI"
    skipped+=("$sdk (no CLI)")
    continue
  fi
  if ! repo_status="$(git -C "$repo" status --porcelain 2>/dev/null)"; then
    echo "SKIP  $sdk: not a git checkout"
    skipped+=("$sdk (not a git checkout)")
    continue
  fi
  if [[ -n "$repo_status" ]]; then
    echo "SKIP  $sdk: checkout is dirty"
    skipped+=("$sdk (dirty)")
    continue
  fi
  # Fast-forward rather than skip. Nearly every one of these is behind — bots push spec refreshes and
  # dependency bumps constantly, and a first pass found four repos 5 to 38 commits behind — so skipping
  # meant doing it by hand 49 times. Safe here: the checkout is already verified clean, and --ff-only
  # cannot merge or rewrite anything, so it fails rather than guessing when there is local work.
  git -C "$repo" fetch origin main --quiet 2>/dev/null || true
  behind="$(git -C "$repo" rev-list --count HEAD..origin/main 2>/dev/null || echo 0)"
  if [[ "$behind" != "0" ]]; then
    if [[ "$DRY_RUN" == true ]]; then
      echo "      ($sdk is $behind behind; a real run would fast-forward it)"
    elif git -C "$repo" pull --ff-only origin main --quiet 2>/dev/null; then
      echo "      $sdk: fast-forwarded $behind commit(s)"
    else
      echo "SKIP  $sdk: $behind behind and cannot fast-forward; reconcile it by hand"
      skipped+=("$sdk (cannot fast-forward)")
      continue
    fi
  fi

  if [[ "$DRY_RUN" == true ]]; then
    echo "WOULD $sdk: run only its cli-project invocation, then build and test"
    prepared+=("$sdk (dry run)")
    continue
  fi

  echo "==> $sdk"
  lib="$(dirname "$script")"

  # Pull out just the cli-project call, keeping its line continuations, and run it as-is.
  invocation="$(awk '/^autosdk cli-project/{found=1} found{print} found && !/\\$/{exit}' "$script")"
  if [[ -z "$invocation" ]]; then
    echo "    FAILED: could not isolate the cli-project invocation" >&2
    failed+=("$sdk (no invocation)")
    continue
  fi

  # Run it from a file rather than collapsing it onto one line. Joining the lines leaves the `\`
  # continuations next to a space, which eval then reads as a literal space argument — Exa failed with
  # "' ' was not matched" until this was fixed. A file keeps the invocation exactly as written.
  runner="$(mktemp)"
  printf '%s\n' "$invocation" > "$runner"

  if (cd "$lib" && bash "$runner" >/dev/null 2>&1) &&
     (cd "$repo" && dotnet build ./*.slnx -p:UseSharedCompilation=false >/dev/null 2>&1) &&
     (cd "$repo" && dotnet test src/tests/IntegrationTests --no-build >/dev/null 2>&1); then
    if git -C "$repo" status --porcelain | grep -q 'CliCompletion.cs'; then
      echo "    ok: completion added, built, tests pass — review and commit by hand"
      prepared+=("$sdk")
    else
      echo "    ok: already up to date (no CliCompletion.cs appeared)"
      skipped+=("$sdk (already current)")
    fi
  else
    echo "    FAILED: cli-project/build/test" >&2
    failed+=("$sdk")
  fi

  rm -f "$runner"
done

echo
echo "prepared: ${#prepared[@]}  skipped: ${#skipped[@]}  failed: ${#failed[@]}"
for entry in "${skipped[@]:-}"; do [[ -n "$entry" ]] && echo "  skipped: $entry"; done
for entry in "${failed[@]:-}"; do [[ -n "$entry" ]] && echo "  failed:  $entry"; done
[[ ${#failed[@]} -eq 0 ]]
