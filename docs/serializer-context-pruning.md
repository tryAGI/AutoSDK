# Serializer context pruning

## Enabling shared metadata

Generate a net10.0 monolithic SDK with `--shared-json-metadata` and add the
build-only `AutoSDK.JsonMetadata` NuGet package to the SDK project. Pin its version
to the AutoSDK version used for generation and set `PrivateAssets="all"`.
The package's build props include generated `*.autosdk-json-metadata` manifests
as compiler inputs. It must be available while building the SDK from source.
Consumers of the resulting SDK NuGet need only its compiled library.

Enable the flag and project dependency together. It is currently opt-in;
the compatibility profile keeps existing large-SDK compilation costs stable
until repositories migrate. Fleet/scaffold adoption is tracked in
[#429](https://github.com/tryAGI/AutoSDK/issues/429).
Split packages and legacy target frameworks retain their existing generation path.

## Retention graph

The shared profile emits internal resolvers for operation entry graphs, preserving
request, response, error, inheritance, discriminator, collection, nullable and
extension-data dependencies. Operations select their own resolver even when
invoked through a root client. Model JSON helpers use a reachable model graph
rather than the whole SDK. Independently unused model components have separate
resolver graphs.

A build-only analyzer runs pinned Microsoft System.Text.Json generation against
the complete SDK compilation and the manifests. It exposes static metadata
factories without an aggregate virtual type switch, per-context metadata caches,
or instance serialization writers. Narrow resolvers call the canonical factory
for each registered type. Factory dependencies remain visible to the IL linker.

The analyzer preserves generated property, constructor, converter and callback
metadata. It supplements schema-planned resolvers with missing reachable types
from the compiled STJ factory graph, including handwritten partial/inherited
members. Scopes without supplements compile the optional hook away.
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
context for each operation. The baseline metadata chunks can still contain
overlapping implicitly discovered factories; only the selected canonical factory
is referenced by narrow resolvers.

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
and additional-manifest diagnostic provenance.

`Generate_LargeMultiTagClient_TrimmedLeafRetainsOnlyReachableSerializerGraph`
uses 40 tags with 36 models each and an unused endpoint within the live tag.
It publishes and runs leaf, root and explicitly configured aggregate consumers
for both extension-data representations. It verifies unused DTO and serializer
methods are absent and checks a material linked-size reduction.

[#427](https://github.com/tryAGI/AutoSDK/issues/427) tracks real large-SDK acceptance;
[#428](https://github.com/tryAGI/AutoSDK/issues/428) tracks metadata sharing and its
compilation budget.

## Real SDK acceptance

See the [OpenAI and AppStoreConnect comparison](benchmarks/shared-json-metadata-20261021.md)
for source/build/package costs, retained DTOs and factories, NativeAOT contracts,
warm repeated publishes, and remaining symbol/cache limitations.
