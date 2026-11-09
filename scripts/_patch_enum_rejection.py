#!/usr/bin/env python3
"""Add --reject-unknown-enum-values and its capability guard to one SDK's generate.sh.

Called by enable-enum-rejection.sh. Deliberately conservative: every anchor it needs must be present
and unambiguous, and it refuses rather than guessing, because the alternative is a silently
mis-patched regeneration script in someone else's repository.
"""
import io
import re
import sys


def guard_from(reference_path):
    """Lift the verified guard out of the reference generate.sh so copies cannot drift from it."""
    text = io.open(reference_path, encoding="utf-8").read()
    match = re.search(
        r"(# --reject-unknown-enum-values is only safe.*?\n\}\n)",
        text,
        re.DOTALL)
    if match is None:
        raise SystemExit("reference generate.sh no longer contains the guard block")
    return match.group(1)


def main():
    if len(sys.argv) != 3:
        raise SystemExit("usage: _patch_enum_rejection.py <generate.sh> <reference-generate.sh>")

    path, reference = sys.argv[1], sys.argv[2]
    text = io.open(path, encoding="utf-8").read()

    if "reject-unknown-enum-values" in text:
        raise SystemExit("already patched")

    # The guard needs somewhere to run from: the script must install the CLI before generating.
    if not re.search(r"^install_autosdk_cli$", text, re.MULTILINE):
        raise SystemExit("no bare `install_autosdk_cli` call to anchor the guard to")

    # Exactly one `autosdk generate` invocation, or the flag might land on the wrong one.
    generate_calls = re.findall(r"^autosdk generate\b", text, re.MULTILINE)
    if len(generate_calls) != 1:
        raise SystemExit(f"expected one `autosdk generate` call, found {len(generate_calls)}")

    guard = guard_from(reference)
    guard_call = "require_autosdk_capability behavior:request-scoped-enum-rejection"

    text = re.sub(
        r"^install_autosdk_cli$",
        guard + "install_autosdk_cli\n" + guard_call,
        text,
        count=1,
        flags=re.MULTILINE)

    # Add the flag as its own continued line inside the generate invocation, keeping the backslash
    # continuation intact. Anchored on `--output`, which every one of these scripts passes.
    patched, count = re.subn(
        r"(^  --output [^\n]*\\\n)",
        r"\1  --reject-unknown-enum-values \\\n",
        text,
        count=1,
        flags=re.MULTILINE)
    if count != 1:
        raise SystemExit("could not find a continued `--output` line in the generate invocation")

    io.open(path, "w", encoding="utf-8").write(patched)
    print("    patched generate.sh")


if __name__ == "__main__":
    main()
