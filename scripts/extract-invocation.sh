#!/usr/bin/env bash
# Print one autosdk invocation out of a generate.sh, bounded by the command itself.
#
# This exists because of a specific mistake. Measuring something about tryAGI/OpenAI, I sliced its
# generate.sh by line numbers — `sed -n '50,65p'` — to get the `generate` invocation. Line 65 was
# `rm -rf ../tryAGI.OpenAI.CLI/GeneratedApi`, the cleanup belonging to the NEXT command. Run from the
# library directory, that relative path resolved into the real repository and deleted 445 tracked
# files. Nothing about the slice looked wrong, which is the point: line numbers carry no information
# about where a command ends.
#
# So: never slice a script by line numbers. This starts at the requested invocation and stops at the
# first line that does not end in a backslash, which is the command's own boundary.
#
# Usage: extract-invocation.sh <generate.sh> <subcommand> [spec]
#   extract-invocation.sh generate.sh generate openapi.yaml
#   extract-invocation.sh generate.sh cli-project
set -euo pipefail

script="${1:?usage: $0 <generate.sh> <subcommand> [spec]}"
subcommand="${2:?usage: $0 <generate.sh> <subcommand> [spec]}"
spec="${3:-}"

[[ -f "$script" ]] || { echo "error: no such file: $script" >&2; exit 1; }

invocation="$(awk -v cmd="$subcommand" -v spec="$spec" '
  # The launcher is either the tool by name or a variable holding it.
  function is_start(line) {
    if (line !~ "^[[:space:]]*(autosdk|\"\\$autosdk_cli\"|\\$autosdk_cli)[[:space:]]+" cmd "([[:space:]]|$)") return 0
    if (spec == "") return 1
    return index(line, spec) > 0
  }
  !found && is_start($0) { found = 1 }
  found { print }
  # A line not ending in a backslash ends the command. This is the boundary line numbers cannot see.
  found && $0 !~ /\\$/ { exit }
' "$script")"

if [[ -z "$invocation" ]]; then
  echo "error: no '$subcommand' invocation${spec:+ reading $spec} in $script" >&2
  exit 1
fi

# Refuse to hand back anything that is not purely one invocation. A stray command swept in is exactly
# the failure this script exists to prevent, so it is checked rather than assumed.
if printf '%s\n' "$invocation" | grep -qE '^[[:space:]]*(rm|mv|cp|rmdir)[[:space:]]'; then
  echo "error: the extracted text contains a file-system command; refusing to return it" >&2
  printf '%s\n' "$invocation" >&2
  exit 1
fi

printf '%s\n' "$invocation"
