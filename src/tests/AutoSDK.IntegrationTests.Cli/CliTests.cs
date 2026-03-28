using System.Diagnostics;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliTests
{
    [TestMethod]
    public async Task Generate_ElevenLabsStreamingSdk()
    {
        await GenerateAsync("elevenlabs.json", expectResponseStream: true);
    }

    [TestMethod]
    public async Task Generate_WeaviateSdk()
    {
        await GenerateAsync("weaviate.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_CohereSdk()
    {
        await GenerateAsync("cohere.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_MistralSdk()
    {
        await GenerateAsync("mistral.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_DeepgramMultichannelSdk()
    {
        await GenerateAsync("deepgram-multichannel.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_LangsmithSdk()
    {
        await GenerateAsync("langsmith.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_TogetherSdk()
    {
        await GenerateAsync("together.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_WithInjectedApiKeyHeaderSecurityScheme_UsesFriendlyConstructorFileName()
    {
        await GenerateAsync(
            "petstore.yaml",
            targetFramework: "net10.0",
            namespaceValue: "Qdrant",
            clientClassName: "QdrantClient",
            expectedGeneratedFile: "Qdrant.QdrantClient.Constructors.ApiKeyInHeader.g.cs",
            additionalArguments: ["--security-scheme", "ApiKey:Header:api-key"]);
    }

    [TestMethod]
    public async Task Generate_WithInjectedCustomHttpAuthorizationScheme_UsesCustomSchemeName()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /test:
    get:
      operationId: getTest
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Result'
components:
  schemas:
    Result:
      type: object
      properties:
        ok:
          type: boolean
""";

        await GenerateFromContentAsync(
            fileName: "custom-http-auth.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "Deepgram",
            clientClassName: "DeepgramClient",
            expectedGeneratedFile: "Deepgram.DeepgramClient.Constructors.Token.g.cs",
            assertGeneratedOutput: async outputDirectory =>
            {
                var authFile = Path.Combine(outputDirectory, "Deepgram.DeepgramClient.Authorizations.Token.g.cs");
                File.Exists(authFile).Should().BeTrue();
                var content = await File.ReadAllTextAsync(authFile);
                content.Should().Contain("Name = \"Token\"");
                content.Should().Contain("Value = apiKey");
            },
            additionalArguments: ["--security-scheme", "Http:Header:Token"]);
    }

    [TestMethod]
    public async Task Generate_WithDuplicateQueryParameterNames_Builds()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: DuplicateParams
  version: 1.0.0
paths:
  /session:
    get:
      operationId: getSession
      parameters:
        - in: query
          name: name
          schema:
            type: string
          description: Session name.
        - in: query
          name: name
          schema:
            type: string
          description: Customer name.
      responses:
        '200':
          description: OK
""";

        await GenerateFromContentAsync(
            fileName: "duplicate-query-params.yaml",
            specContent: spec,
            targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_WithWarningRegressionModels_Builds()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: WarningRegression
  version: 1.0.0
paths:
  /thing:
    get:
      operationId: getThing
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/UsesDeprecatedThing'
    post:
      operationId: createThing
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/DerivedThing'
      responses:
        '200':
          description: OK
components:
  schemas:
    DeprecatedThing:
      type: object
      deprecated: true
      properties:
        id:
          type: string
    UsesDeprecatedThing:
      type: object
      properties:
        item:
          $ref: '#/components/schemas/DeprecatedThing'
    BaseThing:
      type: object
      properties:
        createdAt:
          type: string
    DerivedThing:
      allOf:
        - $ref: '#/components/schemas/BaseThing'
        - type: object
          properties:
            createdAt:
              type: string
            equals:
              type: string
            name:
              type: string
""";

        await GenerateFromContentAsync(
            fileName: "warning-regressions.yaml",
            specContent: spec,
            targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_WithCaseInsensitiveEnumCollisions_Builds()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: EnumCollision
  version: 1.0.0
paths:
  /kind:
    get:
      operationId: getKind
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/KindWrapper'
components:
  schemas:
    Kind:
      type: string
      enum:
        - same
        - Same
    KindWrapper:
      type: object
      properties:
        kind:
          $ref: '#/components/schemas/Kind'
""";

        await GenerateFromContentAsync(
            fileName: "enum-collision.yaml",
            specContent: spec,
            targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_FreeFormObjectSchemas_UseGeneratedWrapperTypes()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: FreeForm
  version: 1.0.0
paths:
  /points:
    post:
      operationId: createPoint
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/PointStruct'
      responses:
        '200':
          description: OK
components:
  schemas:
    Payload:
      type: object
      additionalProperties: true
    PointStruct:
      type: object
      properties:
        payload:
          $ref: '#/components/schemas/Payload'
""";

        await GenerateFromContentAsync(
            fileName: "free-form-object.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "FreeForm",
            assertGeneratedOutput: async outputDirectory =>
            {
                var pointStructFile = Path.Combine(outputDirectory, "FreeForm.Models.PointStruct.g.cs");
                File.Exists(pointStructFile).Should().BeTrue();
                var content = await File.ReadAllTextAsync(pointStructFile);
                content.Should().Contain("public global::FreeForm.Payload? Payload");
                content.Should().NotContain("public object? Payload");
            });
    }

    private static async Task GenerateAsync(
        string spec,
        string targetFramework = "net8.0",
        bool expectResponseStream = false,
        string namespaceValue = "Oag",
        string clientClassName = "",
        string? expectedGeneratedFile = null,
        Func<string, Task>? assertGeneratedOutput = null,
        params string[] additionalArguments)
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var inputPath = spec.StartsWith("http", StringComparison.OrdinalIgnoreCase)
                ? spec
                : Path.IsPathRooted(spec)
                    ? spec
                    : $"specs/{spec}";
            var generateArguments = new List<string>
            {
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", inputPath,
                "--namespace", namespaceValue,
                "--targetFramework", targetFramework,
                "--output", tempDirectory,
            };
            if (!string.IsNullOrWhiteSpace(clientClassName))
            {
                generateArguments.Add("--clientClassName");
                generateArguments.Add(clientClassName);
            }
            generateArguments.AddRange(additionalArguments);

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                generateArguments.ToArray());
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            Directory.EnumerateFiles(tempDirectory, "*", SearchOption.AllDirectories)
                .Should()
                .NotBeEmpty();

            if (expectResponseStream)
            {
                Directory.EnumerateFiles(tempDirectory, "*.ResponseStream.g.cs", SearchOption.AllDirectories)
                    .Should()
                    .ContainSingle();
            }

            if (!string.IsNullOrWhiteSpace(expectedGeneratedFile))
            {
                File.Exists(Path.Combine(tempDirectory, expectedGeneratedFile))
                    .Should()
                    .BeTrue();
            }

            if (assertGeneratedOutput != null)
            {
                await assertGeneratedOutput(tempDirectory);
            }

            await File.WriteAllTextAsync(Path.Combine(tempDirectory, "Oag.csproj"), $@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>{targetFramework}</TargetFramework>
    <LangVersion>preview</LangVersion>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
  </PropertyGroup>

  <PropertyGroup Label=""Analyzers"">
    <EnableNETAnalyzers>true</EnableNETAnalyzers>
    <AnalysisLevel>latest</AnalysisLevel>
    <AnalysisMode>All</AnalysisMode>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
  </PropertyGroup>

</Project>");

            var buildResult = await RunDotnetAsync(
                tempDirectory,
                "build",
                "--disable-build-servers",
                Path.Combine(tempDirectory, "Oag.csproj"));
            Console.WriteLine(buildResult.StandardOutput);
            Console.WriteLine(buildResult.StandardError);
            buildResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    private static async Task GenerateFromContentAsync(
        string fileName,
        string specContent,
        string targetFramework = "net8.0",
        bool expectResponseStream = false,
        string namespaceValue = "Oag",
        string clientClassName = "",
        string? expectedGeneratedFile = null,
        Func<string, Task>? assertGeneratedOutput = null,
        params string[] additionalArguments)
    {
        var tempSpecDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(tempSpecDirectory);

        var specPath = Path.Combine(tempSpecDirectory, fileName);

        try
        {
            await File.WriteAllTextAsync(specPath, specContent);

            await GenerateAsync(
                spec: specPath,
                targetFramework: targetFramework,
                expectResponseStream: expectResponseStream,
                namespaceValue: namespaceValue,
                clientClassName: clientClassName,
                expectedGeneratedFile: expectedGeneratedFile,
                assertGeneratedOutput: assertGeneratedOutput,
                additionalArguments: additionalArguments);
        }
        finally
        {
            TryDeleteDirectory(tempSpecDirectory);
        }
    }

    //[TestMethod]
    public async Task Initialize()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var initResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "init",
                "TestAPI",
                "TestApi",
                "http://localhost/testspec.yaml",
                "TestCompany",
                "--output", tempDirectory);
            Console.WriteLine(initResult.StandardOutput);
            Console.WriteLine(initResult.StandardError);
            initResult.ExitCode.Should().Be(0);

            Directory.EnumerateFiles(tempDirectory, "*", SearchOption.AllDirectories)
                .Should()
                .NotBeEmpty();
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
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

        process.StartInfo.Environment["DOTNET_CLI_USE_MSBUILD_SERVER"] = "0";
        process.StartInfo.Environment["UseSharedCompilation"] = "false";

        foreach (var argument in arguments)
        {
            process.StartInfo.ArgumentList.Add(argument);
        }

        process.Start();

        var standardOutputTask = process.StandardOutput.ReadToEndAsync();
        var standardErrorTask = process.StandardError.ReadToEndAsync();

        await process.WaitForExitAsync();

        return (
            ExitCode: process.ExitCode,
            StandardOutput: await standardOutputTask,
            StandardError: await standardErrorTask);
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
        catch (Exception exception)
        {
            Console.WriteLine($"Failed to delete temporary test output at '{path}': {exception.Message}");
        }
    }
}
