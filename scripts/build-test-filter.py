#!/usr/bin/env python3
"""Build an exact VSTest Name filter without interpreting test data as operators."""

from __future__ import annotations

from pathlib import Path
import sys


def escape_filter_value(value: str) -> str:
    # Same reserved characters as VSTest FilterHelper.Escape. Shell quoting alone
    # does not escape the parentheses in MSTest parameterized display names.
    return "".join("\\" + character if character in "\\()&|=!~" else character
                   for character in value)


def build_filter(names: list[str]) -> str:
    if not names or any(not name.strip() for name in names):
        raise ValueError("At least one nonempty test name is required.")
    return "|".join("Name=" + escape_filter_value(name) for name in names)


def main() -> None:
    if len(sys.argv) != 2:
        raise SystemExit("Usage: build-test-filter.py <membership.txt>")
    names = Path(sys.argv[1]).read_text(encoding="utf-8").splitlines()
    print(build_filter(names))


if __name__ == "__main__":
    main()
