# AutoSDK

AutoSDK generates native .NET SDKs from OpenAPI and AsyncAPI specifications. It is built for SDKs that need to be regenerated often, stay close to upstream API specs, and still feel like regular C# code.

The project includes:

- An `autosdk` CLI for one-off generation, project scaffolding, `.http` artifacts, trimming checks, skill generation, and gRPC client project scaffolding.
- An incremental Roslyn source generator for generating SDK code during build.
- A C# generation pipeline that supports OpenAPI, AsyncAPI WebSocket clients, streaming responses, source-generated JSON serialization, trimming, and NativeAOT-oriented project layouts.

AutoSDK uses [OpenAPI.NET](https://github.com/microsoft/OpenAPI.NET) for OpenAPI parsing and is used across real SDKs such as [tryAGI/OpenAI](https://github.com/tryAGI/OpenAI), [tryAGI/Anthropic](https://github.com/tryAGI/Anthropic), [tryAGI/Ollama](https://github.com/tryAGI/Ollama), and [LangChain.NET](https://github.com/tryAGI/LangChain).

## Features

- Generates C# clients, models, enums, JSON converters, request helpers, and optional CLI commands from OpenAPI specs.
- Generates typed WebSocket clients from AsyncAPI specs, including send/receive methods and cross-namespace type references.
- Scaffolds C# gRPC client projects from local `.proto` files, binary descriptor sets, or Buf module references.
- Supports target-specific generated code via `--targetFramework`; core libraries target `net4.6.2`, `netstandard2.0`, and `net10.0`, while the CLI targets `net10.0`.
- Supports System.Text.Json by default, Newtonsoft.Json as an option, source-generated `JsonSerializerContext`, trimming, and NativeAOT-oriented layouts.
- Supports nullable reference types, CLS compliance helpers, cancellation tokens, partial methods, model filtering, operation filtering, and tag-based client grouping.
- Supports `oneOf`, `anyOf`, `allOf`, `not`, discriminators, vendor naming metadata, streaming responses, multipart requests, response wrappers, and injected security schemes.
- Generates polyfills for older target frameworks where needed.
- Uses incremental source generators for efficient build-time generation and caching.

License details are in [LICENSE.md](LICENSE.md); treat that file as authoritative.

## Quick Start

### CLI

Install the CLI:

```bash
dotnet tool install --global autosdk.cli --prerelease
```

Update an existing install:

```bash
dotnet tool update --global autosdk.cli --prerelease
```

Generate an SDK from an OpenAPI spec:

```bash
autosdk generate openapi.yaml \
    --namespace MyApi \
    --clientClassName MyApiClient \
    --targetFramework net8.0 \
    --output Generated
```

The command writes generated C# files to `Generated/`. Add `--single-file` if you want one combined `.cs` file instead of one file per generated type.

### Source Generator

Add the source generator package:

```bash
dotnet add package AutoSDK.SourceGenerators
```

Mark your spec as an AutoSDK additional file and set the generation options you need:

```xml
<ItemGroup Label="AutoSDK">
    <AdditionalFiles Include="$(MSBuildThisFileDirectory)openapi.yaml" AutoSDK_OpenApiSpecification="true" />
</ItemGroup>

<PropertyGroup Label="AutoSDK">
    <AutoSDK_Namespace>MyApi</AutoSDK_Namespace>
    <AutoSDK_ClassName>MyApiClient</AutoSDK_ClassName>
    <AutoSDK_GenerateSdk>true</AutoSDK_GenerateSdk>
</PropertyGroup>
```

For split generation, disable the full SDK flag and enable only the surfaces you want:

```xml
<PropertyGroup Label="AutoSDK">
    <AutoSDK_GenerateSdk>false</AutoSDK_GenerateSdk>
    <AutoSDK_GenerateModels>true</AutoSDK_GenerateModels>
    <AutoSDK_GenerateMethods>true</AutoSDK_GenerateMethods>
    <AutoSDK_GenerateConstructors>true</AutoSDK_GenerateConstructors>
</PropertyGroup>
```

All source-generator settings are listed in [AutoSDK.SourceGenerators.props](src/libs/AutoSDK.SourceGenerators/AutoSDK.SourceGenerators.props).

Generated code is visible in IDE generated-file views, for example in Rider:

![Rider generated code view](assets/rider_show_generated_code.png)

### AsyncAPI WebSocket

```bash
autosdk generate asyncapi.yaml \
    --namespace MyApi.Realtime \
    --websocket-class-name MyRealtimeClient \
    --output Generated
```

This produces a typed WebSocket client with connect/disconnect lifecycle methods, typed send methods for publish operations, typed receive callbacks for subscribe operations, and the associated models and converters.

### gRPC

Scaffold a standalone C# gRPC client project from a protobuf input:

```bash
autosdk generate greeter.proto \
    --namespace Demo.Grpc \
    --targetFramework net8.0 \
    --output GeneratedGrpc
```

The same `generate` command can scaffold from a local `.proto`, a binary descriptor set, or a Buf module reference. Remote `.proto` URLs are not scaffolded directly; use a local file, descriptor set, or Buf module input.

For mixed REST plus gRPC output, keep the OpenAPI or AsyncAPI file as the primary input and add protobuf sidecars:

```bash
autosdk generate openapi.yaml \
    --grpc-input greeter.proto \
    --namespace MyApi \
    --output Generated
```

By default, mixed output writes API files under `rest/` and gRPC projects under `grpc/`. Use `--api-output-subdirectory` and `--grpc-output-subdirectory` to customize that layout.

## CLI Commands

| Command | Purpose |
| --- | --- |
| `autosdk generate <input>` | Generate C# SDK code from OpenAPI or AsyncAPI, or scaffold a gRPC client project from protobuf input. |
| `autosdk http <input>` | Generate executable `.http` request files from OpenAPI path operations. |
| `autosdk cli <input>` | Generate System.CommandLine command classes for an OpenAPI SDK. |
| `autosdk docs sync <path>` | Sync generated examples into README, docs pages, and MkDocs navigation. |
| `autosdk simplify <input>` | Simplify an OpenAPI spec and write the result to a file. |
| `autosdk convert-to-openapi30 <input>` | Convert an OpenAPI 3.1 spec to OpenAPI 3.0 when a downstream tool still needs 3.0. |
| `autosdk init <solution-name> <client-name> <open-api-spec> <company>` | Scaffold a complete SDK solution with CI, packaging, docs, and tests. |
| `autosdk trim <csproj-path>` | Validate trimming and NativeAOT compatibility for a generated SDK project. |
| `autosdk skill <input>` | Generate an agent skill bundle for a generated SDK CLI package. |

Useful `generate` options:

- `--namespace`, `--clientClassName`, and `--targetFramework` control the generated public surface.
- `--include-models` and `--exclude-models` filter models in CLI generation. Source-generator projects also expose `AutoSDK_IncludeOperationIds`, `AutoSDK_ExcludeOperationIds`, `AutoSDK_IncludeTags`, and `AutoSDK_ExcludeTags`.
- `--security-scheme Type:Location:Name` injects missing security schemes, for example `ApiKey:Header:x-api-key` or `Http:Header:Bearer`.
- `--base-url` injects a server URL when a spec does not define `servers`.
- `--openapi-override path=action` applies targeted spec overrides. Supported actions are `object`, `dictionary`, and `remove`.
- `--namespace-delimiter` splits dotted component IDs into nested namespaces, and `--excluded-model-namespace-mode` controls references to filtered-out dotted models.
- `--generate-cli` emits CLI command classes along with the SDK.
- `--use-system-net-http-json` opts into `System.Net.Http.Json` helper usage where generation can do so safely.

## OpenAPI 3.1 Compatibility

OpenAPI.NET 3.x parses OpenAPI 3.1 natively. AutoSDK still runs a compatibility pass for JSON Schema 2020-12 keywords that can be translated cleanly into the current .NET model pipeline.

The normalization pass handles:

- Numeric `exclusiveMinimum` and `exclusiveMaximum`, by mapping them to `minimum` or `maximum` plus the OpenAPI-compatible boolean exclusivity flag.
- `contentEncoding`, including base64/base64url and binary string hints.
- `contentMediaType`, including binary media types such as `application/octet-stream`, `image/*`, `audio/*`, and `video/*`.
- `contentSchema`, `propertyNames`, `dependentRequired`, and `dependentSchemas`, which are preserved as `x-autosdk-json-schema-*` extensions for traceability.
- Safe `unevaluatedProperties`, including direct mapping to `additionalProperties` when the schema does not rely on composition or regex-keyed property evaluation.
- `unevaluatedItems`, tuple-style `prefixItems`, `additionalItems`, and boolean `items`, mapped to regular `items`, `anyOf`, and `maxItems` shapes where possible.
- Match-all `patternProperties` forms such as `.*` and `^.*$`, mapped to `additionalProperties`.

Unsupported OpenAPI 3.1 shapes fail fast with targeted errors that include JSON-pointer-style paths. This includes regex-keyed `patternProperties` that cannot be represented as a normal dictionary, `contains`/`minContains`/`maxContains`, and `unevaluatedProperties` cases that conflict with existing `additionalProperties` or depend on composition semantics.

When a spec intentionally uses a shape AutoSDK cannot model yet, simplify the schema upstream or use `--openapi-override` / `AutoSDK_OpenApiOverrides` to patch the specific path before generation.

## Streaming

AutoSDK detects streaming response shapes and emits `IAsyncEnumerable<T>` methods where the generated client can safely deserialize item-by-item.

Supported streaming media types include:

- Server-Sent Events through `text/event-stream`.
- Sequential JSON through `application/x-ndjson`, `application/jsonl`, and `application/json-seq`.
- Fern streaming metadata via `x-fern-streaming`, including SSE and NDJSON formats.

For non-streaming binary responses, AutoSDK maps common binary media types such as `application/octet-stream`, `application/zip`, and `audio/*` to binary-friendly response types.

## Vendor Extensions

AutoSDK consumes selected third-party SDK metadata when it directly improves generated .NET output. Extension naming is enabled by default in current settings. In source-generator projects, set this to disable it:

```xml
<AutoSDK_UseExtensionNaming>false</AutoSDK_UseExtensionNaming>
```

Supported extension categories include:

- Naming and grouping hints from Fern, OpenAI, Speakeasy, and Stainless metadata.
- Enum names, enum descriptions, and unknown-enum-value behavior.
- Operation/model skip hints and deprecation messages.
- Const/default hints such as `x-stainless-const`.
- Fern streaming and idempotency metadata.
- Speakeasy polling metadata.

AutoSDK deliberately ignores metadata that cannot yet be represented in generated .NET SDK behavior rather than partially implementing it in a surprising way.

## Trimming and NativeAOT

CLI generation emits trimming-friendly System.Text.Json source-generation support by default.

For source-generator projects, use a two-project layout so the .NET `JsonSerializerContext` generator can see the model types before methods reference the context:

```xml
<!-- Models project -->
<PropertyGroup Label="AutoSDK">
    <AutoSDK_GenerateSdk>false</AutoSDK_GenerateSdk>
    <AutoSDK_GenerateModels>true</AutoSDK_GenerateModels>
    <AutoSDK_GenerateJsonSerializerContextTypes>true</AutoSDK_GenerateJsonSerializerContextTypes>
</PropertyGroup>
```

Reference the models project from the main SDK project, add a context type, and point AutoSDK at it:

```csharp
using System.Text.Json.Serialization;

namespace MyApi;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(AutoSDKTrimmableSupport))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;
```

```xml
<!-- Main SDK project -->
<PropertyGroup Label="AutoSDK">
    <AutoSDK_GenerateSdk>false</AutoSDK_GenerateSdk>
    <AutoSDK_GenerateMethods>true</AutoSDK_GenerateMethods>
    <AutoSDK_GenerateConstructors>true</AutoSDK_GenerateConstructors>
    <AutoSDK_JsonSerializerContext>MyApi.SourceGenerationContext</AutoSDK_JsonSerializerContext>
</PropertyGroup>
```

Enable trimming checks in both projects:

```xml
<PropertyGroup Label="Trimmable" Condition="$([MSBuild]::IsTargetFrameworkCompatible('$(TargetFramework)', 'net6.0'))">
    <IsAotCompatible>true</IsAotCompatible>
    <EnableTrimAnalyzer>true</EnableTrimAnalyzer>
    <IsTrimmable>true</IsTrimmable>
    <SuppressTrimAnalysisWarnings>false</SuppressTrimAnalysisWarnings>
    <TrimmerSingleWarn>false</TrimmerSingleWarn>
</PropertyGroup>
```

Use `autosdk trim <csproj-path>` to validate a generated project with the CLI.

## HTTP Artifacts

`autosdk http` emits executable request files for regular OpenAPI path operations. It also surfaces response links and callbacks as commented documentation blocks next to the owning operation, and writes root-level OpenAPI webhooks to `webhooks.http` as inbound contract documentation instead of outbound client calls.

```bash
autosdk http openapi.yaml --output http
```

## AsyncAPI Cross-Namespace Types

When REST and WebSocket specs share schemas, generate the REST SDK first and then point the AsyncAPI client at the existing namespace:

```bash
autosdk generate openapi.yaml \
    --namespace MyApi \
    --clientClassName MyApiClient \
    --output Generated

autosdk generate asyncapi.yaml \
    --namespace MyApi.Realtime \
    --websocket-class-name MyRealtimeClient \
    --types-namespace MyApi \
    --generate-models false \
    --json-serializer-context MyApi.SourceGenerationContext \
    --output Generated
```

`--types-namespace` makes generated WebSocket code reference `global::<namespace>.<TypeName>` instead of regenerating the models. AsyncAPI schema names must match the target namespace's generated type names; if they do not, generate separate models for the WebSocket namespace.

## Known Issue

### Generated file path is too long on Windows

If the generator reports that it could not write an output file because part of the path was not found, the generated path may exceed Windows path limits. Enable long path support using the official Windows documentation:

https://learn.microsoft.com/en-us/windows/win32/fileio/maximum-file-path-limitation?tabs=registry#registry-setting-to-enable-long-paths

## AI-Assisted Workflows

AutoSDK includes a Claude Code skill that captures the CLI options, SDK project conventions, regeneration pattern, customization hooks, and troubleshooting notes for AI-assisted SDK generation.

```bash
npx skills add tryAGI/AutoSDK@generating-dotnet-sdks
```

Skill source: [skills/generating-dotnet-sdks/](skills/generating-dotnet-sdks/)

## Examples of Use in Real SDKs

- [tryAGI/OpenAI](https://github.com/tryAGI/OpenAI) - REST and WebSocket (AsyncAPI)
- [tryAGI/ElevenLabs](https://github.com/tryAGI/ElevenLabs) - REST and WebSocket (AsyncAPI)
- [tryAGI/Xai](https://github.com/tryAGI/Xai) - REST and WebSocket (AsyncAPI)
- [tryAGI/Ollama](https://github.com/tryAGI/Ollama)
- [tryAGI/Anthropic](https://github.com/tryAGI/Anthropic)
- [tryAGI/LangSmith](https://github.com/tryAGI/LangSmith)
- [tryAGI/Replicate](https://github.com/tryAGI/Replicate)
- [tryAGI/DeepInfra](https://github.com/tryAGI/DeepInfra)
- [tryAGI/Leonardo](https://github.com/tryAGI/Leonardo)
- [HavenDV/GitHub.NET](https://github.com/HavenDV/GitHub.NET)

## Acknowledgments

AutoSDK is inspired by [NSwag](https://github.com/RicoSuter/NSwag).
