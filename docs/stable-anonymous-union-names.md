# Stable public names for anonymous unions

Anonymous `oneOf`/`anyOf`/`allOf` wrappers historically use short property names and
resolve global collisions with numeric suffixes. An unrelated schema can therefore
change `IncludedItem62` into `IncludedItem64` without changing its contract (#455).

Opt in during an intentional public API migration:

```sh
autosdk generate openapi.json --stable-anonymous-union-names ...
```

For the Roslyn source generator use:

```xml
<AutoSDK_StableAnonymousUnionNames>true</AutoSDK_StableAnonymousUnionNames>
```

Library callers set `Settings.StableAnonymousUnionNames = true`. The default is
`false`, preserving existing generated APIs until their owners choose to migrate.
The setting is also carried through `CSharpSettings` and schema-context settings.

The new name contains the owning component and full property/array-item path,
followed by 16 hexadecimal characters from SHA-256 of the raw semantic path.
For the pinned AppStoreConnect specification, `BuildsResponse.Included` uses
`BuildsResponseIncludedItem_e807cc9b04238d70` instead of `IncludedItem64`.
The digest is always present, so adding a different path that normalizes to the
same C# name cannot rename the existing union. Property dictionary positions and
component traversal order do not enter the digest. Inline operation owners include
HTTP method, path, operation ID, response status, parameter name and media type.
Union-branch positions remain part of nested branch paths: reordering the union's
own alternatives can change its contract and is outside this stability guarantee.
Explicit component names and extension-provided type names retain their existing
naming rules. Nullable single-value wrappers still normalize to nullable values.

## Migration

1. Enable the option in the SDK's checked-in generation configuration. Keep using
   the same option for subsequent regenerations.
2. Regenerate into a clean, dedicated output directory (or use
   `--clean-stale-files` there); obsolete numeric wrapper files must be removed.
3. Replace explicit consumer references to numeric anonymous wrapper names with
   their generated owner/path names, and recompile consumers. JSON property names,
   discriminator values and union members do not change.
4. Ship the rename as a breaking SDK API change using the SDK's version policy.
   Consumers needing the old source API can retain legacy mode until migration;
   legacy mode does not promise stable numeric suffixes.

The regression tests insert/reorder unrelated schemas, reorder properties, and
introduce punctuation-normalization collisions. They also check legacy defaults
and settings conversion. Full pinned AppStoreConnect regeneration and an offline
consumer exercise all 12 `BuildsResponse.Included` variants with JSON reflection
disabled, including a trimmed executable; these large-spec checks are performed
separately from the fast naming tests.

## Discriminator identity correction

The AppStoreConnect serialization check also exposed a separate legacy bug:
substring matching associated schema `App` with the mapping for
`AppEncryptionDeclaration`. Exact raw schema identities now determine mapping
selection, including when an extension changes a generated CLR name. This also
corrects affected union member names (for example the duplicated
`AppEncryptionDeclarations1` / `AppEncryptionDeclarations2` pair becomes
`AppEncryptionDeclarations` / `Apps`). Update explicit references to those members
when regenerating an affected SDK, independently of the naming-mode migration.

## Validation (2026-10-26)

The complete pinned AppStoreConnect SDK at repository commit `497ec12cb` was
regenerated in a temporary checkout using the new mode. Its `openapi.json` SHA-256
is `7518d3a94a8bd701ac25c1c601b95b8f53aad92091affb15a2a9d331713dac1a`. The full SDK built with
warnings treated as errors. A source consumer explicitly declaring
`IList<BuildsResponseIncludedItem_e807cc9b04238d70>` was published for `osx-arm64`
with `PublishTrimmed=true`, `JsonSerializerIsReflectionEnabledByDefault=false`,
`TreatWarningsAsErrors=true` and `ILLinkTreatWarningsAsErrors=true`. The executable
round-tripped all 12 included resource types while preserving their `type` and
`id` fields. The shared-metadata analyzer was built from the same AutoSDK sources
and restored from a temporary local feed because the matching preview was not yet
available on NuGet. No provider credentials or network API calls were used.

Array alternatives retain structural dispatch even if a discriminator mapping
points to their schema: an array cannot carry an object discriminator property.
The GitHub content response snapshots cover that boundary. Reviewed snapshots for
ElevenLabs, Letta and LlamaParse also capture corrected prefix collisions such as
`ReasoningContent` / `OmittedReasoningContent` and
`OpenAIEmbeddingConfig` / `AzureOpenAIEmbeddingConfig`.
