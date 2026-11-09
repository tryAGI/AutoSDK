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

# Snapshot mismatches fail and leave .received files for review.
# Review each received/verified diff, then explicitly copy only approved files
# over their corresponding .verified baselines and rerun the affected tests.
# AUTOSDK_AUTO_VERIFY is no longer supported.
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

# Commit and push what the script above prepared, one repo at a time. The review is mechanical, so it
# is enforced rather than done by eye: the tree must hold exactly src/cli/<Project>/{Program.cs,
# README.md,CliCompletion.cs} and nothing else, or it refuses — anything more means the tree also holds
# a spec refresh, model drift, or another agent's work.
scripts/commit-cli-completion.sh --dry-run Exa Deepgram

# Bring one or more generated CLIs up to date with cli-project — in practice, add the `completion`
# command to CLIs generated before AutoSDK emitted it. Runs ONLY the repo's own cli-project invocation
# against its committed spec, never generate.sh, which would re-download the spec and mix upstream
# drift into the diff. Never commits. Skips a dirty or stale checkout, and reports a CLI already current.
scripts/regenerate-cli-completion.sh --dry-run Exa Deepgram

# Prepare --reject-unknown-enum-values in sibling SDKs that ship a CLI: patch generate.sh, regenerate,
# build, test, report. Never commits or pushes — the flag changes how every enum deserializes, so the
# diff wants a person. Refuses outright unless the installed autosdk.cli reports the capability, since
# a repo patched before that version reaches NuGet cannot regenerate until it does. Run in small
# batches; --dry-run first. Skips a dirty checkout, because that is someone else's work in progress.
scripts/enable-enum-rejection.sh --dry-run Firecrawl AI21

# Which sibling SDKs declare a one-value enum reachable from a response — the shape that makes
# --reject-unknown-enum-values dangerous if the narrowing is wrong. Read the script's header for what
# the counts do and do not mean. 96 of 220 specs as of 2026-11-09, 16 of the 52 SDKs that ship a CLI.
python3 -I scripts/audit-single-value-response-enums.py

# Pull/rebase all sibling SDK repos from origin/main.
# Dirty checkouts are reported and skipped, never stashed: a dirty tree here is
# usually another agent's work in progress.
./scripts/sync-all.sh

# Same sync, plus a line for every repo with uncommitted changes.
# --dirty is additive, not a dry run: clean repos are still pulled.
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
- `AutoSDK_SplitByTags`: CLI-only. Emit a per-tag package family instead of one project (default: false)
- `AutoSDK_RejectUnknownEnumValues`: Make the generated converters throw on an enum value the spec does
  not declare instead of falling back to the default member (default: false). Turn it on for SDKs whose
  callers pass user input (a CLI, an agent) and want a typo to fail loudly.

  The opt-in is **direction-aware**: a converter is emitted per type and the same one deserializes
  responses, where an undeclared value means the service shipped something new rather than that the
  caller made a typo. So `Data` backs the strictness off for any enum `JsonSerializationDirectionAnalyzer`
  proves is reachable from a response, including one reached from both directions (a single converter
  cannot be strict one way and lenient the other, so the response side decides). Absence of proof is not
  proof: an enum reached only from requests, one no operation reaches, and a models-only generation with
  no `paths` at all all keep the strictness that was asked for. Single-value enums are never touched —
  those are discriminator consts hardened by `ValidateAnyOfs`, for reasons unrelated to direction.

  Measured on tryAGI/Runway: the flag alone makes 243 converters strict, including the task status read
  on every poll and an enum of model ids the account returns that the spec is already known not to list;
  direction-aware narrowing brings that to 164, all of them `*Request*` enums.

#### Capability discovery (`autosdk capabilities`)

Downstream `generate.sh` scripts have to refuse to run against a CLI that is too old, because passing
an opt-in flag to a build that accepts it but implements it differently produces a wrong SDK rather
than an error. `autosdk capabilities` prints stable tokens for that check, one per line, `--json` for
structured output, and `--require <token>...` to gate directly:

```bash
autosdk capabilities --require behavior:request-scoped-enum-rejection || exit 1
```

Two kinds of token. `flag:<command>:<option>` is derived at runtime from the options the commands
actually register, so the listing cannot claim a flag the build lacks. `behavior:<name>` is a curated
list in `CapabilitiesCommand` for semantics a flag name does not capture — the case that motivated it
is a build that accepts `--reject-unknown-enum-values` but hardens response enums too. Seven today,
covering request-scoped enum rejection, direction-aware JSON modes, same-origin validation of
next-page URLs, the retry handler's vendor defaults, idempotency without a vendor extension,
polymorphic-array auto-detection, and `x-call-scoped-auth`. Each one names behaviour checked against
the source, not a flag that happens to exist: a token is a promise.

**These token names are a compatibility surface.** tryAGI/Runway and tryAGI/Firecrawl check them in
`generate.sh`. Add tokens; do not rename or remove them. When adding an opt-in whose meaning has since
changed, add a `behavior:` token rather than relying on the flag's presence.

