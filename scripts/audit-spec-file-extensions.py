#!/usr/bin/env python3
"""Report sibling SDK specs whose file extension disagrees with their content.

Helicone and Moonshot each shipped tab-indented JSON in a file named `openapi.yaml`, which is valid
JSON and invalid YAML, so YAML-based tooling could not read them at all. They were found by a parser
failing, which only catches the mismatch when it happens to be fatal — tab-free JSON in a `.yaml` file
parses fine as YAML and would never have surfaced, and neither would the reverse.

So this checks both directions by content, not by whether a parse succeeds.

Usage: python3 -I scripts/audit-spec-file-extensions.py [parent-directory]
"""
import json
import os
import sys

import yaml

MAX_SNIFF_BYTES = 4096


def content_format(path):
    """JSON if the first non-blank character opens an object or array, else YAML. A spec document is
    always a mapping at the top level, so this is a safe discriminator."""
    with open(path, encoding="utf-8", errors="replace") as stream:
        head = stream.read(MAX_SNIFF_BYTES)
    stripped = head.lstrip().lstrip("﻿").lstrip()
    if stripped.startswith(("{", "[")):
        return "json"
    return "yaml"


def parses_as(path, fmt):
    try:
        with open(path, encoding="utf-8") as stream:
            if fmt == "json":
                json.load(stream)
            else:
                yaml.safe_load(stream)
    except Exception:  # noqa: BLE001 - the question is only whether it parses
        return False
    return True


def main():
    root = sys.argv[1] if len(sys.argv) > 1 else os.path.dirname(
        os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

    mismatches = []
    checked = 0
    for entry in sorted(os.listdir(root)):
        libs = os.path.join(root, entry, "src", "libs")
        if not os.path.isdir(libs):
            continue
        for lib in sorted(os.listdir(libs)):
            directory = os.path.join(libs, lib)
            if not os.path.isdir(directory):
                continue
            for name in sorted(os.listdir(directory)):
                if not name.startswith(("openapi", "asyncapi")):
                    continue
                extension = os.path.splitext(name)[1].lower()
                if extension not in (".json", ".yaml", ".yml"):
                    continue
                path = os.path.join(directory, name)
                checked += 1
                actual = content_format(path)
                declared = "json" if extension == ".json" else "yaml"
                if actual != declared:
                    mismatches.append((
                        entry, name, declared, actual,
                        "and does not parse as its extension claims"
                        if not parses_as(path, declared)
                        else "but still parses either way"))

    print(f"spec files checked: {checked}")
    if not mismatches:
        print("no extension/content mismatches")
        return

    print(f"mismatched: {len(mismatches)}")
    for sdk, name, declared, actual, note in mismatches:
        print(f"  {sdk:<20} {name:<22} named {declared}, is {actual} — {note}")


if __name__ == "__main__":
    main()
