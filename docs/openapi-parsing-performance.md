# OpenAPI parsing performance

Use `autosdk generate ... --diagnostics` to split the existing `core_parsing_ms`
and `core_parsing_allocated_bytes` totals into these subphases:

- `core_parsing_json_syntax_*`: creation of the input `JsonNode` for JSON specs.
- `core_parsing_compat_normalization_*`: AutoSDK's OpenAPI 3.0/3.1 compatibility pass before the Microsoft reader.
- `core_parsing_microsoft_reader_*`: `Microsoft.OpenApi` JSON or YAML reader work.
- `core_parsing_compat_walker_*`: the compatibility visitor over the parsed document.
- `core_parsing_postprocess_*`: defaults, overrides, discriminators, path parameters, and schema sanitizers.

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
