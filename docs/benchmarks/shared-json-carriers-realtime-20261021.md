# Compact serializer carriers and Realtime scopes

The component carrier change reduces whole SDK size and the infrastructure retained
by a live HTTP graph. AsyncAPI now uses directed per-message scopes as well. An
HTTP-only consumer retains no Realtime metadata after namespace-local dependency
completion. All 33 current runtime profiles passed, with reflection serialization
disabled. This is SDK laboratory evidence, not an Advantage production deployment.

[Machine-readable evidence](shared-json-carriers-realtime-20261021.json).
The [previous component comparison](shared-json-components-20261021.md) records the
prior model-helper pruning and the internal context overhead addressed here.

## Implementations and verification

- `fadb3f26d86ee606f5dbe8a93ca842e709824ca4`: internal static carriers and a shared
  options-bound context implementation; concrete public aggregate/tag APIs preserved.
- `6dcc6419890fe34a9775b7e96936e2ee0af6a960`: dependency completion prefers factories
  from the consuming subtree namespace; cross-manifest regression reproduced first.
- `c5936a68cf1f7ed6f0fc772cc2b55a060c1a2890`: lazy WebSocket defaults, typed outbound
  scopes, independent inbound parsers and complete any-event receive scopes.
- Coordinated CLI/analyzer release: **0.35.0-preview.2.117**, manifest format 2.
  Its CI artifact repository commit matches the source above; both packages are
  confirmed in public NuGet flat-container indexes.
