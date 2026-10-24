# Shared JSON metadata: controlled SDK consumers, 2026-10-24

AutoSDK `0.35.0-preview.2.131` substantially reduces retained serialization code in real NuGet consumers of Anthropic and ElevenLabs. Fully unused SDK references disappear. Each candidate HTTP/model/helper/WebSocket scenario publishes and executes with both trimming and NativeAOT. The full assemblies preserve every baseline public CLR type name.

This report accompanies [#429](https://github.com/tryAGI/AutoSDK/issues/429), with fixes for [#447](https://github.com/tryAGI/AutoSDK/issues/447), [#448](https://github.com/tryAGI/AutoSDK/issues/448), [#449](https://github.com/tryAGI/AutoSDK/issues/449), and [#450](https://github.com/tryAGI/AutoSDK/issues/450). Numeric results and input hashes are in [the JSON report](trimming-measurements-20261024.json). OpenAI's separate MEAI consumer results are [in its repository](https://github.com/tryAGI/OpenAI/blob/main/docs/trimming-measurements-20261024.md).

## Scope and controls

- Generator: published CLI and build-only metadata analyzer `0.35.0-preview.2.131`, repository commit `1d1c4729edbe49da7cfd20e8ae4562d656473302`; public package provenance verified.
- Anthropic baseline: `7e9bb0e671b03538032556b77a19b80b0ad06ee4`.
- ElevenLabs baseline: `91e123154cde9497445c9f337b3896ce56016542`.
- Candidate and baseline use byte-identical pinned specs. All five SHA-256 hashes are recorded in JSON. ElevenLabs later received upstream API changes; this controlled comparison predates them and does not validate the newer spec.
- Linux ARM64, .NET SDK 10.0.402/runtime 10.0.13, two CPUs, 16 GiB, no swap; source packs use the noble SDK and consumers use the noble-aot SDK image. All compilation enters the shared host admission queue. Timings below exclude that queue.
- Both variants are packed into distinct immutable local NuGet versions, then referenced through `PackageReference`, without SDK source project references. Candidate package audit confirms the analyzer is a private build dependency, without an AutoSDK/Roslyn runtime dependency.
- Consumer settings: `PublishTrimmed=true`, `TrimMode=full`, self-contained, reflection JSON disabled, trim warnings/errors enabled, `TreatWarningsAsErrors=true`, `PublishReadyToRun=false`; NativeAOT adds `PublishAot=true`.
- Fixtures exercise actual SDK serialization and offline HTTP request/response handling with nonempty fake authentication. ElevenLabs also exercises its WebSocket model helpers. No provider calls or credentials are needed.
- Each profile publishes, runs the contract, repeats an unchanged `--no-restore` publish, then changes an application success-string constant and publishes/runs again. Package, obj and output caches persist in the container.
- This is one controlled sample per profile. It measures cached compilation, **not Docker layer hits, final Docker image size, deployed startup, live provider latency, or a full Advantage backend**. It does not compare ReadyToRun profiles. No first-ever machine restore cost is claimed.

## SDK source compilation and full assemblies

Source packs use fresh build artifacts with warmed package caches. Memory is sampled every 0.1 seconds from cgroup usage and anonymous memory. Samples may miss shorter peaks; anonymous memory helps distinguish compiler allocation from file-cache usage.

| SDK | Pack seconds, baseline → candidate | User CPU seconds | Peak anonymous GB | Full DLL MB | Embedded PDB MB |
|---|---:|---:|---:|---:|---:|
| Anthropic | 166.248 → 119.791 | 255.977 → 188.798 | 11.77 → 6.44 | 102.71 → 44.55 | 25.50 → 5.01 |
| ElevenLabs | 96.566 → 79.509 | 164.959 → 131.838 | 5.90 → 4.47 | 53.87 → 31.78 | 12.81 → 3.81 |

Generated source grows: Anthropic 9,105 → 13,385 C# files (71.70 → 83.08 MB), ElevenLabs 6,856 → 10,036 (46.28 → 55.30 MB). That is approximately 16% and 19% more source bytes. The shared metadata graph reduces emitted serialization bodies and compiler work despite adding small factory/facade files. Source size and compiled size move in different directions.

Full-assembly metadata/IL bytes, method/field counts, PDB sizes and sampled cgroup peaks are recorded separately in JSON. Anthropic preserves all 6,455 public CLR type names with the same type-name hash. ElevenLabs preserves all 4,658 baseline names and adds 21 tag facade types. No baseline public name is removed. This checks type identity, not every public member signature or binary compatibility case.

## Trimmed NuGet consumers

Sizes are decimal MB. SDK DLL size includes embedded PDB data; it is not the entire self-contained publish directory. The unused-model probe checks `Message`/`Tool` for Anthropic and `VoiceResponseModel` for ElevenLabs.

| SDK/profile | Baseline SDK DLL MB | Candidate SDK DLL MB | Candidate embedded PDB MB | Unused probe retained, baseline → candidate |
|---|---:|---:|---:|---|
| Anthropic/http | 80.92 | 3.44 | 3.17 | yes → no |
| Anthropic/helper | 80.80 | 3.25 | 3.16 | yes → no |
| ElevenLabs/http | 25.24 | 3.32 | 2.49 | yes → no |
| ElevenLabs/helper | 41.13 | 2.49 | 2.44 | yes → no |
| ElevenLabs/ws | 11.30 | 2.49 | 2.44 | no → no |

For a completely unused package reference, both baseline and candidate trimmed output omit the SDK DLL. Candidate NativeAOT also executes the unused-reference fixture; its executable is 1,319,744 bytes for each SDK. The harness does not root every model or the aggregate serializer context. Positive profile contracts and PE inspection establish that unrelated model families are pruned, rather than merely observing a small executable that never exercises the SDK.

## Publish timings with preserved caches

Seconds below are measured inside the admitted container. “First” means the first publish of this consumer profile with packages already available. “Unchanged” preserves all inputs; “app edit” changes application IL and forces relevant publication work. NativeAOT output sizes count the executable only, with debug/other publish files tracked separately in JSON.

| SDK/profile | First s | Unchanged s | App edit s | Native executable MB |
|---|---:|---:|---:|---:|
| Anthropic/baseline-http-trim | 38.062 | 0.602 | 34.331 | — |
| Anthropic/baseline-http-aot | 300.031 (timeout) | — | — | — |
| Anthropic/baseline-helper-trim | 37.527 | 0.608 | 35.399 | — |
| Anthropic/baseline-unused-trim | 4.927 | 0.596 | 4.480 | — |
| Anthropic/candidate-http-trim | 11.192 | 0.577 | 8.803 | — |
| Anthropic/candidate-http-aot | 12.345 | 0.730 | 17.044 | 8.55 |
| Anthropic/candidate-helper-trim | 16.596 | 0.585 | 9.310 | — |
| Anthropic/candidate-helper-aot | 6.118 | 0.624 | 6.184 | 3.58 |
| Anthropic/candidate-unused-trim | 4.761 | 0.577 | 4.310 | — |
| Anthropic/candidate-unused-aot | 3.826 | 0.653 | 2.942 | 1.32 |
| ElevenLabs/baseline-http-trim | 13.769 | 0.621 | 13.763 | — |
| ElevenLabs/baseline-http-aot | 159.409 | 0.738 | 139.679 | 61.62 |
| ElevenLabs/baseline-helper-trim | 16.956 | 0.555 | 17.585 | — |
| ElevenLabs/baseline-ws-trim | 8.932 | 0.568 | 7.764 | — |
| ElevenLabs/baseline-unused-trim | 4.313 | 0.547 | 3.710 | — |
| ElevenLabs/candidate-http-trim | 11.053 | 0.644 | 9.476 | — |
| ElevenLabs/candidate-http-aot | 19.494 | 0.597 | 19.938 | 13.00 |
| ElevenLabs/candidate-helper-trim | 8.467 | 0.721 | 7.629 | — |
| ElevenLabs/candidate-helper-aot | 6.262 | 0.680 | 4.957 | 3.30 |
| ElevenLabs/candidate-ws-trim | 8.417 | 0.752 | 8.434 | — |
| ElevenLabs/candidate-ws-aot | 5.231 | 0.605 | 4.370 | 3.10 |
| ElevenLabs/candidate-unused-trim | 4.878 | 0.582 | 4.028 | — |
| ElevenLabs/candidate-unused-aot | 3.077 | 0.574 | 2.597 | 1.32 |

All 14 candidate profiles passed their publication and runtime contracts at all three stages. Eight completed baseline profiles also passed. Anthropic baseline HTTP NativeAOT reached native compilation but exceeded the 300-second publication budget (exit 124); it has no completed binary or warm/app-edit results. This is a censored timing, not an exact baseline duration or a fabricated speedup ratio.

Unchanged publishes are already about 0.6–0.8 seconds across both variants. The larger benefit appears after application changes: ElevenLabs HTTP NativeAOT changes from 139.679 to 19.938 seconds, with its executable shrinking from 61.62 to 13.00 MB. Anthropic HTTP trimming changes from 34.331 to 8.803 seconds after an app edit. A cached Docker layer that skips publishing altogether would not exhibit these compiler-time differences.

## Embedded symbol experiment

[#451](https://github.com/tryAGI/AutoSDK/issues/451) tracks an explicit symbol policy. A separate four-case experiment changes only `-p:TrimmerRemoveSymbols=true` in the same Anthropic trimmed consumers and executes the offline contract again.

| Profile | Default DLL bytes | With symbol removal | Default embedded PDB bytes |
|---|---:|---:|---:|
| baseline/http | 80918016 | 56159232 | 24758790 |
| baseline/helper | 80803840 | 56046592 | 24756884 |
| candidate/http | 3436032 | 262656 | 3172803 |
| candidate/helper | 3245056 | 86528 | 3158097 |

All four contracts pass. Metadata bytes, IL bytes, type/method/field counts and public type-name hashes are identical before and after symbol removal; embedded PDB payload becomes zero. Candidate HTTP/helper DLLs are 262,656 and 86,528 bytes. The few remaining byte differences beyond PDB payload reflect PE layout.

This is an explicit consumer publication option. Removing symbols reduces debugging/source-location information, so the SDK's default symbol configuration is unchanged. The 3.2 MB default Anthropic helper DLL contains 3.16 MB of embedded symbols; comparing that size alone would obscure how much serialization code was actually removed.

## Reproduction and boundaries

Use the exact baseline commits and pinned spec hashes in JSON, generate candidates with the published CLI version and shared JSON metadata flag, and pack both variants under distinct versions to prevent stale NuGet cache reuse. Consume those packages with the settings above. Publish/run the HTTP, model-helper, WebSocket-helper and unused-reference cases; preserve obj/output between the unchanged and application-edit passes. Inspect full and trimmed assemblies using `PEReader`/`MetadataReader`, enumerating public CLR type names, IL bodies and embedded portable-PDB debug entries. Do not treat a debug file or runtime payload as SDK code.

The full generator CI for `1d1c4729` is [green](https://github.com/tryAGI/AutoSDK/actions/runs/40036884870), and 57 focused metadata/context regressions pass. Anthropic adoption commit `43597364` has [green CI](https://github.com/tryAGI/Anthropic/actions/runs/40039875108). The controlled ElevenLabs measurements are valid for the old pinned spec, while final publication of its adoption commit requires preserving newer upstream API updates and validating regenerated output. Phased fleet issue #429 remains open.
