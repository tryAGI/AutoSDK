# OpenAPI parsing performance

Use `autosdk generate ... --diagnostics` to split the existing `core_parsing_ms`
and `core_parsing_allocated_bytes` totals into these subphases:

- `core_parsing_json_syntax_*`: creation of the input `JsonNode` for JSON specs.
- `core_parsing_compat_normalization_*`: AutoSDK's OpenAPI 3.0/3.1 compatibility pass before the Microsoft reader.
- `core_parsing_microsoft_reader_*`: `Microsoft.OpenApi` JSON or YAML reader work.
- `core_parsing_compat_walker_*`: the compatibility visitor over the parsed document.
- `core_parsing_postprocess_*`: defaults, overrides, discriminators, path parameters, and schema sanitizers.

The post-processing aggregate is split again into:

- `core_parsing_postprocess_setup_injection_*`: document defaults plus base URL and security injection.
- `core_parsing_postprocess_discriminators_*`: discriminator discovery and nested `oneOf` normalization.
- `core_parsing_postprocess_missing_path_parameters_*`: path-template reconciliation.
- `core_parsing_postprocess_overrides_naming_*`: configured overrides and Fern request naming.
- `core_parsing_postprocess_schema_sanitizers_*`: Fern type, numeric, integer-format, and discriminator sanitizers.

Schema sanitization is split one level further into:

- `core_parsing_postprocess_schema_sanitizers_fern_types_*`.
- `core_parsing_postprocess_schema_sanitizers_numeric_constraints_*`.
- `core_parsing_postprocess_schema_sanitizers_large_integer_formats_*`.
- `core_parsing_postprocess_schema_sanitizers_discriminators_*`.

The aggregate remains authoritative. Subphase totals can be slightly lower because setup,
diagnostics checks, retry setup, and measurement overhead stay only in the aggregate.

## Microsoft.OpenApi 3.10.2 investigation

`Microsoft.OpenApi.YamlReader` currently resolves its compatible SharpYaml 2.1.5
dependency transitively. Do not override it with SharpYaml 3.x: version 3.13.0 removes
the `Parser<T>(T, int)` ABI used by YamlReader 3.10.2 and causes YAML parsing to fail
with `MissingMethodException`.

The in-repository `specs/github.yaml` benchmark produced this warm three-run average
on Apple Silicon macOS:

| Subphase | Time | Allocations |
| --- | ---: | ---: |
| JSON detection | 0.1 ms | 0.0 MB |
| Compatibility normalization | 19.0 ms | 22.7 MB |
| Microsoft reader | 294.6 ms | 208.1 MB |
| Compatibility walker | 18.5 ms | 21.1 MB |
| AutoSDK post-processing | 37.0 ms | 16.2 MB |

The CLI workload with `--compute-discriminators` has substantially more AutoSDK
post-processing work, so compare package-reader changes using the dedicated parsing
subphase rather than the aggregate.

## OpenAPI 3.1 compatibility boundary

The compatibility layer cannot yet be removed after the Microsoft.OpenApi 3.10.2
upgrade. A direct reader probe shows that the package now retains substantially more
JSON Schema 2020-12 vocabulary than older releases, but not the complete OpenAPI 3.1
surface:

| Microsoft.OpenApi 3.10.2 behavior | Keywords and compatibility cases |
| --- | --- |
| Retained natively | `propertyNames`, `dependentRequired`, `dependentSchemas`, `contentEncoding`, `contentMediaType`, `unevaluatedProperties`, `patternProperties`, `contains`, `minContains`, `maxContains` |
| Still lost or changed by the reader | `prefixItems`, boolean `items`, `unevaluatedItems` |
| Still normalized for real-world hybrid documents | OpenAPI 3.1 documents using legacy `nullable`, null-only enums, and primitive union shapes |
| Still rejected by AutoSDK when generation would be lossy | Non-match-all `patternProperties` and array `contains` constraints |

AutoSDK therefore keeps the compatibility boundary, but the OpenAPI 3.1 keyword
normalization and general compatibility normalization now share a single JSON tree
walk. JSON Pointer paths are accumulated as segments and materialized only for an
actual diagnostic. On the in-repository ElevenLabs OpenAPI 3.1 workload, the warm
normalization phase fell from 23.5 ms and 21.2 MB to 15.1 ms and 10.3 MB. A fresh CLI
comparison fell from 28.511 ms and 22,203,248 bytes to 19.528 ms and 10,792,920 bytes.
All 4,884 generated files remained byte-identical.

