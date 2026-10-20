# Shared JSON metadata: final large-SDK comparison

Measured 2026-10-20 UTC / 2026-10-21 Dubai. The **opt-in**
`--shared-json-metadata` profile removes automatic aggregate fallback from
operation defaults and model helpers. Both SDK repositories enable it.
Unmigrated SDKs retain their compatibility profile; fleet/scaffold adoption and
coordinated CLI/analyzer upgrades are tracked in #429.
Explicit aggregate/custom contexts retain their documented caller-owned behavior.
The analyzer is a private producer build dependency, with no consumer runtime
Roslyn/analyzer dependency.

## Provenance and measurement limits

- Baseline AutoSDK: `8e5fcadc8c1478650760adde68c2a2a2807e4f87`.
- Final generator/compiler implementation: `897d227dc744f064399688973a303f1eb8f1d71f`.
  The later `faa07bd6e3df9ff92d5a11e51e072b4892545390` fixes documentation/analyzer
  compliance of an intentional byte-array **test fixture**, with no generator change.
- Public build package: **AutoSDK.JsonMetadata 0.35.0-preview.2.102**. Its nuspec
  records implementation commit 897d227. Every non-signature file matches the
  successful CI package artifact; its nuspec has no runtime dependency group.
- OpenAI source/spec: `f2fedc5807e4d697f58f4e1b116c71e8ee6b94b9`.
- AppStore source/spec: `2d590ad604cddbc705795563c4fb0e6d035ac550`.
  Later upstream regeneration changed only generated converters/lazy accessors;
  handwritten build inputs and specs were unchanged. Canonical regeneration in
  both real repositories matches the final benchmark-generated files byte for byte.
- Official Ubuntu Noble Linux ARM64 images: SDK 10.0.402/runtime 10.0.13.
  SDK source compiles use two CPUs, 16 GiB/no swap; existing compiler heap and
  analyzer policies are preserved. Peak memory is whole-container cgroup memory,
  including relevant caches, not just managed GC heap.
- Source timings are one observation per variant with warm NuGet/runtime caches.
  Other admitted host work also ran. Inner wall times exclude admission/container
  setup; CPU times are reported separately. These are **not isolated causal
  speedups or p50/p95 estimates**.
- Consumers reference precompiled NuGets, self-contained/full trimming,
  ReadyToRun off, reflection JSON fallback off, trim warnings enabled and treated
  as errors. Fake HTTP handlers exercise nonempty typed JSON; published binaries
  run with networking disabled. This proves serialization/retention behavior,
  not provider availability, a complete Advantage image or deployment speed.

The adjacent [JSON evidence](shared-json-metadata-20261021.json) contains exact
bytes, commands, hashes, image digests, resource limits, failed probes and runtime results.

## SDK producer cost

MB is decimal. Compiler-emitted source includes JSON generators and auxiliary output.

| Metric | OpenAI baseline | OpenAI shared | AppStore baseline | AppStore shared |
| --- | ---: | ---: | ---: | ---: |
| Untrimmed DLL, MB | 78.960 | 73.027 | 177.801 | 132.521 |
| NuGet, MB | 18.816 | 17.643 | 79.329 | 55.656 |
| Source compile wall, s | 141.732 | 163.586 | 1089.724 | 935.512 |
| Source user CPU, s | 200.118 | 203.497 | 1347.589 | 1102.932 |
| Peak cgroup, decimal GB | 10.025 | 10.360 | 16.809 | 15.859 |
| Unchanged SDK source build, s | 3.678 | 3.455 | 5.511 | 4.171 |
| AutoSDK emitted C#, MB | 79.433 | 100.513 | 157.589 | 198.345 |
| Additional manifest, MB | 0.000 | 1.766 | 0.000 | 5.538 |
| Compiler-emitted C#, MB | 164.229 | 138.533 | 250.026 | 144.742 |

