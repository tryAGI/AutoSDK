"""Find one-value enums reachable from a response, per sibling SDK spec.

That shape is why AutoSDK fa115c6a21 exists. A single-literal enum in a response is still a response,
so hardening it under --reject-unknown-enum-values throws the day the service spells the value
differently or adds a state. Firecrawl's `DELETE /crawl/{id}` answering `status: "cancelled"` is the
case that exposed it.

Run this before enabling --reject-unknown-enum-values across repositories, to know where the narrowing
has to be right. Measured 2026-11-09: 93 of 220 SDK specs have the shape, 16 of them among the 52 SDKs
that ship a CLI.

Scope, stated plainly:

- "reachable from a response" includes types reached in BOTH directions, which the generator treats as
  response-reachable anyway, since one converter cannot be strict one way and lenient the other. So a
  hit is not proof the enum is response-only. Of Firecrawl's 9 hits, only `cancelled` is response-only;
  the rest are the `ScrapeOptionsAction*` consts, echoed in `GET /crawl/active`.
- Only local `$ref`s are followed. A foreign or circular ref is given up on rather than guessed at, so
  counts are a floor, not an exact total.
- This reads specs, not generated code. For the authoritative answer on one SDK, generate it and grep
  the converters for the throw.

Usage: python3 -I scripts/audit-single-value-response-enums.py [parent-directory]
"""
import json
import os
import sys

import yaml

ROOT = sys.argv[1] if len(sys.argv) > 1 else os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
MAX_DEPTH = 40


def load(path):
    with open(path, encoding="utf-8") as stream:
        if path.endswith(".json"):
            return json.load(stream)
        return yaml.safe_load(stream)


def resolve(doc, node, seen):
    """Follow a local $ref once. Foreign refs and cycles are given up on rather than guessed at."""
    ref = node.get("$ref")
    if not isinstance(ref, str) or not ref.startswith("#/"):
        return node if ref is None else None
    if ref in seen:
        return None
    seen = seen | {ref}
    target = doc
    for part in ref[2:].split("/"):
        part = part.replace("~1", "/").replace("~0", "~")
        if not isinstance(target, dict) or part not in target:
            return None
        target = target[part]
    return target if isinstance(target, dict) else None


def walk(doc, node, depth, seen, found):
    if depth > MAX_DEPTH or not isinstance(node, (dict, list)):
        return
    if isinstance(node, list):
        for item in node:
            walk(doc, item, depth + 1, seen, found)
        return

    if "$ref" in node:
        target = resolve(doc, node, seen)
        if target is not None:
            ref = node["$ref"]
            walk(doc, target, depth + 1, seen | {ref}, found)
        return

    enum = node.get("enum")
    if isinstance(enum, list) and len(enum) == 1 and node.get("type") in (None, "string"):
        found.add(str(enum[0]))

    for key, value in node.items():
        if key in ("example", "examples", "default", "description", "enum"):
            continue
        walk(doc, value, depth + 1, seen, found)


def audit(path):
    doc = load(path)
    if not isinstance(doc, dict):
        return None
    found = set()
    for operations in (doc.get("paths") or {}).values():
        if not isinstance(operations, dict):
            continue
        for operation in operations.values():
            if not isinstance(operation, dict):
                continue
            walk(doc, operation.get("responses") or {}, 0, frozenset(), found)
    return found


def main():
    rows = []
    for entry in sorted(os.listdir(ROOT)):
        libs = os.path.join(ROOT, entry, "src", "libs")
        if not os.path.isdir(libs):
            continue
        for lib in sorted(os.listdir(libs)):
            for name in ("openapi.json", "openapi.yaml"):
                path = os.path.join(libs, lib, name)
                if not os.path.isfile(path):
                    continue
                try:
                    found = audit(path)
                except Exception as error:  # noqa: BLE001 - report, never mask
                    rows.append((entry, "ERROR", str(error)[:70]))
                    continue
                if found:
                    sample = ", ".join(sorted(found)[:4])
                    rows.append((entry, str(len(found)), sample))
                break

    affected = [r for r in rows if r[1] not in ("ERROR",)]
    errors = [r for r in rows if r[1] == "ERROR"]
    print(f"SDKs with one-value enums reachable from a response: {len(affected)}")
    for name, count, sample in affected:
        print(f"  {name:<22} {count:>3}  e.g. {sample}")
    if errors:
        print(f"\nspecs that could not be read: {len(errors)}")
        for name, _, message in errors:
            print(f"  {name}: {message}")


if __name__ == "__main__":
    main()
