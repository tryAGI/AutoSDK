#!/usr/bin/env bash
# sync-all.sh — Pull (rebase) all sibling SDK repos from origin/main
#
# Usage:
#   ./scripts/sync-all.sh                    # default: looks for repos in ../
#   ./scripts/sync-all.sh /path/to/tryAGI    # explicit parent directory
#   ./scripts/sync-all.sh --dirty            # also show repos with uncommitted changes
#
# What it does:
#   1. Fetches origin for each repo
#   2. Fast-forwards or rebases local main onto origin/main
#   3. Reports repos that are dirty, on non-main branches, or have conflicts

set -uo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
AUTOSDK_ROOT="$(cd "$SCRIPT_DIR/.." && pwd)"

SHOW_DIRTY=false
REPOS_DIR=""

for arg in "$@"; do
    case "$arg" in
        --dirty) SHOW_DIRTY=true ;;
        *) REPOS_DIR="$arg" ;;
    esac
done

REPOS_DIR="${REPOS_DIR:-$(cd "$AUTOSDK_ROOT/.." && pwd)}"

# Repos to skip (not SDK repos or managed separately)
SKIP_REPOS="Do LangChainChat"

is_in_list() {
    echo "$2" | grep -qw "$1"
}

pulled=0
up_to_date=0
skipped=0
dirty=0
errors=0

echo "Syncing repos from $REPOS_DIR"
echo ""

for repo_path in "$REPOS_DIR"/*/; do
    repo_name="$(basename "$repo_path")"

    # Must be a git repo
    if [[ ! -d "$repo_path/.git" ]]; then
        continue
    fi

    if is_in_list "$repo_name" "$SKIP_REPOS"; then
        skipped=$((skipped + 1))
        continue
    fi

    branch=$(git -C "$repo_path" rev-parse --abbrev-ref HEAD 2>/dev/null)

    # Check for dirty working tree
    has_dirty=$(git -C "$repo_path" status --porcelain 2>/dev/null)
    if [[ -n "$has_dirty" ]]; then
        dirty_count=$(echo "$has_dirty" | wc -l | tr -d ' ')
        if [[ "$SHOW_DIRTY" == "true" ]]; then
            echo "  DIRTY: $repo_name ($dirty_count files, branch: $branch)"
        fi
        dirty=$((dirty + 1))
    fi

    # Skip if not on main
    if [[ "$branch" != "main" ]]; then
        if [[ "$branch" != "main" ]]; then
            echo "  SKIP:  $repo_name (branch: $branch)"
        fi
        skipped=$((skipped + 1))
        continue
    fi

    # Fetch and check if behind
    git -C "$repo_path" fetch origin main --quiet 2>/dev/null
    behind=$(git -C "$repo_path" rev-list HEAD..origin/main --count 2>/dev/null)

    if [[ "$behind" == "0" ]]; then
        up_to_date=$((up_to_date + 1))
        continue
    fi

    # Pull with rebase
    if [[ -n "$has_dirty" ]]; then
        # Stash, rebase, pop
        git -C "$repo_path" stash --quiet 2>/dev/null
        result=$(git -C "$repo_path" pull --rebase origin main 2>&1)
        git -C "$repo_path" stash pop --quiet 2>/dev/null
    else
        result=$(git -C "$repo_path" pull --rebase origin main 2>&1)
    fi

    if echo "$result" | grep -qiE "conflict|error|fatal"; then
        echo "  ERROR: $repo_name — $result"
        errors=$((errors + 1))
    else
        echo "  PULL:  $repo_name (+$behind commits)"
        pulled=$((pulled + 1))
    fi
done

echo ""
echo "Done: $pulled pulled, $up_to_date up-to-date, $skipped skipped, $dirty dirty, $errors errors"