- AutoSDK code CI: [39538658361](https://github.com/tryAGI/AutoSDK/actions/runs/39538658361),
  including full build/tests, CLI shards, split packages and the native CLI, passed.
  Carrier-only CI [39536700147](https://github.com/tryAGI/AutoSDK/actions/runs/39536700147)
  and [documentation](https://github.com/tryAGI/AutoSDK/actions/runs/39538657735) passed.
- Focused local tests: 19 planner/WebSocket tests, 17 metadata tests, and four CLI
  cases (two extension-data representations plus trimming/NativeAOT WebSocket cases).
  The WebSocket cases publish eight loopback consumers for send, typed parsing,
  any-event union and caller-provided contexts, including unknown/malformed input.
- Runtime profiles: 16 carrier HTTP/helper/wrapper cases, nine final OpenAI HTTP
  cases, and eight final Realtime cases. Six separate previous-Realtime profiles
  supply the comparison baseline. No provider credentials or paid requests are used.

## Controlled inputs

.NET SDK 10.0.402 / runtime 10.0.13, Linux ARM64, two CPUs. Full source builds use
16 GiB without swap; precompiled-NuGet consumers use 6 GiB. Publishing uses full
trimming, reflection serialization disabled and ReadyToRun disabled; NativeAOT is
measured separately with OptimizationPreference=Size and stripped symbols. Elapsed figures below exclude host-admission waits. They are
single samples with warmed package/runtime caches, not stable percentiles or an
attribution of every timing difference to the generator.

OpenAI source snapshot `f2fedc5807e4d697f58f4e1b116c71e8ee6b94b9` and Apple snapshot
`2d590ad604cddbc705795563c4fb0e6d035ac550` freeze specs and handwritten code across
phases. Private benchmark packages carry immutable DLL hashes in the evidence.
Canonical repository regeneration uses the released CLI; its current-spec CI is
separate from these controlled source-cost measurements. The later OpenAI spec
update `d955331e802f5c0ca4fdf4e44c15c68caea29a60` adds cache-TTL types and must not
be conflated with a generator-induced change in the frozen model graph.

## Whole SDK costs

“Previous” means the directed-component implementation from the previous report,
not the original aggregate-fallback implementation. Decimal MB are used below.

| Metric | OpenAI previous | OpenAI final, including Realtime | Apple previous | Apple carriers |
| --- | ---: | ---: | ---: | ---: |
| Full DLL | 53.84 MB | 49.72 MB | 117.84 MB | 109.84 MB |
| NuGet | 12.48 MB | 11.65 MB | 43.78 MB | 41.77 MB |
| Generator C# | 103.80 MB | 97.34 MB | 207.45 MB | 190.55 MB |
| Compiler-generated C# | 55.29 MB | 54.24 MB | 79.91 MB | 79.91 MB |
| Source build elapsed | 96.035 s | 90.282 s | 960.718 s | 898.147 s |
| Source build user CPU | 129.466 s | 124.134 s | 1202.853 s | 1111.184 s |
| Peak cgroup memory | 6.99 GB | 6.62 GB | 15.94 GB | 16.58 GB |
| Unchanged source build | 3.325 s | 3.778 s | 5.094 s | 6.607 s |

The Apple memory sample rises about 4% and its unchanged build is slower, while
remaining within the same 16 GiB budget. These results do not claim every metric
improves. An intermediate OpenAI carrier-only sample took 94.407 s, and an early
Realtime sample took 115.012 s before the final isolation run. The final single
sample is encouraging, but repeated cohorts are needed for a timing guarantee.

Full CLR enumeration succeeds for **57,261 OpenAI types** and **112,085 Apple types**,
versus the prior 71,053 / 147,844. This also checks that factory isolation continues
to avoid the CLR methods-per-type limit. Apple tag-context lookup and an invitation
round trip with an unknown field pass.

## Linked HTTP retention

| Consumer | Previous SDK DLL | Current SDK DLL |
| --- | ---: | ---: |
| OpenAI ListModels through root | 123,392 B | 120,832 B |
| OpenAI typed chat | 1,110,528 B | 1,059,840 B |
| OpenAI nested token-logprob helper | 38,400 B | 37,888 B |
| OpenAI metadata dictionary wrapper | 23,040 B | 23,040 B |
| Apple root endpoint | 20,758,016 B | 20,636,160 B |
| Apple ResourceLinks helper | 18,572,288 B | 18,571,776 B |

Chat CLR types fall **1,994 → 1,675**, with the exact same **386 public non-context
type names**. HTTP root and chat retain **zero Realtime types** after the isolation
fix. Unused endpoint models and serializer methods remain absent.

Apple linked DLL bytes still include embedded portable PDB data; they are not a
pure retained-IL measurement. The earlier symbol comparison remains applicable;
no stripped-byte estimate is inferred by subtracting PDB sizes.

## Real OpenAI Realtime contracts

The same pinned schema and handwritten SDK code are used for both profiles. The
previous profile uses ordinary aggregate Realtime metadata; the current profile
uses directed shared scopes. The previous typed path calls the existing model
helper; the current path calls its new client parser. Both construct a client.
Send/receive tests use an actual loopback WebSocket connection with a 20-second
bound. Runtime containers have external networking disabled.

| Workload | Previous trimmed SDK DLL | Current trimmed SDK DLL | Previous NativeAOT executable | Current NativeAOT executable |
| --- | ---: | ---: | ---: | ---: |
| Typed text delta | 2,295,808 B | 34,304 B | 16,255,544 B | 2,972,632 B |
| Audio append send | 2,195,968 B | 37,376 B | 17,559,336 B | 7,214,384 B |
| Any-event receive union | 2,323,456 B | 1,595,904 B | 20,849,440 B | 17,351,736 B |
| Caller-provided typed context | — | 34,304 B | — | 2,972,920 B |

The union deliberately retains all advertised variants. Typed parsing retains
48 CLR types (six public non-context types); audio send retains 53 (seven public).
The full union retains 2,282 (609 public). Native debug sidecars are accounted for
separately from executable bytes in the evidence.

## Repeated publish and Docker caches

These consumers reference compiled SDK NuGets, so application edits do not rebuild
SDK sources. Two real application string edits follow an unchanged warm publish.
Every published executable is run again and passes its offline contract.

| Warm publish | OpenAI | Apple |
| --- | ---: | ---: |
| Unchanged inputs | 0.891 s | 0.931 s |
| Application edit 1 | 8.885 s | 13.878 s |
| Application edit 2 | 8.983 s | 13.209 s |

Docker builds use separate dependency and application COPY layers. For both SDKs,
the unchanged build reuses every layer. A subsequent application-code edit and
republish leaves dependency file hashes/layers identical and changes only the
last application layer. All initial/unchanged/edited images pass the runtime
contract with 512 MiB and external networking disabled. Image sizes, layer digests
and individual build timings are in the evidence. Docker-reported Size is storage
engine dependent; this is not a registry-transfer or full Advantage image claim.

## Repository adoption

AppStoreConnect was regenerated with the released CLI and pushed as
`3ffb5f5155de72c9ad2e806558c551d09846084c`.
[Canonical build, trimming and publication CI](https://github.com/tryAGI/AppStoreConnect/actions/runs/39541472616)
passed.

OpenAI adoption completed on 2026-10-23 in
[`84a08ba9ab63e778d040511dcda8be72d38e5181`](https://github.com/tryAGI/OpenAI/commit/84a08ba9ab63e778d040511dcda8be72d38e5181).
The owner performed the protected shared-checkout synchronization; regeneration
then used released CLI 0.35.0-preview.2.117 and the pinned spec from
`52fba82af119f8314be7e2440086ba11175558d5`.
[Full build, tests, trimming and publication CI](https://github.com/tryAGI/OpenAI/actions/runs/39945150476)
passed.

Seven additional canonical-package consumers passed in Linux ARM64 containers
with networking disabled and a 512 MiB runtime limit: Realtime typed/send/union/custom
and HTTP full trimming, plus typed Realtime and HTTP NativeAOT. Reflection
serialization remained disabled. The typed Realtime linked SDK is 34,304 bytes
and its native executable is 2,972,608 bytes; the HTTP linked SDK is 120,832 bytes
and its native executable is 7,619,856 bytes. Debug sidecars are excluded.

The current-spec full DLL is 49,759,744 bytes and the private validation NuGet is
11,657,850 bytes. These are separate from the frozen-spec comparison above.
The source build took 91.711 seconds of admitted process time (362.500 seconds
including queue/container overhead); all seven publishes took 63.159 seconds
of admitted process time (468.554 seconds including queue/container overhead).
These are single samples with warmed dependency caches.

## Follow-ups

[#440](https://github.com/tryAGI/AutoSDK/issues/440) covers the carrier improvement,
[#439](https://github.com/tryAGI/AutoSDK/issues/439) the Realtime rollout, and
[#442](https://github.com/tryAGI/AutoSDK/issues/442) the fixed manifest-isolation defect.
Remaining work is tracked separately: [equal context names](https://github.com/tryAGI/AutoSDK/issues/443),
[options-aware metadata caching](https://github.com/tryAGI/AutoSDK/issues/441), and
[bounded factory-holder batches](https://github.com/tryAGI/AutoSDK/issues/444).
