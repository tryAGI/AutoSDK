# AutoSDK CLI Reference

Complete reference for the `autosdk` command-line tool.

## Installation

```bash
dotnet tool install --global autosdk.cli --prerelease
```

To update:

```bash
dotnet tool update --global autosdk.cli --prerelease
```

## Commands

### `autosdk generate <input>`

Generates a C# SDK from an OpenAPI or AsyncAPI specification.

**Arguments:**

| Argument | Type | Description |
|----------|------|-------------|
| `input` | string | Path to OpenAPI or AsyncAPI spec file or URL (YAML or JSON) |

**Options:**

| Option | Alias | Type | Default | Description |
|--------|-------|------|---------|-------------|
| `--output` | `-o` | string | `Generated` | Output directory for generated files |
| `--targetFramework` | `-t` | string | `net10.0` | Target framework for generated code (e.g., `net8.0`, `net9.0`, `net10.0`, `netstandard2.0`, `net462`) |
| `--namespace` | `-n` | string | Derived from input filename | C# namespace for all generated code |
| `--clientClassName` | `-c` | string | Derived from input filename + `Client` | Name of the main generated client class |
| `--methodNamingConvention` | `-m` | enum | `SimpleOperationId` | How API method names are generated. Values: `SimpleOperationId`, `MethodAndPath`, `OperationIdWithDots` |
| `--single-file` | `-s` | bool | `false` | Generate all models and methods in a single .cs file instead of one file per type |
| `--exclude-deprecated-operations` | `-e` | bool | `false` | Skip operations marked as deprecated in the OpenAPI spec |
| `--clsCompliantEnumPrefix` | | string | `x` | Prefix for enum values starting with a number (for CLS compliance). Pass empty string to disable (uses `_` prefix instead) |
| `--ignore-openapi-errors` | | bool | `true` | Continue generation even if the OpenAPI spec has validation errors |
| `--ignore-openapi-warnings` | | bool | `true` | Continue generation even if the OpenAPI spec has validation warnings |
| `--validation` | | bool | `false` | Generate `IValidatableObject` validation methods for models |
| `--compute-discriminators` | | bool | `false` | Compute discriminator mappings for polymorphic models (oneOf/anyOf schemas) |
| `--generate-cli` | | bool | `false` | Generate CLI command classes for the API (System.CommandLine-based) |
| `--security-scheme` | | string[] | (none) | Inject a security scheme as `Type:Location:Name`. Repeatable. See below for format |
| `--base-url` | | string | (none) | Server base URL to inject (e.g., `https://api.example.com`). Useful for specs missing a `servers` field |
| `--websocket-class-name` | | string | (none) | Override class name for the generated WebSocket client (AsyncAPI specs only) |
| `--types-namespace` | | string | (none) | Namespace for type references instead of the main namespace. Used for cross-namespace schema referencing where models live in a different namespace |
| `--generate-models` | | bool | `true` | Generate model classes, enums, and JSON converters. Set to `false` when referencing types from an existing namespace via `--types-namespace` |
| `--json-serializer-context` | | string | `SourceGenerationContext` | Override the `JsonSerializerContext` class name. Useful when generating multiple specs into the same project |

**Examples:**

```bash
# Basic generation
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient

# Production SDK with common options
autosdk generate openapi.yaml \
  --namespace MyCompany.MyApi \
  --clientClassName MyApiClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --ignore-openapi-errors

# Single-file output
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --single-file

# From URL
autosdk generate https://petstore3.swagger.io/api/v3/openapi.json \
  --namespace PetStore \
  --clientClassName PetStoreClient \
  --output Generated

# With polymorphic model support
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --compute-discriminators

# Generate validation methods
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --validation

# Inject security schemes (for specs missing securitySchemes)
autosdk generate openapi.yaml \
  --namespace Anthropic \
  --clientClassName AnthropicClient \
  --security-scheme "ApiKey:Header:x-api-key"

# Multiple security schemes
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --security-scheme "ApiKey:Header:x-api-key" \
  --security-scheme "Http:Header:Bearer"

# API key in query parameter
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --security-scheme "ApiKey:Query:api_key"

# Inject base URL for specs missing a servers field
autosdk generate openapi.yaml \
  --namespace ElevenLabs \
  --clientClassName ElevenLabsClient \
  --base-url "https://api.elevenlabs.io"

# Combine base URL with security scheme
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --base-url "https://api.example.com/v1" \
  --security-scheme "ApiKey:Header:x-api-key"

# Generate WebSocket client from AsyncAPI spec
autosdk generate asyncapi.yaml \
  --namespace MyApi.Realtime \
  --websocket-class-name MyRealtimeClient \
  --output Generated

# AsyncAPI with cross-namespace schema referencing (share models with REST API)
autosdk generate asyncapi.yaml \
  --namespace MyApi.Realtime \
  --websocket-class-name MyRealtimeClient \
  --types-namespace MyApi \
  --generate-models false \
  --json-serializer-context MyApi.SourceGenerationContext \
  --output Generated
```

