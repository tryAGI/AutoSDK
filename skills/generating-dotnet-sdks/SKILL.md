---
name: generating-dotnet-sdks
description: >-
  Generates .NET/C# SDKs from OpenAPI specifications using the AutoSDK CLI tool
  (autosdk.cli). Use when the user wants to create a C# client library from an
  OpenAPI/Swagger spec, scaffold a new SDK project, regenerate existing SDK code,
  or customize generated .NET API clients.
---

# Generating .NET SDKs from OpenAPI Specs with AutoSDK

## Overview

AutoSDK is a .NET CLI tool and Roslyn source generator that produces production-quality C# SDKs from OpenAPI specifications. Generated SDKs include:

- Fully typed C# clients with async methods and CancellationToken support
- System.Text.Json serialization (no reflection, NativeAOT/trimming compatible)
- Nullable reference types enabled
- Support for OneOf/AnyOf/AllOf schemas
- Server-Sent Events (SSE) streaming via `application/x-ndjson`
- Enum serialization for System.Text.Json
- Polyfills for .NET Framework / .NET Standard targets
- Strong-named assemblies

AutoSDK is used in 30+ real SDKs (OpenAI, Anthropic, Ollama, HuggingFace, etc.) and tested against OpenAPI specs up to 220k lines.

## Quick Start Workflow

### Step 1: Install the CLI tool

```bash
dotnet tool install --global autosdk.cli --prerelease
```

### Step 2: Obtain the OpenAPI specification

Either download it or point to a local file:

```bash
# Download from URL
curl -o openapi.yaml https://example.com/api/openapi.yaml

# Or use a local file
ls openapi.yaml
```

AutoSDK accepts both YAML and JSON formats. It supports OpenAPI 3.0 and 3.1 specs (3.1 is internally converted to 3.0).

### Step 3: Generate the SDK

```bash
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace MyCompany.MyApi \
  --clientClassName MyApiClient \
  --targetFramework net8.0 \
  --output Generated
```

This creates a `Generated/` directory containing all C# source files.

### Step 4: Build and verify

```bash
dotnet build
```

The generated code compiles as part of any .NET project that includes the `Generated/` directory.

## CLI Commands

### `autosdk generate <input>`

Main command. Generates a C# SDK from an OpenAPI spec file or URL.

```bash
autosdk generate openapi.yaml \
  --namespace Anthropic \
  --clientClassName AnthropicClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
```

Key options:

| Option | Alias | Default | Description |
|--------|-------|---------|-------------|
| `--output` | `-o` | `Generated` | Output directory for generated files |
| `--targetFramework` | `-t` | `net10.0` | Target framework (e.g., `net8.0`, `netstandard2.0`) |
| `--namespace` | `-n` | Derived from filename | C# namespace for generated code |
| `--clientClassName` | `-c` | Derived from filename | Name of the generated client class |
| `--methodNamingConvention` | `-m` | `SimpleOperationId` | How method names are derived |
| `--single-file` | `-s` | `false` | Output all code in a single .cs file |
| `--exclude-deprecated-operations` | `-e` | `false` | Skip deprecated API operations |
| `--ignore-openapi-errors` | | `true` | Continue generation despite spec errors |
| `--validation` | | `false` | Generate model validation methods |
| `--compute-discriminators` | | `false` | Compute discriminators for polymorphic models |
| `--generate-cli` | | `false` | Generate a CLI wrapper for the client |
| `--security-scheme` | | (none) | Inject auth scheme as `Type:Location:Name` (repeatable) |
| `--base-url` | | (none) | Server base URL to inject for specs missing `servers` |

See [CLI-REFERENCE.md](CLI-REFERENCE.md) for the complete option reference.

### `autosdk init <solution-name> <client-name> <openapi-spec> <company>`

Scaffolds a complete SDK project with solution file, CI workflows, tests, and docs.

```bash
autosdk init MyApi MyApiClient https://example.com/openapi.yaml MyCompany
```

This creates a full project structure including:
- Solution file (`.slnx`)
- GitHub Actions workflows (CI, auto-update, auto-merge, MkDocs)
- Integration test project
- TrimmingHelper for NativeAOT validation
- `generate.sh` regeneration script
- `README.md`, `LICENSE`, `.gitignore`

Options: `--output` / `-o`, `--add-mkdocs` / `-m` (default: true), `--add-tests` / `-t` (default: true).

### `autosdk http <input>`

Generates `.http` files from an OpenAPI spec for API testing.

```bash
autosdk http openapi.yaml --output Testing
```

### `autosdk ai spec-from-docs <url>`

AI-powered command that generates an OpenAPI spec from HTML documentation pages.

```bash
export FIRECRAWL_API_KEY=your_key
export OPENAI_API_KEY=your_key
autosdk ai spec-from-docs https://docs.example.com/api --output generated.yaml
```

Requires `FIRECRAWL_API_KEY` and `OPENAI_API_KEY` environment variables.