Whole DLLs shrink **7.5% / 25.5%**, NuGets **6.2% / 29.8%**. Repository C# grows
about 26% because narrow resolver tables replace aggregate lookup; compiler-emitted
C# is smaller. OpenAI's final source wall sample rises 15.4%, while user CPU rises
1.7% and peak cgroup memory rises 3.3%. AppStore wall falls 14.2%, user CPU falls
18.2%, peak memory falls 5.7%. Treat the wall differences within the stated
host/single-sample limits. SDK **NuGet consumers do not repeat SDK source generation
or compilation** on application edits.

An earlier independent-context prototype enlarged the OpenAI DLL by 22% and peak
memory by 33%. It was rejected in favor of shared factories. Further cross-chunk
implicit-factory deduplication remains #428.

## Actual retained DTOs and factories

| Trimmed consumer | Baseline SDK bytes | Shared SDK bytes | Baseline → shared CLR types |
| --- | ---: | ---: | ---: |
| OpenAI root | 57,095,680 | 110,080 | 21,126 → 101 |
| OpenAI leaf | 57,094,144 | 109,056 | 21,124 → 99 |
| AppStoreConnect root | 72,594,944 | 30,166,528 | 12,136 → 1,043 |
| AppStoreConnect leaf | 72,567,808 | 30,164,992 | 12,135 → 1,042 |

OpenAI's unrelated `CreateChatCompletionRequest` and same-tag `DeleteModelResponse`
plus their exact `Create_*` factories disappear from model-list consumers. A separate
chat/union/request/response consumer also runs and retains 909,312 B.
AppStore's `AccessibilityDeclaration` and its exact factory disappear.
`AppRelationshipsAccessibilityDeclarations` is a legitimately reachable relationship
stub; substring matching would incorrectly flag it.

All **965 OpenAI / 2,865 AppStore** public async signatures are unchanged.
Untrimmed CLR loading passes for **30,279 / 54,081** types. AppStore's direct-context
isolation and dynamic-field/enum roundtrip also pass.

AppStore's linked DLL includes **28,511,724 B embedded PDB**;
its non-embedded-PDB portion is **1,654,804 B**, versus
27,607,254 B baseline. Symbols are separate optimization #430; this comparison
preserves debug settings. Baseline AppStore failed its 6-GiB consumer publish in
Cecil's embedded-PDB writer. Its explicitly labeled 12-GiB retry passes; the
candidate passes at the original 6 GiB. The raw evidence preserves that failed
baseline rather than counting it as a successful 6-GiB run.

## Compiled partial members: a real regression caught and fixed

The intermediate implementation (.98 / 53b7eac) passed model-list/chat fixtures
but failed OpenAI's live image response: handwritten partial `Image2.Bytes`
introduces `byte[]`, absent from OpenAPI. Stock STJ sees the property and emits a
factory, while a schema-only resolver could not return that factory.

The final compiler uses official STJ property/collection/constructor/polymorphic
metadata dependencies to supplement each narrow graph with only missing reachable
compiled-model types. It preserves ignored-property handling and cycles. Optional
hooks disappear when no supplement is needed. The final OpenAI/AppStore compiles
emit 139 / 49 small supplementary resolver files.

An expanded image fixture with usage, extension data and bytes now passes both
`ImagesResponse.FromJson` and `CreateImageAsync` offline against precompiled SDKs.
The same scenario publishes/runs under NativeAOT (9,368,896 B test executable).
A repository regression additionally exercises helper serialization of `Bytes` and
extension data. The 40-tag/1,440-model fixture includes an actual handwritten
byte-array member, tests root/direct/custom aggregate consumers, and checks that
unrelated DTOs/factories still disappear in both extension-data profiles. See #434.

## NativeAOT and warm application publishing

