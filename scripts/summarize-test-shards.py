#!/usr/bin/env python3

from __future__ import annotations

import argparse
import csv
import re
import xml.etree.ElementTree as ET
from dataclasses import dataclass
from pathlib import Path


SHARD_PATTERN = re.compile(r"shard-(\d+)$")
DURATION_PATTERN = re.compile(
    r"^(?:(?P<days>\d+)\.)?(?P<hours>\d+):(?P<minutes>\d+):(?P<seconds>\d+)(?:\.(?P<fraction>\d+))?$"
)


@dataclass(frozen=True)
class TestResult:
    name: str
    duration_seconds: float
    outcome: str


@dataclass(frozen=True)
class ShardResult:
    index: int
    membership: tuple[str, ...]
    tests: tuple[TestResult, ...]
    elapsed_seconds: float | None


def parse_duration(value: str) -> float:
    match = DURATION_PATTERN.match(value)
    if match is None:
        raise ValueError(f"Unsupported TRX duration: {value}")

    fraction = match.group("fraction") or ""
    fraction_seconds = float(f"0.{fraction}") if fraction else 0.0
    return (
        int(match.group("days") or 0) * 86400
        + int(match.group("hours")) * 3600
        + int(match.group("minutes")) * 60
        + int(match.group("seconds"))
        + fraction_seconds
    )


def shard_index(path: Path) -> int:
    for candidate in (path, *path.parents):
        match = SHARD_PATTERN.match(candidate.name)
        if match is not None:
            return int(match.group(1))
    raise ValueError(f"Could not determine shard index from {path}")


def read_trx(path: Path) -> tuple[TestResult, ...]:
    root = ET.parse(path).getroot()
    results = []
    for element in root.iter():
        if not element.tag.endswith("UnitTestResult"):
            continue
        results.append(
            TestResult(
                name=element.attrib["testName"],
                duration_seconds=parse_duration(element.attrib.get("duration", "0:00:00")),
                outcome=element.attrib.get("outcome", "Unknown"),
            )
        )
    return tuple(results)


def read_elapsed_seconds(path: Path) -> float | None:
    if not path.exists():
        return None

    with path.open(encoding="utf-8", newline="") as stream:
        metadata = {
            row["key"]: row["value"]
            for row in csv.DictReader(stream, delimiter="\t")
        }
    value = metadata.get("elapsed_seconds")
    return float(value) if value is not None else None


def load_shards(input_directory: Path) -> tuple[ShardResult, ...]:
    shards = []
    for membership_path in sorted(input_directory.rglob("membership.txt")):
        index = shard_index(membership_path.parent)
        membership = tuple(
            line.strip()
            for line in membership_path.read_text(encoding="utf-8").splitlines()
            if line.strip()
        )
        trx_path = membership_path.with_name("results.trx")
        tests = read_trx(trx_path) if trx_path.exists() else ()
        elapsed_seconds = read_elapsed_seconds(membership_path.with_name("metadata.tsv"))
        shards.append(
            ShardResult(
                index=index,
                membership=membership,
                tests=tests,
                elapsed_seconds=elapsed_seconds,
            )
        )
    return tuple(sorted(shards, key=lambda shard: shard.index))


def write_csv(path: Path, header: tuple[str, ...], rows: list[tuple[object, ...]]) -> None:
    with path.open("w", encoding="utf-8", newline="") as stream:
        writer = csv.writer(stream)
        writer.writerow(header)
        writer.writerows(rows)


def write_summary(output_directory: Path, shards: tuple[ShardResult, ...], expected_shards: int) -> None:
    output_directory.mkdir(parents=True, exist_ok=True)
    shard_rows = []
    test_rows = []
    timing_rows = []

    for shard in shards:
        result_by_name = {test.name: test for test in shard.tests}
        duration = sum(test.duration_seconds for test in shard.tests)
        passed = sum(test.outcome == "Passed" for test in shard.tests)
        failed = sum(test.outcome == "Failed" for test in shard.tests)
        shard_rows.append(
            (
                shard.index,
                len(shard.membership),
                len(shard.tests),
                passed,
                failed,
                f"{duration:.3f}",
                f"{shard.elapsed_seconds:.3f}" if shard.elapsed_seconds is not None else "",
            )
        )
        for name in shard.membership:
            result = result_by_name.get(name)
            test_rows.append(
                (
                    shard.index,
                    name,
                    result.outcome if result else "Missing",
                    f"{result.duration_seconds:.6f}" if result else "",
                )
            )
            if result is not None:
                timing_rows.append((name, f"{result.duration_seconds:.6f}"))

    write_csv(
        output_directory / "shards.csv",
        (
            "shard",
            "assigned",
            "reported",
            "passed",
            "failed",
            "duration_seconds",
            "elapsed_seconds",
        ),
        shard_rows,
    )
    write_csv(
        output_directory / "test-results.csv",
        ("shard", "test_name", "outcome", "duration_seconds"),
        test_rows,
    )

    with (output_directory / "test-timings.tsv").open("w", encoding="utf-8", newline="") as stream:
        writer = csv.writer(stream, delimiter="\t", lineterminator="\n")
        writer.writerow(("test_name", "duration_seconds"))
        writer.writerows(sorted(timing_rows))

    missing_shards = sorted(set(range(expected_shards)) - {shard.index for shard in shards})
    total_assigned = sum(len(shard.membership) for shard in shards)
    total_reported = sum(len(shard.tests) for shard in shards)
    lines = [
        "# CLI integration shard diagnostics",
        "",
        f"Discovered artifacts for **{len(shards)} of {expected_shards}** shards. ",
        f"Assigned tests: **{total_assigned}**. Reported results: **{total_reported}**.",
        "",
        "| Shard | Assigned | Reported | Passed | Failed | Test duration | Elapsed |",
        "| ---: | ---: | ---: | ---: | ---: | ---: | ---: |",
    ]
    for index, assigned, reported, passed, failed, duration, elapsed in shard_rows:
        elapsed_display = f"{float(elapsed) / 60:.1f} min" if elapsed else "missing"
        lines.append(
            f"| {index} | {assigned} | {reported} | {passed} | {failed} | "
            f"{float(duration) / 60:.1f} min | {elapsed_display} |"
        )
    if missing_shards:
        lines.extend(("", f"Missing shard artifacts: {', '.join(map(str, missing_shards))}."))
    (output_directory / "summary.md").write_text("\n".join(lines) + "\n", encoding="utf-8")


def main() -> None:
    parser = argparse.ArgumentParser(description="Summarize sharded dotnet TRX diagnostics.")
    parser.add_argument("input_directory", type=Path)
    parser.add_argument("output_directory", type=Path)
    parser.add_argument("--expected-shards", type=int, required=True)
    args = parser.parse_args()

    shards = load_shards(args.input_directory)
    write_summary(args.output_directory, shards, args.expected_shards)


if __name__ == "__main__":
    main()
