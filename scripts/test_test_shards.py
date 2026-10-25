#!/usr/bin/env python3
"""Filter regressions for parameterized test sharding."""

import importlib.util
from pathlib import Path
import unittest


MODULE_PATH = Path(__file__).with_name("build-test-filter.py")
SPEC = importlib.util.spec_from_file_location("build_test_filter", MODULE_PATH)
assert SPEC is not None and SPEC.loader is not None
FILTER = importlib.util.module_from_spec(SPEC)
SPEC.loader.exec_module(FILTER)


class TestShardFilters(unittest.TestCase):
    def test_parameterized_rows_keep_separate_exact_names(self):
        self.assertEqual(
            FILTER.build_filter(["Example (False)", "Example (True)"]),
            r"Name=Example \(False\)|Name=Example \(True\)",
        )

    def test_literal_filter_operators_cannot_select_other_tests(self):
        self.assertEqual(
            FILTER.build_filter(["Data(a|Name=Other&x!~y)"]),
            r"Name=Data\(a\|Name\=Other\&x\!\~y\)",
        )

    def test_backslashes_and_unicode_are_preserved(self):
        self.assertEqual(FILTER.escape_filter_value(r"тест\path"), r"тест\\path")

    def test_simple_names_are_unchanged(self):
        self.assertEqual(FILTER.build_filter(["One", "Two"]), "Name=One|Name=Two")

    def test_empty_membership_fails(self):
        for names in ([], [""]):
            with self.subTest(names=names):
                with self.assertRaises(ValueError):
                    FILTER.build_filter(names)



