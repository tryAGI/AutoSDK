# Source generator NativeAOT example

This example keeps generated models and methods in separate projects so that
`System.Text.Json` can generate metadata for all model types:

- `SourceGeneratorNativeAot.Models` generates the API models and the
  `JsonSerializerContextTypes` aggregation type.
- `SourceGeneratorNativeAot.Client` references the models project, defines
  `SourceGenerationContext`, and generates the client methods and constructors.

Both projects enable trimming and NativeAOT analyzers. Both projects are
included in `AutoSDK.slnx`, so the repository build continuously verifies this
example:

```bash
dotnet build examples/SourceGeneratorNativeAot/SourceGeneratorNativeAot.Client/SourceGeneratorNativeAot.Client.csproj
```

When copying this pattern outside the AutoSDK repository, replace the local
analyzer project references and imports with the `AutoSDK.SourceGenerators`
package described in the root README.