## Discriminator traversal optimization

On the CLI GitHub workload, the nested metrics showed that discriminator discovery
accounted for 179.8 ms and 232.4 MB of the 230.2 ms and 249.4 MB post-processing
aggregate. The graph walk revisited the same resolved component schemas through many
`$ref` instances and also allocated path strings that were no longer consumed after
the Microsoft.OpenApi 3.x migration.

The walk now visits component roots at depth zero, memoizes schema identity, defers
component references to their root pass, and avoids unused recursive path construction.
The root-first rule preserves `$ref` sibling overrides and the existing depth-limit
semantics. A three-process median measured 24.6 ms and 13.0 MB for discriminator
discovery, while the post-processing aggregate fell to 76.9 ms and 30.0 MB. That is
an 86.3% time and 94.4% allocation reduction for discriminator discovery, with all
16,942 generated GitHub files and the OpenAI/Cohere discriminator snapshots unchanged.

The App Store Connect JSON control, where discriminator discovery is disabled,
measured 30.6 ms and 4.35 MB for all post-processing. Its largest nested phase was
schema sanitization at 19.5 ms and 2.32 MB, confirming that the GitHub optimization
targets reference-heavy discriminator workloads rather than shifting cost elsewhere.

## Schema sanitizer investigation

The sanitizer split identified Fern normalization as the largest remaining traversal:
the three-run GitHub median was 15.6 ms and 7.66 MB, while App Store Connect measured
9.0 ms and 0.72 MB. Neither specification contains `x-fern-type`, so this is traversal
cost rather than extension parsing. A shared visited-schema set was tested, but its
hash-table storage raised GitHub Fern allocations from 7.66 MB to 9.06 MB and was not
retained.

Discriminator sanitation had a different allocation hotspot. It rebuilt every mapping
with LINQ even when every target was valid. The sanitizer now scans for invalid entries
first and allocates a replacement dictionary only when a mapping actually needs repair.
On GitHub this reduced discriminator-sanitizer allocations from 2.54 MB to 0.14 MB
(94.7%); on App Store Connect they fell from 1.15 MB to 0.23 MB (80.2%). Total sanitizer
allocations fell by 22.9% and 39.7%, respectively. The three fresh CLI runs were stable,
and all 16,942 GitHub plus 24,895 App Store Connect generated files remained byte-identical.

Reference thresholds and the observed three-run medians are stored in
`src/tests/AutoSDK.Benchmarks/performance-budgets/large-spec-regeneration.json`.
The benchmark `--profile` output also includes an `OpenAPI schema sanitizer detail`
table for quick local hotspot checks.

## Enum rendering optimization

Closed enum model and extension rendering was the largest directly controlled render
hotspot on App Store Connect. It previously built a large graph of per-value strings,
LINQ iterators, injected separators, and whitespace-cleanup intermediates. The renderer
now writes directly into pre-sized `StringBuilder` instances and computes each escaped
wire value once for both conversion directions.

On App Store Connect, the three-run median enum phase fell from 129.003 ms and
191,589,264 allocated bytes to 107.939 ms and 167,435,904 bytes. Total rendering fell
from 863.025 ms and 1,040,198,248 bytes to 828.947 ms and 1,016,094,224 bytes. The
GitHub control reduced enum allocations from 91,488,192 to 84,736,568 bytes and its
enum phase from 60.255 ms to 35.854 ms; total render wall time remained within normal
run-to-run noise. Across ElevenLabs, GitHub, and App Store Connect, all 46,721 generated
files remained byte-identical to the public CLI baseline.

## Direct rendering and schema-shape fast paths

After enum rendering was reduced, the remaining controlled render allocation was
spread across model bodies, method responses, serializer-context registrations, and
XML documentation. These paths now write directly into pooled normalized builders
instead of composing large trees of temporary interpolated strings and enumerables.
The render worker count is eight: a measured increase to sixteen made the workloads
slower and was not retained.

