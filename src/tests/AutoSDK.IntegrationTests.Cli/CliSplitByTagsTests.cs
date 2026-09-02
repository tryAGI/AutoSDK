using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

/// <summary>
/// End-to-end coverage for <c>autosdk generate --split-by-tags</c>.
/// </summary>
/// <remarks>
/// The load-bearing assertion is that the generated family <em>builds as separate assemblies</em>.
/// A single-project build cannot catch the failures this mode introduces — cross-assembly
/// <c>partial</c> types, shared runtime members that are still <c>internal</c>, and the OAuth2
/// support types that would otherwise make every tag assembly reference the facade that already
/// references it. Enumerating those by hand in a unit test would go stale; compiling the graph
/// does not.
/// </remarks>
[TestClass]
public class CliSplitByTagsTests
{
    private const string PackageId = "tryAGI.Fixture";
    private const string Namespace = "Fixture";
    private const string ClientClassName = "FixtureClient";
    private const string TargetFramework = "net10.0";

    [TestMethod]
    public async Task Generate_SplitByTags_ProducesAFamilyThatBuildsAsSeparateAssemblies()
    {
        await WithGeneratedFamilyAsync(async (repositoryDirectory, outputDirectory) =>
        {
            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");

            var buildResult = await RunDotnetAsync(
                packagesRoot,
                "build",
                "--disable-build-servers",
                Path.Combine(packagesRoot, $"{PackageId}.slnx"));

            Console.WriteLine(buildResult.StandardOutput);
            Console.WriteLine(buildResult.StandardError);
            buildResult.ExitCode.Should().Be(0);
        });
    }

    [TestMethod]
    public async Task Generate_SplitByTags_RoutesEachGeneratedFileToExactlyOnePackage()
    {
        await WithGeneratedFamilyAsync((_, outputDirectory) =>
        {
            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");

            var core = GeneratedFileNames(packagesRoot, $"{PackageId}.Core");
            var albums = GeneratedFileNames(packagesRoot, $"{PackageId}.Albums");
            var artists = GeneratedFileNames(packagesRoot, $"{PackageId}.Artists");
            var facade = GeneratedFileNames(packagesRoot, PackageId);

            // Shared surface belongs to Core exactly once.
            core.Should().Contain($"{Namespace}.Models.Album.g.cs");
            core.Should().Contain($"{Namespace}.OptionsSupport.g.cs");
            core.Should().Contain($"{Namespace}.Security.g.cs");
            core.Should().Contain($"{Namespace}.JsonSerializerContext.g.cs");

            // The OAuth2 support types are hoisted out of the root client so tag assemblies can
            // reach them without referencing the facade.
            core.Should().Contain($"{Namespace}.AutoSDKOAuth2.g.cs");

            // A tag package carries its client and nothing else.
            albums.Should().Contain($"{Namespace}.AlbumsClient.g.cs");
            albums.Should().Contain($"{Namespace}.AlbumsClient.ListAlbums.g.cs");
            albums.Should().NotContain(x => x.StartsWith($"{Namespace}.ArtistsClient.", StringComparison.Ordinal));
            albums.Should().NotContain(x => x.StartsWith($"{Namespace}.Models.", StringComparison.Ordinal));
            artists.Should().Contain($"{Namespace}.ArtistsClient.GetArtist.g.cs");

            // Root-client partials — including the untagged operation — stay together in the facade.
            facade.Should().Contain($"{Namespace}.{ClientClassName}.g.cs");
            facade.Should().Contain($"{Namespace}.{ClientClassName}.GetStatus.g.cs");
            facade.Should().Contain($"{Namespace}.{ClientClassName}.Authorizations.OAuth2.g.cs");

            var allFiles = core.Concat(albums).Concat(artists).Concat(facade).ToArray();
            allFiles.Should().OnlyHaveUniqueItems(
                because: "a generated file duplicated across packages would be an ambiguous type");

            return Task.CompletedTask;
        });
    }

