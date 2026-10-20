# Shared JSON metadata acceptance: OpenAI and AppStoreConnect

Measured 2026-10-20 UTC / 2026-10-21 Dubai. The new **opt-in**
`--shared-json-metadata` profile removes the automatic aggregate fallback from
operation defaults and model helpers. Both real SDKs now enable this profile.
Unmigrated SDKs retain the compatibility profile; fleet rollout is #429.
An explicitly accessed/assigned public aggregate context intentionally retains all
of its metadata. The build-only analyzer has no consumer runtime dependency.

## Pinned comparison

- Baseline AutoSDK: `8e5fcadc8c1478650760adde68c2a2a2807e4f87`.
- Candidate generator: `53b7eac0fea21bb3d54aaade84ae8ed03fbbf51e`.
- Published build analyzer: `AutoSDK.JsonMetadata/0.35.0-preview.2.98`, private SDK build dependency.
- OpenAI source: `f2fedc5807e4d697f58f4e1b116c71e8ee6b94b9`.
- AppStoreConnect source: `2d590ad604cddbc705795563c4fb0e6d035ac550`.
  Subsequent upstream regeneration only changed generated converters/client lazy
  context accessors; the pinned spec and handwritten build inputs were unchanged.
  Actual canonical regeneration matched final benchmark-generated files byte for byte.
- .NET SDK 10.0.402/runtime 10.0.13, official Ubuntu Noble Linux ARM64 images,
  two CPUs, SDK source compile limit 16 GiB/no swap. Existing AppStore compiler
  heap policy and both SDKs' analyzer settings were preserved.
- Self-contained consumers reference precompiled SDK NuGets: `PublishTrimmed=true`,
  `TrimMode=full`, `PublishReadyToRun=false`, reflection JSON fallback disabled,
  trim warnings enabled and treated as errors. Root and directly constructed tag
  clients execute nonempty typed JSON with a fake HTTP handler, network disabled.
  This is offline serialization/runtime proof, not provider availability evidence.
- Source compile timings below are one sample per variant, with warm NuGet/runtime
  packs. Inner process wall times exclude host queue/container startup. They are
  cost observations, not timing percentiles or a guaranteed speedup.

Raw bytes, commands, hashes, memory and per-consumer results are in the adjacent
[JSON evidence](shared-json-metadata-20261021.json). MB below is decimal.

## Full SDK cost

| Metric | OpenAI baseline | OpenAI shared | AppStore baseline | AppStore shared |
| --- | ---: | ---: | ---: | ---: |
| Untrimmed DLL, MB | 78.960 | 73.001 | 177.801 | 132.505 |
| NuGet, MB | 18.816 | 17.638 | 79.329 | 55.631 |
| Source compile wall, s | 141.732 | 140.370 | 1089.724 | 831.241 |
| Source compile user CPU, s | 200.118 | 179.441 | 1347.589 | 1005.806 |
| Compiler peak cgroup, GB | 10.025 | 10.357 | 16.809 | 15.524 |
| Incremental unchanged SDK build, s | 3.678 | 2.124 | 5.511 | 5.726 |
| AutoSDK emitted C#, MB | 79.433 | 100.293 | 157.589 | 197.649 |
| Additional metadata manifest, MB | 0 | 1.766 | 0 | 5.538 |
| STJ compiler-generated C#, MB | 164.229 | 138.369 | 250.026 | 144.714 |

The generated repository source grows because narrow resolvers replace aggregate
lookup tables. This does **not** translate into a larger compiled SDK: whole DLLs
shrank 7.5% and 25.5%, NuGets 6.3% and 29.9%. OpenAI peak memory rose 3.3%; its
source wall time is essentially unchanged. AppStore source wall time fell 23.7%
and peak memory fell 7.6%. An earlier independent-context prototype enlarged the
OpenAI DLL by 22% and peak memory by 33%; it was rejected in favor of shared factories.
SDK source compilation is a package producer cost and is not repeated when an
application consumes its NuGet and changes application code.

## Actual retained models and serializers

| Trimmed consumer | Baseline SDK DLL | Shared SDK DLL | Baseline types → shared types |
| --- | ---: | ---: | ---: |
| OpenAI root.Models | 57,095,680 B | 110,080 B | 21,126 → 101 |
| OpenAI direct ModelsClient | 57,094,144 B | 108,544 B | 21,124 → 99 |
| AppStore root.Builds | 72,594,944 B | 30,151,680 B | 12,136 → 1,043 |
| AppStore direct BuildsClient | 72,567,808 B | 30,150,656 B | 12,135 → 1,042 |