The core naming profile exposed a separate non-render hotspot. Simple schemas were
paying for nullable `oneOf`/`anyOf` inspection through Microsoft.OpenApi collection
accessors even when the relevant collection was empty. Shape predicates now reject
those cases before union inspection, model classification checks the already-computed
type first, and generated namespaces are cached on the immutable schema context.

The final warm three-run profile measured the following allocation changes:

| Workload | Total before | Total after | Core naming before | Core naming after |
| --- | ---: | ---: | ---: | ---: |
| GitHub | 1,383.8 MB | 1,225.0 MB | 84.8 MB | 45.5 MB |
| ElevenLabs | 422.0 MB | 363.7 MB | 49.8 MB | 25.8 MB |

Fresh CLI render allocation fell from 677,601,488 to 474,201,776 bytes on GitHub,
from 1,016,094,224 to 699,830,520 bytes on App Store Connect, and from 212,349,624
to 169,880,992 bytes on ElevenLabs. The generated output remained byte-identical to
public `AutoSDK.CLI 0.32.1-dev.42` for all 46,721 files. The full snapshot suite also
passed all 287 cases. Allocation ceilings for these paths are stored with the other
large-spec budgets.

## Current provider enrichment profiling

The benchmark corpus now also pins current Vapi, Anthropic, OpenAI, and ElevenLabs
specifications under `src/tests/AutoSDK.Benchmarks/Specs`. They are embedded only by
the benchmark project, so updating the performance corpus does not change the older
snapshot fixtures or generated SDK contracts. `--profile-enrichment` splits the former
`core_compute_classes` aggregate into schema models, operations, endpoints,
authorizations, converters, tags/clients, and JSON-context output. The CLI exposes the
same timing and allocation fields through `--diagnostics`.

Vapi exposed the largest new hotspot. Request representation selection recursively
searched the same deeply connected `oneOf`/`allOf` schema graph for binary values for
each operation. A generation-scoped binary-schema cache reduced Vapi endpoint
allocations from 109.9 MB to 19.4 MB in the warm benchmark. The fresh CLI
`core_compute_classes_allocated_bytes` fell from 172,335,200 to 44,510,368 bytes.
Caching already-normalized enum data on each immutable `SchemaContext` removed a
second full enum construction during lazy model creation and benefited every current
provider workload.

The fresh CLI allocation results against public `AutoSDK.CLI 0.32.1-dev.45` were:

| Workload | Compute classes before | Compute classes after | Reduction | Total before | Total after |
| --- | ---: | ---: | ---: | ---: | ---: |
| Vapi | 172.3 MB | 44.5 MB | 74.2% | 721.2 MB | 592.2 MB |
| Anthropic | 53.6 MB | 37.1 MB | 30.8% | 583.4 MB | 566.3 MB |
| OpenAI | 91.3 MB | 60.1 MB | 34.1% | 800.8 MB | 768.2 MB |
| ElevenLabs | 85.8 MB | 69.5 MB | 19.0% | 733.0 MB | 716.9 MB |

All 29,904 generated files were byte-identical to the public CLI baseline. The unit
suite passed 560 tests, the snapshot suite passed 287 tests, and the libraries built
for `net4.6.2`, `netstandard2.0`, and `net10.0`.

Parallel union rendering was re-tested at degrees 2, 4, and 8. Results varied by spec
and run, with regressions on Vapi and OpenAI, while allocations stayed essentially
unchanged. A request-union traversal index likewise added allocation without a stable
gain after the binary-schema hotspot was removed. Neither experiment is present in
the production pipeline. The pinned hashes, observed values, and allocation ceilings
are stored in `src/tests/AutoSDK.Benchmarks/performance-budgets/large-spec-regeneration.json`.

### Expanded production-spec enrichment pass

A second pass used current App Store Connect, Vercel, Composio, Novu, and D-ID
specifications in addition to the four pinned provider fixtures. App Store Connect was
the decisive workload: its repeated schema references made Microsoft.OpenAPI's
reference-holder convenience getters dominate `ComputeData`. Each getter resolves the
same target through the workspace and creates a new cycle guard. AutoSDK now caches a
generation context's effective schema only for bare references. References carrying any
OpenAPI 3.1 JSON Schema sibling keyword continue through the reference holder, so
sibling override behavior is preserved.

The same trace found three independent allocation sources:

