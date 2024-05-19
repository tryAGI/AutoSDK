# OpenApiGenerator
Allows you to partially (for example, only models) or completely generate a native (without dependencies) C# client sdk according to the OpenAPI specification.  
Inspired by [NSwag](https://github.com/RicoSuter/NSwag) ❤️.

## 🔥Features🔥
- Uses Incremental Source Generators for efficient generation and caching.
- Detects your TargetFramework and generates optimal code for it (including net6.0/net7.0/net8.0 improvements)
- Supports .Net Framework/.Net Standard
- Does not contain dependencies for modern versions of dotnet
- Only System.Text.Json dependency for .Net Framework/.Net Standard
- Any generated methods provide the ability to pass a CancellationToken
- Allows partial generation (models only) or end points filtering
- Available under MIT license for general users and most organizations
- Uses https://github.com/microsoft/OpenAPI.NET for parsing OpenAPI specification
- Supports trimming/native AOT compilation

## 🚀Quick start🚀
- Install the package
```bash
dotnet add package OpenApiGenerator
```
- Add the following optional settings to your csproj file to customize generation. You can check all settings [here](https://github.com/HavenDV/OpenApiGenerator/blob/76c06e6e2265bc875d0619cfe96e28002fba1d3d/src/libs/OpenApiGenerator/OpenApiGenerator.props):
```xml
<!-- This generator automatically detects all .yaml files in the project directory and adds them to the generation -->
<!-- If your yaml file is not in the project directory, you can specify it manually -->
<ItemGroup Label="OpenApiGenerator">
    <AdditionalFiles Include="$(MSBuildThisFileDirectory)../../../docs/openapi.yaml" />
</ItemGroup>

<!-- All settings optional -->
<PropertyGroup Label="OpenApiGenerator">
    <OpenApiGenerator_Namespace>Ollama</OpenApiGenerator_Namespace>
    <OpenApiGenerator_ClassName>OllamaApi</OpenApiGenerator_ClassName>

    <!-- By default, it generates all models/methods. You can disable this behavior using these properties -->
    <OpenApiGenerator_GenerateSdk>false</OpenApiGenerator_GenerateSdk>
    <OpenApiGenerator_GenerateModels>true</OpenApiGenerator_GenerateModels>
    <OpenApiGenerator_GenerateMethods>true</OpenApiGenerator_GenerateMethods>
    <OpenApiGenerator_GenerateConstructors>true</OpenApiGenerator_GenerateConstructors>
    <OpenApiGenerator_IncludeOperationIds>getPet;deletePet</OpenApiGenerator_IncludeOperationIds>
    <OpenApiGenerator_ExcludeOperationIds>getPet;deletePet</OpenApiGenerator_ExcludeOperationIds>
    <OpenApiGenerator_IncludeModels>Pet;Model</OpenApiGenerator_IncludeModels>
    <OpenApiGenerator_ExcludeModels>Pet;Model</OpenApiGenerator_ExcludeModels>
</PropertyGroup>
```
- It's all! Now you can build your project and use the generated code. You also can use IDE to see the generated code in any moment, this is a example for Rider:  
![rider_show_generated_code.png](assets/rider_show_generated_code.png)

## CLI
You can use the CLI to generate the code.  
```bash
dotnet tool install --global openapigenerator.cli --prerelease
oag --help
oag generate openapi.yaml
```
It will generate the code in the "openapi" subdirectory.