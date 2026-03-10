# AutoSDK Troubleshooting

Common issues when generating .NET SDKs with AutoSDK and their solutions.

## "Could not find part of the path" Error

**Symptom:** Build or generation fails with `Could not write to output file 'Path/to/file'. Could not find part of the path`.

**Cause:** The generated file path exceeds the Windows maximum path length (260 characters). This commonly happens with large OpenAPI specs that have deeply nested schemas.

**Solution:** Enable Windows long path support via the registry:

1. Open Registry Editor (`regedit`)
2. Navigate to `HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FileSystem`
3. Set `LongPathsEnabled` to `1`
4. Restart your machine

Official docs: https://learn.microsoft.com/en-us/windows/win32/fileio/maximum-file-path-limitation?tabs=registry#registry-setting-to-enable-long-paths

## OpenAPI 3.1 Spec Compatibility

**Symptom:** Parse errors or unexpected behavior when using an OpenAPI 3.1 specification.

**Cause:** AutoSDK uses Microsoft.OpenApi.NET for parsing which historically targeted OpenAPI 3.0. While newer versions support 3.1 natively, some features may need conversion.

**Solution:** Use the FixOpenApiSpec helper included in every scaffolded SDK project:

```bash
dotnet run --project src/helpers/FixOpenApiSpec openapi.yaml
```

This converts OpenAPI 3.1 features to 3.0-compatible equivalents:
- `type: [string, null]` -> `type: string` with `nullable: true`
- `const` values -> `enum` with single value
- `examples` array -> `example` single value

Always run FixOpenApiSpec before `autosdk generate` in your `generate.sh` script.

## Spec Parse Errors

**Symptom:** AutoSDK reports OpenAPI validation errors and stops generation.

**Cause:** The OpenAPI spec has validation issues (missing required fields, invalid references, etc.).

**Solution:** Use the `--ignore-openapi-errors` flag:

```bash
autosdk generate openapi.yaml \
  --namespace MyApi \
  --clientClassName MyApiClient \
  --ignore-openapi-errors
```

This is enabled by default in CLI mode. For warnings, use `--ignore-openapi-warnings` (also enabled by default).

If specific errors cause generation problems, fix them in the FixOpenApiSpec helper before generation.

## Missing Operations in Output

**Symptom:** Some API operations from the OpenAPI spec are not present in the generated SDK.

**Possible causes and solutions:**

1. **Missing operationIds:** AutoSDK requires `operationId` on each operation to generate method names. Add missing operationIds in your FixOpenApiSpec helper.

2. **Deprecated operations:** If using `--exclude-deprecated-operations`, deprecated endpoints are intentionally skipped. Remove the flag to include them.

3. **Tag filtering:** If using source generator properties like `AutoSDK_IncludeTags` or `AutoSDK_ExcludeTags`, check that your desired operations are not filtered out.

4. **OperationId filtering:** Check `AutoSDK_IncludeOperationIds` and `AutoSDK_ExcludeOperationIds` properties.

## Naming Collisions

**Symptom:** Compiler errors about duplicate type or member names.

**Cause:** Multiple OpenAPI schemas resolve to the same C# identifier.

**Solution:** AutoSDK automatically resolves naming collisions by appending numeric suffixes (e.g., `Model`, `Model2`, `Model3`). If you see collisions, ensure you're using the latest version of `autosdk.cli`:

```bash
dotnet tool update --global autosdk.cli --prerelease
```

If collisions persist, you can:
- Rename schemas in your FixOpenApiSpec helper
- Use `--methodNamingConvention MethodAndPath` for method name collisions
- Exclude specific operations with `AutoSDK_ExcludeOperationIds`

## Trimming / NativeAOT Issues

**Symptom:** Trimming warnings or runtime failures when publishing with NativeAOT.

**Cause:** JSON serialization uses reflection, which is incompatible with trimming.

**Solution for CLI-generated code:** CLI mode generates trimming-compatible code by default using `JsonSerializerContext`. No additional steps needed.

**Solution for source generator:** Use the two-project pattern:

1. Create a separate models project with `AutoSDK_GenerateJsonSerializerContextTypes=true`
2. Reference it from your main project
3. Add a `SourceGenerationContext.cs` with `[JsonSerializable(typeof(AutoSDKTrimmableSupport))]`
4. Set `AutoSDK_JsonSerializerContext` to point to your context class

See [CUSTOMIZATION-PATTERNS.md](CUSTOMIZATION-PATTERNS.md) for the full two-project pattern.

## Validate trimming compatibility:

```bash
dotnet build src/helpers/TrimmingHelper/TrimmingHelper.csproj
```

If this builds without warnings, your SDK is NativeAOT-compatible.

## Large Specs / Slow Generation

**Symptom:** Generation takes a very long time or uses excessive memory.

**Cause:** Very large OpenAPI specs (100k+ lines) require proportionally more processing.

**Solutions:**

- AutoSDK uses O(n) algorithms designed for large specs (tested on 220k-line GitHub spec)
- Use `--exclude-deprecated-operations` to reduce output size
- Use `--single-file` to reduce filesystem overhead
- Filter to specific operations with `AutoSDK_IncludeOperationIds` or `AutoSDK_IncludeTags` (source generator only)

## dotnet tool install Fails

**Symptom:** `dotnet tool install --global autosdk.cli --prerelease` fails.

**Solutions:**

1. Ensure .NET SDK 8.0+ is installed: `dotnet --version`
2. Clear NuGet cache: `dotnet nuget locals all --clear`
3. Ensure nuget.org is in your sources: `dotnet nuget list source`
4. Try specifying the source explicitly:
   ```bash
   dotnet tool install --global autosdk.cli --prerelease --add-source https://api.nuget.org/v3/index.json
   ```

## Generated Code Won't Compile

**Symptom:** Build errors in generated code after running `autosdk generate`.

**Common causes:**

1. **Wrong target framework:** Ensure `--targetFramework` matches your project's `<TargetFramework>` in `.csproj`. Generated code for `net8.0` won't compile under `netstandard2.0`.

2. **Namespace conflicts:** If the generated namespace conflicts with existing types, use a more specific namespace (e.g., `MyCompany.MyApi` instead of `MyApi`).

3. **Stale generated files:** Always `rm -rf Generated` before regenerating to remove files from operations that no longer exist in the spec.

4. **Missing polyfills:** For `netstandard2.0` / `net462` targets, ensure polyfills are generated (they are by default).
