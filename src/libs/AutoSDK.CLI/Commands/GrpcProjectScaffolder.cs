using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using AutoSDK.Extensions;
using AutoSDK.Grpc;
using AutoSDK.Helpers;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace AutoSDK.CLI.Commands;

internal static class GrpcProjectScaffolder
{
    private const string GoogleProtobufVersion = "3.34.0";
    private const string GrpcNetClientVersion = "2.76.0";
    private const string GrpcToolsVersion = "2.78.0";
    private const string MicrosoftExtensionsDependencyInjectionAbstractionsVersion = "10.0.1";

    private static readonly Regex BufModuleReferenceRegex = new(
        @"^(?:https?://)?buf\.build/(?<owner>[A-Za-z0-9][A-Za-z0-9_-]*)/(?<module>[A-Za-z0-9][A-Za-z0-9._-]*)(?::(?<reference>[^/\s?#]+))?/?$",
        RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

    private static readonly HashSet<string> DescriptorSetExtensions = new(StringComparer.OrdinalIgnoreCase)
    {
        ".binpb",
        ".bin",
        ".pb",
        ".protoset",
        ".desc",
        ".fds",
    };

    public static bool CanHandleInput(string input)
    {
        return TryParseBufModuleReference(input, out _) ||
               IsDescriptorSetInput(input) ||
               IsProtoInput(input);
    }

    public static string GetSuggestedProjectName(string input)
    {
        if (TryParseBufModuleReference(input, out var moduleReference))
        {
            return moduleReference.ModuleName
                .ToPropertyName()
                .UseWordSeparator('\\', '-', '.', '_', '/');
        }

        return Path.GetFileNameWithoutExtension(GetInputFileName(input))
            .ToPropertyName()
            .UseWordSeparator('\\', '-', '.', '_', '/');
    }

    public static async Task ScaffoldAsync(
        string input,
        string output,
        string namespaceValue,
        string targetFramework,
        string? protoText = null,
        CancellationToken cancellationToken = default)
    {
        if (TryParseBufModuleReference(input, out var moduleReference))
        {
            await ScaffoldFromBufModuleAsync(
                moduleReference,
                output,
                namespaceValue,
                targetFramework,
                cancellationToken).ConfigureAwait(false);
            return;
        }

        if (IsDescriptorSetInput(input))
        {
            await ScaffoldFromDescriptorSetAsync(
                input,
                output,
                namespaceValue,
                targetFramework,
                cancellationToken).ConfigureAwait(false);
            return;
        }

        await ScaffoldFromProtoAsync(
            input,
            protoText,
            output,
            namespaceValue,
            targetFramework,
            cancellationToken).ConfigureAwait(false);
    }

    private static async Task ScaffoldFromProtoAsync(
        string input,
        string? protoText,
        string output,
        string namespaceValue,
        string targetFramework,
        CancellationToken cancellationToken)
    {
        if (input.StartsWith("http", StringComparison.OrdinalIgnoreCase))
        {
            throw new NotSupportedException(
                "Remote gRPC .proto inputs are not supported for scaffolding yet. " +
                "Use a local `.proto`, a descriptor-set input, or a Buf module reference instead.");
        }

        var entryPath = Path.GetFullPath(input);
        protoText ??= await File.ReadAllTextAsync(entryPath, cancellationToken).ConfigureAwait(false);

        var entryDocument = GrpcProtoParser.Parse(protoText);
        var projectName = Path.GetFileNameWithoutExtension(entryPath)
            .ToPropertyName()
            .UseWordSeparator('\\', '-', '.', '_', '/');
        var rootNamespace = DetermineRootNamespace(
            new[] { entryDocument.CSharpNamespace },
            namespaceValue,
            projectName);

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
                ". Keep the imported protos alongside the entry proto or use a Buf module or descriptor-set input.");
        }

