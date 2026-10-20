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


if __name__ == "__main__":
    unittest.main()
