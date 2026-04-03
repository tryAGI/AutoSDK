using AutoSDK.Extensions;
using AutoSDK.Grpc;
using AutoSDK.Helpers;

namespace AutoSDK.CLI.Commands;

internal static class GrpcProjectScaffolder
{
    private const string GoogleProtobufVersion = "3.34.0";
    private const string GrpcNetClientVersion = "2.76.0";
    private const string GrpcToolsVersion = "2.78.0";

    public static async Task ScaffoldAsync(
        string input,
        string protoText,
        string output,
        string namespaceValue,
        string targetFramework,
        CancellationToken cancellationToken = default)
    {
        if (input.StartsWith("http", StringComparison.OrdinalIgnoreCase))
        {
            throw new NotSupportedException(
                "Remote gRPC .proto inputs are not supported for scaffolding yet. " +
                "Download the proto set locally first. Buf module input is planned as a follow-up slice.");
        }

        var entryPath = Path.GetFullPath(input);
        var entryDocument = GrpcProtoParser.Parse(protoText);
        var projectName = Path.GetFileNameWithoutExtension(entryPath)
            .ToPropertyName()
            .UseWordSeparator('\\', '-', '.', '_', '/');
        var rootNamespace = !string.IsNullOrWhiteSpace(entryDocument.CSharpNamespace)
            ? entryDocument.CSharpNamespace!
            : (!string.IsNullOrWhiteSpace(namespaceValue) ? namespaceValue : projectName);

        Directory.CreateDirectory(output);

        var copyResult = await CopyProtoClosureAsync(
            entryPath,
            Path.Combine(output, "Protos"),
            cancellationToken).ConfigureAwait(false);

        if (copyResult.UnresolvedImports.Count > 0)
        {
            throw new InvalidOperationException(
                "Unable to resolve imported proto files: " +
                string.Join(", ", copyResult.UnresolvedImports.OrderBy(static x => x, StringComparer.Ordinal)) +
                ". Keep the imported protos alongside the entry proto or use vendored include paths.");
        }

        await File.WriteAllTextAsync(
            Path.Combine(output, $"{projectName}.Grpc.csproj"),
            RenderProjectFile(rootNamespace, targetFramework),
            cancellationToken).ConfigureAwait(false);

        await File.WriteAllTextAsync(
            Path.Combine(output, "GrpcChannelFactory.cs"),
            RenderChannelFactory(rootNamespace),
            cancellationToken).ConfigureAwait(false);

        await File.WriteAllTextAsync(
            Path.Combine(output, "README.md"),
            RenderReadme(projectName, rootNamespace, copyResult.EntryRelativePath, entryDocument),
            cancellationToken).ConfigureAwait(false);
    }

    private static async Task<ProtoCopyResult> CopyProtoClosureAsync(
        string entryPath,
        string protoOutputRoot,
        CancellationToken cancellationToken)
    {
        Directory.CreateDirectory(protoOutputRoot);

        var rootDirectory = Path.GetDirectoryName(entryPath) ??
                            throw new InvalidOperationException("Entry proto must have a parent directory.");
        var copiedFiles = new HashSet<string>(StringComparer.Ordinal);
        var visitedPaths = new HashSet<string>(GetPathComparer());
        var unresolvedImports = new HashSet<string>(StringComparer.Ordinal);

        await VisitAsync(entryPath).ConfigureAwait(false);

        return new ProtoCopyResult(
            EntryRelativePath: Path.GetFileName(entryPath),
            UnresolvedImports: unresolvedImports.ToArray());

        async Task VisitAsync(string fullPath)
        {
            fullPath = Path.GetFullPath(fullPath);
            if (!visitedPaths.Add(fullPath))
            {
                return;
            }

            var relativePath = Path.GetRelativePath(rootDirectory, fullPath);
            if (relativePath.StartsWith("..", StringComparison.Ordinal))
            {
                throw new InvalidOperationException(
                    $"Imported proto '{fullPath}' is outside the entry proto root '{rootDirectory}'. " +
                    "The first gRPC slice only supports local proto trees rooted at the input file directory.");
            }

            var normalizedRelativePath = NormalizePath(relativePath);
            copiedFiles.Add(normalizedRelativePath);

            var destinationPath = Path.Combine(protoOutputRoot, normalizedRelativePath.Replace('/', Path.DirectorySeparatorChar));
            Directory.CreateDirectory(Path.GetDirectoryName(destinationPath)!);

            var text = await File.ReadAllTextAsync(fullPath, cancellationToken).ConfigureAwait(false);
            await File.WriteAllTextAsync(destinationPath, text, cancellationToken).ConfigureAwait(false);

            var document = GrpcProtoParser.Parse(text);
            foreach (var import in document.Imports)
            {
                var resolvedImport = ResolveImportPath(rootDirectory, fullPath, import);
                if (resolvedImport != null)
                {
                    await VisitAsync(resolvedImport).ConfigureAwait(false);
                    continue;
                }

                if (!import.StartsWith("google/protobuf/", StringComparison.Ordinal))
                {
                    unresolvedImports.Add(import);
                }
            }
        }
    }