    [TestMethod]
    public async Task Generate_SplitByTags_WritesAStableManifestAndSolution()
    {
        await WithGeneratedFamilyAsync(async (_, outputDirectory) =>
        {
            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");

            var manifest = await File.ReadAllTextAsync(Path.Combine(packagesRoot, "autosdk-packages.json"));
            manifest.Should().Contain("\"schemaVersion\": 1");
            manifest.Should().Contain($"\"basePackageId\": \"{PackageId}\"");
            manifest.Should().Contain($"\"corePackageId\": \"{PackageId}.Core\"");
            manifest.Should().Contain("\"tags\": [\"albums\"]");
            manifest.Should().Contain("\"clientClassNames\": [\"ArtistsClient\"]");
            manifest.Should().Contain("\"kind\": \"facade\"");

            var solution = await File.ReadAllTextAsync(Path.Combine(packagesRoot, $"{PackageId}.slnx"));
            solution.Should().Contain($"{PackageId}.Core/{PackageId}.Core.csproj");
            solution.Should().Contain($"{PackageId}.Albums/{PackageId}.Albums.csproj");

            // Core must not reference anything in the family, or the graph would cycle.
            var coreProject = await File.ReadAllTextAsync(
                Path.Combine(packagesRoot, $"{PackageId}.Core", $"{PackageId}.Core.csproj"));
            coreProject.Should().NotContain("ProjectReference");

            var albumsProject = await File.ReadAllTextAsync(
                Path.Combine(packagesRoot, $"{PackageId}.Albums", $"{PackageId}.Albums.csproj"));
            albumsProject.Should().Contain($"{PackageId}.Core.csproj");
            albumsProject.Should().NotContain($"{PackageId}.Artists.csproj");
        });
    }

    [TestMethod]
    public async Task Generate_SplitByTags_IsByteStableAcrossRuns()
    {
        await WithGeneratedFamilyAsync(async (repositoryDirectory, outputDirectory) =>
        {
            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");
            var before = await ReadTreeAsync(packagesRoot);

            var second = await GenerateAsync(repositoryDirectory, outputDirectory);
            second.ExitCode.Should().Be(0);

            var after = await ReadTreeAsync(packagesRoot);

            after.Keys.Should().BeEquivalentTo(before.Keys);
            foreach (var (relativePath, text) in before)
            {
                after[relativePath].Should().Be(text, because: relativePath);
            }
        });
    }

    [TestMethod]
    public async Task Generate_SplitByTags_ConsumerReferencingOneTagPackageCanCallIt()
    {
        await WithGeneratedFamilyAsync(async (_, outputDirectory) =>
        {
            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");
            var consumerDirectory = Path.Combine(outputDirectory, "TagOnlyConsumer");
            Directory.CreateDirectory(consumerDirectory);

            // Deliberately references neither the base package nor the other tag package.
            await WriteConsumerAsync(
                consumerDirectory,
                "TagOnlyConsumer",
                Path.Combine(packagesRoot, $"{PackageId}.Albums", $"{PackageId}.Albums.csproj"),
                $$"""
                using {{Namespace}};

                using var client = new AlbumsClient();
                client.Authorizations.Add(new EndPointAuthorization { Type = "Http", Name = "Bearer", Value = "token" });

                AlbumPage page = await client.ListAlbumsAsync(limit: 10, offset: 0);
                Album album = await client.GetAlbumAsync("album-id");
                Console.WriteLine($"{page.Items.Count} {album.Name}");
                """);

            var buildResult = await RunDotnetAsync(
                consumerDirectory,
                "build",
                "--disable-build-servers",
                Path.Combine(consumerDirectory, "TagOnlyConsumer.csproj"));

            Console.WriteLine(buildResult.StandardOutput);
            Console.WriteLine(buildResult.StandardError);
            buildResult.ExitCode.Should().Be(0);
        });
    }

