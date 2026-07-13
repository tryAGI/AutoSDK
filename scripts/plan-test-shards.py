#!/usr/bin/env python3

from __future__ import annotations

import csv
import statistics
import sys
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
    if not path.exists():
        return {}

    with path.open(encoding="utf-8", newline="") as stream:
        return {
            row["test_name"]: float(row["duration_seconds"])
            for row in csv.DictReader(stream, delimiter="\t")
        }


def plan_shards(
    tests: tuple[str, ...],
    timings: dict[str, float],
    shard_count: int,
) -> tuple[tuple[int, TestEstimate], ...]:
    known_durations = [timings[name] for name in tests if name in timings]
    fallback_duration = statistics.median(known_durations) if known_durations else 1.0
    estimates = [
        TestEstimate(name=name, duration_seconds=timings.get(name, fallback_duration))
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


def main() -> None:
    if len(sys.argv) != 5:
        raise SystemExit(
            "Usage: plan-test-shards.py <tests.txt> <timings.tsv> <shard-count> <output.tsv>"
        )

    tests_path = Path(sys.argv[1])
    timings_path = Path(sys.argv[2])
    shard_count = int(sys.argv[3])
    output_path = Path(sys.argv[4])
    if shard_count <= 0:
        raise SystemExit("Shard count must be positive.")

    tests = read_tests(tests_path)
    if not tests:
        raise SystemExit("At least one test is required.")
    if len(set(tests)) != len(tests):
        raise SystemExit("Test names must be unique.")

    assignments = plan_shards(tests, read_timings(timings_path), shard_count)
    write_plan(output_path, assignments)


if __name__ == "__main__":
    main()