#### Response fields that are required *and* defaulted

`generate` warns when a schema reachable from a response body declares a property `required` while
also giving it a `default`. The generated deserializers enforce `required`, so a field the service
omits turns a successful HTTP 200 into a `JsonException` — and a documented default is the spec
saying the producer may omit it.

This is not hypothetical: Anthropic's spec marked `caller` that way on 52 response block schemas and
the API never sends it, so every response that used a server tool (web search, web fetch, code
execution) failed to deserialize until `generate.sh` stripped it.

`--relax-response-required` (`AutoSDK_RelaxResponseRequired`) drops those entries from `required`
during document preparation. It is **off by default** on purpose: a finding is a candidate, not a
confirmed defect — plenty of services do send a field that has a default (`UsageInfo.prompt_tokens`)
— so the warning asks for a live test first. The same reasoning as `--reject-unknown-enum-values`,
pointing the other way: leniency belongs on the response-reading path, where the service, not the
caller, decides what arrives.

`FindResponseRequiredWithDefault` / `RelaxResponseRequiredWithDefault` in
`AutoSDK/Extensions/OpenApiResponseRequiredExtensions.cs` do the work; only schemas reachable from a
response body are considered, because in a request body the pair is exactly what a default means.
`scripts/audit_response_required_defaults.py` in the workspace repo runs the same check across every
sibling SDK without generating.

#### Generated CLI shell completion

`cli-project` emits `CliCompletion.cs` and, for non-`--api-only` projects, wires
`completion bash|zsh|fish` into the generated `Program.cs`. The script is built by walking the live
`Command` tree at runtime — subcommands, option names, and the values of any enum-typed option read off
`Option.ValueType` — so it describes the CLI as assembled, including hand-added commands, and cannot go
stale the way a checked-in word list does. An `--api-only` project gets the file but wires it up itself,
since it owns `Program.cs`.

#### Split-by-tags package families (CLI only)

`autosdk generate --split-by-tags --package-id <id>` emits `<id>.Core` (shared models, converters,
serializer context, runtime support), one package per OpenAPI tag, a base package holding the root
client plus any untagged operations, a `.slnx`, and a deterministic `autosdk-packages.json`.
Reference graph is `base -> tag* -> Core`.

A model, enum or named union reached by exactly one tag ships in that tag's package;
`ModelOwnershipResolver` decides that and both `PackagePlanner` (routing files) and `CSharpPipeline`
(emitting a matching serializer context per package) must get the same answer, which is why the
decision lives in one place and is recomputed rather than carried on `Data`.
`TagOwnershipAnalyzer` proposes ownership from schema reachability; the resolver then verifies it
against the generated C# reference graph and demotes anything that would cross a package boundary,
because the schema graph is depth- and cycle-limited and under-reports on large specs
(`specs/github.yaml` is the case that proved it).

Three things only this mode changes, all gated on `Settings.SplitByTags`:

- Shared runtime members (`EndPointSecurityResolver`, `AutoSDKRequestOptionsSupport`, polling
  helpers, `AutoSDKHttpResponse.CreateHeaders`, `AutoSDKServerConfiguration`, `ResponseStream`,
  `JsonSerializerContextProvider`) become `public` + `[EditorBrowsable(Never)]` via
  `Sources.SharedMemberModifier` / `SharedNestedMemberModifier`. With
  `--strong-name-public-key` they stay `internal` and the generated projects emit
  `InternalsVisibleTo` instead.
- Each package emits its own JSON serializer context (`Core` keeps `SourceGenerationContext`, a tag
  gets `{Ns}.{Tag}SourceGenerationContext`, the facade `{Ns}.{RootClient}SourceGenerationContext`),
  chained through a generated `TypeInfoResolver` property. Chain through that, never through a
  context's `Default`: a context is bound to the options it was built with and throws when a
  resolver hands it different ones. Every context also registers the converters for everything it
  can be asked to resolve, not just what it owns.
- The OAuth2 support types are hoisted out of the root client class into a namespace-level
  `{Ns}.AutoSDKOAuth2.g.cs` in Core (`Sources.OAuth2SupportTypes`). Left nested they would sit in
  the base package while tag clients and tag operation bodies need them, so every tag assembly
  would reference the base package that already references it.

A Roslyn generator cannot create projects, so `SdkGenerator` forces `SplitByTags` off and reports
`OAG004`. The guarantee that the family actually compiles as separate assemblies is
`CliSplitByTagsTests` in `AutoSDK.IntegrationTests.Cli`, which builds the generated `.slnx` plus a
tag-only and a base-package consumer — not a hand-maintained list of members.

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
- `x-autosdk-path`: The real request path for an operation, overriding the path key. A spec cannot
  declare two operations on the same path and method, so a spec exposing a beta variant of an
  endpoint keys it by appending a query string (`/v1/messages?beta=true`, as Anthropic's does);
  without this extension that disambiguator is sent to the service as a bogus query parameter.

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
