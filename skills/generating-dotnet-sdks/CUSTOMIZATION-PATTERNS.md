# AutoSDK Customization Patterns

Patterns for extending and customizing auto-generated SDKs, drawn from real-world usage across 30+ SDKs.

## Extending the Client via Partial Classes

Generated client classes are `partial`, so you can add functionality in separate files alongside (not inside) the `Generated/` directory:

```
src/libs/MyApi/
├── Generated/                          # Auto-generated -- never edit
│   ├── MyApiClient.g.cs
│   └── ...
├── MyApiClient.Streaming.cs            # Optional custom streaming helpers
├── MyApiClient.AdditionalConstructors.cs  # Extra constructors
└── Extensions/
    └── StringExtensions.cs             # Helper methods
```

Example partial class extension:

```csharp
namespace MyApi;

public partial class MyApiClient
{
    public MyApiClient(string apiKey)
        : this(new HttpClient
        {
            DefaultRequestHeaders =
            {
                Authorization = new AuthenticationHeaderValue("Bearer", apiKey)
            }
        })
    {
    }
}
```

## Generated Client Hooks

Every generated client exposes four partial method hooks for intercepting the HTTP pipeline:

### PrepareArguments

Modify parameters before the request is built:

```csharp
public partial class MyApiClient
{
    partial void PrepareArguments(/* parameters vary by method */);
}
```

### PrepareRequest

Modify the `HttpRequestMessage` before it is sent:

```csharp
public partial class MyApiClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request);
}
```

Use cases: add custom headers, modify authentication, log requests.

### ProcessResponse

Inspect or modify the `HttpResponseMessage` after receiving it:

```csharp
public partial class MyApiClient
{
    partial void ProcessResponse(HttpClient client, HttpResponseMessage response);
}
```

Use cases: rate-limit tracking, response logging, custom error handling.

### ProcessResponseContent

Inspect or modify the deserialized response body:

```csharp
public partial class MyApiClient
{
    partial void ProcessResponseContent(
        HttpClient client,
        HttpResponseMessage response,
        ref string content);
}
```

Use cases: content transformation, sanitization, debugging.

## Adding Serializable Types

When you add custom types that need JSON serialization (important for NativeAOT/trimming), register them in `JsonSerializerContextTypes.AdditionalTypes.cs`:

```csharp
namespace MyApi;

public sealed partial class JsonSerializerContextTypes
{
    // Add properties for your custom types
    public MyCustomType? MyCustomType { get; set; }
    public List<MyOtherType>? MyOtherTypes { get; set; }
}
```

The generated `SourceGenerationContext` picks these up automatically through the `JsonSerializable` attribute on `JsonSerializerContextTypes`.

## CSharpToJsonSchema Tool Integration

For SDKs that support function/tool calling (OpenAI, Anthropic, Ollama), use the `CSharpToJsonSchema` source generator:

1. Install the package:

```bash
dotnet add package CSharpToJsonSchema
```

2. Define tools as C# interfaces:

```csharp
using System.ComponentModel;
using CSharpToJsonSchema;

[GenerateJsonSchema]
public interface IMyTools
{
    [Description("Gets the current weather for a location")]
    public Weather GetWeather(
        [Description("City name")] string city,
        [Description("Temperature unit")] TemperatureUnit unit = TemperatureUnit.Celsius);
}
```

3. Convert to API tool format:

```csharp
using CSharpToJsonSchema;

var service = new MyToolsService();

// Get tool definitions for the API
var tools = service.AsTools();

// Execute tool calls from API responses
var result = service.AsCalls(toolCallName, toolCallArguments);
```

## Injecting a Base URL

Some OpenAPI specs lack a `servers` field, which means the generated client will have an empty `DefaultBaseUrl`. Use the `--base-url` CLI option to inject the server URL at generation time:

```bash
autosdk generate openapi.yaml \
  --namespace ElevenLabs \
  --clientClassName ElevenLabsClient \
  --base-url "https://api.elevenlabs.io"
```

The URL must be a valid absolute URL. Invalid URLs are rejected with a warning.

For the source generator approach, use the MSBuild property:

```xml
<PropertyGroup>
  <AutoSDK_BaseUrl>https://api.elevenlabs.io</AutoSDK_BaseUrl>
</PropertyGroup>
```

This inserts the URL at position 0 in the spec's `servers` list, taking precedence over any existing server entries.

## Injecting Security Schemes

Many OpenAPI specs (e.g., Anthropic) lack `securitySchemes` definitions, which means the generated SDK won't include authentication constructors. Instead of patching the spec manually, use the `--security-scheme` CLI option:

