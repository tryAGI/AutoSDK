# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build Commands
```bash
# Build entire solution
dotnet build

# Build specific projects
dotnet build src/libs/AutoSDK/AutoSDK.csproj
dotnet build src/libs/AutoSDK.SourceGenerators/AutoSDK.SourceGenerators.csproj
dotnet build src/libs/AutoSDK.CLI/AutoSDK.CLI.csproj
```

## Test Commands
```bash
# Run all tests
dotnet test

# Run specific test projects
dotnet test src/tests/AutoSDK.UnitTests/AutoSDK.UnitTests.csproj
dotnet test src/tests/AutoSDK.SnapshotTests/AutoSDK.SnapshotTests.csproj

# Run with filter
dotnet test --filter "FullyQualifiedName~DataTests"
dotnet test --filter "FullyQualifiedName~NamingTests"
dotnet test --filter "FullyQualifiedName~JsonTests"

# Auto-verify all snapshots (accepts all changes as new baselines)
# Use after changes that cause expected widespread snapshot churn
# (e.g., ordering fixes, formatting changes, template adjustments)
AUTOSDK_AUTO_VERIFY=true dotnet test src/tests/AutoSDK.SnapshotTests/
```

## CLI Tool Development
```bash
# Run CLI locally (from src/libs/AutoSDK.CLI/)
dotnet run -- generate openapi.yaml --namespace MyApi --output Generated

# Install CLI globally for testing
dotnet pack src/libs/AutoSDK.CLI/AutoSDK.CLI.csproj
dotnet tool install --global --add-source ./src/libs/AutoSDK.CLI/bin/Debug autosdk.cli --prerelease

# Uninstall
dotnet tool uninstall --global autosdk.cli
```

## Scripts
```bash
# Sync OpenAPI specs from sibling SDK repos into specs/
./scripts/sync-specs.sh

# Pull/rebase all sibling SDK repos from origin/main
./scripts/sync-all.sh

# Show repos with uncommitted changes
./scripts/sync-all.sh --dirty

# Explicit parent directory
./scripts/sync-all.sh /path/to/tryAGI
```

## Architecture Overview

### Core Components

