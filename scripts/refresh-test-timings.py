#!/usr/bin/env python3
"""Produce a reviewable timing catalog from passed CI rows, never local warm runs."""
import argparse
import csv
import hashlib
import json
import re
from pathlib import Path
from shard_timings import passed_samples, read_catalog, refresh, record_observation

def main() -> None:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("input_directory", type=Path)
    parser.add_argument("catalog", type=Path)
    parser.add_argument("output_directory", type=Path)
    parser.add_argument("--run-url", required=True)
    parser.add_argument("--commit", required=True)
    parser.add_argument("--runner-os", required=True, choices=["Linux"])
    parser.add_argument("--runner-arch", required=True, choices=["X64"])
    args = parser.parse_args()
    if not re.fullmatch(r"https://github.com/tryAGI/AutoSDK/actions/runs/[1-9][0-9]*", args.run_url):
        parser.error("A tryAGI/AutoSDK CI run URL is required")
    if not re.fullmatch(r"[0-9a-f]{40}", args.commit):
        parser.error("A full source commit SHA is required")
    samples = passed_samples(args.input_directory)
    before = read_catalog(args.catalog)
    after = refresh(before, samples)
    tests_files = sorted(args.input_directory.rglob("discovered-tests.txt"))
    if not tests_files:
        parser.error("Fresh discovered-tests.txt inventory is required")
    tests = tests_files[0].read_text().splitlines()
    if len(tests) != len(set(tests)) or any(p.read_text().splitlines() != tests for p in tests_files):
        parser.error("Discovered test inventories must agree and contain unique names")
    missing = sorted(set(tests) - after.keys())
    if missing:
        parser.error("Unmeasured discovered rows: " + ", ".join(missing))
    if set(samples) - set(tests):
        parser.error("TRX samples contain undiscovered rows")
    prior_path = args.catalog.with_suffix(".provenance.json")
    prior = json.loads(prior_path.read_text()) if prior_path.exists() else {"samples": {}}
    if prior_path.exists() and prior.get("catalog_sha256") != hashlib.sha256(args.catalog.read_bytes()).hexdigest():
        parser.error("Catalog/provenance hash mismatch; reconcile the catalog before refreshing")
    provenance = {name: prior.get("samples", {}).get(name, {"source": "legacy_unattributed"}) for name in tests}
    for name, sample in samples.items():
        observation = {**sample, "source": "ci", "run_url": args.run_url, "commit": args.commit,
                       "runner_os": args.runner_os, "runner_arch": args.runner_arch}
        provenance[name] = record_observation(provenance[name], observation)
        after[name] = provenance[name]["duration_seconds"]
    args.output_directory.mkdir(parents=True, exist_ok=True)
    target = args.output_directory / args.catalog.name
    with target.open("w", newline="") as stream:
        writer = csv.writer(stream, delimiter="\t", lineterminator="\n")
        writer.writerow(["test_name", "duration_seconds"])
        writer.writerows((name, f"{after[name]:.6f}") for name in sorted(tests))
    target.with_suffix(".provenance.json").write_text(json.dumps({
        "schema_version": 2, "catalog_sha256": hashlib.sha256(target.read_bytes()).hexdigest(),
        "base_catalog_sha256": hashlib.sha256(args.catalog.read_bytes()).hexdigest(),
        "samples": provenance,
    }, indent=2, sort_keys=True) + "\n")
    print(f"Recorded {len(samples)} passed CI rows using a three-cohort upper bound; retained {len(tests)-len(samples)} existing estimates.")
if __name__ == "__main__":
    main()