**Namespace/ClassName auto-derivation:** If `--namespace` or `--clientClassName` are not specified, they are derived from the input filename. For example, `my-cool-api.yaml` produces namespace `MyCoolApi` and client class `MyCoolApiClient`. Special characters (`\`, `-`, `.`, `_`, `/`) are treated as word separators and converted to PascalCase.

---

### `autosdk init <solution-name> <client-name> <openapi-spec> <company>`

Scaffolds a complete SDK project structure with CI/CD, tests, and documentation.

**Arguments:**

| Argument | Type | Description |
|----------|------|-------------|
| `solution-name` | string | Name of the solution (used for directory, .slnx file, csproj names) |
| `client-name` | string | API client name (used in code references) |
| `openapi-spec` | string | URL to the OpenAPI specification |
| `company` | string | Company name (used in LICENSE and docs) |

**Options:**

| Option | Alias | Type | Default | Description |
|--------|-------|------|---------|-------------|
| `--output` | `-o` | string | `./<solution-name>` | Output directory (created if it doesn't exist) |
| `--add-mkdocs` | `-m` | bool | `true` | Include MkDocs Material documentation setup |
| `--add-tests` | `-t` | bool | `true` | Include integration test project |

**Generated structure:**

```
<solution-name>/
├── <solution-name>.slnx
├── .gitignore
├── LICENSE
├── README.md
├── global.json
├── mkdocs.yml                         # if --add-mkdocs
├── assets/nuget-icon.png
├── docs/
│   ├── css/extra.css                  # if --add-mkdocs
│   └── media/icon128.png              # if --add-mkdocs
├── src/
│   ├── Directory.Build.props
│   ├── key.snk
│   ├── libs/
│   │   ├── Directory.Build.props
│   │   └── <solution-name>/
│   │       ├── <solution-name>.csproj
│   │       └── generate.sh
│   ├── tests/IntegrationTests/        # if --add-tests
│   │   ├── <solution-name>.IntegrationTests.csproj
│   │   ├── Tests.cs
│   │   └── Tests.Test.cs
│   └── helpers/
│       ├── GenerateDocs/              # if --add-mkdocs
│       │   ├── GenerateDocs.csproj
│       │   └── Program.cs
│       └── TrimmingHelper/
│           ├── TrimmingHelper.csproj
│           └── Program.cs
└── .github/
    ├── dependabot.yml
    └── workflows/
        ├── auto-merge.yml
        ├── auto-update.yml
        ├── dotnet.yml
        ├── mkdocs.yml                 # if --add-mkdocs
        └── pull-request.yml
```

**Example:**

```bash
# Full project scaffold
autosdk init Anthropic AnthropicClient \
  https://raw.githubusercontent.com/anthropics/anthropic-sdk-typescript/main/openapi.yaml \
  Anthropic

# Without docs or tests
autosdk init MyApi MyApiClient \
  https://example.com/openapi.yaml \
  MyCompany \
  --add-mkdocs false \
  --add-tests false
```

---

### `autosdk http <input>`

Generates `.http` files for testing API endpoints.

**Arguments:**

| Argument | Type | Description |
|----------|------|-------------|
| `input` | string | Path to OpenAPI spec file |

**Options:**

| Option | Alias | Type | Default | Description |
|--------|-------|------|---------|-------------|
| `--output` | `-o` | string | `Testing` | Output directory for .http files |
| `--single-file` | `-s` | bool | `false` | Generate a single .http file |
| `--exclude-deprecated-operations` | `-e` | bool | `false` | Skip deprecated operations |
| `--ignore-openapi-errors` | | bool | `true` | Ignore spec validation errors |
| `--ignore-openapi-warnings` | | bool | `true` | Ignore spec validation warnings |

**Example:**

```bash
autosdk http openapi.yaml --output Testing
```

---

### `autosdk ai spec-from-docs <url>`

Uses AI to generate an OpenAPI specification from HTML API documentation. Scrapes the given URL using Firecrawl, then uses OpenAI GPT-4o to produce a structured OpenAPI 3.0 spec.

**Arguments:**

| Argument | Type | Description |
|----------|------|-------------|
| `url` | URI | URL of the API documentation page |

**Options:**

| Option | Alias | Type | Default | Description |
|--------|-------|------|---------|-------------|
| `--output` | `-o` | string | `generated.yaml` | Output file path for the generated spec |

**Required environment variables:**

| Variable | Purpose |
|----------|---------|
| `FIRECRAWL_API_KEY` | API key for Firecrawl web scraping service |
| `OPENAI_API_KEY` | API key for OpenAI GPT-4o |

**Example:**

```bash
export FIRECRAWL_API_KEY=fc-your-key
export OPENAI_API_KEY=sk-your-key
autosdk ai spec-from-docs https://docs.example.com/api \
  --output example-api.yaml
```

## Security Scheme Format

The `--security-scheme` option injects authentication schemes into OpenAPI specs that lack `securitySchemes` definitions. Format: `Type:Location:Name`.

**Type** (first segment):

| Value | Maps to | Description |
|-------|---------|-------------|
| `ApiKey` | `SecuritySchemeType.ApiKey` | API key authentication |
| `Http` | `SecuritySchemeType.Http` | HTTP authentication (Bearer, Basic) |

**Location** (second segment):

| Value | Maps to | Description |
|-------|---------|-------------|
| `Header` | `ParameterLocation.Header` | Auth via HTTP header |
| `Query` | `ParameterLocation.Query` | Auth via query parameter |
| `Cookie` | `ParameterLocation.Cookie` | Auth via cookie |

**Name** (third segment):

- For `ApiKey`: the header/query/cookie parameter name (e.g., `x-api-key`, `api_key`)
- For `Http`: the HTTP auth scheme name (e.g., `Bearer`, `Basic`)

**Common patterns:**

| Scheme string | Generated auth |
|---------------|----------------|
| `ApiKey:Header:x-api-key` | API key in `x-api-key` header |
| `ApiKey:Header:Authorization` | API key in `Authorization` header |
| `ApiKey:Query:api_key` | API key in `api_key` query parameter |
| `Http:Header:Bearer` | HTTP Bearer token authentication |
| `Http:Header:Basic` | HTTP Basic authentication |

**MSBuild property equivalent** (for source generator usage):

```xml
<PropertyGroup>
  <!-- Single scheme -->
  <AutoSDK_SecuritySchemes>ApiKey:Header:x-api-key</AutoSDK_SecuritySchemes>
  <!-- Multiple schemes (semicolon-separated) -->
  <AutoSDK_SecuritySchemes>ApiKey:Header:x-api-key;Http:Header:Bearer</AutoSDK_SecuritySchemes>
</PropertyGroup>
```

---

## Base URL Injection

The `--base-url` option injects a server entry at position 0 in the OpenAPI spec's `servers` list. This is useful for specs that lack a `servers` field entirely, which would otherwise result in an empty `DefaultBaseUrl` in the generated client.

The URL must be a valid absolute URL (e.g., `https://api.example.com`). Invalid URLs are rejected with a warning.

**MSBuild property equivalent** (for source generator usage):

```xml
<PropertyGroup>
  <AutoSDK_BaseUrl>https://api.example.com</AutoSDK_BaseUrl>
</PropertyGroup>
```

---

## Method Naming Conventions

The `--methodNamingConvention` option controls how C# method names are derived from OpenAPI operations:

| Convention | Description | Example |
|------------|-------------|---------|
| `SimpleOperationId` (default) | Uses the operationId directly, simplified to PascalCase | `listPets` -> `ListPets` |
| `MethodAndPath` | Combines HTTP method + path | `GET /pets/{id}` -> `GetPetsById` |
| `OperationIdWithDots` | Preserves dots in operationId as namespace separators | `pets.list` -> `PetsList` |

If the primary convention fails to produce a unique name, the fallback convention `MethodAndPath` is used automatically.

---

## AsyncAPI / WebSocket Generation

AutoSDK supports [AsyncAPI 3.0](https://www.asyncapi.com/) specifications for generating typed WebSocket clients. The `generate` command auto-detects whether the input is an OpenAPI or AsyncAPI spec.

**What gets generated from an AsyncAPI spec:**
- A WebSocket client class with connect/disconnect lifecycle
- Typed `Send*` methods for publish operations
- Typed `Receive*` methods (via event callbacks) for subscribe operations
- All associated models, enums, and JSON converters

### Cross-Namespace Schema Referencing

When an API has both REST (OpenAPI) and WebSocket (AsyncAPI) specs that share model types, generate them into separate namespaces while avoiding model duplication:

```bash
# Step 1: Generate REST API (models + HTTP client)
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --output Generated

# Step 2: Generate WebSocket client referencing existing REST types
autosdk generate asyncapi.yaml \
  --namespace MyApi.Realtime \
  --websocket-class-name MyRealtimeClient \
  --types-namespace MyApi \
  --generate-models false \
  --json-serializer-context MyApi.SourceGenerationContext \
  --output Generated
```

| Option | Purpose |
|--------|---------|
| `--types-namespace <ns>` | Generated code uses `global::<ns>.{TypeName}` references instead of its own namespace |
| `--generate-models false` | Skips model/enum/converter generation (they already exist in the types namespace) |
| `--json-serializer-context <ctx>` | References an existing `JsonSerializerContext` from the types namespace |
| `--websocket-class-name <name>` | Overrides the generated WebSocket client class name |

> **Constraint:** AsyncAPI schema names must match the target namespace's type names. If they differ (e.g., OpenAI where AsyncAPI uses different names), use separate namespaces with full model generation instead.

**Real-world SDKs using AsyncAPI:**
- [tryAGI/OpenAI](https://github.com/tryAGI/OpenAI) — REST + Realtime WebSocket API
- [tryAGI/ElevenLabs](https://github.com/tryAGI/ElevenLabs) — REST + Realtime Speech-to-Text WebSocket API
- [tryAGI/Xai](https://github.com/tryAGI/Xai) — REST + Realtime Voice Agent WebSocket API