class TestShardTimings(unittest.TestCase):
    @classmethod
    def setUpClass(cls):
        import sys
        sys.path.insert(0, str(MODULE_PATH.parent))
        spec = importlib.util.spec_from_file_location("plan_test_shards", MODULE_PATH.with_name("plan-test-shards.py"))
        cls.planner = importlib.util.module_from_spec(spec)
        sys.modules[spec.name] = cls.planner
        spec.loader.exec_module(cls.planner)

    def test_renamed_parameterized_row_cannot_use_median(self):
        with self.assertRaisesRegex(ValueError, "Missing exact-name"):
            self.planner.plan_shards(("Publish (True)",), {"Publish": 220.0}, 8)

    def test_exact_rows_keep_cost_and_membership(self):
        plan = self.planner.plan_shards(("Publish (False)", "Publish (True)"), {"Publish (False)": 218, "Publish (True)": 226}, 2)
        self.assertEqual({item.name: item.duration_seconds for _, item in plan},
                         {"Publish (False)": 218, "Publish (True)": 226})
        self.assertEqual(len({shard for shard, _ in plan}), 2)

    def test_invalid_costs_fail(self):
        for cost in (0, -1, float("nan"), float("inf")):
            with self.subTest(cost=cost), self.assertRaises(ValueError):
                self.planner.plan_shards(("Publish",), {"Publish": cost}, 1)

    def test_initial_estimates_require_reason_and_positive_cost(self):
        from shard_timings import initial_estimates
        with self.assertRaises(ValueError):
            initial_estimates({"Publish (True)": {"duration_seconds": 300}})
        self.assertEqual(initial_estimates({"Publish (True)": {"duration_seconds": 300, "reason": "Cold CI AOT estimate pending first sample"}}),
                         {"Publish (True)": 300})

    def test_slow_ci_sample_keeps_its_attribution_until_window_expires(self):
        from shard_timings import record_observation
        def sample(run, duration):
            return {"source": "ci", "outcome": "Passed", "run_url": f"run-{run}",
                    "commit": str(run), "duration_seconds": duration}
        entry = record_observation(sample(1, 100), sample(2, 40))
        self.assertEqual(entry["duration_seconds"], 100)
        self.assertEqual(entry["commit"], "1")
        entry = record_observation(entry, sample(3, 50))
        self.assertEqual(entry["duration_seconds"], 100)
        entry = record_observation(entry, sample(4, 30))
        self.assertEqual(entry["duration_seconds"], 50)
        self.assertEqual(entry["commit"], "3")
        self.assertEqual(len(entry["observations"]), 3)

    def test_same_ci_cohort_does_not_duplicate_history_or_adopt_legacy_weight(self):
        from shard_timings import record_observation
        sample = {"source": "ci", "outcome": "Passed", "run_url": "run-1", "duration_seconds": 40}
        entry = record_observation({"source": "legacy_unattributed", "duration_seconds": 999}, sample)
        entry = record_observation(entry, sample)
        self.assertEqual(entry["duration_seconds"], 40)
        self.assertEqual(len(entry["observations"]), 1)

    def test_failed_rows_never_replace_previous_estimate(self):
        import tempfile
        from shard_timings import passed_samples, refresh
        with tempfile.TemporaryDirectory() as directory:
            path = Path(directory) / "results.trx"
            path.write_text('<TestRun><Results><UnitTestResult testName="Passed (True)" outcome="Passed" duration="00:03:46"/><UnitTestResult testName="Failed" outcome="Failed" duration="00:00:01"/><UnitTestResult testName="Skipped" outcome="NotExecuted" duration="00:00:00"/></Results></TestRun>')
            samples = passed_samples(Path(directory))
            self.assertEqual(set(samples), {"Passed (True)"})
            self.assertEqual(refresh({"Failed": 220}, samples), {"Failed": 220, "Passed (True)": 226})
            self.assertEqual(samples["Passed (True)"]["outcome"], "Passed")
            self.assertEqual(len(samples["Passed (True)"]["trx_sha256"]), 64)

    def test_duplicate_samples_fail_instead_of_arbitrary_overwrite(self):
        import tempfile
        from shard_timings import passed_samples
        with tempfile.TemporaryDirectory() as directory:
            for name in ("shard-0", "shard-1"):
                path = Path(directory) / name
                path.mkdir()
                (path / "results.trx").write_text('<TestRun><UnitTestResult testName="Duplicate" outcome="Passed" duration="00:00:10"/></TestRun>')
            with self.assertRaisesRegex(ValueError, "Duplicate"):
                passed_samples(Path(directory))

    def test_duplicate_catalog_rows_fail(self):
        import tempfile
        from shard_timings import read_catalog
        with tempfile.TemporaryDirectory() as directory:
            path = Path(directory) / "timings.tsv"
            path.write_text("test_name\tduration_seconds\nDuplicate\t10\nDuplicate\t11\n")
            with self.assertRaisesRegex(ValueError, "duplicate"):
                read_catalog(path)

    def test_budget_reserves_setup_and_runner_variation_without_raising_sla(self):
        plan = self.planner.plan_shards(("A", "B", "C", "D"), {"A": 350, "B": 300, "C": 250, "D": 200}, 2)
        budget = self.planner.check_budget(plan, 2, 720, 120)
        self.assertEqual(budget["test_budget_seconds"], 600)
        self.assertEqual(sorted(budget["estimated_shard_seconds"]), [550, 550])
        self.assertEqual(budget["max_elapsed_seconds"], 720)

    def test_invalid_reserve_cannot_disable_budget(self):
        for reserve in (-1, 720, float("nan"), float("inf")):
            with self.subTest(reserve=reserve), self.assertRaises(ValueError):
                self.planner.check_budget((), 1, 720, reserve)

    def test_over_budget_plan_fails_before_emitting_membership(self):
        import tempfile
        import subprocess
        import sys
        import json
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            (root / "tests.txt").write_text("Slow\n")
            (root / "timings.tsv").write_text("test_name\tduration_seconds\nSlow\t601\n")
            result = subprocess.run([sys.executable, str(MODULE_PATH.with_name("plan-test-shards.py")),
                                     str(root / "tests.txt"), str(root / "timings.tsv"), "1", str(root / "plan.tsv"), "--duration-safety-factor", "1"],
                                    capture_output=True, text=True)
            self.assertNotEqual(result.returncode, 0)
            self.assertIn("600.0s test budget", result.stderr)
            budget = json.loads((root / "plan.budget.json").read_text())
            self.assertEqual(budget["estimated_shard_seconds"], [601])
            self.assertFalse((root / "plan.tsv").exists())

    def test_variation_factor_rejects_a_raw_plan_that_fits_without_margin(self):
        import tempfile
        import subprocess
        import sys
        import json
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            (root / "tests.txt").write_text("Slow\n")
            (root / "timings.tsv").write_text("test_name\tduration_seconds\nSlow\t510\n")
            result = subprocess.run([sys.executable, str(MODULE_PATH.with_name("plan-test-shards.py")),
                                     str(root / "tests.txt"), str(root / "timings.tsv"), "1", str(root / "plan.tsv")],
                                    capture_output=True, text=True)
            self.assertNotEqual(result.returncode, 0)
            budget = json.loads((root / "plan.budget.json").read_text())
            self.assertEqual(budget["estimated_shard_seconds"], [612])
            self.assertEqual(budget["duration_safety_factor"], 1.2)
            self.assertFalse((root / "plan.tsv").exists())

    def test_coverage_report_identifies_missing_exact_row(self):
        import tempfile
        import subprocess
        import sys
        import json
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            (root / "tests.txt").write_text("Publish (True)\n")
            (root / "timings.tsv").write_text("test_name\tduration_seconds\nPublish\t220\n")
            result = subprocess.run([sys.executable, str(MODULE_PATH.with_name("plan-test-shards.py")),
                                     str(root / "tests.txt"), str(root / "timings.tsv"), "8", str(root / "plan.tsv")],
                                    capture_output=True, text=True)
            self.assertNotEqual(result.returncode, 0)
            self.assertEqual(json.loads((root / "plan.coverage.json").read_text())["missing"], ["Publish (True)"])
            self.assertFalse((root / "plan.tsv").exists())

    def test_refresh_cli_records_source_and_rejects_local_metadata(self):
        import tempfile
        import subprocess
        import sys
        import json
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            source = root / "input"
            source.mkdir()
            (source / "discovered-tests.txt").write_text("Publish (True)\n")
            (source / "results.trx").write_text('<TestRun><UnitTestResult testName="Publish (True)" outcome="Passed" duration="00:01:15"/></TestRun>')
            catalog = root / "test-timings.tsv"
            catalog.write_text("test_name\tduration_seconds\nPublish (True)\t15\n")
            command = [sys.executable, str(MODULE_PATH.with_name("refresh-test-timings.py")), str(source), str(catalog), str(root / "output"),
                       "--run-url", "https://github.com/tryAGI/AutoSDK/actions/runs/123", "--commit", "a"*40, "--runner-os", "Linux", "--runner-arch", "X64"]
            subprocess.run(command, check=True, capture_output=True)
            provenance = json.loads((root / "output/test-timings.provenance.json").read_text())
            self.assertEqual(provenance["samples"]["Publish (True)"]["duration_seconds"], 75)
            self.assertEqual(provenance["samples"]["Publish (True)"]["commit"], "a"*40)
            command[command.index("--run-url") + 1] = "local-warmed-run"
            self.assertNotEqual(subprocess.run(command, capture_output=True).returncode, 0)


if __name__ == "__main__":
    unittest.main()