        await WriteSourceProtoProjectAsync(
            output,
            projectName,
            rootNamespace,
            targetFramework,
            RenderLocalProtoReadme(projectName, rootNamespace, copyResult.EntryRelativePath, entryDocument),
            cancellationToken).ConfigureAwait(false);
    }

    private static async Task ScaffoldFromBufModuleAsync(
        BufModuleReference moduleReference,
        string output,
        string namespaceValue,
        string targetFramework,
        CancellationToken cancellationToken)
    {
        var exportDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            await ExportBufModuleAsync(moduleReference, exportDirectory, cancellationToken).ConfigureAwait(false);

            var metadata = await AnalyzeProtoTreeAsync(exportDirectory, cancellationToken).ConfigureAwait(false);
            if (metadata.ProtoFiles.Length == 0)
            {
                throw new InvalidOperationException(
                    $"`buf export {moduleReference.CanonicalReference}` did not produce any `.proto` files.");
            }

            var projectName = moduleReference.ModuleName
                .ToPropertyName()
                .UseWordSeparator('\\', '-', '.', '_', '/');
            var rootNamespace = DetermineRootNamespace(
                metadata.CSharpNamespaces,
                namespaceValue,
                projectName);

            Directory.CreateDirectory(output);

            await CopyDirectoryAsync(
                exportDirectory,
                Path.Combine(output, "Protos"),
                cancellationToken).ConfigureAwait(false);

            await WriteSourceProtoProjectAsync(
                output,
                projectName,
                rootNamespace,
                targetFramework,
                RenderBufModuleReadme(projectName, rootNamespace, moduleReference, metadata),
                cancellationToken).ConfigureAwait(false);
        }
        finally
        {
            TryDeleteDirectory(exportDirectory);
        }
    }

    private static async Task ScaffoldFromDescriptorSetAsync(
        string input,
        string output,
        string namespaceValue,
        string targetFramework,
        CancellationToken cancellationToken)
    {
        byte[] descriptorBytes = await ReadBinaryInputAsync(input, cancellationToken).ConfigureAwait(false);

        FileDescriptorSet descriptorSet;
        try
        {
            descriptorSet = FileDescriptorSet.Parser.ParseFrom(descriptorBytes);
        }
        catch (Exception exception) when (exception is InvalidProtocolBufferException or IOException)
        {
            throw new InvalidOperationException(
                $"Input '{input}' is not a valid binary protobuf descriptor set.",
                exception);
        }

        var metadata = AnalyzeDescriptorSet(descriptorSet);
        if (metadata.ProtoFileNames.Length == 0)
        {
            throw new InvalidOperationException(
                $"Descriptor set '{input}' does not contain any non-WKT `.proto` files.");
        }

        var projectName = Path.GetFileNameWithoutExtension(GetInputFileName(input))
            .ToPropertyName()
            .UseWordSeparator('\\', '-', '.', '_', '/');
        var rootNamespace = DetermineRootNamespace(
            metadata.CSharpNamespaces,
            namespaceValue,
            projectName);

        Directory.CreateDirectory(output);

        var descriptorDirectory = Path.Combine(output, "Descriptors");
        Directory.CreateDirectory(descriptorDirectory);

        var descriptorFileName = GetDescriptorOutputFileName(input);
        var descriptorRelativePath = NormalizePath(Path.Combine("Descriptors", descriptorFileName));
        await File.WriteAllBytesAsync(
            Path.Combine(output, descriptorRelativePath.Replace('/', Path.DirectorySeparatorChar)),
            descriptorBytes,
            cancellationToken).ConfigureAwait(false);

        await File.WriteAllTextAsync(
            Path.Combine(output, $"{projectName}.Grpc.csproj"),
            RenderDescriptorSetProjectFile(
                rootNamespace,
                targetFramework,
                descriptorRelativePath,
                metadata.ProtoFileNames),
            cancellationToken).ConfigureAwait(false);

        await WriteAutoSdkGrpcSupportFilesAsync(
            output,
            rootNamespace,
            cancellationToken).ConfigureAwait(false);

        await File.WriteAllTextAsync(
            Path.Combine(output, "README.md"),
            RenderDescriptorSetReadme(
                projectName,
                rootNamespace,
                descriptorRelativePath,
                metadata),
            cancellationToken).ConfigureAwait(false);
    }

    private static async Task WriteSourceProtoProjectAsync(
        string output,
        string projectName,
        string rootNamespace,
        string targetFramework,
        string readme,
        CancellationToken cancellationToken)
    {
        await File.WriteAllTextAsync(
            Path.Combine(output, $"{projectName}.Grpc.csproj"),
            RenderSourceProtoProjectFile(rootNamespace, targetFramework),
            cancellationToken).ConfigureAwait(false);

        await WriteAutoSdkGrpcSupportFilesAsync(
            output,
            rootNamespace,
            cancellationToken).ConfigureAwait(false);

        await File.WriteAllTextAsync(
            Path.Combine(output, "README.md"),
            readme,
            cancellationToken).ConfigureAwait(false);
    }

    private static async Task WriteAutoSdkGrpcSupportFilesAsync(
        string output,
        string rootNamespace,
        CancellationToken cancellationToken)
    {
        await File.WriteAllTextAsync(
            Path.Combine(output, "AutoSdkGrpcClient.cs"),
            RenderAutoSdkGrpcClient(rootNamespace),
            cancellationToken).ConfigureAwait(false);

        await File.WriteAllTextAsync(
            Path.Combine(output, "AutoSdkGrpcClientFactory.cs"),
            RenderAutoSdkGrpcClientFactory(rootNamespace),
            cancellationToken).ConfigureAwait(false);

        await File.WriteAllTextAsync(
            Path.Combine(output, "AutoSdkGrpcClientOptions.cs"),
            RenderAutoSdkGrpcClientOptions(rootNamespace),
            cancellationToken).ConfigureAwait(false);

        await File.WriteAllTextAsync(
            Path.Combine(output, "AutoSdkGrpcCallOptionsInterceptor.cs"),
            RenderAutoSdkGrpcCallOptionsInterceptor(rootNamespace),
            cancellationToken).ConfigureAwait(false);

        await File.WriteAllTextAsync(
            Path.Combine(output, "AutoSdkGrpcServiceCollectionExtensions.cs"),
            RenderAutoSdkGrpcServiceCollectionExtensions(rootNamespace),
            cancellationToken).ConfigureAwait(false);

        await File.WriteAllTextAsync(
            Path.Combine(output, "GrpcChannelFactory.cs"),
            RenderChannelFactory(rootNamespace),
            cancellationToken).ConfigureAwait(false);
    }

    private static async Task ExportBufModuleAsync(
        BufModuleReference moduleReference,
        string exportDirectory,
        CancellationToken cancellationToken)
    {
        Directory.CreateDirectory(exportDirectory);

        using var process = new Process
        {
            StartInfo = new ProcessStartInfo("buf")
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            },
        };

        process.StartInfo.ArgumentList.Add("export");
        process.StartInfo.ArgumentList.Add(moduleReference.CanonicalReference);
        process.StartInfo.ArgumentList.Add("-o");
        process.StartInfo.ArgumentList.Add(exportDirectory);

        try
        {
            process.Start();
        }
        catch (Win32Exception exception)
        {
            throw new InvalidOperationException(
                "Buf module input currently requires the `buf` CLI to be installed and available on PATH.",
                exception);
        }

        var standardOutputTask = process.StandardOutput.ReadToEndAsync(cancellationToken);
        var standardErrorTask = process.StandardError.ReadToEndAsync(cancellationToken);

        await process.WaitForExitAsync(cancellationToken).ConfigureAwait(false);

        var standardOutput = await standardOutputTask.ConfigureAwait(false);
        var standardError = await standardErrorTask.ConfigureAwait(false);

        if (process.ExitCode != 0)
        {
            throw new InvalidOperationException(
                $"`buf export {moduleReference.CanonicalReference}` failed with exit code {process.ExitCode}:{Environment.NewLine}{standardError}{standardOutput}");
        }
    }

    private static async Task<byte[]> ReadBinaryInputAsync(
        string input,
        CancellationToken cancellationToken)
    {
        if (input.StartsWith("http", StringComparison.OrdinalIgnoreCase))
        {
            using var client = new HttpClient();
            return await client.GetByteArrayAsync(new Uri(input), cancellationToken).ConfigureAwait(false);
        }

        return await File.ReadAllBytesAsync(input, cancellationToken).ConfigureAwait(false);
    }

    private static async Task<ProtoCopyResult> CopyProtoClosureAsync(
        string entryPath,
        string protoOutputRoot,
        CancellationToken cancellationToken)
    {
        Directory.CreateDirectory(protoOutputRoot);

        var rootDirectory = Path.GetDirectoryName(entryPath) ??
                            throw new InvalidOperationException("Entry proto must have a parent directory.");
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
                    "Use a Buf module or descriptor-set input for broader multi-file graphs.");
            }

            var normalizedRelativePath = NormalizePath(relativePath);
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

    private static async Task CopyDirectoryAsync(
        string sourceDirectory,
        string destinationDirectory,
        CancellationToken cancellationToken)
    {
        Directory.CreateDirectory(destinationDirectory);

        foreach (var sourcePath in Directory.EnumerateFiles(sourceDirectory, "*", SearchOption.AllDirectories))
        {
            var relativePath = Path.GetRelativePath(sourceDirectory, sourcePath);
            var destinationPath = Path.Combine(destinationDirectory, relativePath);
            Directory.CreateDirectory(Path.GetDirectoryName(destinationPath)!);

            using var sourceStream = File.OpenRead(sourcePath);
            using var destinationStream = File.Create(destinationPath);
            await sourceStream.CopyToAsync(destinationStream, cancellationToken).ConfigureAwait(false);
        }
    }

    private static async Task<ProtoTreeMetadata> AnalyzeProtoTreeAsync(
        string protoRoot,
        CancellationToken cancellationToken)
    {
        var protoFiles = Directory.EnumerateFiles(protoRoot, "*.proto", SearchOption.AllDirectories)
            .OrderBy(static path => path, StringComparer.Ordinal)
            .ToArray();
        var csharpNamespaces = new HashSet<string>(StringComparer.Ordinal);
        var packages = new HashSet<string>(StringComparer.Ordinal);
        var serviceCount = 0;

        foreach (var file in protoFiles)
        {
            var text = await File.ReadAllTextAsync(file, cancellationToken).ConfigureAwait(false);
            var document = GrpcProtoParser.Parse(text);
            if (!string.IsNullOrWhiteSpace(document.CSharpNamespace))
            {
                csharpNamespaces.Add(document.CSharpNamespace);
            }

            if (!string.IsNullOrWhiteSpace(document.PackageName))
            {
                packages.Add(document.PackageName);
            }

            serviceCount += document.Services.Length;
        }

        return new ProtoTreeMetadata(
            ProtoFiles: protoFiles.Select(file => NormalizePath(Path.GetRelativePath(protoRoot, file))).ToArray(),
            CSharpNamespaces: csharpNamespaces.ToArray(),
            Packages: packages.ToArray(),
            ServiceCount: serviceCount);
    }

    private static DescriptorSetMetadata AnalyzeDescriptorSet(FileDescriptorSet descriptorSet)
    {
        var protoFileNames = descriptorSet.File
            .Select(static file => file.Name)
            .Where(static name => !string.IsNullOrWhiteSpace(name))
            .Where(static name => !name.StartsWith("google/protobuf/", StringComparison.Ordinal))
            .Distinct(StringComparer.Ordinal)
            .OrderBy(static name => name, StringComparer.Ordinal)
            .ToArray();

        var csharpNamespaces = descriptorSet.File
            .Select(static file => file.Options?.CsharpNamespace)
            .Where(static value => !string.IsNullOrWhiteSpace(value))
            .Select(static value => value!)
            .Distinct(StringComparer.Ordinal)
            .OrderBy(static value => value, StringComparer.Ordinal)
            .ToArray();

        var packages = descriptorSet.File
            .Select(static file => file.Package)
            .Where(static value => !string.IsNullOrWhiteSpace(value))
            .Distinct(StringComparer.Ordinal)
            .OrderBy(static value => value, StringComparer.Ordinal)
            .ToArray()!;

        var serviceCount = descriptorSet.File.Sum(static file => file.Service.Count);

        return new DescriptorSetMetadata(
            ProtoFileNames: protoFileNames,
            CSharpNamespaces: csharpNamespaces,
            Packages: packages,
            ServiceCount: serviceCount);
    }

    private static string DetermineRootNamespace(
        IEnumerable<string?> namespaceCandidates,
        string namespaceValue,
        string projectName)
    {
        var distinctNamespaces = namespaceCandidates
            .Where(static value => !string.IsNullOrWhiteSpace(value))
            .Select(static value => value!)
            .Distinct(StringComparer.Ordinal)
            .ToArray();

        if (distinctNamespaces.Length == 1)
        {
            return distinctNamespaces[0];
        }

        return !string.IsNullOrWhiteSpace(namespaceValue)
            ? namespaceValue
            : projectName;
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

    private static bool IsDescriptorSetInput(string input)
    {
        var extension = GetInputExtension(input);
        return extension.Length > 0 && DescriptorSetExtensions.Contains(extension);
    }

    private static bool IsProtoInput(string input)
    {
        return string.Equals(GetInputExtension(input), ".proto", StringComparison.OrdinalIgnoreCase);
    }

    private static bool TryParseBufModuleReference(
        string input,
        out BufModuleReference moduleReference)
    {
        moduleReference = default;
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        var match = BufModuleReferenceRegex.Match(input);
        if (!match.Success)
        {
            return false;
        }

        var owner = match.Groups["owner"].Value;
        var module = match.Groups["module"].Value;
        var reference = match.Groups["reference"].Success
            ? match.Groups["reference"].Value
            : string.Empty;

        moduleReference = new BufModuleReference(
            Owner: owner,
            ModuleName: module,
            Reference: reference,
            CanonicalReference: string.IsNullOrWhiteSpace(reference)
                ? $"buf.build/{owner}/{module}"
                : $"buf.build/{owner}/{module}:{reference}");
        return true;
    }

    private static string GetDescriptorOutputFileName(string input)
    {
        var fileName = GetInputFileName(input);
        if (Path.HasExtension(fileName))
        {
            return fileName;
        }

        return $"{fileName}.binpb";
    }

    private static string GetInputExtension(string input)
    {
        if (Uri.TryCreate(input, UriKind.Absolute, out var uri) &&
            (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
        {
            return Path.GetExtension(uri.AbsolutePath);
        }

        return Path.GetExtension(input);
    }

    private static string GetInputFileName(string input)
    {
        if (Uri.TryCreate(input, UriKind.Absolute, out var uri) &&
            (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
        {
            return Path.GetFileName(uri.AbsolutePath);
        }

        return Path.GetFileName(input);
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

    private static string RenderSourceProtoProjectFile(
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
                     <PackageReference Include="Microsoft.Extensions.DependencyInjection.Abstractions" Version="{{MicrosoftExtensionsDependencyInjectionAbstractionsVersion}}" />
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

    private static string RenderDescriptorSetProjectFile(
        string rootNamespace,
        string targetFramework,
        string descriptorRelativePath,
        IReadOnlyCollection<string> protoFileNames)
    {
        var descriptorPath = descriptorRelativePath.Replace("\\", "/", StringComparison.Ordinal);
        var protocFileArguments = string.Join(
            " ",
            protoFileNames.Select(static fileName => $"\"{fileName}\""));

        return $$"""
                 <Project Sdk="Microsoft.NET.Sdk">

                   <PropertyGroup>
                     <TargetFramework>{{targetFramework}}</TargetFramework>
                     <Nullable>enable</Nullable>
                     <ImplicitUsings>enable</ImplicitUsings>
                     <RootNamespace>{{rootNamespace}}</RootNamespace>
                     <GrpcGeneratedOutputDir>$(IntermediateOutputPath)GrpcGenerated</GrpcGeneratedOutputDir>
                   </PropertyGroup>

                   <ItemGroup>
                     <PackageReference Include="Google.Protobuf" Version="{{GoogleProtobufVersion}}" />
                     <PackageReference Include="Grpc.Net.Client" Version="{{GrpcNetClientVersion}}" />
                     <PackageReference Include="Microsoft.Extensions.DependencyInjection.Abstractions" Version="{{MicrosoftExtensionsDependencyInjectionAbstractionsVersion}}" />
                     <PackageReference Include="Grpc.Tools" Version="{{GrpcToolsVersion}}">
                       <PrivateAssets>all</PrivateAssets>
                       <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
                     </PackageReference>
                   </ItemGroup>

                   <Target Name="GenerateGrpcFromDescriptorSet"
                           BeforeTargets="BeforeCompile"
                           DependsOnTargets="Protobuf_ResolvePlatform;gRPC_ResolvePluginFullPath">
                     <RemoveDir Directories="$(GrpcGeneratedOutputDir)" />
                     <MakeDir Directories="$(GrpcGeneratedOutputDir)" />
                     <Exec WorkingDirectory="$(MSBuildProjectDirectory)"
                           Command='"$(Protobuf_ProtocFullPath)" --descriptor_set_in="$(MSBuildProjectDirectory)/{{descriptorPath}}" --csharp_out="$(GrpcGeneratedOutputDir)" --grpc_opt=no_server --grpc_out="$(GrpcGeneratedOutputDir)" --plugin=protoc-gen-grpc="$(gRPC_PluginFullPath)" {{protocFileArguments}}' />
                     <ItemGroup>
                       <Compile Include="$(GrpcGeneratedOutputDir)/**/*.cs" />
                     </ItemGroup>
                   </Target>

                 </Project>
                 """;
    }

    private static string RenderAutoSdkGrpcClient(string rootNamespace)
    {
        return $$"""
                 using Grpc.Core;
                 using Grpc.Net.Client;

                 namespace {{rootNamespace}};

                 public sealed class AutoSdkGrpcClient<TClient> : IDisposable
                     where TClient : ClientBase<TClient>
                 {
                     public AutoSdkGrpcClient(AutoSdkGrpcClientOptions options)
                     {
                         Options = options ?? throw new ArgumentNullException(nameof(options));
                         Channel = GrpcChannelFactory.Create(Options);
                         Client = AutoSdkGrpcClientFactory.CreateClient<TClient>(Channel, Options);
                     }

                     public AutoSdkGrpcClientOptions Options { get; }

                     public GrpcChannel Channel { get; }

                     public TClient Client { get; }

                     public void Dispose()
                     {
                         Channel.Dispose();
                     }
                 }
                 """;
    }

    private static string RenderAutoSdkGrpcClientFactory(string rootNamespace)
    {
        return $$"""
                 using Grpc.Core;
                 using Grpc.Core.Interceptors;
                 using Grpc.Net.Client;

                 namespace {{rootNamespace}};

                 public static class AutoSdkGrpcClientFactory
                 {
                     public static AutoSdkGrpcClient<TClient> Create<TClient>(
                         Action<AutoSdkGrpcClientOptions> configure)
                         where TClient : ClientBase<TClient>
                     {
                         ArgumentNullException.ThrowIfNull(configure);

                         var options = new AutoSdkGrpcClientOptions();
                         configure(options);
                         return new AutoSdkGrpcClient<TClient>(options);
                     }

                     public static AutoSdkGrpcClient<TClient> Create<TClient>(
                         AutoSdkGrpcClientOptions options)
                         where TClient : ClientBase<TClient>
                     {
                         ArgumentNullException.ThrowIfNull(options);

                         return new AutoSdkGrpcClient<TClient>(options.Clone());
                     }

                     internal static TClient CreateClient<TClient>(
                         GrpcChannel channel,
                         AutoSdkGrpcClientOptions options)
                         where TClient : ClientBase<TClient>
                     {
                         ArgumentNullException.ThrowIfNull(channel);
                         ArgumentNullException.ThrowIfNull(options);

                         var callInvoker = channel
                             .CreateCallInvoker()
                             .Intercept(new AutoSdkGrpcCallOptionsInterceptor(options));

                         return Activator.CreateInstance(typeof(TClient), callInvoker) is TClient client
                             ? client
                             : throw new InvalidOperationException(
                                 $"Unable to create gRPC client '{typeof(TClient).FullName}'. " +
                                 "Expected a public constructor that accepts Grpc.Core.CallInvoker.");
                     }
                 }
                 """;
    }

    private static string RenderAutoSdkGrpcClientOptions(string rootNamespace)
    {
        return $$"""
                 using System.Collections.Generic;

                 namespace {{rootNamespace}};

                 public sealed class AutoSdkGrpcClientOptions
                 {
                     public string Address { get; set; } = string.Empty;

                     public string? BearerToken { get; set; }

                     public string? ApiKey { get; set; }

                     public string ApiKeyHeaderName { get; set; } = "x-api-key";

                     public TimeSpan? Deadline { get; set; }

                     public int? MaxRetryAttempts { get; set; }

                     public TimeSpan RetryInitialBackoff { get; set; } = TimeSpan.FromMilliseconds(200);

                     public TimeSpan RetryMaxBackoff { get; set; } = TimeSpan.FromSeconds(2);

                     public double RetryBackoffMultiplier { get; set; } = 2.0d;

                     public IDictionary<string, string> Headers { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

                     public AutoSdkGrpcClientOptions AddHeader(string name, string value)
                     {
                         ArgumentException.ThrowIfNullOrWhiteSpace(name);
                         ArgumentNullException.ThrowIfNull(value);

                         Headers[name] = value;
                         return this;
                     }

                     public AutoSdkGrpcClientOptions UseBearerToken(string bearerToken)
                     {
                         ArgumentException.ThrowIfNullOrWhiteSpace(bearerToken);

                         BearerToken = bearerToken;
                         return this;
                     }

                     public AutoSdkGrpcClientOptions UseApiKey(string apiKey, string headerName = "x-api-key")
                     {
                         ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);
                         ArgumentException.ThrowIfNullOrWhiteSpace(headerName);

                         ApiKey = apiKey;
                         ApiKeyHeaderName = headerName;
                         return this;
                     }

                     public AutoSdkGrpcClientOptions WithDefaultDeadline(TimeSpan deadline)
                     {
                         if (deadline <= TimeSpan.Zero)
                         {
                             throw new ArgumentOutOfRangeException(nameof(deadline), "Deadline must be greater than zero.");
                         }

                         Deadline = deadline;
                         return this;
                     }

                     public AutoSdkGrpcClientOptions WithRetry(
                         int maxAttempts = 3,
                         TimeSpan? initialBackoff = null,
                         TimeSpan? maxBackoff = null,
                         double? backoffMultiplier = null)
                     {
                         if (maxAttempts < 2)
                         {
                             throw new ArgumentOutOfRangeException(nameof(maxAttempts), "Retry attempts must be at least 2.");
                         }

                         if (initialBackoff.HasValue &&
                             initialBackoff.Value <= TimeSpan.Zero)
                         {
                             throw new ArgumentOutOfRangeException(nameof(initialBackoff), "Initial backoff must be greater than zero.");
                         }

                         if (maxBackoff.HasValue &&
                             maxBackoff.Value <= TimeSpan.Zero)
                         {
                             throw new ArgumentOutOfRangeException(nameof(maxBackoff), "Max backoff must be greater than zero.");
                         }

                         if (backoffMultiplier is <= 0d)
                         {
                             throw new ArgumentOutOfRangeException(nameof(backoffMultiplier), "Backoff multiplier must be greater than zero.");
                         }

                         MaxRetryAttempts = maxAttempts;
                         RetryInitialBackoff = initialBackoff ?? TimeSpan.FromMilliseconds(200);
                         RetryMaxBackoff = maxBackoff ?? TimeSpan.FromSeconds(2);
                         RetryBackoffMultiplier = backoffMultiplier ?? 2.0d;
                         return this;
                     }

                     public AutoSdkGrpcClientOptions Clone()
                     {
                         var clone = new AutoSdkGrpcClientOptions
                         {
                             Address = Address,
                             BearerToken = BearerToken,
                             ApiKey = ApiKey,
                             ApiKeyHeaderName = ApiKeyHeaderName,
                             Deadline = Deadline,
                             MaxRetryAttempts = MaxRetryAttempts,
                             RetryInitialBackoff = RetryInitialBackoff,
                             RetryMaxBackoff = RetryMaxBackoff,
                             RetryBackoffMultiplier = RetryBackoffMultiplier,
                         };

                         foreach (var header in Headers)
                         {
                             clone.Headers[header.Key] = header.Value;
                         }

                         return clone;
                     }
                 }
                 """;
    }

    private static string RenderAutoSdkGrpcCallOptionsInterceptor(string rootNamespace)
    {
        return $$"""
                 using System.Linq;
                 using Grpc.Core;
                 using Grpc.Core.Interceptors;

                 namespace {{rootNamespace}};

                 internal sealed class AutoSdkGrpcCallOptionsInterceptor : Interceptor
                 {
                     private readonly AutoSdkGrpcClientOptions _options;

                     public AutoSdkGrpcCallOptionsInterceptor(AutoSdkGrpcClientOptions options)
                     {
                         _options = options ?? throw new ArgumentNullException(nameof(options));
                     }

                     public override TResponse BlockingUnaryCall<TRequest, TResponse>(
                         TRequest request,
                         ClientInterceptorContext<TRequest, TResponse> context,
                         BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
                     {
                         return continuation(request, CreateContext(context));
                     }

                     public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
                         TRequest request,
                         ClientInterceptorContext<TRequest, TResponse> context,
                         AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
                     {
                         return continuation(request, CreateContext(context));
                     }

                     public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(
                         TRequest request,
                         ClientInterceptorContext<TRequest, TResponse> context,
                         AsyncServerStreamingCallContinuation<TRequest, TResponse> continuation)
                     {
                         return continuation(request, CreateContext(context));
                     }

                     public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(
                         ClientInterceptorContext<TRequest, TResponse> context,
                         AsyncClientStreamingCallContinuation<TRequest, TResponse> continuation)
                     {
                         return continuation(CreateContext(context));
                     }

                     public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(
                         ClientInterceptorContext<TRequest, TResponse> context,
                         AsyncDuplexStreamingCallContinuation<TRequest, TResponse> continuation)
                     {
                         return continuation(CreateContext(context));
                     }

                     private ClientInterceptorContext<TRequest, TResponse> CreateContext<TRequest, TResponse>(
                         ClientInterceptorContext<TRequest, TResponse> context)
                         where TRequest : class
                         where TResponse : class
                     {
                         var callOptions = context.Options;
                         var headers = CloneHeaders(callOptions.Headers);

                         if (!string.IsNullOrWhiteSpace(_options.BearerToken) &&
                             !headers.Any(static entry => string.Equals(entry.Key, "authorization", StringComparison.OrdinalIgnoreCase)))
                         {
                             headers.Add("authorization", $"Bearer {_options.BearerToken}");
                         }

                         if (!string.IsNullOrWhiteSpace(_options.ApiKey) &&
                             !headers.Any(entry => string.Equals(entry.Key, _options.ApiKeyHeaderName, StringComparison.OrdinalIgnoreCase)))
                         {
                             headers.Add(_options.ApiKeyHeaderName, _options.ApiKey);
                         }

                         foreach (var header in _options.Headers)
                         {
                             if (!headers.Any(entry => string.Equals(entry.Key, header.Key, StringComparison.OrdinalIgnoreCase)))
                             {
                                 headers.Add(header.Key, header.Value);
                             }
                         }

                         if (headers.Count > 0)
                         {
                             callOptions = callOptions.WithHeaders(headers);
                         }

                         if (_options.Deadline is { } deadline &&
                             callOptions.Deadline is null)
                         {
                             callOptions = callOptions.WithDeadline(DateTime.UtcNow.Add(deadline));
                         }

                         return new ClientInterceptorContext<TRequest, TResponse>(
                             context.Method,
                             context.Host,
                             callOptions);
                     }

                     private static Metadata CloneHeaders(Metadata? source)
                     {
                         var headers = new Metadata();
                         if (source == null)
                         {
                             return headers;
                         }

                         foreach (var entry in source)
                         {
                             if (entry.IsBinary)
                             {
                                 headers.Add(entry.Key, entry.ValueBytes);
                             }
                             else
                             {
                                 headers.Add(entry.Key, entry.Value);
                             }
                         }

                         return headers;
                     }
                 }
                 """;
    }

    private static string RenderAutoSdkGrpcServiceCollectionExtensions(string rootNamespace)
    {
        return $$"""
                 using Grpc.Core;
                 using Microsoft.Extensions.DependencyInjection;

                 namespace {{rootNamespace}};

                 public static class AutoSdkGrpcServiceCollectionExtensions
                 {
                     public static IServiceCollection AddAutoSdkGrpcClient<TClient>(
                         this IServiceCollection services,
                         Action<AutoSdkGrpcClientOptions> configure)
                         where TClient : ClientBase<TClient>
                     {
                         ArgumentNullException.ThrowIfNull(services);
                         ArgumentNullException.ThrowIfNull(configure);

                         var options = new AutoSdkGrpcClientOptions();
                         configure(options);

                         return services.AddAutoSdkGrpcClient<TClient>(options);
                     }

                     public static IServiceCollection AddAutoSdkGrpcClient<TClient>(
                         this IServiceCollection services,
                         AutoSdkGrpcClientOptions options)
                         where TClient : ClientBase<TClient>
                     {
                         ArgumentNullException.ThrowIfNull(services);
                         ArgumentNullException.ThrowIfNull(options);

                         services.AddSingleton(_ => new AutoSdkGrpcClient<TClient>(options.Clone()));
                         services.AddSingleton(static provider => provider.GetRequiredService<AutoSdkGrpcClient<TClient>>().Client);

                         return services;
                     }
                 }
                 """;
    }

    private static string RenderChannelFactory(string rootNamespace)
    {
        return $$"""
                 using Grpc.Core;
                 using Grpc.Net.Client;
                 using Grpc.Net.Client.Configuration;

                 namespace {{rootNamespace}};

                 public static class GrpcChannelFactory
                 {
                     public static GrpcChannel Create(string address)
                     {
                         ArgumentException.ThrowIfNullOrWhiteSpace(address);

                         return Create(new AutoSdkGrpcClientOptions
                         {
                             Address = address,
                         });
                     }

                     public static GrpcChannel Create(AutoSdkGrpcClientOptions options)
                     {
                         ArgumentNullException.ThrowIfNull(options);
                         ArgumentException.ThrowIfNullOrWhiteSpace(options.Address);

                         return GrpcChannel.ForAddress(options.Address, CreateChannelOptions(options));
                     }

                     private static GrpcChannelOptions CreateChannelOptions(AutoSdkGrpcClientOptions options)
                     {
                         var channelOptions = new GrpcChannelOptions();
                         if (options.MaxRetryAttempts is > 1)
                         {
                             channelOptions.MaxRetryAttempts = options.MaxRetryAttempts.Value;
                             channelOptions.ServiceConfig = new ServiceConfig
                             {
                                 MethodConfigs =
                                 {
                                     new MethodConfig
                                     {
                                         Names =
                                         {
                                             MethodName.Default,
                                         },
                                         RetryPolicy = new RetryPolicy
                                         {
                                             MaxAttempts = options.MaxRetryAttempts.Value,
                                             InitialBackoff = options.RetryInitialBackoff,
                                             MaxBackoff = options.RetryMaxBackoff,
                                             BackoffMultiplier = options.RetryBackoffMultiplier,
                                             RetryableStatusCodes =
                                             {
                                                 StatusCode.Unavailable,
                                                 StatusCode.DeadlineExceeded,
                                                 StatusCode.Internal,
                                             },
                                         },
                                     },
                                 },
                             };
                         }

                         return channelOptions;
                     }
                 }
                 """;
    }

    private static string RenderLocalProtoReadme(
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

                 1. Use `{{rootNamespace}}.AutoSdkGrpcClientFactory.Create<TClient>(options => ...)` for a disposable typed client wrapper with auth, headers, deadlines, and retries
                 2. Or register generated clients in DI with `services.AddAutoSdkGrpcClient<TClient>(options => ...)`
                 3. The lower-level `{{rootNamespace}}.GrpcChannelFactory.Create(...)` method remains available if you want to work with raw channels

                 ## Notes

                 - `google/protobuf/*` imports are provided by `Grpc.Tools`
                 - Mixed OpenAPI+protobuf workflows remain a follow-up slice for `#185`
                 """;
    }

    private static string RenderBufModuleReadme(
        string projectName,
        string rootNamespace,
        BufModuleReference moduleReference,
        ProtoTreeMetadata metadata)
    {
        var namespaceLine = metadata.CSharpNamespaces.Length == 1
            ? $"- detected shared proto csharp_namespace: `{metadata.CSharpNamespaces[0]}`"
            : $"- generated project root namespace: `{rootNamespace}`";
        var packageLine = metadata.Packages.Length == 0
            ? "- detected proto packages: none"
            : $"- detected proto packages: `{string.Join("`, `", metadata.Packages)}`";

        return $$"""
                 # {{projectName}}.Grpc

                 This project was scaffolded by AutoSDK from the Buf module `{{moduleReference.CanonicalReference}}`.
                 AutoSDK used `buf export` to materialize the module locally, then configured `Grpc.Tools` to generate client stubs during build.

                 ## Included

                 - source module: `{{moduleReference.CanonicalReference}}`
                 - exported proto files: `{{metadata.ProtoFiles.Length}}`
                 - detected services: `{{metadata.ServiceCount}}`
                 {{packageLine}}
                 {{namespaceLine}}

                 ## Build

                 ```bash
                 dotnet build
                 ```

                 ## Usage

                 1. Use `{{rootNamespace}}.AutoSdkGrpcClientFactory.Create<TClient>(options => ...)` for a disposable typed client wrapper with auth, headers, deadlines, and retries
                 2. Or register generated clients in DI with `services.AddAutoSdkGrpcClient<TClient>(options => ...)`
                 3. The lower-level `{{rootNamespace}}.GrpcChannelFactory.Create(...)` method remains available if you want to work with raw channels

                 ## Notes

                 - Buf module input requires the `buf` CLI to be available on `PATH`
                 - Mixed OpenAPI+protobuf workflows remain a follow-up slice for `#185`
                 """;
    }

    private static string RenderDescriptorSetReadme(
        string projectName,
        string rootNamespace,
        string descriptorRelativePath,
        DescriptorSetMetadata metadata)
    {
        var namespaceLine = metadata.CSharpNamespaces.Length == 1
            ? $"- detected shared proto csharp_namespace: `{metadata.CSharpNamespaces[0]}`"
            : $"- generated project root namespace: `{rootNamespace}`";
        var packageLine = metadata.Packages.Length == 0
            ? "- detected proto packages: none"
            : $"- detected proto packages: `{string.Join("`, `", metadata.Packages)}`";

        return $$"""
                 # {{projectName}}.Grpc

                 This project was scaffolded by AutoSDK from a binary protobuf descriptor set.
                 It keeps the descriptor set under source control and uses `Grpc.Tools`/`protoc` during build to generate client stubs.

                 ## Included

                 - descriptor set: `{{descriptorRelativePath}}`
                 - proto files in image: `{{metadata.ProtoFileNames.Length}}`
                 - detected services: `{{metadata.ServiceCount}}`
                 {{packageLine}}
                 {{namespaceLine}}

                 ## Build

                 ```bash
                 dotnet build
                 ```

                 ## Usage

                 1. Build the project to materialize the generated `*Client` types from the descriptor set
                 2. Use `{{rootNamespace}}.AutoSdkGrpcClientFactory.Create<TClient>(options => ...)` for a disposable typed client wrapper with auth, headers, deadlines, and retries
                 3. Or register generated clients in DI with `services.AddAutoSdkGrpcClient<TClient>(options => ...)`

                 ## Notes

                 - The descriptor-set path expects a binary `FileDescriptorSet`/Buf image input
                 - Mixed OpenAPI+protobuf workflows remain a follow-up slice for `#185`
                 """;
    }

    private static void TryDeleteDirectory(string path)
    {
        try
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path, recursive: true);
            }
        }
        catch (IOException)
        {
            // Best-effort cleanup for temporary export directories.
        }
        catch (UnauthorizedAccessException)
        {
            // Best-effort cleanup for temporary export directories.
        }
    }

    private sealed record ProtoCopyResult(
        string EntryRelativePath,
        IReadOnlyCollection<string> UnresolvedImports);

    private sealed record ProtoTreeMetadata(
        string[] ProtoFiles,
        string[] CSharpNamespaces,
        string[] Packages,
        int ServiceCount);

    private sealed record DescriptorSetMetadata(
        string[] ProtoFileNames,
        string[] CSharpNamespaces,
        string[] Packages,
        int ServiceCount);

    private readonly record struct BufModuleReference(
        string Owner,
        string ModuleName,
        string Reference,
        string CanonicalReference);
}