**AutoSDK** (`src/libs/AutoSDK/`)
- Core library with data models, naming strategies, and code generation logic
- Key directories:
  - `Models/`: OpenAPI representation (EndPoint, ModelData, Client, etc.)
  - `Naming/`: Name generation strategies (ModelNameGenerator, PropertyNameGenerator, etc.)
  - `Sources/`: Code generation templates (partial methods that emit C# code)
  - `Extensions/`: OpenAPI parsing and manipulation helpers
  - `Serialization/`: JSON/form serialization strategies

**AutoSDK.SourceGenerators** (`src/libs/AutoSDK.SourceGenerators/`)
- Roslyn incremental source generators (IIncrementalGenerator)
- Two generators:
  - `SdkGenerator`: Generates models, methods, clients, auth, JSON serialization
  - `CliGenerator`: Generates CLI commands from API operations
- Reads configuration from `.csproj` properties and `AdditionalFiles` metadata

**AutoSDK.CLI** (`src/libs/AutoSDK.CLI/`)
- Standalone CLI tool using System.CommandLine
- Commands in `Commands/`:
  - `generate`: Main SDK generation
  - `initialize`: Scaffold new SDK project structure
  - `trim`: Validate trimming/NativeAOT compatibility for a .csproj
  - `cli`: Generate CLI commands
  - `convert`: Convert OpenAPI formats
  - `simplify`: Simplify OpenAPI specs
  - `ai`: AI-powered spec generation/modification
  - `http`: HTTP utility

### Source Generation Pipeline

```
OpenAPI Spec → Data.Prepare() → SchemaContext tree → Name generation →
Data structure (Classes/Enums/EndPoints/Clients) → Sources.* methods → C# files
```

Key classes:
- `Data.Prepare()`: Main entry point, processes OpenAPI → Models.Data
- `SchemaContext`: Internal tree representing schema relationships
- `Settings`: Configuration container (parsed from .csproj properties)
- `Sources`: Static partial methods for code templates

### Configuration System

All settings defined in `AutoSDK.SourceGenerators.props` as `CompilerVisibleProperty`:
- Prefix: `AutoSDK_*`
- Examples: `AutoSDK_Namespace`, `AutoSDK_ClassName`, `AutoSDK_GenerateMethods`
- Set in `.csproj` `<PropertyGroup>` or per-file via `AdditionalFiles` metadata
- Full list: See `src/libs/AutoSDK.SourceGenerators/AutoSDK.SourceGenerators.props`

Important settings:
- `AutoSDK_GenerateSdk`: Generate full SDK (default: true)
- `AutoSDK_GenerateModels`: Generate only models
- `AutoSDK_GenerateMethods`: Generate only methods
- `AutoSDK_GenerateConstructors`: Generate client constructors
- `AutoSDK_JsonSerializerContext`: Enable trimming support
- `AutoSDK_ModelStyle`: Class/Record/ReadonlyRecordStruct
- `AutoSDK_MethodNamingConvention`: SimpleOperationId/MethodAndPath/OperationIdWithDots
- `AutoSDK_UseExtensionNaming`: Use OpenAPI `x-` extensions for naming/grouping (default: true)

#### OpenAPI `x-` Extension Support

AutoSDK recognizes vendor extensions (`x-*`) in OpenAPI specs to improve generated code quality.

**Always-on extensions** (not affected by `UseExtensionNaming`):
- `x-enum-varnames`: Override enum member names via parallel string array
- `x-fern-enum`: Override enum member names/descriptions via object map
- `x-enum-descriptions`: Set enum member XML doc summaries
- `x-nullable`: Swagger 2.x nullable fallback
- `x-displayName`: Tag display names for client class XML docs
- `x-stainless-deprecation-message`: Custom `[Obsolete()]` message text
- `x-label`: Fallback summary when `description` is empty
- `x-stainless-const`: Mark properties as const (when `default` exists)
- `x-codeSamples`: Code samples emitted as `<remarks>` XML docs

**Gated by `UseExtensionNaming`** (breaking: affects generated names/structure):
- `x-fern-sdk-method-name`: Override method names
- `x-fern-sdk-group-name`: Override client grouping (overrides tags). Ad-hoc group names are pre-scanned from operations and added to `allTags` in a single pass (`Data.cs`), ensuring sub-client classes are generated. Tags with no assigned methods after reassignment are filtered out to prevent empty sub-clients.
- `x-fern-type-name`: Override class/type names
- `x-fern-ignore` / `x-hidden`: Skip endpoint/schema generation

**CLI command naming**: `EndPoint.CliCommandClassName` includes a tag prefix (e.g., `ConnectorsCreateCommand`) to avoid class name collisions when multiple groups share the same method name. Used by `Sources.CLI.Command.cs`, `Sources.CLI.GroupCommand.cs`, and `Sources.CLI.AddCommands.cs`.

### Integration Test Pattern

Tests use a two-project pattern for trimming/NativeAOT support:

```
<ServiceName>.Models/               (Step 1: Generate models)
├── .csproj
│   ├── AutoSDK_GenerateSdk=false
│   ├── AutoSDK_GenerateModels=true
│   └── AutoSDK_GenerateJsonSerializerContextTypes=true
└── Reference: AutoSDK.SourceGenerators

<ServiceName>/                      (Step 2: Generate methods)
├── Tests.cs
├── SourceGenerationContext.cs
├── .csproj
│   ├── AutoSDK_GenerateSdk=false
│   ├── AutoSDK_GenerateMethods=true
│   ├── AutoSDK_GenerateConstructors=true
│   └── AutoSDK_JsonSerializerContext=<Namespace>.SourceGenerationContext
└── Reference: <ServiceName>.Models
```

Why two projects?
- Proper source generator dependency ordering
- Enables JsonSerializerContext for trimming/NativeAOT
- Models project generates types for serialization context
- Main project uses the serialization context

### Specs Directory

`specs/` contains OpenAPI specifications:
- Real APIs: `openai.yaml`, `github.yaml`, `twitch.json`, etc.
- Test fixtures: `petstore.yaml`, `special-cases.yaml`
- Used by integration tests via `<AdditionalFiles Include="specs/foo.yaml" />`

### Key Patterns

**Incremental Generators**: Uses `IIncrementalGenerator` for efficient caching and O(n) performance

**Partial Class Generation**: Each model generates multiple partials:
- `.g.cs`: Main definition
- `.Json.g.cs`: Serialization extensions
- `.IValidatableObject.g.cs`: Validation (optional)

**Naming Collision Resolution**: `ModelNameGenerator` handles identifier conflicts via suffixes

**Polymorphism Support**: Computes discriminator mappings from `oneOf`/`anyOf` schemas

**Two JSON Serializers**: SystemTextJson (default, trimming-compatible) or NewtonsoftJson

**Model Styles**:
- `Class`: Traditional reference types (default)
- `Record`: Immutable records
- `ReadonlyRecordStruct`: Value types for performance

### Code Generation String Template Conventions

> **CRITICAL WARNING — Trailing Space Convention**
>
> In `Sources/` template strings, a **trailing space** after `@"` or `$@"` controls whether the first line is trimmed or preserved. **Never remove trailing spaces** from template string openers — this causes unwanted blank lines in ALL generated output files (thousands of snapshot changes).
>
> - `$@" \n` (space after `"`) → first line is `" "` (whitespace-only) → **TRIMMED** by `RemoveBlankLinesWhereOnlyWhitespaces()`
> - `$@"\n` (no space after `"`) → first line is `""` (empty, length 0) → **PRESERVED** as blank line
>
> When editing ternary expressions inside templates (e.g., changing `@" \n...[Obsolete]..."` to `$@" \n...[Obsolete("custom")]..."`), always preserve the space between `"` and the newline. The same applies to `return $@" \n` at the start of template methods.

The `Sources/` code generation templates use two key extension methods that interact:
- **`Inject()`** (`StringExtensions.cs`): Concatenates strings and trims leading/trailing `\r`/`\n` characters. Returns `" "` (space) if empty.
- **`RemoveBlankLinesWhereOnlyWhitespaces()`**: Removes lines that contain only whitespace (but keeps truly empty lines).

These methods create a convention for controlling blank lines in generated output:

| Pattern | Effect | Use Case |
|---------|--------|----------|
| `$@" \n` (space after `"`) | Line is removed by `RemoveBlankLinesWhereOnlyWhitespaces()` | Separator between items — prevents unwanted blank lines |
| `$@"\n` (no space after `"`) | Empty line is preserved in output | Intentional blank line between code sections |

**Example — trimmed separator (no blank line between items):**
```csharp
anyOfData.Properties.Select((x, i) => $@"
            {(i == 0 ? "" : "else ")}if (...)
            {{
            }}
").Inject()
```
The leading `" \n"` creates a whitespace-only line that gets removed, preventing blank lines between `if/else if` blocks.

**Example — preserved blank line (intentional spacing):**
```csharp
anyOfData.Properties.Select(x => $@"
                {x.ParameterName},
").Inject()
```
The leading `"\n"` creates a true empty line that is preserved, adding visual spacing between constructor arguments.

**Key rule**: When writing `$@"` inside a `.Select()` lambda for `Inject()`, always consider whether you want the first line trimmed away (use trailing space: `$@" \n`) or preserved as a blank line (use no space: `$@"\n`).

## Code Style Guidelines
- **Naming**: PascalCase for types/methods, camelCase for parameters/variables
- **Structure**: Using directives at top, followed by namespace
- **Patterns**: Nullable reference types, expression-bodied members, pattern matching
- **Error Handling**: Validate parameters with explicit null checks
- **Formatting**: 4 spaces indentation, braces on new lines
- **Testing**: MSTest with AwesomeAssertions (unit), Verify (snapshot)

## Common Workflows

### Adding a New Source Template
1. Add partial method signature to `Sources.cs`
2. Implement in appropriate file under `Sources/`
3. Call from `Data.cs` or generator class
4. Add snapshot test in `AutoSDK.SnapshotTests`

### Testing Code Generation
1. Add/modify spec in `specs/`
2. Create snapshot test in `AutoSDK.SnapshotTests`
3. Run test to generate baseline: `dotnet test --filter "TestName"`
4. Verify output in `_snapshots/` directory

### Adding Configuration Option
1. Add `CompilerVisibleProperty` in `AutoSDK.SourceGenerators.props`
2. Add property to `Settings` record in `Settings.cs`
3. Parse in `Settings.GetSettings()` method
4. Use in generation pipeline

### Debugging Source Generator
1. Add `<IsRoslynComponent>true</IsRoslynComponent>` to generator `.csproj`
2. Set breakpoint in generator code
3. Launch debugger on test project build
4. Alternative: Use `System.Diagnostics.Debugger.Launch()` in generator

## Dependencies

- **Runtime**: Microsoft.OpenApi, Microsoft.OpenApi.Readers
- **Build**: Microsoft.CodeAnalysis.CSharp (Roslyn)
- **Testing**: MSTest, AwesomeAssertions, Verify
- **CLI**: System.CommandLine
- **Target Frameworks**: net4.6.2, netstandard2.0, net10.0 (AutoSDK core); net10.0 only (generated SDKs)
