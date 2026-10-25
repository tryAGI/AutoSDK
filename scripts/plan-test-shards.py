#!/usr/bin/env python3

from __future__ import annotations

import csv
import argparse
import json
import math
from shard_timings import initial_estimates, positive_duration, read_catalog
from dataclasses import dataclass
from pathlib import Path


@dataclass(frozen=True)
class TestEstimate:
    name: str
    duration_seconds: float


def read_tests(path: Path) -> tuple[str, ...]:
    return tuple(
        line.strip()
        for line in path.read_text(encoding="utf-8").splitlines()
        if line.strip()
    )


def read_timings(path: Path) -> dict[str, float]:
    return read_catalog(path)


def plan_shards(
    tests: tuple[str, ...],
    timings: dict[str, float],
    shard_count: int,
) -> tuple[tuple[int, TestEstimate], ...]:
    missing = sorted(set(tests) - timings.keys())
    if missing:
        raise ValueError("Missing exact-name timing estimates: " + ", ".join(missing))
    if shard_count <= 0:
        raise ValueError("Shard count must be positive")
    estimates = [
        TestEstimate(name=name, duration_seconds=positive_duration(timings[name]))
        for name in tests
    ]
    estimates.sort(key=lambda test: (-test.duration_seconds, test.name))

    loads = [0.0] * shard_count
    counts = [0] * shard_count
    assignments = []
    for estimate in estimates:
        shard = min(range(shard_count), key=lambda index: (loads[index], counts[index], index))
        assignments.append((shard, estimate))
        loads[shard] += estimate.duration_seconds
        counts[shard] += 1

    return tuple(sorted(assignments, key=lambda assignment: (assignment[0], assignment[1].name)))


def write_plan(path: Path, assignments: tuple[tuple[int, TestEstimate], ...]) -> None:
    with path.open("w", encoding="utf-8", newline="") as stream:
        writer = csv.writer(stream, delimiter="\t", lineterminator="\n")
        writer.writerow(("shard_index", "estimated_seconds", "test_name"))
        for shard, estimate in assignments:
            writer.writerow((shard, f"{estimate.duration_seconds:.6f}", estimate.name))


def check_budget(assignments: tuple[tuple[int, TestEstimate], ...], shard_count: int,
                 max_elapsed_seconds: float, reserve_seconds: float) -> dict:
    limit = positive_duration(max_elapsed_seconds)
    if reserve_seconds < 0 or reserve_seconds >= limit or not math.isfinite(reserve_seconds):
        raise ValueError("Reserve must be finite, non-negative and less than the elapsed-time limit")
    loads = [0.0] * shard_count
    for shard, estimate in assignments:
        loads[shard] += estimate.duration_seconds
    budget = {"max_elapsed_seconds": limit, "reserve_seconds": reserve_seconds,
              "test_budget_seconds": limit - reserve_seconds, "estimated_shard_seconds": loads}
    return budget


def main() -> None:
    parser = argparse.ArgumentParser(description="Plan shards with complete explicit timing coverage.")
    parser.add_argument("tests_path", type=Path)
    parser.add_argument("timings_path", type=Path)
    parser.add_argument("shard_count", type=int)
    parser.add_argument("output_path", type=Path)
    parser.add_argument("--initial-estimates", type=Path)
    parser.add_argument("--max-elapsed-seconds", type=float, default=720)
    parser.add_argument("--reserve-seconds", type=float, default=120)
    args = parser.parse_args()
    tests_path, timings_path, shard_count, output_path = args.tests_path, args.timings_path, args.shard_count, args.output_path
    if shard_count <= 0:
        raise SystemExit("Shard count must be positive.")

    tests = read_tests(tests_path)
    if not tests:
        raise SystemExit("At least one test is required.")
    if len(set(tests)) != len(tests):
        raise SystemExit("Test names must be unique.")

    measured = read_timings(timings_path)
    seeds = initial_estimates(json.loads(args.initial_estimates.read_text())) if args.initial_estimates else {}
    missing = sorted(set(tests) - measured.keys() - seeds.keys())
    coverage = {"discovered": len(tests), "measured": len(set(tests) & measured.keys()),
                "initial": sorted(set(tests) & (seeds.keys() - measured.keys())), "missing": missing}
    output_path.with_suffix(".coverage.json").write_text(json.dumps(coverage, indent=2) + "\n")
    print(json.dumps(coverage))
    assignments = plan_shards(tests, {**seeds, **measured}, shard_count)
    budget = check_budget(assignments, shard_count, args.max_elapsed_seconds, args.reserve_seconds)
    output_path.with_suffix(".budget.json").write_text(json.dumps(budget, indent=2) + "\n")
    if max(budget["estimated_shard_seconds"]) > budget["test_budget_seconds"]:
        raise SystemExit(f"Estimated shard workload exceeds {budget['test_budget_seconds']:.1f}s test budget "
                         f"({args.max_elapsed_seconds:.1f}s limit minus {args.reserve_seconds:.1f}s reserve). "
                         "Refresh CI timings, rebalance or optimize the tests before running.")
    print(json.dumps(budget))
    write_plan(output_path, assignments)


if __name__ == "__main__":
    main()