    [TestMethod]
    public async Task Generate_SplitByTags_ConsumerReferencingTheBasePackageKeepsTheFullSdkShape()
    {
        await WithGeneratedFamilyAsync(async (_, outputDirectory) =>
        {
            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");
            var consumerDirectory = Path.Combine(outputDirectory, "FullConsumer");
            Directory.CreateDirectory(consumerDirectory);

            // The tag-client properties, the untagged operation and OAuth2 all still hang off the
            // one root client, exactly as they do in single-project mode.
            await WriteConsumerAsync(
                consumerDirectory,
                "FullConsumer",
                Path.Combine(packagesRoot, PackageId, $"{PackageId}.csproj"),
                $$"""
                using {{Namespace}};

                using var client = new {{ClientClassName}}();
                client.AuthorizeUsingOAuth2(new OAuth2Token { AccessToken = "token" });

                AlbumPage albums = await client.Albums.ListAlbumsAsync(limit: 10, offset: 0);
                Artist artist = await client.Artists.GetArtistAsync("artist-id");
                Status status = await client.GetStatusAsync();
                Console.WriteLine($"{albums.Items.Count} {artist.Name} {status.Healthy}");
                """);

            var buildResult = await RunDotnetAsync(
                consumerDirectory,
                "build",
                "--disable-build-servers",
                Path.Combine(consumerDirectory, "FullConsumer.csproj"));

            Console.WriteLine(buildResult.StandardOutput);
            Console.WriteLine(buildResult.StandardError);
            buildResult.ExitCode.Should().Be(0);
        });
    }

    [TestMethod]
    public async Task Generate_SplitByTags_RemovesPackagesForTagsThatNoLongerExist()
    {
        await WithGeneratedFamilyAsync(async (repositoryDirectory, outputDirectory) =>
        {
            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");
            Directory.Exists(Path.Combine(packagesRoot, $"{PackageId}.Artists")).Should().BeTrue();

            // Regenerating with the artists tag excluded must retire its package rather than leave
            // a project behind that no longer has any sources.
            var result = await GenerateAsync(
                repositoryDirectory,
                outputDirectory,
                extraArguments: ["--package-map", await WriteGroupingPackageMapAsync(outputDirectory)]);
            result.ExitCode.Should().Be(0);

            Directory.Exists(Path.Combine(packagesRoot, $"{PackageId}.Catalog")).Should().BeTrue();
            Directory.Exists(Path.Combine(packagesRoot, $"{PackageId}.Artists")).Should().BeFalse();
            Directory.Exists(Path.Combine(packagesRoot, $"{PackageId}.Albums")).Should().BeFalse();
        });
    }

