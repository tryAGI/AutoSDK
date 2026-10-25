"""Validated exact-name timing catalogs and passed CI samples."""
from __future__ import annotations
import csv
import hashlib
import math
import re
import xml.etree.ElementTree as ET
from pathlib import Path

def positive_duration(value: object) -> float:
    number = float(value)
    if not math.isfinite(number) or number <= 0:
        raise ValueError(f"Duration must be finite and positive: {value}")
    return number

def read_catalog(path: Path) -> dict[str, float]:
    if not path.exists():
        return {}
    result = {}
    with path.open(encoding="utf-8", newline="") as stream:
        for row in csv.DictReader(stream, delimiter="\t"):
            name = row["test_name"]
            if not name or name in result:
                raise ValueError(f"Empty or duplicate timing name: {name!r}")
            result[name] = positive_duration(row["duration_seconds"])
    return result

def initial_estimates(document: dict) -> dict[str, float]:
    result = {}
    for name, entry in document.items():
        if not name or not isinstance(entry.get("reason"), str) or not entry["reason"].strip():
            raise ValueError(f"Initial estimate needs an exact name and reason: {name!r}")
        result[name] = positive_duration(entry["duration_seconds"])
    return result

def passed_samples(directory: Path) -> dict[str, dict]:
    samples = {}
    for path in sorted(directory.rglob("results.trx")):
        digest = hashlib.sha256(path.read_bytes()).hexdigest()
        for element in ET.parse(path).getroot().iter():
            if element.tag.rsplit("}", 1)[-1] != "UnitTestResult" or element.attrib.get("outcome") != "Passed":
                continue
            name = element.attrib["testName"]
            if name in samples:
                raise ValueError(f"Duplicate passed CI sample: {name}")
            match = re.fullmatch(r"(?:(\d+)\.)?(\d+):(\d+):(\d+(?:\.\d+)?)", element.attrib.get("duration", ""))
            if not match:
                raise ValueError(f"Invalid TRX duration for {name}")
            days, hours, minutes, seconds = match.groups()
            duration = positive_duration(int(days or 0)*86400 + int(hours)*3600 + int(minutes)*60 + float(seconds))
            samples[name] = {"duration_seconds": duration, "trx_path": path.relative_to(directory).as_posix(), "trx_sha256": digest, "outcome": "Passed"}
    if not samples:
        raise ValueError("No passed CI timing samples found")
    return samples

def refresh(catalog: dict[str, float], samples: dict[str, dict]) -> dict[str, float]:
    return {**catalog, **{name: positive_duration(sample["duration_seconds"]) for name, sample in samples.items()}}

def record_observation(previous: dict, observation: dict, window: int = 3) -> dict:
    """Keep the slowest of recent passed CI cohorts, with its original attribution."""
    history = previous.get("observations", [])
    if not history and previous.get("source") == "ci":
        history = [{key: value for key, value in previous.items() if key != "observations"}]
    history = [entry for entry in history
               if entry.get("source") == "ci" and entry.get("outcome") == "Passed"
               and entry.get("run_url") != observation["run_url"]]
    history = [*history, observation][-window:]
    selected = max(history, key=lambda entry: positive_duration(entry["duration_seconds"]))
    return {**selected, "observations": history}
