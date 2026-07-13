#!/usr/bin/env python3

from __future__ import annotations

import argparse
import csv
from pathlib import Path


def main() -> None:
    parser = argparse.ArgumentParser(description="Enforce completeness and elapsed-time SLAs for test shards.")
    parser.add_argument("shards_csv", type=Path)
    parser.add_argument("--expected-shards", type=int, required=True)
    parser.add_argument("--max-elapsed-seconds", type=float, required=True)
    args = parser.parse_args()

    with args.shards_csv.open(encoding="utf-8", newline="") as stream:
        rows = list(csv.DictReader(stream))

    errors: list[str] = []
    rows_by_shard: dict[int, dict[str, str]] = {}
    for row in rows:
        index = int(row["shard"])
        if index in rows_by_shard:
            errors.append(f"shard {index}: duplicate diagnostics")
        rows_by_shard[index] = row

    expected = set(range(args.expected_shards))
    actual = set(rows_by_shard)
    for index in sorted(expected - actual):
        errors.append(f"shard {index}: diagnostics are missing")
    for index in sorted(actual - expected):
        errors.append(f"shard {index}: unexpected diagnostics")

    for index in sorted(expected & actual):
        row = rows_by_shard[index]
        assigned = int(row["assigned"])
        reported = int(row["reported"])
        passed = int(row["passed"])
        failed = int(row["failed"])

        if reported != assigned:
            errors.append(f"shard {index}: reported {reported} of {assigned} assigned tests")
        if failed:
            errors.append(f"shard {index}: {failed} tests failed")
        if passed != reported:
            errors.append(f"shard {index}: only {passed} of {reported} reported tests passed")

        elapsed_value = row.get("elapsed_seconds", "")
        if not elapsed_value:
            errors.append(f"shard {index}: elapsed time is missing")
            continue
        elapsed_seconds = float(elapsed_value)
        if elapsed_seconds > args.max_elapsed_seconds:
            errors.append(
                f"shard {index}: elapsed {elapsed_seconds:.1f}s exceeds "
                f"{args.max_elapsed_seconds:.1f}s SLA"
            )

    if errors:
        for error in errors:
            print(f"::error title=CLI integration shard SLA::{error}")
        raise SystemExit(1)

    print(
        f"All {args.expected_shards} shards reported complete passing results within "
        f"{args.max_elapsed_seconds:.1f}s."
    )


if __name__ == "__main__":
    main()