Both candidate root consumers publish and execute under NativeAOT:
OpenAI **8,241,376 B**, AppStore
**19,334,848 B** native test executables.
These include runtime code and are not isolated SDK contributions. Separate debug
files are **13,861,008 / 58,627,976 B**;
do not mistake total folders including symbols for deployment executable size.
This is compatibility proof, not a complete Advantage AOT/Docker comparison.

Warm publishes preserve obj/bin/output plus NuGet/runtime packs and Docker images.
Each application edit forces compilation but keeps the same API graph. Every
resulting binary is executed offline. AppStore baseline uses the explicitly
labeled 12-GiB consumer profile; candidate uses 6 GiB.

| Warm root consumer | Unchanged baseline → shared, s | Edit 1 baseline → shared, s | Edit 2 baseline → shared, s |
| --- | ---: | ---: | ---: |
| OpenAI | 0.902 → 0.925 | 24.508 → 13.617 | 25.318 → 12.177 |
| AppStoreConnect | 1.082 → 1.102 | 26.429 → 18.687 | 25.950 → 17.464 |

All twelve binaries pass. Two changed samples are not stable timing percentiles;
sub-second no-op differences do not establish a regression or improvement.
These process measurements do not measure BuildKit layer hits, registry transfers,
whole Advantage image size, startup or deployment duration.

A separate **plain STJ/no AutoSDK/no PackageReference** repro exposes stale trimmed
`.deps.json` after a warm edit adds a framework dependency on SDK 10.0.402. The
second publish succeeds but runtime cannot load System.IO.Pipelines. Fresh
intermediates pass; deleting only the stale intermediate deps file repairs it in
1.193 s while retaining other caches. #432 tracks a production-safe guard and
upstream report. Same-graph edit successes do not prove arbitrary graph-change
correctness. No artificial SDK/runtime roots hide that defect.

## Coverage, CI and remaining work

- Seven graph-planning tests, five compiler-component tests, 296 unchanged
  snapshots; 709 AutoSDK unit cases pass in the release job. No snapshots were
  accepted to conceal API changes.
- Final AutoSDK code CI: [39495033602](https://github.com/tryAGI/AutoSDK/actions/runs/39495033602)
  **success**, all 188 CLI integration tests pass. Eight shards keep the original
  720-s limit; maximum elapsed is 679 s. The timing refresh uses Passed TRX rows,
  not a raised budget or removed test. Parameter-row filter escaping is also
  verified against VSTest. The native CLI/source-generator lanes pass.
- Public-package content/provenance, ordinary STJ coexistence, trim/AOT runtime,
  CLR load, direct/root/custom options, model/serializer pruning and signature
  checks are separate evidence, not substitutes for one another.
- SDK final commits/runs: OpenAI
  [53c04bd4f](https://github.com/tryAGI/OpenAI/commit/53c04bd4f6adf8d6426061d66bd3af99f4135045),
  [CI 39498996240](https://github.com/tryAGI/OpenAI/actions/runs/39498996240);
  AppStore [d6413821](https://github.com/tryAGI/AppStoreConnect/commit/d641382126c9c39b539fafe716c512e1491570c2),
  [CI 39499004690](https://github.com/tryAGI/AppStoreConnect/actions/runs/39499004690).
  Both runs completed **successfully**, including build, tests, trimming checks and
  publication. Provider credential skips and offline contracts remain separate
  from comprehensive live coverage of every endpoint.
- #428: implicit chunk duplication; #429: fleet/scaffolds/version coordination;
  #430: symbol packaging; #431: precise standalone helper components; #432: warm
  dependency output; #433: scalar/API-hook compatibility; #435: timing coverage;
  #436: actionable error text before large bodies.
- The .102 analyzer used in this original benchmark forwards nested errors but
  omits warnings (#437), so its reported compiler warning counts do not establish
  complete nested-driver diagnostic coverage. The bridge now forwards warnings;
  [follow-up evidence](shared-json-followups-20261021.md) records strict diagnostic
  tests, both large-SDK source rechecks, warm-cache correctness and symbol removal.
