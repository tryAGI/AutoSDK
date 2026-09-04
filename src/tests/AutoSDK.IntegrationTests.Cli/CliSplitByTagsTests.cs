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

            // Shared surface belongs to Core exactly once. Album and AlbumPage are returned by
            // operations on both tags, so no single tag can claim them.
            core.Should().Contain($"{Namespace}.Models.Album.g.cs");
            core.Should().Contain($"{Namespace}.Models.AlbumPage.g.cs");
            core.Should().Contain($"{Namespace}.Models.Artist.g.cs");
            core.Should().Contain($"{Namespace}.OptionsSupport.g.cs");
            core.Should().Contain($"{Namespace}.Security.g.cs");
            core.Should().Contain($"{Namespace}.JsonSerializerContext.g.cs");

            // Status is reached only by the untagged operation, which claims nothing.
            core.Should().Contain($"{Namespace}.Models.Status.g.cs");

            // The OAuth2 support types are hoisted out of the root client so tag assemblies can
            // reach them without referencing the facade.
            core.Should().Contain($"{Namespace}.AutoSDKOAuth2.g.cs");

            // A tag package carries its client, the models only it reaches, and a serializer
            // context for them chained onto Core's.
            albums.Should().Contain($"{Namespace}.AlbumsClient.g.cs");
            albums.Should().Contain($"{Namespace}.AlbumsClient.ListAlbums.g.cs");
            albums.Should().Contain($"{Namespace}.Models.AlbumCreate.g.cs");
            albums.Should().Contain($"{Namespace}.Models.Error.g.cs");
            albums.Should().Contain($"{Namespace}.Albums.JsonSerializerContext.g.cs");
            albums.Should().NotContain(x => x.StartsWith($"{Namespace}.ArtistsClient.", StringComparison.Ordinal));

            // An enum takes its generated converters with it, and those sit under a different name
            // prefix than the model itself.
            artists.Should().Contain($"{Namespace}.ArtistsClient.GetArtist.g.cs");
            artists.Should().Contain($"{Namespace}.Models.ArtistImport.g.cs");
            artists.Should().Contain($"{Namespace}.Models.ArtistImportStatus.g.cs");
            artists.Should().Contain($"{Namespace}.JsonConverters.ArtistImportStatus.g.cs");
            artists.Should().Contain($"{Namespace}.JsonConverters.ArtistImportStatusNullable.g.cs");

            // Neither tag may take a model the other one also reaches.
            albums.Should().NotContain(x => x.StartsWith($"{Namespace}.Models.Album.", StringComparison.Ordinal));
            artists.Should().NotContain(x => x.StartsWith($"{Namespace}.Models.Artist.g", StringComparison.Ordinal));

            // Root-client partials — including the untagged operation — stay together in the facade.
            facade.Should().Contain($"{Namespace}.{ClientClassName}.g.cs");
            facade.Should().Contain($"{Namespace}.{ClientClassName}.GetStatus.g.cs");
            facade.Should().Contain($"{Namespace}.{ClientClassName}.Authorizations.OAuth2.g.cs");

            // The facade's context chains Core and every tag context, so the root client can hand
            // one context down to its sub-clients exactly as it does in single-project mode.
            facade.Should().Contain($"{Namespace}.{ClientClassName}.JsonSerializerContext.g.cs");

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
    public async Task Generate_SplitByTags_TagOnlyConsumerExercisesTheSharedRuntimeAtRuntime()
    {
        await WithGeneratedFamilyAsync(async (_, outputDirectory) =>
        {
            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");
            var consumerDirectory = Path.Combine(outputDirectory, "TagOnlyConsumer");
            Directory.CreateDirectory(consumerDirectory);

            // Deliberately references neither the base package nor the other tag package. Every
            // runtime type touched below lives in Core while the code driving it was generated
            // into the albums assembly, so this is the cross-assembly path in both directions.
            await WriteConsumerAsync(
                consumerDirectory,
                "TagOnlyConsumer",
                Path.Combine(packagesRoot, $"{PackageId}.Albums", $"{PackageId}.Albums.csproj"),
                $$"""
                using {{Namespace}};

                var albumJson = "{\"id\":\"a1\",\"name\":\"First\"}";
                var pageOne = "{\"items\":[{\"id\":\"a1\",\"name\":\"First\"},{\"id\":\"a2\",\"name\":\"Second\"}],\"next_cursor\":\"c2\",\"total\":3}";
                var pageTwo = "{\"items\":[{\"id\":\"a3\",\"name\":\"Third\"}],\"total\":3}";

                var handler = new StubHandler((request, body) =>
                {
                    if (request.Method == HttpMethod.Post)
                    {
                        // Echoing the name back turns a broken request-side serializer into a
                        // wrong value rather than a silent pass.
                        var sent = System.Text.Json.JsonDocument.Parse(body).RootElement.GetProperty("name").GetString();
                        return StubHandler.Json("{\"id\":\"a9\",\"name\":\"" + sent + "\"}", System.Net.HttpStatusCode.Created);
                    }

                    var path = request.RequestUri!.AbsolutePath;
                    if (path.EndsWith("/albums", StringComparison.Ordinal))
                    {
                        return StubHandler.Json(request.RequestUri!.Query.Contains("cursor=c2", StringComparison.Ordinal)
                            ? pageTwo
                            : pageOne);
                    }

                    return StubHandler.Json(albumJson);
                });

                using var httpClient = new HttpClient(handler);
                using var client = new AlbumsClient(httpClient, disposeHttpClient: false);
                // EndPointSecurityResolver lives in Core and matches this against the OAuth2
                // requirement literals that were generated into the tag assembly.
                client.Authorizations.Add(new EndPointAuthorization
                {
                    Type = "OAuth2",
                    SchemeId = "Oauth2",
                    Location = "Header",
                    Name = "Bearer",
                    Value = "token",
                });

                // AutoSDKPager is a Core type; the helper driving it was generated into this tag.
                var names = new List<string>();
                await foreach (var album in client.ListAlbumsAutoPagingAsync(limit: 2))
                {
                    names.Add(album.Name);
                }
                Console.WriteLine("paged=" + string.Join(",", names));

                // AutoSDKServerConfiguration is a Core type the tag client mutates and reads back.
                client.SelectedServer = client.AvailableServers[1];
                var one = await client.GetAlbumAsync("a1");
                Console.WriteLine("single=" + one.Name);
                Console.WriteLine("server=" + new Uri(handler.Uris[^1]).Host);

                // AutoSDKRequestOptions crosses the boundary into a tag operation body, and the
                // echoed name proves the source-generated context round-tripped the request model.
                var created = await client.CreateAlbumAsync(
                    new AlbumCreate { Name = "Round Trip" },
                    new AutoSDKRequestOptions { Headers = { ["X-Test"] = "on" } });
                Console.WriteLine("created=" + created.Name);
                Console.WriteLine("header=" + handler.Headers[^1]);

                // The generated helpers default to a context, and for a model that moved out of
                // Core that has to be its own package's -- Core's does not register it.
                var draft = new AlbumCreate { Name = "Direct" };
                Console.WriteLine("selfjson=" + AlbumCreate.FromJson(draft.ToJson())!.Name);
                """);

            var output = await RunConsumerAsync(consumerDirectory, "TagOnlyConsumer");

            output.Should().Contain("paged=First,Second,Third");
            output.Should().Contain("single=First");
            output.Should().Contain("server=sandbox.example.com");
            output.Should().Contain("created=Round Trip");
            output.Should().Contain("header=on");
            output.Should().Contain("selfjson=Direct");
        });
    }

    [TestMethod]
    public async Task Generate_SplitByTags_TagOnlyConsumerPollsAndStreamsAtRuntime()
    {
        await WithGeneratedFamilyAsync(async (_, outputDirectory) =>
        {
            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");
            var consumerDirectory = Path.Combine(outputDirectory, "PollingConsumer");
            Directory.CreateDirectory(consumerDirectory);

            await WriteConsumerAsync(
                consumerDirectory,
                "PollingConsumer",
                Path.Combine(packagesRoot, $"{PackageId}.Artists", $"{PackageId}.Artists.csproj"),
                $$"""
                using {{Namespace}};

                var polls = 0;
                var handler = new StubHandler((request, body) =>
                {
                    var path = request.RequestUri!.AbsolutePath;
                    if (path.Contains("/portrait", StringComparison.Ordinal))
                    {
                        return StubHandler.Bytes(new byte[] { 1, 2, 3, 4 });
                    }

                    if (path.Contains("/imports/", StringComparison.Ordinal))
                    {
                        polls++;
                        // The first attempt is still running, so the helper has to actually loop.
                        return StubHandler.Json(polls < 2
                            ? "{\"id\":\"i1\",\"status\":\"running\"}"
                            : "{\"id\":\"i1\",\"status\":\"completed\",\"importedCount\":7}");
                    }

                    return StubHandler.Json("{\"id\":\"ar1\",\"name\":\"Artist\"}");
                });

                using var httpClient = new HttpClient(handler);
                using var client = new ArtistsClient(httpClient, disposeHttpClient: false);
                // EndPointSecurityResolver lives in Core and matches this against the OAuth2
                // requirement literals that were generated into the tag assembly.
                client.Authorizations.Add(new EndPointAuthorization
                {
                    Type = "OAuth2",
                    SchemeId = "Oauth2",
                    Location = "Header",
                    Name = "Bearer",
                    Value = "token",
                });

                // ResponseStream is a Core type constructed inside this tag assembly's body.
                var portrait = await client.GetArtistPortraitAsync("ar1");
                Console.WriteLine("portrait=" + portrait.Length);

                // AutoSDKPollingSupport is a Core type; the wait loop is generated into the tag.
                var import = await client.GetArtistImportWaitAsync(
                    "i1",
                    new AutoSDKPollingOptions
                    {
                        InitialDelay = TimeSpan.Zero,
                        Interval = TimeSpan.FromMilliseconds(10),
                        MaxAttempts = 5,
                    });
                Console.WriteLine("polls=" + polls);

                // The status enum and its converter live in Core, reached through a tag response.
                Console.WriteLine("status=" + import.Status);
                Console.WriteLine("imported=" + import.ImportedCount);
                """);

            var output = await RunConsumerAsync(consumerDirectory, "PollingConsumer");

            output.Should().Contain("portrait=4");
            output.Should().Contain("polls=2");
            output.Should().Contain("status=Completed");
            output.Should().Contain("imported=7");
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
            // one root client, exactly as they do in single-project mode -- and one serializer
            // context has to resolve models owned by Core through both tag assemblies.
            await WriteConsumerAsync(
                consumerDirectory,
                "FullConsumer",
                Path.Combine(packagesRoot, PackageId, $"{PackageId}.csproj"),
                $$"""
                using {{Namespace}};

                var handler = new StubHandler((request, body) =>
                {
                    var path = request.RequestUri!.AbsolutePath;
                    if (path.EndsWith("/status", StringComparison.Ordinal))
                    {
                        return StubHandler.Json("{\"healthy\":true,\"version\":\"1.0\"}");
                    }

                    if (path.Contains("/imports/", StringComparison.Ordinal))
                    {
                        return StubHandler.Json("{\"id\":\"i1\",\"status\":\"completed\",\"importedCount\":7}");
                    }

                    if (path.Contains("/artists/", StringComparison.Ordinal))
                    {
                        return StubHandler.Json("{\"id\":\"ar1\",\"name\":\"Artist\"}");
                    }

                    return StubHandler.Json("{\"items\":[{\"id\":\"a1\",\"name\":\"First\"}],\"total\":1}");
                });

                using var httpClient = new HttpClient(handler);
                using var client = new {{ClientClassName}}(httpClient, disposeHttpClient: false);
                client.AuthorizeUsingOAuth2(new OAuth2Token { AccessToken = "token" });

                AlbumPage albums = await client.Albums.ListAlbumsAsync(limit: 10);
                Artist artist = await client.Artists.GetArtistAsync("artist-id");
                Status status = await client.GetStatusAsync();
                Console.WriteLine("full=" + albums.Items.Count + "," + artist.Name + "," + status.Healthy);

                // A model and an enum converter that both live in a tag assembly, resolved through
                // the context the root client hands down. A converter registered only on the
                // package that owns it would not be applied here.
                ArtistImport import = await client.Artists.GetArtistImportAsync("i1");
                Console.WriteLine("import=" + import.Status + "," + import.ImportedCount);

                // One context resolving models from two different tag assemblies and from Core,
                // in both directions. This is what the chained resolver exists to do.
                var context = client.JsonSerializerContext;
                var fromAlbums = new AlbumCreate { Name = "From Albums" };
                var fromArtists = new ArtistImport { Id = "i2", Status = ArtistImportStatus.Running };
                var shared = new Artist { Id = "ar2", Name = "Shared" };
                Console.WriteLine("cross="
                    + AlbumCreate.FromJson(fromAlbums.ToJson(context), context)!.Name + ","
                    + ArtistImport.FromJson(fromArtists.ToJson(context), context)!.Status + ","
                    + Artist.FromJson(shared.ToJson(context), context)!.Name);
                """);

            var output = await RunConsumerAsync(consumerDirectory, "FullConsumer");

            output.Should().Contain("full=1,Artist,True");
            output.Should().Contain("import=Completed,7");
            output.Should().Contain("cross=From Albums,Running,Shared");
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
    public async Task Generate_SplitByTags_RepacksWhenThePackageMapIsEditedInPlace()
    {
        var outputDirectory = CreateTempDirectory();

        try
        {
            var repositoryDirectory = GetRepositoryDirectory();
            var packagesRoot = Path.Combine(outputDirectory, "GeneratedPackages");

            // Settings records the map by path only, so an edit in place changes nothing the
            // generation cache used to look at. The whole family would then stay on the previous
            // grouping while reporting a cache hit.
            var packageMapPath = await WriteGroupingPackageMapAsync(outputDirectory, "Catalog");
            var first = await GenerateAsync(
                repositoryDirectory,
                outputDirectory,
                extraArguments: ["--package-map", packageMapPath]);
            first.ExitCode.Should().Be(0);
            Directory.Exists(Path.Combine(packagesRoot, $"{PackageId}.Catalog")).Should().BeTrue();

            await WriteGroupingPackageMapAsync(outputDirectory, "Media");
            var second = await GenerateAsync(
                repositoryDirectory,
                outputDirectory,
                extraArguments: ["--package-map", packageMapPath]);
            Console.WriteLine(second.StandardOutput);
            Console.WriteLine(second.StandardError);
            second.ExitCode.Should().Be(0);
            second.StandardOutput.Should().NotContain(
                "Generation cache hit.",
                because: "the map's contents are part of the output tree and so must be part of the cache key");

            Directory.Exists(Path.Combine(packagesRoot, $"{PackageId}.Media")).Should().BeTrue();
            Directory.Exists(Path.Combine(packagesRoot, $"{PackageId}.Catalog")).Should().BeFalse();
        }
        finally
        {
            TryDeleteDirectory(outputDirectory);
        }
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
            "--auto-detect-status-polling",
            "--clean-stale-files",
            .. extraArguments,
        ];

        return RunDotnetAsync(repositoryDirectory, arguments);
    }

    private static async Task<string> WriteGroupingPackageMapAsync(
        string outputDirectory,
        string suffix = "Catalog")
    {
        var path = Path.Combine(outputDirectory, "package-map.json");
        await File.WriteAllTextAsync(path, $$"""
        {
          "tags": {
            "albums": "{{suffix}}",
            "artists": "{{suffix}}"
          }
        }
        """);

        return path;
    }

    /// <summary>
    /// Builds and runs a generated consumer, returning its stdout.
    /// </summary>
    /// <remarks>
    /// The load-bearing difference from a plain build: a serializer context chained across
    /// assemblies, a pager, and a polling loop all compile whether or not they resolve at runtime.
    /// Only executing them proves the family actually works once split.
    /// </remarks>
    private static async Task<string> RunConsumerAsync(string directory, string projectName)
    {
        var result = await RunDotnetAsync(
            directory,
            "run",
            "--disable-build-servers",
            "--no-launch-profile",
            "--project",
            Path.Combine(directory, $"{projectName}.csproj"));

        Console.WriteLine(result.StandardOutput);
        Console.WriteLine(result.StandardError);
        result.ExitCode.Should().Be(0);

        return result.StandardOutput;
    }

    /// <summary>
    /// A canned-response <see cref="HttpMessageHandler"/> dropped next to each consumer, so the
    /// runtime assertions stay hermetic and need no network.
    /// </summary>
    private static Task WriteStubHandlerAsync(string directory)
    {
        return File.WriteAllTextAsync(
            Path.Combine(directory, "StubHandler.cs"),
            """
            using System.Net;
            using System.Text;

            internal sealed class StubHandler : HttpMessageHandler
            {
                private readonly Func<HttpRequestMessage, string, HttpResponseMessage> respond;

                public StubHandler(Func<HttpRequestMessage, string, HttpResponseMessage> respond)
                {
                    this.respond = respond;
                }

                public List<string> Uris { get; } = new();

                public List<string> Headers { get; } = new();

                protected override async Task<HttpResponseMessage> SendAsync(
                    HttpRequestMessage request,
                    CancellationToken cancellationToken)
                {
                    var body = request.Content is null
                        ? string.Empty
                        : await request.Content.ReadAsStringAsync(cancellationToken);

                    Uris.Add(request.RequestUri!.ToString());
                    Headers.Add(request.Headers.TryGetValues("X-Test", out var values)
                        ? string.Join(",", values)
                        : string.Empty);

                    return respond(request, body);
                }

                public static HttpResponseMessage Json(string json, HttpStatusCode status = HttpStatusCode.OK)
                {
                    return new HttpResponseMessage(status)
                    {
                        Content = new StringContent(json, Encoding.UTF8, "application/json"),
                    };
                }

                public static HttpResponseMessage Bytes(byte[] bytes)
                {
                    var content = new ByteArrayContent(bytes);
                    content.Headers.ContentType =
                        new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                    return new HttpResponseMessage(HttpStatusCode.OK) { Content = content };
                }
            }
            """);
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
        await WriteStubHandlerAsync(directory);
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
