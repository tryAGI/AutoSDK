# Source generator NativeAOT example

This example keeps generated models and methods in separate projects so that
`System.Text.Json` can generate metadata for all model types:

- `SourceGeneratorNativeAot.Models` generates the API models and the
  `JsonSerializerContextTypes` aggregation type.
- `SourceGeneratorNativeAot.Client` references the models project, defines
  `SourceGenerationContext`, and generates the client methods and constructors.
- `SourceGeneratorNativeAot.Tests` verifies that the generated client context
  applies AutoSDK's generated converters to top-level `oneOf`, `anyOf`, and
  enum payloads.

The client generator composes `SourceGenerationContext.Default` with the
converters emitted by AutoSDK. Consumers do not need to duplicate the generated
converter list in `JsonSourceGenerationOptions`.

The source generator reports informational diagnostic `OAG003` with the
generated converters composed into each wrapper context. See the
[root diagnostic guidance](../../README.md#oag003-converter-composition-diagnostic)
for project-level suppression and `.editorconfig` severity configuration.

The models and client projects enable trimming and NativeAOT analyzers. All projects are
included in `AutoSDK.slnx`, so the repository build continuously verifies this
example:

```bash
dotnet test examples/SourceGeneratorNativeAot/SourceGeneratorNativeAot.Tests/SourceGeneratorNativeAot.Tests.csproj
```

When copying this pattern outside the AutoSDK repository, replace the local
analyzer project references and imports with the `AutoSDK.SourceGenerators`
package described in the root README.