- authorization requirement sets were rebuilt for every representation of every
  endpoint even when operation- or document-level security was shared;
- enum normalization always copied its dictionary twice, including the common path
  where member names were already unique;
- query parameter serialization used a multi-stage LINQ flattening pipeline, and status
  polling repeatedly resolved the same reference while walking a schema.

The retained implementation adds generation-scoped authorization and effective-schema
caches, an allocation-free enum uniqueness fast path, a pre-sized enum dictionary, a
single-pass query serializer, and one-time reference resolution in polling. A direct
request-data cache and direct immutable-builder query output were measured but removed:
the former added about 0.45 MB on App Store Connect and the latter did not reduce
allocation.

Fresh CLI allocation results against public `AutoSDK.CLI 0.32.1-dev.48` were:

| Workload | Pipeline before | Pipeline after | Reduction | Total before | Total after |
| --- | ---: | ---: | ---: | ---: | ---: |
| App Store Connect | 911.1 MB | 456.8 MB | 49.9% | 2,082.7 MB | 1,629.1 MB |
| Vercel | 440.2 MB | 350.0 MB | 20.5% | 1,269.9 MB | 1,178.8 MB |
| Vapi | 277.1 MB | 203.1 MB | 26.7% | 592.0 MB | 519.8 MB |
| Anthropic | 249.1 MB | 205.1 MB | 17.6% | 565.5 MB | 522.6 MB |
| OpenAI | 329.2 MB | 270.6 MB | 17.8% | 763.5 MB | 705.3 MB |
| ElevenLabs | 359.7 MB | 296.0 MB | 17.7% | 716.0 MB | 653.1 MB |
| Composio | 109.7 MB | 102.8 MB | 6.3% | 285.8 MB | 279.3 MB |
| Novu | 147.2 MB | 99.6 MB | 32.3% | 314.0 MB | 267.2 MB |
| D-ID | 119.8 MB | 106.6 MB | 11.0% | 428.6 MB | 416.3 MB |

All 92,700 generated files across the pinned and expanded corpora were byte-identical
to the public CLI baseline. The full solution built for `net4.6.2`, `netstandard2.0`,
and `net10.0`; 563 unit tests and 287 snapshot tests passed.

After enrichment was cut in half on App Store Connect, the largest remaining phases
are render (699.8 MB) and output writing (357.7 MB), not schema enrichment. Within
render, method implementations allocate 242.1 MB, model JSON extensions 104.8 MB, and
the serializer context 100.5 MB. Core parsing remains 139.8 MB and is mostly the
Microsoft reader. These are the next profiling targets; the updated ceilings and exact
spec hashes are recorded in the performance-budget JSON.

### Direct response rendering and streamed output encoding

The next allocation trace showed that response rendering built every exception block
as a sequence of strings and then concatenated the complete sequence before appending
it to the generated method. Request hook invocations repeated the same pattern five
times per method. Both paths now append directly into the normalized pooled method
builder. The shared operation, method, path, and HTTP-method literals are computed once
per method, and specs with no declared error responses retain their original whitespace.

Large serializer contexts had a separate growth pattern. App Store Connect's generated
context contains 8.95 million characters and 8,288 lazy converter registrations, while
its old initial-capacity estimate covered only 5.41 million characters. The retained
estimate includes converter and chunk scaffolding, so the pooled builder rents its final
bucket once. Collision-analysis dictionaries and sets are also sized from the known
type counts and use single-pass nullable-type collection on the CLI target.

The largest remaining allocation was outside rendering. `GeneratedFileWriter` first
created a second normalized UTF-16 copy of every generated file, then encoded that copy
to a pooled UTF-8 buffer. It now scans and encodes the retained spans directly into the
UTF-8 buffer, preserving CRLF/LF endings and the exact normalized-line count without the
intermediate string. Fresh-file writes already receive the complete byte buffer, so they
use an unbuffered synchronous `FileStream` inside the existing eight-worker pool instead
of allocating another 4 KB stream buffer and async state for each small file. Existing
files still use atomic replacement, and comparisons use their existing pooled 64 KB
buffer with duplicate stream buffering disabled.

Fresh CLI allocations changed as follows after commit `850a1da375`:

