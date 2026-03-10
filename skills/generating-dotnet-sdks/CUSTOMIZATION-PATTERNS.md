# AutoSDK Customization Patterns

Patterns for extending and customizing auto-generated SDKs, drawn from real-world usage across 30+ SDKs.

## Extending the Client via Partial Classes

Generated client classes are `partial`, so you can add functionality in separate files alongside (not inside) the `Generated/` directory:

```
src/libs/MyApi/
├── Generated/                          # Auto-generated -- never edit
│   ├── MyApiClient.g.cs
│   └── ...
├── MyApiClient.Streaming.cs            # Hand-written streaming support
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

## Injecting Security Schemes

Many OpenAPI specs (e.g., Anthropic) lack `securitySchemes` definitions, which means the generated SDK won't include authentication constructors. Instead of patching the spec in FixOpenApiSpec, use the `--security-scheme` CLI option:

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

## The FixOpenApiSpec Helper

Every SDK project includes a `FixOpenApiSpec` helper that preprocesses the OpenAPI spec before generation. It handles:

- Converting OpenAPI 3.1 to 3.0 format
- Fixing common spec issues (missing operationIds, invalid references)
- Normalizing schema structures

Usage in the regeneration pipeline:

```bash
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
```

To customize spec fixing for your API, modify `src/helpers/FixOpenApiSpec/Program.cs`. Common customizations:

- Remove or rename conflicting operations
- Add missing operationIds
- Fix invalid schema references
- Merge or split spec files

## CI Auto-Update Workflow

The standard `auto-update.yml` GitHub Actions workflow automatically:

1. Runs every 3 hours on a cron schedule
2. Downloads the latest OpenAPI spec from the provider
3. Runs FixOpenApiSpec
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

CLI-generated code is NativeAOT-compatible by default. It uses `JsonSerializerContext` for source-generated JSON serialization (no reflection).

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