    private static string? ResolveImportPath(
        string rootDirectory,
        string currentFilePath,
        string importPath)
    {
        var currentDirectory = Path.GetDirectoryName(currentFilePath)!;
        foreach (var candidate in new[]
                 {
                     Path.GetFullPath(Path.Combine(currentDirectory, importPath)),
                     Path.GetFullPath(Path.Combine(rootDirectory, importPath)),
                 })
        {
            if (File.Exists(candidate))
            {
                return candidate;
            }
        }

        return null;
    }

    private static StringComparer GetPathComparer()
    {
        return OperatingSystem.IsWindows()
            ? StringComparer.OrdinalIgnoreCase
            : StringComparer.Ordinal;
    }

    private static string NormalizePath(string path)
    {
        return path.Replace('\\', '/');
    }

    private static string RenderProjectFile(
        string rootNamespace,
        string targetFramework)
    {
        return $$"""
                 <Project Sdk="Microsoft.NET.Sdk">

                   <PropertyGroup>
                     <TargetFramework>{{targetFramework}}</TargetFramework>
                     <Nullable>enable</Nullable>
                     <ImplicitUsings>enable</ImplicitUsings>
                     <RootNamespace>{{rootNamespace}}</RootNamespace>
                   </PropertyGroup>

                   <ItemGroup>
                     <PackageReference Include="Google.Protobuf" Version="{{GoogleProtobufVersion}}" />
                     <PackageReference Include="Grpc.Net.Client" Version="{{GrpcNetClientVersion}}" />
                     <PackageReference Include="Grpc.Tools" Version="{{GrpcToolsVersion}}">
                       <PrivateAssets>all</PrivateAssets>
                       <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
                     </PackageReference>
                   </ItemGroup>

                   <ItemGroup>
                     <Protobuf Include="Protos/**/*.proto" ProtoRoot="Protos" GrpcServices="Client" />
                   </ItemGroup>

                 </Project>
                 """;
    }

    private static string RenderChannelFactory(string rootNamespace)
    {
        return $$"""
                 using Grpc.Net.Client;

                 namespace {{rootNamespace}};

                 public static class GrpcChannelFactory
                 {
                     public static GrpcChannel Create(string address)
                     {
                         ArgumentException.ThrowIfNullOrWhiteSpace(address);

                         return GrpcChannel.ForAddress(address);
                     }
                 }
                 """;
    }

    private static string RenderReadme(
        string projectName,
        string rootNamespace,
        string entryRelativePath,
        GrpcProtoDocument entryDocument)
    {
        var packageLine = string.IsNullOrWhiteSpace(entryDocument.PackageName)
            ? "- detected proto package: none"
            : $"- detected proto package: `{entryDocument.PackageName}`";
        var namespaceLine = string.IsNullOrWhiteSpace(entryDocument.CSharpNamespace)
            ? $"- generated project root namespace: `{rootNamespace}`"
            : $"- detected proto csharp_namespace: `{entryDocument.CSharpNamespace}`";

        return $$"""
                 # {{projectName}}.Grpc

                 This project was scaffolded by AutoSDK from a local `.proto` input.
                 It uses `Grpc.Tools` to generate client stubs during build instead of trying to reinterpret protobuf through the OpenAPI pipeline.

                 ## Included

                 - entry proto: `Protos/{{entryRelativePath}}`
                 {{packageLine}}
                 {{namespaceLine}}

                 ## Build

                 ```bash
                 dotnet build
                 ```

                 ## Usage

                 1. Create a channel with `{{rootNamespace}}.GrpcChannelFactory.Create("https://localhost:5001")`
                 2. Use the generated `*Client` types emitted by `Grpc.Tools`

                 ## Notes

                 - `google/protobuf/*` imports are provided by `Grpc.Tools`
                 - Buf module input and higher-level AutoSDK auth/DI wrappers are planned follow-up slices for `#185`
                 """;
    }

    private sealed record ProtoCopyResult(
        string EntryRelativePath,
        IReadOnlyCollection<string> UnresolvedImports);
}
