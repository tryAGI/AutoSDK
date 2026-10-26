# Warm trimmed publication guard (#432)

This is a .NET SDK incremental dependency-manifest bug, also tracked upstream in
[dotnet/sdk#56730](https://github.com/dotnet/sdk/issues/56730). No AutoSDK runtime
root or broad serializer fallback is needed.

Applications that need the workaround can import the opt-in
[`AutoSDK.WarmPublish.targets`](../build/AutoSDK.WarmPublish.targets) after their
project properties. It uses the SDK's `_ComputeIntermediateDepsFilePath` target
to resolve the actual file, including `PublishDepsFilePath` overrides, and
invalidates only that dependency manifest before `GeneratePublishDependencyFile`.
NuGet, compilation and ILLink outputs are retained. Managed trimmed publication
regenerates the small manifest even on an unchanged warm run; NativeAOT and
ordinary untrimmed builds retain their existing behavior. Nothing is installed
into SDK consumers automatically.

The inspected .NET 10 SDK target declares assets files, project imports and a
static property-input cache as inputs, while ILLink's changed reachable runtime
assembly set does not invalidate that cache. The workaround relies on an SDK
internal target and is deliberately explicit. Revalidate it when upgrading SDKs;
remove it after the upstream fix passes the durable contracts.

```sh
python3 scripts/check-warm-publish.py --output /tmp/new-warm-contract --aot
```

The output path must be new; the harness never clears a caller's existing files.
It records toolchain information, publish/run logs, deps hashes and library lists.
It first reads JSON, then adds JSON serialization without changing the referenced
SDK package. It also publishes into a fresh output with reused intermediates and
removes the SDK PackageReference. Both plain STJ and a precompiled local NuGet
SDK fixture are used, with trimming and NativeAOT. Every successful publication
is executed with JSON reflection disabled and warnings treated as errors.

The separate `warm-publish.yml` CI workflow executes the same matrix and uploads
logs. It accepts the known managed baseline execution failure as recorded negative
evidence, but all publishes must succeed, all guarded results must execute, and
initial/removed-reference and NativeAOT runs must pass. No test is silently skipped
when the SDK fixes the baseline behavior.

## Measured validation, 2026-10-26

[Raw results](benchmarks/warm-publish-20261026.json): official .NET SDK
`10.0.402-noble-aot`, runtime 10.0.13, Linux ARM64, two CPUs, 4 GiB, no swap.
28 publications were executed. All 14 guarded results passed. Four managed
baseline executions failed after successful publication (plain/PackageReference,
changed graph/fresh output), reproducing the missing System.IO.Pipelines failure.
All NativeAOT, initial-read and SDK-reference-removal contracts passed. Thus a
fresh output alone is insufficient when intermediates persist; the narrow guard
repairs the warmed result without deleting package or compilation caches.
