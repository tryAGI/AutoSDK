# Shared JSON follow-ups — 2026-10-21

Follow-up to [the original large-SDK acceptance](shared-json-metadata-20261021.md).
These are separate axes: diagnostic coverage, warm dependency correctness, and
debug payload. The published SDK consumer package inputs and original size
comparison remain pinned in that report.

## Nested STJ warnings (#437)

[154d1fb141](https://github.com/tryAGI/AutoSDK/commit/154d1fb141193aaacb77812815a096b5c9144b1d)
forwards nested official STJ warnings as AMETA002, preserving original SYSLIB
ID/message and source or additional-manifest provenance. It avoids invalid
locations from augmented syntax trees and does not duplicate ordinary-context
diagnostics. A comparison generator run occurs only on the warning path.

[abcbc22daa](https://github.com/tryAGI/AutoSDK/commit/abcbc22daa43bc85aca287cf037fe29ace2085a5)
also preserves explicitly configured per-SYSLIB error severity, in addition to
global TreatWarningsAsErrors. Focused tests: **9 passed, 0 failed**.
[Code CI](https://github.com/tryAGI/AutoSDK/actions/runs/39507536724) **succeeded**.

Both full source probes with the updated build-only analyzer passed with zero
warnings/errors and byte-identical compiler-generated source maps:

| Metric | OpenAI | AppStoreConnect |
| --- | ---: | ---: |
| Identical generated files | 23,829 | 38,312 |
| Full DLL, prior candidate | 73,027,072 B | 132,520,960 B |
| Full DLL, diagnostic recheck | 73,027,072 B | 132,515,328 B |
| Recheck process time | 183.635 s | 938.215 s |
| Prior candidate process time | 163.586 s | 935.512 s |
| Recheck peak cgroup memory | 9,744,375,808 B | 15,622,594,560 B |

OpenAI DLL SHA is identical. AppStore's small byte difference is in a build with
embedded debugging data and different intermediate paths; generated C# is
identical. These single source samples ran on a busy shared host and do not
isolate a causal OpenAI timing regression. The source probes use 154d1fb141;
the subsequent severity-only change affects the warning path and its two
warnings-as-errors configurations are covered separately.

Maintained SDK project references remain pinned to the previously released
.102 analyzer. These probes selected the updated analyzer explicitly.
Coordinated analyzer/CLI package adoption is still
[#429](https://github.com/tryAGI/AutoSDK/issues/429), rather than an implicit
claim that every generated SDK already uses the diagnostic fix.

## Warm trimmed dependency manifests (#432)

Plain STJ, without AutoSDK or any PackageReference, reproduces a successful warm
trimmed publish whose stale deps.json then prevents resolving System.IO.Pipelines.
Upstream report: [dotnet/sdk#56730](https://github.com/dotnet/sdk/issues/56730).

The tested mitigation adds ILLink's removed managed-assembly set to the existing
`_GeneratePublishDependencyFilePropertyInputsCacheToHash` after ILLink.
It uses the SDK's own WriteOnlyWhenDifferent hash target. No compiler, NuGet,
linker, Docker or obj/bin cache is cleared.

A four-stage API read / add serialization / remove serialization / no-op matrix
passed all **16 protected executables** across ordinary self-contained,
trimmed IL, trimmed + ReadyToRun, and NativeAOT profiles. The mitigation activates
only in the two trimmed IL profiles. Guarded deps digests change on addition and
removal; the final no-op keeps both digest and nanosecond modification time of
deps.json and its input cache. No-op publish times were 0.763–1.104 seconds.

The unguarded control captured the expected missing-assembly exception.
Docker did not finish the crashed container before the 60-second bound; the
preserved runtime exit is 124, not relabeled as a normal exit or 134.
The acceptance oracle requires the captured FileNotFoundException and assembly
name, so an unrelated timeout does not establish this defect.

This workaround depends on SDK-private target/item names and must retain an
executable regression when upgrading .NET. It is a consumer build mitigation,
not a new runtime root in generated SDKs. Runtime graph edits involving package
reference removal and upstream fix adoption remain follow-up scope in #432.

## Publish-only symbol removal (#430)

Same AppStoreConnect package, typed offline builds endpoint, full trimming,
Linux ARM64, two CPUs and six-GiB consumer budget. The only symbol profile
difference is explicit `TrimmerRemoveSymbols=false/true`; DebuggerSupport and
the producer package policy are unchanged. Profiles have separate stable
intermediate directories, with four warm phases inside each profile.

| Metric | Preserve embedded PDB | Remove symbols |
| --- | ---: | ---: |
| Linked SDK DLL | 30,166,528 B | 1,654,272 B |
| Embedded PDB in DLL | 28,511,724 B | 0 B |
| Total publish | 55,062,502 B | 26,539,046 B |
| Local Docker image | 85,023,512 B | 56,506,085 B |
| No-op publish | 0.998 s | 1.370 s |
| App edit 1 / 2 | 19.550 / 20.482 s | 15.317 / 16.106 s |
| Profile-cohort peak memory | 5,067,059,200 B | 4,622,475,264 B |

All **8 image executions passed**. Both DLLs have the same **1,043 types,
8,261 methods**, endpoint names and serializer factory set. The SDK DLL does not
change across app edits within a profile. Every filesystem layer is reused for
the no-op, although image configuration IDs can change.

Image Size fields are local Docker-reported values, including a common runtime-deps
base. They are storage-engine-dependent and are not assumed uncompressed.
No registry upload or compressed transfer was measured. This fixture uses one
COPY for the whole publish directory, so real application edits change that
layer even though only 19,904 / 8,704 bytes of individual files changed.
Do not extrapolate these small-consumer image sizes to the full Advantage image.

Only two warm app edits were sampled per symbol profile, on a non-idle host.
Cold phase timing is excluded from speedup attribution because restore/cache
conditions differ. Cohort peak includes four publish processes and page cache.
Stripping removes source-line debug information from the deployed linked
assemblies; portable PDB/snupkg/Source Link and debugger acceptance remain open
in [#430](https://github.com/tryAGI/AutoSDK/issues/430). No global symbol policy
was changed. OpenAI already disables embedded symbols.

The private Advantage harness, executable profiles and raw receipts were
committed separately. Its Python footprint suite passed **39 tests**; a full
Advantage backend rebuild was not repeated for that scoped MSBuild/Python change.

## Cached dependency versus application layers

Advantage already separates stable dependencies and app binaries in its image
recipe. Repackaging the same preserved consumer snapshots with this grouping
passed another **8 runtime executions**, without compiling again:

| Split-layer metric | Preserve symbols | Remove symbols |
| --- | ---: | ---: |
| Docker-reported image Size | 85,024,194 B | 56,508,348 B |
| Raw uncompressed layer sum | 211,779,584 B | 183,255,040 B |
| Stable dependency COPY layer | 55,054,336 B | 26,542,080 B |
| Application COPY layer | 122,880 B | 110,592 B |

Raw byte sums use `docker history --human=false`. Both app edits change only
the app layer; every dependency-layer digest remains identical. The no-op reuses
all filesystem layers. Removing the SDK's symbols therefore saves overall image
and dependency-layer space, but does not imply 28.5 MB saved on every warmed
app-only upload. Registry compression, fresh ECS image pulls and full production
payloads remain unmeasured.

The durable harness supports `--repackage-only --layering split` from preserved
snapshots, captures layer byte evidence before tags change, and keeps source
compilation/cache timing separate from packaging.