## Project Structure Convention

AutoSDK-based SDK projects follow a standard layout:

```
MyApi/
├── MyApi.sln
├── src/
│   ├── libs/MyApi/
│   │   ├── MyApi.csproj
│   │   ├── openapi.yaml              # Source OpenAPI spec
│   │   ├── generate.sh               # Regeneration script
│   │   ├── Generated/                # AUTO-GENERATED -- never edit
│   │   │   ├── MyApiClient.g.cs
│   │   │   ├── Models/*.g.cs
│   │   │   └── ...
│   │   └── *.cs                      # Hand-written extensions
│   ├── tests/IntegrationTests/
│   └── helpers/
│       ├── GenerateDocs/              # Doc generation
│       └── TrimmingHelper/            # NativeAOT validation
└── .github/workflows/
    └── auto-update.yml
```

**Critical rule:** Never manually edit files in `Generated/` directories. They are overwritten on regeneration. Place customizations in partial classes outside `Generated/`.

## The generate.sh Pattern

Every SDK includes a `generate.sh` script that automates the full regeneration pipeline. Here is a real-world example (from the Anthropic SDK):

```bash
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://example.com/openapi.yaml
autosdk generate openapi.yaml \
  --namespace Anthropic \
  --clientClassName AnthropicClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
```

The pipeline: install CLI -> download spec -> optionally patch the spec inline in `generate.sh` -> generate.

If the spec lacks authentication definitions (no `securitySchemes`), use `--security-scheme` instead of patching the spec manually:

```bash
autosdk generate openapi.yaml \
  --namespace Anthropic \
  --clientClassName AnthropicClient \
  --targetFramework net8.0 \
  --output Generated \
  --security-scheme "ApiKey:Header:x-api-key"
```

If the spec is missing a `servers` field, use `--base-url` to inject the base URL:

```bash
autosdk generate openapi.yaml \
  --namespace ElevenLabs \
  --clientClassName ElevenLabsClient \
  --targetFramework net8.0 \
  --output Generated \
  --base-url "https://api.elevenlabs.io"
```

## Post-Generation Customization

Generated clients are partial classes, enabling extension without modifying generated code:

### Client Hooks

Generated clients expose partial method hooks you can override:

```csharp
public partial class MyApiClient
{
    partial void PrepareArguments(/* modify parameters before request */);
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request);
    partial void ProcessResponse(HttpClient client, HttpResponseMessage response);
    partial void ProcessResponseContent(HttpClient client, HttpResponseMessage response, ref string content);
}
```

### Extension Files

Place hand-written code alongside `Generated/` (not inside it):

- `MyApiClient.Streaming.cs` -- SSE/streaming extensions
- `MyApiClient.AdditionalConstructors.cs` -- extra constructor overloads
- `JsonSerializerContextTypes.AdditionalTypes.cs` -- extra types for JSON source gen
- `Extensions/` -- helper extension methods

See [CUSTOMIZATION-PATTERNS.md](CUSTOMIZATION-PATTERNS.md) for detailed patterns.

## Configuration Options

The `generate` command's most important configuration flags:

| Flag | Purpose | When to use |
|------|---------|-------------|
| `--targetFramework net8.0` | Set target framework | Always set explicitly for your project |
| `--namespace X` | Set C# namespace | Always set to match your project namespace |
| `--clientClassName X` | Set client class name | Always set to a descriptive name |
| `--exclude-deprecated-operations` | Skip deprecated endpoints | Most production SDKs |
| `--ignore-openapi-errors` | Tolerate spec issues | Specs with minor validation errors |
| `--single-file` | One output file | Smaller APIs or embedding in existing projects |
| `--compute-discriminators` | Polymorphic model support | APIs with oneOf/anyOf discriminators |
| `--validation` | Model validation methods | When input validation is needed |
| `--generate-cli` | Generate CLI wrapper | When you want a CLI for the API |
| `--methodNamingConvention` | Method name style | `SimpleOperationId` (default), `MethodAndPath`, `OperationIdWithDots` |
| `--security-scheme` | Inject auth for specs missing `securitySchemes` | `ApiKey:Header:x-api-key`, `Http:Header:Bearer` (repeatable) |

## Troubleshooting

Common issues and solutions:

- **"Could not find part of the path"** -- Enable Windows long paths in registry
- **Malformed or incomplete specs** -- Patch the downloaded spec inline in `generate.sh` with `jq`, `yq`, `sed`, or `perl` before generation
- **Missing operations** -- Check that operationIds exist in the spec; use `--ignore-openapi-errors` if needed
- **Naming collisions** -- AutoSDK resolves these automatically via suffixes
- **No auth constructors generated** -- Spec is missing `securitySchemes`; use `--security-scheme "ApiKey:Header:x-api-key"` to inject auth

See [TROUBLESHOOTING.md](TROUBLESHOOTING.md) for the complete troubleshooting guide.
