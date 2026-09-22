#!/usr/bin/env python3
"""Time one canary command and sample the memory of its process tree.

Usage: measure-canary-command.py --cwd DIR --log LOG --result JSON -- COMMAND...
The compiler figure is the largest sampled RSS of a csc.dll process. A missing
compiler sample is reported as null, never as zero.
"""

import argparse
import json
import os
import signal
import subprocess
import time
from pathlib import Path


def sample_process_tree(root_pid: int) -> tuple[int, int | None]:
    output = subprocess.check_output(
        ["ps", "-axo", "pid=,ppid=,rss=,command="], text=True
    )
    processes: dict[int, tuple[int, int, str]] = {}
    children: dict[int, list[int]] = {}
    for line in output.splitlines():
        parts = line.split(maxsplit=3)
        if len(parts) != 4:
            continue
        try:
            pid, parent, rss = map(int, parts[:3])
        except ValueError:
            continue
        processes[pid] = (parent, rss, parts[3])
        children.setdefault(parent, []).append(pid)

    descendants = {root_pid}
    pending = [root_pid]
    while pending:
        parent = pending.pop()
        for pid in children.get(parent, []):
            if pid not in descendants:
                descendants.add(pid)
                pending.append(pid)

    tree_rss_kib = sum(processes[pid][1] for pid in descendants if pid in processes)
    compiler_samples = [
        processes[pid][1]
        for pid in descendants
        if pid in processes and (
            "csc.dll" in processes[pid][2].lower()
            or processes[pid][2].split(maxsplit=1)[0].rsplit("/", 1)[-1].lower()
            in {"csc", "csc.exe"}
        )
    ]
    return tree_rss_kib, max(compiler_samples, default=None)


def main() -> int:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--cwd", required=True)
    parser.add_argument("--log", required=True)
    parser.add_argument("--result", required=True)
    parser.add_argument("command", nargs=argparse.REMAINDER)
    args = parser.parse_args()
    command = args.command[1:] if args.command[:1] == ["--"] else args.command
    if not command:
        parser.error("a command is required after --")

    log_path = Path(args.log)
    result_path = Path(args.result)
    log_path.parent.mkdir(parents=True, exist_ok=True)
    result_path.parent.mkdir(parents=True, exist_ok=True)
    peak_tree_kib = 0
    peak_compiler_kib = None
    started = time.monotonic()
    with log_path.open("w") as log:
        process = subprocess.Popen(
            command, cwd=args.cwd, stdin=subprocess.DEVNULL,
            stdout=log, stderr=subprocess.STDOUT,
            start_new_session=True,
        )
        while process.poll() is None:
            # Some macOS desktop sessions suspend dotnet/MSBuild children while their
            # parent is still active. Keep this command's own process group running.
            try:
                os.killpg(process.pid, signal.SIGCONT)
            except ProcessLookupError:
                pass
            try:
                tree_kib, compiler_kib = sample_process_tree(process.pid)
                peak_tree_kib = max(peak_tree_kib, tree_kib)
                if compiler_kib is not None:
                    peak_compiler_kib = max(peak_compiler_kib or 0, compiler_kib)
            except (OSError, subprocess.CalledProcessError):
                pass
            time.sleep(0.5)

    result = {
        "command": command,
        "cwd": args.cwd,
        "exitCode": process.returncode,
        "elapsedSeconds": round(time.monotonic() - started, 3),
        "peakProcessTreeRssMiB": round(peak_tree_kib / 1024, 1),
        "peakCompilerRssMiB": (
            round(peak_compiler_kib / 1024, 1)
            if peak_compiler_kib is not None else None
        ),
        "log": str(log_path),
    }
    result_path.write_text(json.dumps(result, indent=2) + "\n")
    print(json.dumps(result))
    return process.returncode


if __name__ == "__main__":
    raise SystemExit(main())
