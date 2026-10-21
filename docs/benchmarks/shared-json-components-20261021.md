# Directed shared JSON metadata components

The `0.35.0-preview.2.113` release discovers metadata in one STJ context, relocates
factories into independent holders, and composes model helpers through directed
strongly connected components. This completes the pre-generation deduplication
and precise-helper work in [#428](https://github.com/tryAGI/AutoSDK/issues/428) and
[#431](https://github.com/tryAGI/AutoSDK/issues/431). CLI/analyzer coordination,
scaffolds and the first two-SDK adoption batch are implemented under
[#429](https://github.com/tryAGI/AutoSDK/issues/429).

[Machine-readable evidence](shared-json-components-20261021.json) records exact
inputs, package/DLL hashes, resource limits, runtime receipts, retention checks,
warm repeats and Docker layers.

## Full SDK costs

The comparison is against the preceding shared-factory profile, not the older
aggregate-fallback SDK. Linux ARM64, .NET SDK 10.0.402/runtime 10.0.13; both source
builds use 2 CPUs, 16 GiB and no swap. NuGet/runtime-pack caches are warm.
Times below exclude host-admission queues and are single samples.

| Metric | OpenAI previous → directed | AppStoreConnect previous → directed |
| --- | ---: | ---: |
| Whole SDK DLL, bytes | 73,027,072 → 53,840,896 | 132,520,960 → 117,843,456 |
| NuGet, bytes | 17,643,279 → 12,477,394 | 55,656,382 → 43,779,357 |
| Source build wall, seconds | 163.586 → 96.035 | 935.512 → 960.718 |
| Source build user CPU, seconds | 203.497 → 129.466 | 1,102.932 → 1,202.853 |
| Peak cgroup bytes | 10,359,869,440 → 6,988,107,776 | 15,858,733,056 → 15,939,375,104 |
| No-op source build, seconds | 3.455 → 3.325 | 4.171 → 5.094 |
| AutoSDK C# source, bytes | 100,512,906 → 103,801,918 | 198,344,823 → 207,451,469 |
| Compiler-generated C#, bytes | 138,532,696 → 55,287,038 | 144,741,783 → 79,909,805 |

Both whole DLLs and packages shrink. AppStoreConnect remains within its existing
16-GiB compilation budget: wall time increases 2.7%, user CPU 9.1%, peak memory
0.5%. More small component files increase its no-op input-scanning cost.
These measurements do not establish stable timing percentiles.

All CLR types load successfully: 71,053 OpenAI and 147,844 AppStoreConnect types.
These counts increase from 30,279 / 54,081 because factories and scopes now have
independent internal holders. The previous giant compiler-generated closure
failure is not reintroduced. Internal-type overhead is tracked separately in
[#440](https://github.com/tryAGI/AutoSDK/issues/440).

## Published consumers

Consumers use precompiled SDK NuGets, with reflection serialization disabled,
full trimming, 2 CPUs and 6 GiB/no swap. SDK source compilation is excluded.

| Trimmed SDK DLL, bytes | Previous | Directed |
| --- | ---: | ---: |
| OpenAI root / Models.ListModels | 110,080 | 123,392 |
| OpenAI leaf / Models.ListModels | 109,056 | 121,856 |
| OpenAI typed chat | 909,312 | 1,110,528 |
| OpenAI nested ChatCompletionTokenLogprob helper | 166,912 | 38,400 |
| OpenAI ConversationResourceMetadata wrapper helper | not collected | 23,040 |
| AppStoreConnect root / Builds collection | 30,166,528 | 20,758,016 |
| AppStoreConnect leaf / Builds collection | 30,164,992 | 20,756,992 |
| AppStoreConnect ResourceLinks helper | 28,461,568 | 18,572,288 |
| AppStoreConnect empty-wrapper helper | not collected | 18,570,752 |

The OpenAI chat increase is real: the public non-context type set stays identical
at 386 types, while metadata infrastructure types grow from 141 to 1,572.
The nested helper instead removes upstream/sibling types: public non-context
types decrease 68 → 3 in OpenAI and 10 → 2 in AppStoreConnect.
The remaining context overhead is the measured follow-up in #440.

AppStoreConnect sizes include embedded debug data. The directed root contains
18,666,240 compressed PDB bytes; its standalone helper contains 18,548,247.
Do not interpret these symbol bytes as retained model IL. Symbol policy and the
separate stripping experiment remain documented in
[the cache/symbol follow-up](shared-json-followups-20261021.md) and
[#430](https://github.com/tryAGI/AutoSDK/issues/430).

NativeAOT root executable bytes are 8,241,376 → 7,619,896 for OpenAI and
19,334,848 → 19,342,544 for AppStoreConnect. Native helper executables are
3,234,520 / 3,102,128 bytes; empty-wrapper executables are 3,167,656 / 3,102,048.
Debug sidecars are counted separately in the JSON evidence.

All **16** selected runtime profiles pass: OpenAI has root, leaf, chat, nested
helper and wrapper trimming profiles plus root/chat/helper/wrapper NativeAOT;
AppStoreConnect has root/leaf/helper/wrapper trimming plus root/helper/wrapper
NativeAOT. Contracts use nonempty typed JSON, nested collections, manually
supplied extension-data values and unknown JSON fields. No provider calls or
live credentials are involved.

PE checks confirm unrelated endpoint models and factories disappear, including
OpenAI's unused same-client DeleteModel response. Explicit public aggregate
serialization remains an intentional way to retain the complete graph.

## Ownership and compatibility

An additional audit found emitted map-wrapper classes omitted from `Data.Types`.
Their model helpers still referenced the aggregate default. The planner now seeds
every emitted class, enum and named union, and retargeting no longer silently
falls back. Both complete generated SDKs have **zero** unintended aggregate model
helper defaults, compared with 158 / 42 in the intermediate prototype.
[#438](https://github.com/tryAGI/AutoSDK/issues/438) records the defect and proof.

Protocol 2 prevents an older analyzer from flattening the component graph.
Generated props bind the analyzer to the producing CLI version, with
`PrivateAssets="all"`. Unsupported formats fail with AMETA003; old unversioned
manifests retain their original ABI while migration proceeds. New SDK scaffolds
enable the flag and binding together. The adoption/package audit passes for both
canonical SDK projects and rejects runtime AutoSDK/Roslyn compiler dependencies.

The focused suites pass 16 metadata tests, 11 planner tests and 3 adoption-audit
tests. The large 40-tag regression publishes nested-helper, root, leaf and
explicit-aggregate consumers for both extension-data representations; it includes
deprecated models, cycles/partial members and unknown JSON fields.
The strict NativeAOT CLI matrix also compares shared-profile output.

The full [AutoSDK CI](https://github.com/tryAGI/AutoSDK/actions/runs/39519593459)
passes. Canonical SDK regenerations use the actually downloaded published
CLI/analyzer .113, rather than the private benchmark build. Both canonical CI runs also pass:
[OpenAI](https://github.com/tryAGI/OpenAI/actions/runs/39522006985) and
[AppStoreConnect](https://github.com/tryAGI/AppStoreConnect/actions/runs/39522039100),
including their trimming checks.

## Repeated publication and Docker layers

Unchanged consumer publishes take 0.860 s (OpenAI) and 0.960 s (AppStoreConnect).
Two warmed application edits take 9.622 / 10.489 s and 21.045 / 14.300 s.
These are bounded samples, not throughput or deployment SLOs.

For both SDKs, a split dependency/application Docker layout is tested with an
actual application-code change and republish. All dependency-file hashes and
dependency layers stay identical; only the application layer changes. No-op
builds reuse every layer. Initial/no-op/changed images all execute their offline
contract under 512 MiB.

| Image metric | OpenAI | AppStoreConnect |
| --- | ---: | ---: |
| Initial Docker-reported size, bytes | 56,150,318 | 75,274,124 |
| Sum of raw history layer sizes, bytes | 181,747,712 | 202,403,840 |
| Initial / no-op / app-edit image-build seconds | 2.062 / 0.451 / 0.619 | 2.226 / 1.476 / 0.685 |

Docker-reported size depends on its storage engine and is not labeled
uncompressed size. Raw history sums are separate. A smaller stable SDK layer
does not save that layer's upload on every application-only deployment once it
is cached. No registry transfer or full Advantage production image is measured.

## Remaining optimization work

- [#440](https://github.com/tryAGI/AutoSDK/issues/440): reduce internal component
  context/holder overhead without widening live model graphs.
- [#441](https://github.com/tryAGI/AutoSDK/issues/441): measure factory construction
  and options-bound caching. In a 1,000-round-trip nested-helper probe, OpenAI
  becomes faster (84.293 → 44.002 ms), while current-thread allocation grows
  15,276,960 → 15,932,960 bytes. AppStoreConnect shows the same tradeoff
  (51.198 → 24.275 ms; 7,122,944 → 7,778,944 bytes). JSON/model allocations are
  included; these are not isolated resolver-attribution measurements.
- [#439](https://github.com/tryAGI/AutoSDK/issues/439): define directed defaults
  for AsyncAPI/WebSocket send/receive. OpenAI Realtime retains its previously
  validated generation profile.

Existing SDKs outside this first batch remain explicit migrations under #429;
legacy frameworks and split packages keep their validated compatibility path.

## Reproduction and provenance

The source comparison reuses archival provider bases
`f2fedc5807e4d697f58f4e1b116c71e8ee6b94b9` (OpenAI) and
`2d590ad604cddbc705795563c4fb0e6d035ac550` (AppStoreConnect), with identical
generation flags and compiler limits before/after. Exact spec hashes, CLI
assembly hashes and commands are in the JSON.

Canonical OpenAI later inherited the four-line spec update `4347ed857` before
the .113 regeneration. Its current CI is separate proof from the archival
timing samples. Canonical commits are `b6b7a988700041adedfe2b7710b875248b0e9de4`
and `e2f5b42e397381b0c7da5d3832020dc6ababd50e`.

Use each SDK's `generate.sh --pinned-spec` with an exact
`AUTOSDK_EXECUTABLE`, then build with `EmitCompilerGeneratedFiles=true`,
`UseSharedCompilation=false`, one MSBuild node and the recorded container
limits. Pack first; publish test applications against those immutable NuGets.
The committed CLI/planner/metadata regressions provide the deterministic
behavioral gate independently of these machine-specific timing samples.
