# Serializer context pruning

## Enabling shared metadata

Generate a net10.0 monolithic SDK with `--shared-json-metadata`. The generated
`AutoSDK.SharedJsonMetadata.props` records the exact CLI/analyzer package version
and manifest protocol. Import that file and bind the build-only package to it:

```xml
<Import Project="Generated/AutoSDK.SharedJsonMetadata.props"
        Condition="Exists('Generated/AutoSDK.SharedJsonMetadata.props')" />
<ItemGroup Condition="'$(AutoSDKJsonMetadataVersion)' != ''">
  <PackageReference Include="AutoSDK.JsonMetadata"
                    Version="$(AutoSDKJsonMetadataVersion)" PrivateAssets="all" />
</ItemGroup>
```

Use a published CLI release so the matching analyzer is available from NuGet.
The package's build props include generated `*.autosdk-json-metadata` manifests
as compiler inputs. It must be available while building the SDK from source.
Consumers of the resulting SDK NuGet need only its compiled library.

New net10.0 SDK scaffolds enable the flag and version binding together. Existing
repositories migrate explicitly; the compatibility profile keeps their existing
compilation path until adoption. Versioned manifests emit a compile-time support
guard; unsupported versions produce AMETA003 before STJ runs. Legacy unversioned
manifests retain their original factory ABI while consumers migrate.
Fleet adoption is tracked in [#429](https://github.com/tryAGI/AutoSDK/issues/429).
Split packages and legacy target frameworks retain their existing generation path.

## Retention graph

The shared profile partitions the emitted C# type graph into strongly connected
components. Each internal resolver owns one component and lazy references to its
outgoing dependencies. It preserves request, response, error, inheritance,
discriminator, collection, nullable and extension-data dependencies. Operations
select only their entry components even through a root client. A model helper
selects its own component, excluding upstream parents and sibling requests.
Cycles stay together; iterative scope traversal visits diamond dependencies once
and avoids recursive resolver or static-initializer stacks.

A build-only analyzer runs pinned Microsoft System.Text.Json generation against
the complete SDK compilation and the manifests. It exposes static metadata
factories without an aggregate virtual type switch, per-context metadata caches,
or instance serialization writers. Narrow resolvers call the canonical factory
for each registered type. Factory dependencies remain visible to the IL linker.

The analyzer preserves generated property, constructor, converter and callback
metadata. It supplements schema-planned resolvers with missing reachable types
from the compiled STJ factory graph, including handwritten partial/inherited
members. Traversal stops at an already reachable owning component, whose own
resolver completes its partial members; it does not flatten child closures into
ancestors. Scopes without supplements compile the optional hook away.
It passes the caller's serializer options through resolver chains.
The analyzer and Roslyn are not runtime dependencies, and the CLI does not depend
on this compiler component. Unsupported changes in the pinned generator's source
shape produce AMETA001 instead of enabling reflection fallback. Nested STJ warnings
are forwarded as AMETA002 with the original SYSLIB ID/message and source or manifest
provenance. TreatWarningsAsErrors rejects these warnings. Ordinary-context warnings
remain owned by the framework generator and are not duplicated. The comparison run
is performed only when nested warnings exist; supported warning-free SDKs do not
pay for a second generator run. See [#437](https://github.com/tryAGI/AutoSDK/issues/437).

The public aggregate context remains available for explicit serialization of
arbitrary SDK models. Reading or explicitly assigning that context retains its
complete graph. A custom context assigned to a root client still propagates to
children and overrides operation defaults. This is deliberate caller ownership.

## Cost and caching

Operation-specific System.Text.Json contexts alone are insufficient: their
implicitly generated dependency graphs overlap and can enlarge the untrimmed
library and compiler heap. Shared factories avoid generating a complete STJ
context for each operation. One STJ compilation context discovers each implicit
dependency once. Before C# compilation the analyzer relocates each factory into
an independent holder, keeping compiler-generated lambda types below CLR method
limits. Small component contexts compose a shared per-SDK runtime helper; enum
converter lookup is lazy and indexed, with no process-wide type registry.

Measure these costs separately:

- Generation: source bytes, resolver registrations and manifest bytes.
- SDK source compilation: full DLL/NuGet size, elapsed/CPU time and peak memory.
- Backend publishing from SDK NuGets: trimming time, retained models and metadata,
  output size, and a runtime request/response contract.
- Repeated publishing: unchanged and changed application inputs with warmed
  package/runtime caches. SDK source compilation is not repeated by NuGet consumers.

A zero-warning publish or a small endpoint-method count is insufficient proof.
Inspect the linked assembly and execute the published binary with nonempty typed
JSON. Check unused endpoints within the same client and unrelated model types,
including their metadata factories.

## Regression coverage

`SerializerContextPlanTests` checks same-tag operation separation, shared model
helpers, independent orphan components, primitive union converters, nullable
scalar unions, and settings round trips.

`SharedJsonMetadataTests` checks compilable static factories, coexistence with
ordinary STJ contexts, partial-member/collection/cyclic/ignored dependencies,
rejection of instance writers, projects without manifests, inaccessible-member
warning propagation, warnings-as-errors, ordinary-context diagnostic deduplication,
additional-manifest diagnostic provenance, version guards, isolated factories,
and completion of compiled partial members without flattening reachable children.

`Generate_LargeMultiTagClient_TrimmedLeafRetainsOnlyReachableSerializerGraph`
uses 40 tags with 36 models each and an unused endpoint within the live tag.
It publishes and runs leaf, root, standalone nested-helper and explicitly configured aggregate consumers
for both extension-data representations. It verifies unused DTO and serializer
methods are absent and checks a material linked-size reduction.

[#427](https://github.com/tryAGI/AutoSDK/issues/427) tracks real large-SDK acceptance;
[#428](https://github.com/tryAGI/AutoSDK/issues/428) tracks metadata sharing and its
compilation budget.

## Adoption audit

Before an organization-wide snapshot, run the workspace's normal SDK audit sync.
Then audit the explicit SDK batch and its newly packed NuGets:

```bash
python3 scripts/audit-shared-json-metadata.py \
  ../OpenAI/src/libs/tryAGI.OpenAI/tryAGI.OpenAI.csproj \
  ../AppStoreConnect/src/libs/AppStoreConnect/AppStoreConnect.csproj \
  --expected-cli-version <published-version> --package <sdk.nupkg>
```

The audit rejects missing/incompatible manifests, missing binding imports,
uncoordinated package pins, missing `PrivateAssets=all`, and packaged runtime
references to AutoSDK compiler tooling or Roslyn. It reports legacy manifests as
migration failures rather than silently treating them as adopted. Its failure
modes run in CI independently of source compilation.

## Real SDK acceptance

See the [directed-components comparison](benchmarks/shared-json-components-20261021.md)
for the current CLI/analyzer coordination, model-helper retention, whole SDK costs,
NativeAOT, repeated publishes, Docker layers and measured context overhead.
The [initial comparison](benchmarks/shared-json-metadata-20261021.md) preserves the
older aggregate-fallback baseline and symbol/cache limitations.