| Workload | Total before | Total after | Reduction | Render before | Render after | Write before | Write after |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| App Store Connect | 1,629.1 MB | 1,224.3 MB | 24.8% | 699.8 MB | 603.2 MB | 357.7 MB | 48.3 MB |
| Vercel | 1,178.8 MB | 1,037.2 MB | 12.0% | 491.8 MB | 480.6 MB | 254.2 MB | 122.3 MB |
| Vapi | 519.8 MB | 465.3 MB | 10.5% | 200.4 MB | 198.7 MB | 90.0 MB | 37.6 MB |
| Anthropic | 522.6 MB | 473.3 MB | 9.4% | 214.6 MB | 195.5 MB | 62.6 MB | 32.3 MB |
| OpenAI | 705.3 MB | 635.0 MB | 10.0% | 259.6 MB | 246.4 MB | 111.9 MB | 54.8 MB |
| ElevenLabs | 653.1 MB | 593.9 MB | 9.1% | 227.2 MB | 216.0 MB | 82.2 MB | 34.1 MB |
| Composio | 279.3 MB | 245.8 MB | 12.0% | 105.3 MB | 99.9 MB | 49.3 MB | 21.0 MB |
| Novu | 267.2 MB | 227.1 MB | 15.0% | 99.7 MB | 83.2 MB | 37.6 MB | 13.9 MB |
| D-ID | 416.3 MB | 361.9 MB | 13.1% | 191.5 MB | 178.2 MB | 89.4 MB | 48.0 MB |

On App Store Connect, method-implementation allocation fell from 242.1 MB to
172.5 MB. The main serializer-context file fell from 100.5 MB to 79.0 MB and its
context-types companion from 39.3 MB to 33.9 MB. A final three-run fresh-process median
was 3,636 ms total and 1,414 ms for normalize/compare/write; allocation counts were
stable even when wall time was affected by concurrent machine load.

All 92,700 files in the pinned and expanded provider corpora were byte-identical to the
pre-change outputs. The full solution built for `net4.6.2`, `netstandard2.0`, and
`net10.0`; 564 unit tests and 287 snapshot tests passed. The unit coverage includes
direct UTF-8 output for Cyrillic, CJK, emoji, CRLF, LF, and trailing whitespace.

`dotnet-trace` identifies the YAML package path as
`OpenApiYamlReader.ReadCore -> YamlJsonParser.Parse`. The sampled descendants are
primarily SharpYaml token scanning and materialization, including `FetchMoreTokens`,
`ParseBlockMappingKey`, `ScanPlainScalar`, and `MaterializedNode` construction.

The following public settings were tested and intentionally not retained:

- Setting the empty `ExtensionParsers` dictionary to `null`.
- Registering `Microsoft.OpenApi.YamlReader` only after the direct JSON path fails.

On App Store Connect JSON, the A/B medians for `core_parsing_microsoft_reader_ms`
were 127.7 ms with the normal settings and 134.5 ms with both candidates. Reader
allocations were unchanged at approximately 66.1 MB. This is noise or a regression,
not an optimization.

## Upstream issue draft

**Title:** Reduce YAML materialization cost for large OpenAPI documents

**Body:**

AutoSDK uses `Microsoft.OpenApi` and `Microsoft.OpenApi.YamlReader` 3.10.2 with an
empty validation rule set. On the 7.9 MB GitHub OpenAPI YAML document, the warm
Microsoft reader subphase averages about 295 ms and 208 MB allocated across three
runs. The same process measures compatibility normalization, the compatibility
walker, and post-processing separately, so these values exclude AutoSDK's passes.

A sampled trace attributes most reader time to
`OpenApiYamlReader.ReadCore -> YamlJsonParser.Parse`, with SharpYaml scanner/parser
frames and materialized-node construction underneath. Public reader settings do not
offer a way to avoid this YAML-to-JSON materialization, and disabling empty extension
parser lookup did not improve the JSON control workload.

Could the YAML reader reduce intermediate node/string allocation or expose a more
streaming path while retaining the normal `OpenApiDocument` result? A runnable
reproduction is `dotnet run --project src/tests/AutoSDK.Benchmarks -c Release -- --profile`
in tryAGI/AutoSDK; `specs/github.yaml` is embedded and the output includes time and
allocation breakdowns for the Microsoft reader.
