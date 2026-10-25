# CLI integration timing estimates

The shard planner requires an estimate for every exact discovered MSTest display name.
A renamed DataRow is a new row. Missing estimates fail planning and appear in
`plan.coverage.json`; they never inherit a median cost.

For a new expensive publish, trimming, or NativeAOT case, provide an explicit seed:

```json
{
  "PublishCase (True)": {
    "duration_seconds": 300,
    "reason": "Conservative cold CI estimate until the first passed Linux X64 sample"
  }
}
```

Pass it with `plan-test-shards.py --initial-estimates seeds.json`, or set
`TEST_SHARD_INITIAL_ESTIMATES_FILE` for `run-test-shard.sh`. Measured exact-name
durations take precedence. Seeds require a nonempty reason and a finite positive
duration. No universal fallback is available.

## Refresh from CI

Every integration summary emits a `timing-candidate` directory in the
`cli-integration-summary` artifact. The refresh uses only Passed TRX rows with
their exact display names. A workflow that failed only its scheduling SLA can
still supply valid passed rows. Failed, skipped, missing, duplicated and zero
duration results cannot seed weights. A partial sample retains existing estimates
with their original provenance; it does not relabel them as new measurements.

The candidate contains `test-timings.tsv` and `test-timings.provenance.json`.
Provenance binds the catalog hash, original catalog hash, run URL, full source
commit, Linux X64 runner cohort, TRX path/hash and outcome for each refreshed row.
A catalog/provenance hash mismatch fails refresh. Local warmed runs are not a
supported source for the CI catalog.

To refresh from downloaded shard artifacts:

```bash
python3 scripts/refresh-test-timings.py downloaded-shards \
  src/tests/AutoSDK.IntegrationTests.Cli/test-timings.tsv timing-candidate \
  --run-url https://github.com/tryAGI/AutoSDK/actions/runs/RUN_ID \
  --commit FULL_SOURCE_SHA --runner-os Linux --runner-arch X64
```

Before adopting a candidate, verify its run/commit against GitHub and compare
`base_catalog_sha256` with the current tracked catalog. Review and copy both files
together in a scoped commit. The workflow produces reviewable artifacts; it
does not grant an untrusted run permission to push. Eight shards, the 720 second
SLA, and all test cases remain unchanged.

## Planning reserve

The eight-shard CI lane retains its 720 second elapsed-time SLA. Planning permits
at most 600 seconds of measured test work per shard, reserving 120 seconds for
project build, test discovery, process startup and runner variation. The planner
writes these limits and every projected load to `plan.budget.json` and fails
before emitting an over-budget plan. The runtime summary still enforces actual
elapsed time against 720 seconds.

The 2026-10-26 catalog refresh uses all 194 passed Linux X64 samples from
[run 40242096266](https://github.com/tryAGI/AutoSDK/actions/runs/40242096266)
at `ced47adc5a77c908adceba1ff1932ef1e5339466`. Its original assignments spent
392–746 seconds in tests, plus 11–15 seconds in setup. The refreshed plan assigns
580–584 seconds of measured work per shard, leaving at least 136 seconds below
the elapsed-time limit. These projections require confirmation by the next CI
run; they are not a substitute for the runtime SLA check.
