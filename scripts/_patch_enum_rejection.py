#!/usr/bin/env python3
"""Add --reject-unknown-enum-values and its capability guard to one SDK's generate.sh.

Called by enable-enum-rejection.sh. Deliberately conservative: every anchor it needs must be present
and unambiguous, and it refuses rather than guessing, because the alternative is a silently
mis-patched regeneration script in someone else's repository.
"""
import io
import os
import re
import shutil
import subprocess
import sys
import tempfile


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

    # The guard needs somewhere to run from: the script must install the CLI before generating. The
    # call may be indented, because several scripts make it inside a function or a conditional —
    # Deepgram, Exa and tryAGI/OpenAI all do — so the guard call is inserted at the same indentation.
    install_call = re.search(r"^([ \t]*)install_autosdk_cli[ \t]*$", text, re.MULTILINE)
    if install_call is None:
        raise SystemExit("no `install_autosdk_cli` call to anchor the guard to")

    # Several `autosdk generate` invocations are normal — Algolia, Exa and Deepgram each have two —
    # so every one of them is flagged, except AsyncAPI inputs. Those are skipped deliberately: the
    # direction analysis is built on OpenAPI operations and cannot classify a realtime message, and
    # measuring Deepgram's asyncapi generation showed the flag changes nothing there anyway (104
    # strict converters with it and without, already hardened by --validate-any-ofs).
    # tryAGI/OpenAI invokes the CLI through a variable — `"$autosdk_cli" generate` — rather than by
    # name, so the launcher is matched as either form.
    launcher = r'(?:autosdk|"\$autosdk_cli"|\$autosdk_cli)'
    invocations = re.findall(
        r"^" + launcher + r" generate +([^\s\\]+)", text, re.MULTILINE)
    if not invocations:
        raise SystemExit("no `autosdk generate` invocation to flag")

    openapi_specs = [spec for spec in invocations if "asyncapi" not in spec.lower()]
    if not openapi_specs:
        raise SystemExit(
            "every `autosdk generate` invocation here reads an AsyncAPI document; "
            "the flag is not applicable")

    guard = guard_from(reference)
    guard_call = "require_autosdk_capability behavior:request-scoped-enum-rejection"

    indent = install_call.group(1)
    if indent:
        # Indented: the guard function still goes at top level, after the install helper's definition,
        # and only the call follows the indented call site.
        helper_end = re.search(r"^install_autosdk_cli\(\) \{.*?^\}\n", text, re.DOTALL | re.MULTILINE)
        if helper_end is None:
            raise SystemExit("could not find the install_autosdk_cli definition to place the guard after")
        text = text[:helper_end.end()] + "\n" + guard + text[helper_end.end():]
        install_call = re.search(r"^([ \t]*)install_autosdk_cli[ \t]*$", text, re.MULTILINE)
        text = (text[:install_call.end()] + "\n" + indent + guard_call
                + text[install_call.end():])
    else:
        text = re.sub(
            r"^install_autosdk_cli$",
            guard + "install_autosdk_cli\n" + guard_call,
            text,
            count=1,
            flags=re.MULTILINE)

    # Add the flag as its own continued line inside each chosen invocation, keeping the backslash
    # continuation intact. Anchored on that invocation's `--output`, which every one of these scripts
    # passes.
    patched = text
    for spec in openapi_specs:
        pattern = re.compile(
            r"(^" + launcher + r" generate +" + re.escape(spec)
            + r"[^\n]*\\\n(?:[^\n]*\\\n)*?)"
            r"([ \t]*--output [^\n]*\\\n)",
            re.MULTILINE)
        patched, count = pattern.subn(
            lambda m: m.group(1) + m.group(2) + "  --reject-unknown-enum-values \\\n",
            patched,
            count=1)
        if count != 1:
            raise SystemExit(
                f"could not find a continued `--output` line for the invocation reading {spec}")

    # Check the result parses before putting it in place. The regex edits are anchored, but a
    # malformed script would otherwise surface much later as a failed regeneration, and by then the
    # repository has already been written to.
    with tempfile.NamedTemporaryFile("w", suffix=".sh", encoding="utf-8", delete=False) as handle:
        handle.write(patched)
        candidate = handle.name
    try:
        check = subprocess.run(
            ["bash", "-n", candidate],
            capture_output=True,
            text=True,
            check=False)
        if check.returncode != 0:
            raise SystemExit(
                "the patched script does not parse, so nothing was written:\n"
                + (check.stderr.strip() or "bash -n failed without a message"))
        shutil.copyfile(candidate, path)
    finally:
        os.unlink(candidate)

    print("    patched generate.sh (bash -n clean)")


if __name__ == "__main__":
    main()
