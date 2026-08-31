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
