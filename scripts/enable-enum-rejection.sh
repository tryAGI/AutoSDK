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

# The test project is discovered, not assumed. Four of the 52 CLI SDKs name it after the SDK —
# AI21.IntegrationTests, and likewise DeepInfra, OpenAI and VoyageAI — so a hard-coded
# src/tests/IntegrationTests made `dotnet test` fail with MSB1009 "Project file does not exist" and the
# repo was reported as a test failure when nothing had been tested at all.
find_test_project() {
  local repo="$1" sdk candidate named="" integration="" any=""
  sdk="$(basename "$repo")"
  for candidate in "$repo"/src/tests/*/; do
    [[ -d "$candidate" ]] || continue
    compgen -G "$candidate"'*.csproj' >/dev/null || continue
    case "$(basename "$candidate")" in
      "$sdk".IntegrationTests) named="$candidate" ;;
      *IntegrationTests) [[ -z "$integration" ]] && integration="$candidate" ;;
    esac
    [[ -z "$any" ]] && any="$candidate"
  done
  # Named after the SDK wins. OpenAI ships seven test projects, and taking the first that merely ends
  # in IntegrationTests picked FreeLLM.IntegrationTests — running someone else's suite and calling it
  # a pass.
  printf '%s' "${named:-${integration:-$any}}"
}
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

# A dry run writes nothing, and planning the batches before the CLI is ready is the main reason to run
# one, so only a real run is gated.
if ! autosdk capabilities --require "$CAPABILITY" >/dev/null 2>&1; then
  if [[ "$DRY_RUN" == true ]]; then
    echo "note: the installed autosdk.cli does not report $CAPABILITY yet, so a real run would stop here." >&2
    echo
  else
    echo "error: the installed autosdk.cli does not report $CAPABILITY." >&2
    echo "       Patching repositories now would leave each one unable to regenerate." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi
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
  # `git status` must actually answer. Silencing its failure would make a path that is not a repository
  # look clean, and this script's safety rests on being able to see uncommitted work before it writes.
  if ! repo_status="$(git -C "$repo" status --porcelain 2>/dev/null)"; then
    echo "SKIP  $sdk: not a git checkout, so uncommitted work cannot be ruled out"
    skipped+=("$sdk (not a git checkout)")
    continue
  fi
  # A dirty checkout is someone else's work in progress; never regenerate over it.
  if [[ -n "$repo_status" ]]; then
    echo "SKIP  $sdk: checkout is dirty"
    skipped+=("$sdk (dirty)")
    continue
  fi

  # Regenerating a stale checkout produces a diff against code that is no longer current, and the push
  # would be refused anyway. These repositories run bots, so being tens of commits behind is normal:
  # AI21 was 38 behind, Gladia 16 and Beatoven 5 the first time this was run.
  git -C "$repo" fetch origin main --quiet 2>/dev/null || true
  behind="$(git -C "$repo" rev-list --count HEAD..origin/main 2>/dev/null || echo 0)"
  ahead="$(git -C "$repo" rev-list --count origin/main..HEAD 2>/dev/null || echo 0)"
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
  if [[ "$ahead" != "0" ]]; then
    echo "SKIP  $sdk: $ahead unpushed commit(s); push or review them before regenerating"
    skipped+=("$sdk ($ahead unpushed)")
    continue
  fi

  if [[ "$DRY_RUN" == true ]]; then
    echo "WOULD $sdk: patch $script, regenerate, build, test"
    done_list+=("$sdk (dry run)")
    continue
  fi

  echo "==> $sdk"
  lib="$(dirname "$script")"

  # Snapshot before touching anything, so a failure can be undone by copying files back. Plain copies
  # on purpose: the git commands that restore files from history bulk-overwrite a shared worktree,
  # which is the thing that must not happen here, and they are blocked in this environment for that
  # reason.
  #
  # Every path the script writes has to be covered, taken from its own `--output` arguments rather than
  # assumed. The first version snapshotted `generate.sh` and `Generated/` only, and AI21 — whose script
  # also emits a CLI project into ../../cli/AI21.CLI — came out of a failed run with 148 files still
  # modified. The spec is covered too, since the script re-downloads it.
  snapshot="$(mktemp -d)"
  snapshot_paths=()

  cp "$script" "$snapshot/generate.sh"
  index=0
  while IFS= read -r target; do
    resolved="$lib/$target"
    [[ -e "$resolved" ]] || continue
    cp -R "$resolved" "$snapshot/out$index"
    snapshot_paths+=("$index:$resolved")
    index=$((index + 1))
  done < <(grep -oE '^[[:space:]]*--output[[:space:]]+[^[:space:]\\]+' "$script" | awk '{print $2}')

  for spec in "$lib"/openapi.* "$lib"/asyncapi.*; do
    if [[ -f "$spec" ]]; then
      cp "$spec" "$snapshot/spec$index"
      snapshot_paths+=("spec$index:$spec")
      index=$((index + 1))
    fi
  done

  if [[ ${#snapshot_paths[@]} -eq 0 ]]; then
    echo "    FAILED: no --output target or spec found to snapshot; refusing to patch" >&2
    failed+=("$sdk (nothing to snapshot)")
    rm -rf "$snapshot"
    continue
  fi

  restore_snapshot() {
    cp "$snapshot/generate.sh" "$script"
    for entry in "${snapshot_paths[@]}"; do
      local key="${entry%%:*}"
      local destination="${entry#*:}"
      if [[ "$key" == spec* ]]; then
        cp "$snapshot/$key" "$destination"
      else
        rm -rf "$destination"
        cp -R "$snapshot/out$key" "$destination"
      fi
    done
  }

  if python3 "$(dirname "${BASH_SOURCE[0]}")/_patch_enum_rejection.py" "$script" "$GUARD_SOURCE" &&
     (cd "$lib" && ./generate.sh >/dev/null 2>&1) &&
     (cd "$repo" && dotnet build ./*.slnx -p:UseSharedCompilation=false >/dev/null 2>&1) &&
     (cd "$repo" && { tests="$(find_test_project "$repo")"; if [[ -n "$tests" ]]; then dotnet test "$tests" --no-build >/dev/null 2>&1; else echo "      no test project found; skipping tests" >&2; fi; }); then
    echo "    ok: regenerated, built, tests pass — review and commit by hand"
    done_list+=("$sdk")
  else
    echo "    FAILED: patch/generate/build/test — restoring from snapshot" >&2
    restore_snapshot
    if [[ -n "$(git -C "$repo" status --porcelain 2>/dev/null)" ]]; then
      echo "    WARNING: $sdk is still not clean after the restore; inspect it by hand" >&2
      failed+=("$sdk (restore incomplete)")
    else
      echo "    restored: $sdk is clean again"
      failed+=("$sdk (restored)")
    fi
  fi

  rm -rf "$snapshot"
done

echo
echo "prepared: ${#done_list[@]}  skipped: ${#skipped[@]}  failed: ${#failed[@]}"

# The whole point of this script is that it leaves work for a person, so say exactly where that work is
# rather than making them go and look.
if [[ "$DRY_RUN" == false ]]; then
  echo
  echo "checkouts left with uncommitted changes (review and commit these):"
  left=0
  for sdk in "$@"; do
    if [[ -n "$(git -C "$PARENT/$sdk" status --porcelain 2>/dev/null)" ]]; then
      echo "  $sdk: $(git -C "$PARENT/$sdk" status --porcelain | wc -l | tr -d ' ') file(s)"
      left=$((left + 1))
    fi
  done
  [[ $left -eq 0 ]] && echo "  none"
fi
for entry in "${skipped[@]:-}"; do [[ -n "$entry" ]] && echo "  skipped: $entry"; done
for entry in "${failed[@]:-}"; do [[ -n "$entry" ]] && echo "  failed:  $entry"; done
[[ ${#failed[@]} -eq 0 ]]
