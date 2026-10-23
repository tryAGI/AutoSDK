# Shared JSON factory batches and options caching

Bounded compiler-only factory groups reduce full-SDK metadata while preserving
public DTOs and per-method linker reachability. The options-cache fix separately
removes repeated metadata construction. Neither change adds a runtime registry.

## Controlled comparison

Both variants enable `--shared-json-metadata` **and** the options-cache fix:
protocol 2 at [2b88305454](https://github.com/tryAGI/AutoSDK/commit/2b883054544681fbed1678b1a9e559ede815223b)
versus protocol 3 at [9b08ce1201](https://github.com/tryAGI/AutoSDK/commit/9b08ce1201709714f11e5ce93b777460f266f51e).
Each SDK uses identical pinned HTTP/AsyncAPI inputs and handwritten sources.
Public-type fingerprints and non-JSON DTO source files match exactly.

.NET SDK 10.0.402 / runtime 10.0.13, Ubuntu 24.04, linux-arm64. Builds use two CPUs;
source compilation has 16 GiB without swap, consumer publication 6 GiB.
All SDK source analyzers and existing compiler-memory settings remain enabled.
The build-only analyzer binding is replaced with the corresponding local analyzer
for this controlled comparison. Consumers reference the resulting **precompiled
NuGet**, with reflection serialization disabled, and execute without network access.

[Machine-readable evidence](shared-json-batches-and-cache-20261023.json) records
input hashes, package/DLL hashes, exact bytes, CPU, memory and individual profiles.

## Full SDK footprint

MB below means decimal megabytes.

| SDK | DLL MB, v2 → v3 | NuGet MB, v2 → v3 | CLR types, v2 → v3 | Public types, unchanged |
| --- | ---: | ---: | ---: | ---: |
| OpenAI | 49.864 → 48.264 | 11.667 → 11.581 | 57,306 → 42,969 | 13,240 |
| AppStoreConnect | 110.010 → 94.191 | 41.795 → 29.757 | 112,087 → 82,857 | 23,314 |

The public-type fingerprints match for both SDKs. All type-count reduction is
within factory-related infrastructure, including nested compiler closure classes.

AppStoreConnect embeds portable PDB data in its DLL. Separate that payload before
attributing the entire raw-DLL reduction to runtime code:

| SDK | Embedded PDB MB, v2 → v3 | DLL minus embedded PDB payload MB, v2 → v3 |
| --- | ---: | ---: |
| OpenAI | 0.000 → 0.000 | 49.864 → 48.264 |
| AppStoreConnect | 22.131 → 10.498 | 87.879 → 83.693 |

The subtraction retains section alignment and debug-directory records; it is
not a separately rebuilt stripped binary. OpenAI contains no embedded PDB payload.

## SDK source compilation

Times below exclude host admission waits; full wall time is recorded separately
in the JSON. CPU is user plus system time. Peak cgroup memory includes file cache.
These are single constrained samples, not statistical performance SLAs.

| SDK | Build seconds, v2 → v3 | CPU seconds, v2 → v3 | Peak GiB, v2 → v3 | Unchanged build seconds, v2 → v3 |
| --- | ---: | ---: | ---: | ---: |
| OpenAI | 88.324 → 84.734 | 127.731 → 125.706 | 5.86 → 5.86 | 2.618 → 2.792 |
| AppStoreConnect | 861.340 → 827.630 | 1120.603 → 1077.937 | 15.44 → 14.00 | 6.172 → 5.373 |

Both SDKs compiled with zero warnings and errors. Compilation remains substantial
for AppStoreConnect; a backend consuming its NuGet does not repeat that source
compilation. The small OpenAI memory difference is noise-scale.

## Precompiled NuGet consumers

Twenty published consumers passed nonempty JSON contracts: both SDK versions,
root endpoint and nested-helper profiles, plus OpenAI typed chat, each under
full trimming and NativeAOT. HTTP uses an offline handler; helper profiles perform
1,000 warmed round trips. No provider credentials or live API calls are used.

| SDK/profile | Trimmed SDK DLL bytes, v2 → v3 | NativeAOT executable bytes, v2 → v3 |
| --- | ---: | ---: |
| OpenAI/root | 120,832 → 120,320 | 7,619,888 → 7,625,944 |
| OpenAI/helper | 37,888 → 37,376 | 3,234,512 → 3,238,552 |
| OpenAI/chat | 1,064,448 → 1,036,288 | 15,412,728 → 15,447,976 |
| AppStoreConnect/root | 20,636,160 → 8,846,848 | 19,277,000 → 19,237,328 |
| AppStoreConnect/helper | 18,572,288 → 6,842,880 | 3,102,112 → 3,103,200 |

NativeAOT executable size changes are small and can include layout and consumer
assembly-identity effects. Grouping is primarily a metadata/source optimization;
it does not promise a smaller native executable. External `.dbg` files are
reported separately from executable bytes in the JSON.

| SDK/profile | Trimmed publish seconds, v2 → v3 | NativeAOT publish seconds, v2 → v3 |
| --- | ---: | ---: |
| OpenAI/root | 10.735 → 11.727 | 11.838 → 11.221 |
| OpenAI/helper | 9.876 → 9.543 | 6.839 → 6.500 |
| OpenAI/chat | 11.769 → 11.272 | 25.910 → 24.753 |
| AppStoreConnect/root | 18.524 → 18.252 | 35.893 → 38.352 |
| AppStoreConnect/helper | 13.619 → 13.369 | 6.581 → 6.713 |

These publications use warmed package/runtime caches and fresh consumer projects.
This follow-up does not repeat the earlier three-profile Advantage/ReadyToRun
and Docker-layer experiment; see the
[carrier and Realtime study](shared-json-carriers-realtime-20261021.md).
Backend publication consumes the precompiled library. This follow-up makes no
new Docker-image or repeated-backend-publish timing claim.

## Options-bound cache regression

A separate instrumented NativeAOT fixture measures 1,000 recursive/polymorphic
model round trips. Before the fix, the expected red-phase cache assertion fails;
the loop itself completes and records its costs.

| Metric | Before caching | After caching |
| --- | ---: | ---: |
| Warm resolver callbacks | 5,000 | 0 |
| Allocated bytes | 81,830,224 | 2,585,056 |
| Warm loop milliseconds | 76.501 | 2.395 |

Allocations include JSON/model work. Timing samples are diagnostic, while zero
warm callbacks is an enforced regression contract. The framework's read-only
`JsonSerializerOptions` cache owns metadata; the context callback remains a raw
factory entry to avoid recursion. No SDK-wide cache or held caller-options list
is introduced. Separate case settings, custom converters, nullable values,
reference cycles, HTTP arrays, streams and concurrent first use pass.

## Reachability and compatibility

Canonical holders contain at most 16 entry factories. A conservative 8,192
method/lambda weight splits heavy bodies behind stable forwarding methods.
An individually large factory retains its previous isolated compatibility path.
Dependency completion inspects original per-factory bodies **before** batching,
so sharing a holder does not add sibling model dependencies.

The full-trim fixture checks that `EnvelopeUnused` and `Create_EnvelopeUnused`
disappear while sharing a holder with used `Envelope`. This uses a separate
default-scope consumer: the instrumentation probe deliberately supplies an
aggregate caller context, which retains its full graph.

The metadata suite passes 29 cases, including legacy protocols, malformed/guarded
batch plans, heavy DTO CLR loading, namespace collisions and partial/cyclic
dependency completion. Focused planner/WebSocket units pass 14 cases; the six
CLI cases cover large graphs, WebSocket profiles and cache/pruning contracts.

## Published adoption

CLI and analyzer **0.35.0-preview.2.123** are published. Normal pinned-spec
regeneration preserves input hashes and produces source identical to the tested
candidate: 21,162 C#/manifest files for OpenAI and 40,724 for AppStoreConnect.

- [AutoSDK implementation and CI](https://github.com/tryAGI/AutoSDK/actions/runs/39963021658).
- [OpenAI adoption](https://github.com/tryAGI/OpenAI/commit/8bad364b9784ea0590fdc1ba6fa581c458fe3936)
  and [CI](https://github.com/tryAGI/OpenAI/actions/runs/39970069974).
- [AppStoreConnect adoption](https://github.com/tryAGI/AppStoreConnect/commit/66f568f4aeb69f59a1b8bc5f324555ac9c89e42c)
  and [CI](https://github.com/tryAGI/AppStoreConnect/actions/runs/39972213790).

Handwritten MEAI/tool/speech helpers still explicitly access aggregate contexts;
their linked-size acceptance is tracked in
[OpenAI #452](https://github.com/tryAGI/OpenAI/issues/452).
The measurements above establish typed endpoint/helper behavior.
