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
    parser.add_argument(
        "--warn-elapsed-ratio",
        type=float,
        default=0.75,
        help="Warn about a shard whose elapsed time reaches this fraction of the SLA while still "
        "passing, so a regression is visible before it crosses the line. Set 0 to disable.",
    )
    args = parser.parse_args()

    with args.shards_csv.open(encoding="utf-8", newline="") as stream:
        rows = list(csv.DictReader(stream))

    errors: list[str] = []
    warnings: list[str] = []
    elapsed_by_shard: dict[int, float] = {}
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
        elapsed_by_shard[index] = elapsed_seconds
        if elapsed_seconds > args.max_elapsed_seconds:
            errors.append(
                f"shard {index}: elapsed {elapsed_seconds:.1f}s exceeds "
                f"{args.max_elapsed_seconds:.1f}s SLA"
            )
        elif args.warn_elapsed_ratio > 0 and args.max_elapsed_seconds > 0 and (
            elapsed_seconds >= args.max_elapsed_seconds * args.warn_elapsed_ratio
        ):
            warnings.append(
                f"shard {index}: elapsed {elapsed_seconds:.1f}s is "
                f"{elapsed_seconds / args.max_elapsed_seconds:.0%} of the "
                f"{args.max_elapsed_seconds:.1f}s SLA"
            )

    for warning in warnings:
        print(f"::warning title=CLI integration shard SLA::{warning}")

    if errors:
        for error in errors:
            print(f"::error title=CLI integration shard SLA::{error}")
        raise SystemExit(1)

    # Print the headroom on every green run too. The SLA only says pass or fail, which hides a shard
    # creeping towards the limit until it crosses: the regression that motivated this took one shard
    # from 9 to 37 minutes, and the fix brought it back to 520s of a 720s budget — passing, with far
    # less room than the number alone suggests.
    if elapsed_by_shard:
        slowest = max(elapsed_by_shard, key=lambda index: elapsed_by_shard[index])
        slowest_seconds = elapsed_by_shard[slowest]
        print(
            f"All {args.expected_shards} shards reported complete passing results within "
            f"{args.max_elapsed_seconds:.1f}s. Slowest: shard {slowest} at {slowest_seconds:.1f}s "
            f"({slowest_seconds / args.max_elapsed_seconds:.0%} of the budget)."
        )
    else:
        print(
            f"All {args.expected_shards} shards reported complete passing results within "
            f"{args.max_elapsed_seconds:.1f}s."
        )


if __name__ == "__main__":
    main()
