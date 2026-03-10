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

Generates a C# SDK from an OpenAPI specification.

**Arguments:**

| Argument | Type | Description |
|----------|------|-------------|
| `input` | string | Path to OpenAPI spec file or URL (YAML or JSON) |

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
│       ├── FixOpenApiSpec/
│       │   ├── FixOpenApiSpec.csproj
│       │   ├── Program.cs
│       │   └── Properties/launchSettings.json
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

## Method Naming Conventions

The `--methodNamingConvention` option controls how C# method names are derived from OpenAPI operations:

| Convention | Description | Example |
|------------|-------------|---------|
| `SimpleOperationId` (default) | Uses the operationId directly, simplified to PascalCase | `listPets` -> `ListPets` |
| `MethodAndPath` | Combines HTTP method + path | `GET /pets/{id}` -> `GetPetsById` |
| `OperationIdWithDots` | Preserves dots in operationId as namespace separators | `pets.list` -> `PetsList` |

If the primary convention fails to produce a unique name, the fallback convention `MethodAndPath` is used automatically.