    [TestMethod]
    public async Task Generate_SplitByTags_WithStrongNameKey_KeepsMembersInternalAndStillBuilds()
    {
        var outputDirectory = CreateTempDirectory();

        try
        {
            var repositoryDirectory = GetRepositoryDirectory();
            var publicKey = ReadRepositoryPublicKey(repositoryDirectory);

            var generateResult = await GenerateAsync(
                repositoryDirectory,
                outputDirectory,
                extraArguments: ["--strong-name-public-key", publicKey]);
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");

            // With a key the shared runtime members stay internal — the whole point of the option
            // is that the Core package's public surface is unchanged.
            var security = await File.ReadAllTextAsync(
                Path.Combine(packagesRoot, $"{PackageId}.Core", "Generated", $"{Namespace}.Security.g.cs"));
            security.Should().Contain("internal static class EndPointSecurityResolver");
            security.Should().NotContain("EditorBrowsable");

            var coreProject = await File.ReadAllTextAsync(
                Path.Combine(packagesRoot, $"{PackageId}.Core", $"{PackageId}.Core.csproj"));
            coreProject.Should().Contain($"""<InternalsVisibleTo Include="{PackageId}.Albums, PublicKey={publicKey}" />""");
            coreProject.Should().Contain($"""<InternalsVisibleTo Include="{PackageId}, PublicKey={publicKey}" />""");

            // Each tag assembly grants the facade access to the serializer-context hook it assigns.
            var albumsProject = await File.ReadAllTextAsync(
                Path.Combine(packagesRoot, $"{PackageId}.Albums", $"{PackageId}.Albums.csproj"));
            albumsProject.Should().Contain($"""<InternalsVisibleTo Include="{PackageId}, PublicKey={publicKey}" />""");

            // InternalsVisibleTo only grants anything when the assemblies are actually signed with
            // the matching key, which is the generated repository's job rather than AutoSDK's.
            await File.WriteAllTextAsync(
                Path.Combine(packagesRoot, "Directory.Build.props"),
                $"""
                <Project>
                  <PropertyGroup>
                    <SignAssembly>true</SignAssembly>
                    <AssemblyOriginatorKeyFile>{Path.Combine(repositoryDirectory, "src", "key.snk")}</AssemblyOriginatorKeyFile>
                  </PropertyGroup>
                </Project>
                """);

            var buildResult = await RunDotnetAsync(
                packagesRoot,
                "build",
                "--disable-build-servers",
                Path.Combine(packagesRoot, $"{PackageId}.slnx"));

            Console.WriteLine(buildResult.StandardOutput);
            Console.WriteLine(buildResult.StandardError);
            buildResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(outputDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_SplitByTags_WithNonHexStrongNameKey_IsRejected()
    {
        var outputDirectory = CreateTempDirectory();

        try
        {
            var result = await GenerateAsync(
                GetRepositoryDirectory(),
                outputDirectory,
                extraArguments: ["--strong-name-public-key", "0x0024-not-hex"]);

            result.ExitCode.Should().NotBe(0);
            result.StandardError.Should().Contain("hex-encoded public key");
        }
        finally
        {
            TryDeleteDirectory(outputDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_SplitByTags_WithGenerateCli_IsRejected()
    {
        var outputDirectory = CreateTempDirectory();

        try
        {
            var result = await GenerateAsync(
                GetRepositoryDirectory(),
                outputDirectory,
                extraArguments: ["--generate-cli"]);

            result.ExitCode.Should().NotBe(0);
            result.StandardError.Should().Contain("mutually exclusive");
        }
        finally
        {
            TryDeleteDirectory(outputDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_SplitByTags_WithSingleFile_IsRejected()
    {
        var outputDirectory = CreateTempDirectory();

        try
        {
            var repositoryDirectory = GetRepositoryDirectory();
            var result = await GenerateAsync(
                repositoryDirectory,
                outputDirectory,
                extraArguments: ["--single-file"]);

            result.ExitCode.Should().NotBe(0);
            result.StandardError.Should().Contain("mutually exclusive");
        }
        finally
        {
            TryDeleteDirectory(outputDirectory);
        }
    }

    private static async Task WithGeneratedFamilyAsync(Func<string, string, Task> assert)
    {
        var outputDirectory = CreateTempDirectory();

        try
        {
            var repositoryDirectory = GetRepositoryDirectory();

            var generateResult = await GenerateAsync(repositoryDirectory, outputDirectory);
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            await assert(repositoryDirectory, outputDirectory);
        }
        finally
        {
            TryDeleteDirectory(outputDirectory);
        }
    }

    private static Task<(int ExitCode, string StandardOutput, string StandardError)> GenerateAsync(
        string repositoryDirectory,
        string outputDirectory,
        params string[] extraArguments)
    {
        string[] arguments =
        [
            "run",
            "--disable-build-servers",
            "--no-launch-profile",
            "--project", "src/libs/AutoSDK.CLI",
            "generate", Path.Combine(repositoryDirectory, "specs", "split-by-tags.yaml"),
            "--namespace", Namespace,
            "--clientClassName", ClientClassName,
            "--targetFramework", TargetFramework,
            "--output", outputDirectory,
            "--split-by-tags",
            "--package-id", PackageId,
            "--generate-pageable-helpers",
            "--clean-stale-files",
            .. extraArguments,
        ];

        return RunDotnetAsync(repositoryDirectory, arguments);
    }

    private static async Task<string> WriteGroupingPackageMapAsync(string outputDirectory)
    {
        var path = Path.Combine(outputDirectory, "package-map.json");
        await File.WriteAllTextAsync(path, """
        {
          "tags": {
            "albums": "Catalog",
            "artists": "Catalog"
          }
        }
        """);

        return path;
    }

    private static async Task WriteConsumerAsync(
        string directory,
        string projectName,
        string sdkProjectPath,
        string program)
    {
        await File.WriteAllTextAsync(
            Path.Combine(directory, $"{projectName}.csproj"),
            $"""
            <Project Sdk="Microsoft.NET.Sdk">

              <PropertyGroup>
                <OutputType>Exe</OutputType>
                <TargetFramework>{TargetFramework}</TargetFramework>
                <LangVersion>preview</LangVersion>
                <Nullable>enable</Nullable>
                <ImplicitUsings>enable</ImplicitUsings>
              </PropertyGroup>

              <ItemGroup>
                <ProjectReference Include="{sdkProjectPath}" />
              </ItemGroup>

            </Project>
            """);

        await File.WriteAllTextAsync(Path.Combine(directory, "Program.cs"), program);
    }

    private static string[] GeneratedFileNames(string packagesRoot, string packageId)
    {
        var directory = Path.Combine(packagesRoot, packageId, "Generated");

        return Directory.Exists(directory)
            ? Directory.EnumerateFiles(directory, "*.g.cs", SearchOption.AllDirectories)
                .Select(Path.GetFileName)
                .Select(static x => x!)
                .OrderBy(static x => x, StringComparer.Ordinal)
                .ToArray()
            : [];
    }

    private static async Task<Dictionary<string, string>> ReadTreeAsync(string root)
    {
        var result = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var path in Directory.EnumerateFiles(root, "*", SearchOption.AllDirectories))
        {
            result[Path.GetRelativePath(root, path).Replace('\\', '/')] =
                await File.ReadAllTextAsync(path);
        }

        return result;
    }

    /// <summary>
    /// The public key of the repository's shared <c>src/key.snk</c>, read back out of the
    /// <c>InternalsVisibleTo</c> grant that already uses it, so the test follows a key rotation
    /// instead of pinning a copy of the key.
    /// </summary>
    private static string ReadRepositoryPublicKey(string repositoryDirectory)
    {
        var project = File.ReadAllText(Path.Combine(
            repositoryDirectory, "src", "libs", "AutoSDK.CSharp", "AutoSDK.CSharp.csproj"));
        var match = System.Text.RegularExpressions.Regex.Match(project, "PublicKey=([0-9a-fA-F]+)");
        match.Success.Should().BeTrue(because: "AutoSDK.CSharp.csproj should still carry a signed InternalsVisibleTo grant");

        return match.Groups[1].Value;
    }

    private static string GetRepositoryDirectory()
    {
        return Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../../.."));
    }

    private static string CreateTempDirectory()
    {
        // Canonicalise the temp root first. On macOS Path.GetTempPath() returns /var/folders/…,
        // and /var is a symlink to /private/var. MSBuild treats the two spellings as different
        // projects, so a consumer would fail to see the Core package flow through its tag
        // package's ProjectReference — a harness artifact, not a defect in the generated output.
        var path = Path.Combine(
            ResolveRealPath(Path.GetTempPath().TrimEnd(Path.DirectorySeparatorChar)),
            Path.GetRandomFileName());
        Directory.CreateDirectory(path);

        return path;
    }

    /// <summary>
    /// Resolves symlinks anywhere in <paramref name="path"/>, not just on its final component.
    /// </summary>
    private static string ResolveRealPath(string path)
    {
        var resolved = new DirectoryInfo(path).ResolveLinkTarget(returnFinalTarget: true)?.FullName;
        if (resolved is not null)
        {
            return resolved;
        }

        var parent = Path.GetDirectoryName(path);

        return string.IsNullOrEmpty(parent) || string.Equals(parent, path, StringComparison.Ordinal)
            ? path
            : Path.Combine(ResolveRealPath(parent), Path.GetFileName(path));
    }

    private static async Task<(int ExitCode, string StandardOutput, string StandardError)> RunDotnetAsync(
        string workingDirectory,
        params string[] arguments)
    {
        using var process = new Process
        {
            StartInfo = new ProcessStartInfo("dotnet")
            {
                WorkingDirectory = workingDirectory,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
            },
        };

        foreach (var argument in arguments)
        {
            process.StartInfo.ArgumentList.Add(argument);
        }

        process.Start();

        var standardOutputTask = process.StandardOutput.ReadToEndAsync();
        var standardErrorTask = process.StandardError.ReadToEndAsync();

        await process.WaitForExitAsync();

        return
        (
            process.ExitCode,
            await standardOutputTask,
            await standardErrorTask
        );
    }

    private static void TryDeleteDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            return;
        }

        try
        {
            Directory.Delete(path, recursive: true);
        }
        catch (IOException)
        {
        }
        catch (UnauthorizedAccessException)
        {
        }
    }
}