For OpenAI, unused `CreateChatCompletionRequest`, same-tag `DeleteModelResponse`
and their `Create_*` metadata factories are absent from the linked assembly.
The separate chat request/union/response consumer also runs and retains 906,752 B.
For AppStore, unrelated `AccessibilityDeclaration` and its exact metadata factory
are absent. `AppRelationshipsAccessibilityDeclarations` remains legitimately
reachable through the live response; matching a substring would produce a false
failure. Public endpoint signatures are unchanged: all **965 OpenAI** and
**2,865 AppStoreConnect** public asynchronous overloads are preserved.
Full untrimmed CLR type loading passes for 30,279 OpenAI and 54,081 AppStore types;
AppStore's dynamic-field/enum roundtrip and direct context isolation also pass.

The large AppStore linked DLL is mostly symbols: baseline embedded PDB is
44,987,690 B; candidate PDB is 28,497,101 B. Candidate DLL excluding that embedded
payload is **1,654,579 B** versus baseline 27,607,254 B. Symbol packaging is tracked
separately in #430; this comparison did not change debug configuration.

Baseline AppStore trimming failed under 6 GiB in Cecil's embedded-PDB writer.
An explicitly labeled 12-GiB retry passed, peak 6.466 GB. Candidate root and leaf
pass at the original 6-GiB consumer limit (root peak 5.014 GB). The evidence keeps
the failed baseline; it is not counted as a successful 6-GiB run.

## NativeAOT and cache behavior

Both candidate root consumers publish and run with NativeAOT and no reflection
fallback. OpenAI native executable is 8,175,616 B; AppStore 19,334,848 B. These are
whole test executables including their runtime code, not isolated SDK contributions.
AOT produces separate debug files (13,832,048 B / 58,626,336 B); total publish
folders include these and must not be mistaken for deployment executable size.
The AOT smoke is a compatibility check; this is not a complete Advantage Docker
image or baseline-vs-candidate AOT deployment comparison.

Repeated package-consuming publishes preserve the same Docker image, NuGet and
runtime-pack cache, obj/bin and output. Each result is executed with the network
disabled. The application edits force compilation while retaining the same API
graph. Unchanged SDK source builds are separately listed above. These are process
cache measurements; they do not measure registry transfers, BuildKit layer hits,
whole Advantage image size, startup or deployment duration.

| Warm package consumer | Unchanged baseline → shared, s | App edit 1 baseline → shared, s | App edit 2 baseline → shared, s |
| --- | ---: | ---: | ---: |
| OpenAI root | 1.596 → 0.910 | 25.204 → 12.609 | 24.333 → 12.626 |
| AppStore root | 0.923 → 1.014 | 26.717 → 21.162 | 26.410 → 19.024 |

The baseline AppStore repeats use the explicitly labeled 12-GiB consumer profile;
shared repeats use 6 GiB. All twelve resulting binaries execute successfully.
Two source edits are too few samples to infer stable p50/p95 or causality for
sub-second no-op differences.

A separate **plain STJ, no AutoSDK/no PackageReference** reproduction exposes stale
trimmed `.deps.json` when a warm edit adds a framework dependency under SDK
10.0.402. The second publish succeeds but runtime cannot load System.IO.Pipelines.
Fresh intermediates pass; deleting only the stale intermediate deps file and
republishing repairs it in 1.193 s while preserving compilation/package caches.
See #432. Unchanged and same-graph edit successes do not establish correctness
for arbitrary API-graph changes. No artificial runtime roots were added to hide it.

## Coverage and remaining work

- Seven serializer graph planning tests, four compiler-component tests, 296
  unchanged snapshots and the large 40-tag/1,440-model fixture cover narrow root,
  leaf and explicit aggregate behavior, nullable/primitive unions and both
  extension-data representations. The two parameterized retention cases each
  publish/run multiple consumers. Cross-target CSharp builds remain warning-free.
- The analyzer pins the official STJ generator, transforms only manifest contexts,
  preserves ordinary STJ contexts and rejects unsupported instance writers with
  AMETA001. A released-package trim/runtime probe passed with no runtime analyzer
  or Roslyn dependency. The CLI NativeAOT CI lane remains enabled.
- #428: remaining cross-chunk implicit dependency duplication; canonical factories
  already shared across resolvers, but the profile is not claimed to have exactly
  one compiled factory for every implicit chunk dependency.
- #429: scaffold/fleet migration; #430: separate embedded symbols; #431: precise
  standalone model-helper components; #432: warm deps correctness; #433: scalar
  classification/API-signature compatibility. These are future work, not hidden
  regressions or relaxed build budgets.

SDK adoption commits: OpenAI `b0138307f1b652829c91a538afd8c21bdb3d9fc6`,
AppStoreConnect `a724586f1f5a89cb720f9800a9eb36cad1da0d38` (includes the concurrent
upstream generation merge). See linked commits/actions for complete CI state.
