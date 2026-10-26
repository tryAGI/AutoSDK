# Optional SDK symbol profiles

`autosdk init ... --symbol-profile portable` creates a library with external
portable PDBs and a separate `.snupkg`. Source Link maps tracked source to its
repository commit; untracked generated source is embedded in the optional PDB.
The runtime `.nupkg` omits the SDK PDB. `embedded` and `none` are also explicit
choices. Omitting the option inherits the existing symbol policy.

For an existing SDK, copy [AutoSDK.Symbols.props](../build/AutoSDK.Symbols.props)
outside Generated, then set the profile and import it in the project body, before
the SDK's common targets evaluate symbol-copy settings:

```xml
<PropertyGroup>
  <AutoSDKSymbolProfile>portable</AutoSDKSymbolProfile>
</PropertyGroup>
<Import Project="AutoSDK.Symbols.props" />
```

Keep Source Link/repository metadata configured. The scaffold imports its copy
from `src/libs/AutoSDK.Symbols.props`; its default remains unchanged. Invalid
profile values fail the build. This profile changes packaging and debug data,
not the serializer retention strategy or compiler memory allowance.

## Controlled AppStoreConnect comparison

The [2026-10-26 numeric receipt](benchmarks/symbol-profiles-20261026.json)
uses the same read-only AppStoreConnect source commit
`c33a096dfc36d0a6b442579331351f269ce447e9`, already generated with shared
metadata/analyzer `0.35.0-preview.2.146`. Every profile packs version `1.0.0`
with isolated artifacts; consumer NuGet caches are separate to prevent equal
package versions from reusing another profile's DLL. Package/DLL hashes are
recorded and the packaged DLL matches the inspected source-build DLL.

Official Linux ARM64 SDK `10.0.402-noble-aot`, runtime 10.0.13, two CPUs, no swap;
source compilation has a 16-GiB limit and linked consumers a 6-GiB limit.
Consumers use **precompiled NuGet packages**, full trimming, reflection-disabled
JSON and warnings as errors. They round-trip a model and execute an offline HTTP
failure using fake authorization. No provider calls or credentials are used.

Sizes below are decimal MB; peaks are cgroup usage including file cache.

| Profile | Full DLL MB | Runtime nupkg MB | Optional snupkg MB | Linked SDK DLL MB | Whole publish MB | Link peak GB |
|---|---:|---:|---:|---:|---:|---:|
| embedded | 95.912 | 30.436 | — | 8.091 | 33.019 | 3.975 |
| portable | 85.302 | 20.468 | 10.609 | 1.181 | 26.109 | 3.452 |
| none | 84.237 | 20.009 | — | 1.161 | 26.089 | 3.481 |

Embedded and portable have identical managed metadata bytes, IL bytes and member
counts, both before and after linking. Embedded PDB payload is 10,609,534 bytes
in the full DLL and 6,909,911 in the linked DLL. Portable moves that debug data
out of the runtime package/output; combined runtime plus symbol package size is
slightly larger than the embedded package. `none` also changes compiler-emitted
metadata/IL bytes, so it is a separate diagnostic tradeoff rather than a pure
PDB-removal control. All three preserve type/method/field counts and pass runtime
contracts; this is not a complete public-signature or behavioral equivalence proof.

| Profile | Source pack wall seconds | Cgroup CPU seconds | Source peak GB |
|---|---:|---:|---:|
| embedded | 333.702 | 502.258 | 14.524 |
| portable | 482.080 | 770.926 | 13.771 |
| none | 546.356 | 868.997 | 14.046 |

These are single observations on a shared host. Portable and none source packs
overlapped during the correction run, so the timings do not establish a symbol
compile-speed ranking. No normal budget was raised and no analyzer was disabled.
All three linked successfully under 6 GiB; the old issue's 177.8-MB DLL and OOM
used a different generator/source baseline and are not attributed solely to symbols.

## Runtime and diagnostic images

All three normal publications execute in ordinary runtime-deps
`10.0.13-noble` Docker images with network disabled. The portable publication and
image omit `AppStoreConnect.pdb`, and SDK stack frames have no source lines.
Embedded frames retain source lines. The portable PDB contains 47,139 documents,
6,404 embedded untracked-source records and Source Link mappings to the pinned
GitHub commit. The none profile has no source debugging data.

For an opt-in diagnostic image, restore the matching SDK PDB from the `.snupkg`
beside the **unlinked package DLL before publication**, enable
`CopyDebugSymbolFilesFromPackages=true`, and publish to fresh artifacts/output.
ILLink rewrites the PDB with the linked assembly. Copying an original PDB beside
an already-linked DLL is not a valid substitution. The tested diagnostic publish
and Docker image both contain the SDK PDB, execute the same contract and show
generated SDK source file/line locations. Source Link metadata and stack frames
are verified; an interactive debugger session was not performed.

Reproduce using a clean pinned AppStoreConnect clone:

```sh
python3 scripts/measure-symbol-profiles.py --source /path/to/clone --output /new/results --docker-images
```

The script preserves toolchain/logs/results and never deletes existing output.
`--profiles portable` isolates a profile; `--pack-results /previous/results`
reuses matching completed source packs while rerunning consumer/image checks.
The first late-import packaging failure and the initial fixture's missing fake
authorization were corrected; only the successful source packs and final passing
consumer/image checks populate the acceptance receipt.

`autosdk trim` footprint reports already separate embedded PE PDB bytes,
external symbols, managed metadata and IL. The benchmark's inspector uses the
same `AssemblyFootprint` implementation rather than counting debug payload as code.