```bash
# API key in a custom header
autosdk generate openapi.yaml \
  --namespace Anthropic \
  --clientClassName AnthropicClient \
  --security-scheme "ApiKey:Header:x-api-key"

# HTTP Bearer token
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --security-scheme "Http:Header:Bearer"

# Multiple schemes
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --security-scheme "ApiKey:Header:x-api-key" \
  --security-scheme "Http:Header:Bearer"
```

Format: `Type:Location:Name` where:
- **Type**: `ApiKey` or `Http`
- **Location**: `Header`, `Query`, or `Cookie`
- **Name**: Header/query param name (for ApiKey) or scheme name like `Bearer`/`Basic` (for Http)

For the source generator approach, use the MSBuild property (semicolon-separated):

```xml
<PropertyGroup>
  <AutoSDK_SecuritySchemes>ApiKey:Header:x-api-key</AutoSDK_SecuritySchemes>
</PropertyGroup>
```

This injects the security schemes into the OpenAPI document at generation time, producing the same auth constructors as if the spec defined them natively.

## Inline Spec Patching In generate.sh

OpenAPI.NET 3.x parses OpenAPI 3.1 specs directly, and AutoSDK runs a compatibility normalization pass for JSON Schema 2020-12 keywords it can safely map. Scaffolded SDKs do not include a separate fixer project. When an upstream spec still needs local cleanup, patch it inline in `generate.sh` before calling `autosdk generate`.

Common approaches:

- `jq` for JSON spec tweaks
- `yq` for YAML/JSON structural edits
- `sed` or `perl` for small text replacements

Typical customizations:

- Remove or rename conflicting operations
- Add missing operationIds
- Fix invalid schema references
- Inject missing `info` / `servers` metadata
- Normalize defaults or examples that create noisy diffs
- Simplify unsupported OpenAPI 3.1 shapes reported by AutoSDK, such as regex-keyed `patternProperties` or `contains` constraints

## CI Auto-Update Workflow

The standard `auto-update.yml` GitHub Actions workflow automatically:

1. Runs every 3 hours on a cron schedule
2. Downloads the latest OpenAPI spec from the provider
3. Applies any inline spec patches from `generate.sh`
4. Regenerates the SDK with `generate.sh`
5. Opens a pull request if changes are detected

This keeps SDKs synchronized with upstream API changes automatically.

## Multi-Targeting

For SDKs that need to support multiple .NET versions, configure multi-targeting in the `.csproj`:

```xml
<PropertyGroup>
  <TargetFrameworks>netstandard2.0;net462;net8.0;net9.0;net10.0</TargetFrameworks>
</PropertyGroup>
```

AutoSDK generates framework-specific code when the `--targetFramework` flag is set:

- `netstandard2.0` / `net462`: Includes polyfills for missing APIs, System.Text.Json dependency
- `net8.0`+: Uses modern .NET features (required members, init properties, etc.)

For multi-target scenarios, generate with the lowest target:

```bash
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --targetFramework netstandard2.0 \
  --output Generated
```

The generated polyfills ensure compatibility across all target frameworks.

## Trimming / NativeAOT Support

CLI-generated code is trimming-friendly by default. It uses `JsonSerializerContext` for source-generated JSON serialization where possible, which is the intended path for NativeAOT-oriented SDKs.

For the source generator approach, you need a two-project pattern:

**Models project** (generates types + serialization context types):

```xml
<PropertyGroup Label="AutoSDK">
  <AutoSDK_GenerateSdk>false</AutoSDK_GenerateSdk>
  <AutoSDK_GenerateModels>true</AutoSDK_GenerateModels>
  <AutoSDK_GenerateJsonSerializerContextTypes>true</AutoSDK_GenerateJsonSerializerContextTypes>
</PropertyGroup>
```

**Main project** (generates methods, references models project):

```xml
<PropertyGroup Label="AutoSDK">
  <AutoSDK_GenerateSdk>false</AutoSDK_GenerateSdk>
  <AutoSDK_GenerateMethods>true</AutoSDK_GenerateMethods>
  <AutoSDK_GenerateConstructors>true</AutoSDK_GenerateConstructors>
  <AutoSDK_JsonSerializerContext>MyApi.SourceGenerationContext</AutoSDK_JsonSerializerContext>
</PropertyGroup>
```

Add `SourceGenerationContext.cs` to the main project:

```csharp
using System.Text.Json.Serialization;

namespace MyApi;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(AutoSDKTrimmableSupport))]
internal sealed partial class SourceGenerationContext : JsonSerializerContext;
```
