using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace AutoSDK.IntegrationTests;

[TestClass]
public class CliTests
{
    [TestMethod]
    public async Task Generate_ElevenLabsStreamingSdk()
    {
        await GenerateAsync("elevenlabs.json", expectResponseStream: true);
    }

    // --- New SDK specs ---

    [TestMethod]
    public async Task Generate_BlackForestLabsSdk()
    {
        await GenerateAsync("blackforestlabs.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_BlandAISdk()
    {
        await GenerateAsync("blandai.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_WithOpenApiExamples_EmitsGeneratedSnippetManifest()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var specPath = Path.Combine(tempDirectory, "examples.yaml");
            await File.WriteAllTextAsync(
                specPath,
                """
                openapi: 3.0.1
                info:
                  title: Examples
                  version: 1.0.0
                paths:
                  /items/{itemId}:
                    post:
                      operationId: createItem
                      parameters:
                        - name: itemId
                          in: path
                          required: true
                          schema:
                            type: string
                          example: item_123
                      requestBody:
                        required: true
                        content:
                          application/json:
                            example:
                              name: widget
                            schema:
                              type: object
                              properties:
                                name:
                                  type: string
                      responses:
                        '201':
                          description: Created
                          content:
                            application/json:
                              example:
                                id: item_123
                              schema:
                                type: object
                                properties:
                                  id:
                                    type: string
                  /uploads:
                    post:
                      operationId: uploadFile
                      requestBody:
                        required: true
                        content:
                          multipart/form-data:
                            example:
                              file: example.txt
                            schema:
                              type: object
                              properties:
                                file:
                                  type: string
                                  format: binary
                      responses:
                        '202':
                          description: Accepted
                """);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var outputDirectory = Path.Combine(tempDirectory, "Generated");

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath,
                "--namespace", "G",
                "--clientClassName", "ExampleClient",
                "--output", outputDirectory);

            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var manifestPath = Path.Combine(outputDirectory, "autosdk.generated-examples.json");
            File.Exists(manifestPath).Should().BeTrue();

            var manifest = await File.ReadAllTextAsync(manifestPath);
            manifest.Should().Contain("\"OperationId\": \"createItem\"");
            manifest.Should().Contain("\"OperationId\": \"uploadFile\"");
            manifest.Should().Contain("\"Language\": \"csharp\"");
            manifest.Should().Contain("\"Language\": \"http\"");
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_ProtoInput_ScaffoldsGrpcClientProject()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var protoPath = Path.Combine(tempDirectory, "greeter.proto");
            var messagesDirectory = Path.Combine(tempDirectory, "messages");
            Directory.CreateDirectory(messagesDirectory);

            await File.WriteAllTextAsync(
                protoPath,
                """
                syntax = "proto3";

                package demo;
                option csharp_namespace = "Demo.Grpc";

                import "messages/common.proto";

                service Greeter {
                  rpc SayHello (demo.messages.HelloRequest) returns (demo.messages.HelloReply);
                }
                """);
            await File.WriteAllTextAsync(
                Path.Combine(messagesDirectory, "common.proto"),
                """
                syntax = "proto3";

                package demo.messages;

                message HelloRequest {
                  string name = 1;
                }

                message HelloReply {
                  string message = 1;
                }
                """);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var outputDirectory = Path.Combine(tempDirectory, "Generated");
            var result = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate",
                protoPath,
                "--namespace", "Ignored.ByProtoNamespace",
                "--targetFramework", "net10.0",
                "--output", outputDirectory);

            result.ExitCode.Should().Be(0);
            result.StandardError.Should().BeNullOrWhiteSpace();

            var csprojPath = Path.Combine(outputDirectory, "Greeter.Grpc.csproj");
            File.Exists(csprojPath).Should().BeTrue();
            File.Exists(Path.Combine(outputDirectory, "README.md")).Should().BeTrue();
            File.Exists(Path.Combine(outputDirectory, "Protos", "greeter.proto")).Should().BeTrue();
            File.Exists(Path.Combine(outputDirectory, "Protos", "messages", "common.proto")).Should().BeTrue();
            AssertAutoSdkGrpcSupportFilesExist(outputDirectory);

            var csprojText = await File.ReadAllTextAsync(csprojPath);
            csprojText.Should().Contain("Grpc.Tools");
            csprojText.Should().Contain("<RootNamespace>Demo.Grpc</RootNamespace>");
            csprojText.Should().Contain("Microsoft.Extensions.DependencyInjection.Abstractions");

            var buildResult = await RunDotnetAsync(
                outputDirectory,
                "build",
                "--disable-build-servers",
                csprojPath);
            buildResult.ExitCode.Should().Be(0);

            var consumerBuildResult = await BuildAutoSdkGrpcConsumerAsync(
                tempDirectory,
                csprojPath,
                "Demo.Grpc",
                "Greeter.GreeterClient");
            consumerBuildResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_ProtoInput_WithMissingImport_ShowsExplicitMessage()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var protoPath = Path.Combine(tempDirectory, "greeter.proto");
            await File.WriteAllTextAsync(
                protoPath,
                """
                syntax = "proto3";

                package demo;

                import "messages/common.proto";

                service Greeter {
                  rpc SayHello (demo.messages.HelloRequest) returns (demo.messages.HelloReply);
                }
                """);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var outputDirectory = Path.Combine(tempDirectory, "Generated");
            var result = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate",
                protoPath,
                "--targetFramework", "net10.0",
                "--output", outputDirectory);

            result.ExitCode.Should().Be(1);
            result.StandardError.Should().Contain("Unable to resolve imported proto files: messages/common.proto");
            result.StandardError.Should().Contain("use a Buf module or descriptor-set input");
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_DescriptorSetInput_ScaffoldsGrpcClientProject()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var descriptorSetPath = Path.Combine(tempDirectory, "greeter.binpb");
            var descriptorSet = new FileDescriptorSet
            {
                File =
                {
                    CreateGreeterFileDescriptorProto(),
                },
            };
            await File.WriteAllBytesAsync(descriptorSetPath, descriptorSet.ToByteArray());

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var outputDirectory = Path.Combine(tempDirectory, "Generated");
            var result = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate",
                descriptorSetPath,
                "--targetFramework", "net10.0",
                "--output", outputDirectory);

            result.ExitCode.Should().Be(0);
            result.StandardError.Should().BeNullOrWhiteSpace();

            var csprojPath = Path.Combine(outputDirectory, "Greeter.Grpc.csproj");
            File.Exists(csprojPath).Should().BeTrue();
            File.Exists(Path.Combine(outputDirectory, "README.md")).Should().BeTrue();
            File.Exists(Path.Combine(outputDirectory, "Descriptors", "greeter.binpb")).Should().BeTrue();
            AssertAutoSdkGrpcSupportFilesExist(outputDirectory);

            var csprojText = await File.ReadAllTextAsync(csprojPath);
            csprojText.Should().Contain("GenerateGrpcFromDescriptorSet");
            csprojText.Should().Contain("<RootNamespace>Demo.Grpc</RootNamespace>");
            csprojText.Should().Contain("Microsoft.Extensions.DependencyInjection.Abstractions");

            var buildResult = await RunDotnetAsync(
                outputDirectory,
                "build",
                "--disable-build-servers",
                csprojPath);
            buildResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_DescriptorSetInput_WithInvalidBinary_ShowsExplicitMessage()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var descriptorSetPath = Path.Combine(tempDirectory, "greeter.binpb");
            await File.WriteAllTextAsync(descriptorSetPath, "not a descriptor set");

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var outputDirectory = Path.Combine(tempDirectory, "Generated");
            var result = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate",
                descriptorSetPath,
                "--targetFramework", "net10.0",
                "--output", outputDirectory);

            result.ExitCode.Should().Be(1);
            result.StandardError.Should().Contain($"Input '{descriptorSetPath}' is not a valid binary protobuf descriptor set.");
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_WithRequestAndClientOptions_EmitsOptionsSupportAndBuilds()
    {
        const string spec = """
                            openapi: 3.0.3
                            info:
                              title: Options
                              version: 1.0.0
                            paths:
                              /search:
                                get:
                                  operationId: search
                                  parameters:
                                    - in: query
                                      name: q
                                      schema:
                                        type: string
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            type: object
                                            properties:
                                              id:
                                                type: string
                            """;

        await GenerateFromContentAsync(
            fileName: "request-options.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "Generated.Options",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedFiles = Directory.GetFiles(outputDirectory, "*.cs", SearchOption.AllDirectories);
                generatedFiles.Should().NotBeEmpty();

                var combinedSource = string.Join(
                    Environment.NewLine,
                    await Task.WhenAll(generatedFiles.Select(path => File.ReadAllTextAsync(path))));

                combinedSource.Should().Contain("public sealed class AutoSDKClientOptions");
                combinedSource.Should().Contain("public sealed class AutoSDKRequestOptions");
                combinedSource.Should().Contain("public interface IAutoSDKHook");
                combinedSource.Should().Contain("public sealed class AutoSDKHookContext");
                combinedSource.Should().Contain("options: null");
                combinedSource.Should().Contain("global::Generated.Options.AutoSDKClientOptions? options,");
                combinedSource.Should().Contain("global::Generated.Options.AutoSDKRequestOptions? requestOptions = default");
                combinedSource.Should().Contain("AutoSDKRequestOptionsSupport.AppendQueryParameters(");
                combinedSource.Should().Contain("AutoSDKRequestOptionsSupport.ApplyHeaders(");
                combinedSource.Should().Contain("AutoSDKRequestOptionsSupport.GetMaxAttempts(");
                combinedSource.Should().Contain("AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(");
                combinedSource.Should().Contain("AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(");
                combinedSource.Should().Contain("AutoSDKRequestOptionsSupport.OnAfterErrorAsync(");
            });
    }

    [TestMethod]
    public async Task Generate_WithFernIdempotencyHeaders_EmitsFirstClassSdkSupport()
    {
        const string spec = """
                            openapi: 3.0.3
                            info:
                              title: Idempotency
                              version: 1.0.0
                            x-fern-idempotency-headers:
                              - header: Idempotency-Key
                                name: idempotency_key
                            paths:
                              /charges:
                                post:
                                  operationId: createCharge
                                  x-fern-idempotent: true
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            type: object
                                            properties:
                                              id:
                                                type: string
                            """;

        await GenerateFromContentAsync(
            fileName: "idempotency.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "Generated.Idempotency",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedFiles = Directory.GetFiles(outputDirectory, "*.cs", SearchOption.AllDirectories);
                generatedFiles.Should().NotBeEmpty();

                var combinedSource = string.Join(
                    Environment.NewLine,
                    await Task.WhenAll(generatedFiles.Select(path => File.ReadAllTextAsync(path))));

                combinedSource.Should().Contain("CreateIdempotencyKey");
                combinedSource.Should().Contain("string? idempotencyKey = default");
                combinedSource.Should().Contain("TryAddWithoutValidation(\"Idempotency-Key\", __idempotencyKey)");
            });
    }

    [TestMethod]
    public async Task Generate_WithSpeakeasyPolling_EmitsWaitHelpersAndBuilds()
    {
        const string spec = """
                            openapi: 3.0.3
                            info:
                              title: Polling
                              version: 1.0.0
                            paths:
                              /jobs/{id}:
                                get:
                                  operationId: getJob
                                  parameters:
                                    - in: path
                                      name: id
                                      required: true
                                      schema:
                                        type: string
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            type: object
                                            required:
                                              - status
                                            properties:
                                              status:
                                                type: string
                                  x-speakeasy-polling:
                                    - name: WaitForCompleted
                                      delaySeconds: 2
                                      intervalSeconds: 4
                                      limitCount: 12
                                      failureCriteria:
                                        - condition: $statusCode == 200
                                        - condition: $response.body#/status == "errored"
                                      successCriteria:
                                        - condition: $statusCode == 200
                                        - condition: $response.body#/status == "completed"
                            """;

        await GenerateFromContentAsync(
            fileName: "polling.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "Generated.Polling",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedFiles = Directory.GetFiles(outputDirectory, "*.cs", SearchOption.AllDirectories);
                generatedFiles.Should().NotBeEmpty();

                var combinedSource = string.Join(
                    Environment.NewLine,
                    await Task.WhenAll(generatedFiles.Select(path => File.ReadAllTextAsync(path))));

                combinedSource.Should().Contain("public sealed class AutoSDKPollingOptions");
                combinedSource.Should().Contain("public sealed class AutoSDKPollingException");
                combinedSource.Should().Contain("GetJobWaitForCompletedAsync(");
                combinedSource.Should().Contain("await GetJobAsResponseAsync(");
                combinedSource.Should().Contain("AutoSDKPollingSupport.ResolvePollingOptions(");
                combinedSource.Should().Contain("AutoSDKPollingSupport.MatchesSimpleCondition(");
            });
    }

    [TestMethod]
    public async Task Generate_BufModuleInput_ScaffoldsGrpcClientProject()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var protoSourceDirectory = Path.Combine(tempDirectory, "ProtoSource");
            await WriteGreeterProtoTreeAsync(protoSourceDirectory);

            var fakeBufDirectory = Path.Combine(tempDirectory, "FakeBuf");
            await WriteFakeBufAsync(fakeBufDirectory);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var outputDirectory = Path.Combine(tempDirectory, "Generated");
            var environment = new Dictionary<string, string>(StringComparer.Ordinal)
            {
                ["AUTOSDK_FAKE_BUF_SOURCE"] = protoSourceDirectory,
                ["PATH"] = string.Join(
                    Path.PathSeparator,
                    new[]
                    {
                        fakeBufDirectory,
                        Environment.GetEnvironmentVariable("PATH") ?? string.Empty,
                    }),
            };

            var result = await RunDotnetAsync(
                repositoryDirectory,
                environment,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate",
                "buf.build/acme/petapis:main",
                "--targetFramework", "net10.0",
                "--output", outputDirectory);

            result.ExitCode.Should().Be(0);
            result.StandardError.Should().BeNullOrWhiteSpace();

            var csprojPath = Path.Combine(outputDirectory, "Petapis.Grpc.csproj");
            File.Exists(csprojPath).Should().BeTrue();
            File.Exists(Path.Combine(outputDirectory, "README.md")).Should().BeTrue();
            File.Exists(Path.Combine(outputDirectory, "Protos", "greeter.proto")).Should().BeTrue();
            File.Exists(Path.Combine(outputDirectory, "Protos", "messages", "common.proto")).Should().BeTrue();
            AssertAutoSdkGrpcSupportFilesExist(outputDirectory);

            var csprojText = await File.ReadAllTextAsync(csprojPath);
            csprojText.Should().Contain("Grpc.Tools");
            csprojText.Should().Contain("<RootNamespace>Demo.Grpc</RootNamespace>");
            csprojText.Should().Contain("Microsoft.Extensions.DependencyInjection.Abstractions");

            var buildResult = await RunDotnetAsync(
                outputDirectory,
                environment,
                "build",
                "--disable-build-servers",
                csprojPath);
            buildResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_OpenApiAndProtoInput_ProducesMixedModeLayout()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var openApiPath = Path.Combine(tempDirectory, "demo.yaml");
            await File.WriteAllTextAsync(
                openApiPath,
                """
                openapi: 3.0.3
                info:
                  title: Demo
                  version: 1.0.0
                paths:
                  /hello:
                    get:
                      operationId: getHello
                      responses:
                        '200':
                          description: ok
                          content:
                            application/json:
                              schema:
                                type: object
                                properties:
                                  message:
                                    type: string
                """);

            await WriteGreeterProtoTreeAsync(tempDirectory);
            var protoPath = Path.Combine(tempDirectory, "greeter.proto");

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var outputDirectory = Path.Combine(tempDirectory, "Generated");
            var result = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate",
                openApiPath,
                "--grpc-input", protoPath,
                "--api-output-subdirectory", "rest-sdk",
                "--grpc-output-subdirectory", "grpc-sdk",
                "--namespace", "Demo.Mixed",
                "--targetFramework", "net10.0",
                "--output", outputDirectory);

            result.ExitCode.Should().Be(0);
            result.StandardError.Should().BeNullOrWhiteSpace();

            var readmePath = Path.Combine(outputDirectory, "README.md");
            var apiOutputDirectory = Path.Combine(outputDirectory, "rest-sdk");
            var grpcProjectDirectory = Path.Combine(outputDirectory, "grpc-sdk", "Greeter");
            var grpcProjectPath = Path.Combine(grpcProjectDirectory, "Greeter.Grpc.csproj");

            File.Exists(readmePath).Should().BeTrue();
            Directory.Exists(apiOutputDirectory).Should().BeTrue();
            Directory.Exists(grpcProjectDirectory).Should().BeTrue();
            File.Exists(grpcProjectPath).Should().BeTrue();
            Directory.EnumerateFiles(apiOutputDirectory, "*.cs", SearchOption.AllDirectories).Should().NotBeEmpty();
            AssertAutoSdkGrpcSupportFilesExist(grpcProjectDirectory);

            var readmeText = await File.ReadAllTextAsync(readmePath);
            readmeText.Should().Contain("rest-sdk");
            readmeText.Should().Contain("grpc-sdk/Greeter");

            var buildResult = await RunDotnetAsync(
                grpcProjectDirectory,
                "build",
                "--disable-build-servers",
                grpcProjectPath);
            buildResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Cli_ProtoInput_ShowsGrpcNotSupportedMessage()
    {
        await AssertProtoInputShowsGrpcNotSupportedMessageAsync(
            "cli",
            "--output", "Generated");
    }

    [TestMethod]
    public async Task Http_ProtoInput_ShowsGrpcNotSupportedMessage()
    {
        await AssertProtoInputShowsGrpcNotSupportedMessageAsync(
            "http",
            "--output", "Generated");
    }

    [TestMethod]
    public async Task Generate_BraintrustSdk()
    {
        await GenerateAsync("braintrust.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_BraveSearchSdk()
    {
        await GenerateAsync("bravesearch.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_BrowserbaseSdk()
    {
        await GenerateAsync("browserbase.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_CartesiaSdk()
    {
        await GenerateAsync("cartesia.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_ChromaSdk()
    {
        await GenerateAsync("chroma.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_ComposioSdk()
    {
        await GenerateAsync("composio.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_CozeSdk()
    {
        await GenerateAsync("coze.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_CursorAgentsSdk()
    {
        await GenerateAsync("cursoragents.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_DeepLSdk()
    {
        await GenerateAsync("deepl.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_DescriptSdk()
    {
        await GenerateAsync("descript.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_DIdSdk()
    {
        await GenerateAsync("did.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_DoclingServeSdk()
    {
        await GenerateAsync("doclingserve.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_E2BSdk()
    {
        await GenerateAsync("e2b.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_ExaSdk()
    {
        await GenerateAsync("exa.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_FalSdk()
    {
        await GenerateAsync("fal.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_FirecrawlSdk()
    {
        await GenerateAsync("firecrawl.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_FishAudioSdk()
    {
        await GenerateAsync("fishaudio.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_FlowiseSdk()
    {
        await GenerateAsync("flowise.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_ForemSdk()
    {
        await GenerateAsync("forem.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_GladiaSdk()
    {
        await GenerateAsync("gladia.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_GoogleGeminiDiscoverySdk()
    {
        await GenerateAsync("google-gemini-discovery.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_GroqSdk()
    {
        await GenerateAsync("groq.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_GroundXSdk()
    {
        await GenerateAsync("groundx.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_GuardrailsSdk()
    {
        await GenerateAsync("guardrails.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_HedraSdk()
    {
        await GenerateAsync("hedra.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_HeliconeSdk()
    {
        await GenerateAsync("helicone.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_HumanloopSdk()
    {
        await GenerateAsync("humanloop.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_HumeAISdk()
    {
        await GenerateAsync("humeai.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_KlingAISdk()
    {
        await GenerateAsync("klingai.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_LabelStudioSdk()
    {
        await GenerateAsync("labelstudio.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_LakeraSdk()
    {
        await GenerateAsync("lakera.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_LangfuseSdk()
    {
        await GenerateAsync("langfuse.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_LettaSdk()
    {
        await GenerateAsync("letta.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_LlamaParseSdk()
    {
        await GenerateAsync("llamaparse.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_Mem0Sdk()
    {
        await GenerateAsync("mem0.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_MeshcapadeSdk()
    {
        await GenerateAsync("meshcapade.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_MeshySdk()
    {
        await GenerateAsync("meshy.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_MilvusSdk()
    {
        await GenerateAsync("milvus.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_MixedbreadSdk()
    {
        await GenerateAsync("mixedbread.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_MurfSdk()
    {
        await GenerateAsync("murf.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_NanonetsSdk()
    {
        await GenerateAsync("nanonets.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_NightfallAISdk()
    {
        await GenerateAsync("nightfallai.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_NixtlaSdk()
    {
        await GenerateAsync("nixtla.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_OpenRouterSdk()
    {
        await GenerateAsync("openrouter.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_OpikSdk()
    {
        await GenerateAsync("opik.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_PhoenixSdk()
    {
        await GenerateAsync("phoenix.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_PhotoroomSdk()
    {
        await GenerateAsync("photoroom.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_PortkeySdk()
    {
        await GenerateAsync("portkey.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_PredictionGuardSdk()
    {
        await GenerateAsync("predictionguard.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_PromptLayerSdk()
    {
        await GenerateAsync("promptlayer.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_QdrantSdk()
    {
        await GenerateAsync("qdrant.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_RekaSdk()
    {
        await GenerateAsync("reka.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_RetellAISdk()
    {
        await GenerateAsync("retellai.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_RevAISdk()
    {
        await GenerateAsync("revai.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_RoboflowSdk()
    {
        await GenerateAsync("roboflow.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_SarvamAISdk()
    {
        await GenerateAsync("sarvamai.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_SerperSdk()
    {
        await GenerateAsync("serper.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_ShotstackSdk()
    {
        await GenerateAsync("shotstack.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_SpeechmaticsSdk()
    {
        await GenerateAsync("speechmatics.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_StabilityAISdk()
    {
        await GenerateAsync("stabilityai.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_SynthesiaSdk()
    {
        await GenerateAsync("synthesia.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_TavilySdk()
    {
        await GenerateAsync("tavily.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_TavusSdk()
    {
        await GenerateAsync("tavus.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_TripoSdk()
    {
        await GenerateAsync("tripo.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_TurbopufferSdk()
    {
        await GenerateAsync("turbopuffer.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_TwelveLabsSdk()
    {
        await GenerateAsync("twelvelabs.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_UpstageSdk()
    {
        await GenerateAsync("upstage.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_VapiSdk()
    {
        await GenerateAsync("vapi.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_VoyageAISdk()
    {
        await GenerateAsync("voyageai.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_WeaveSdk()
    {
        await GenerateAsync("weave.json", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_WriterSdk()
    {
        await GenerateAsync("writer.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_WeaviateSdk()
    {
        await GenerateAsync("weaviate.yaml", targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_CohereSdk()
    {
        await GenerateAsync(
            "cohere.yaml",
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedFiles = Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories).ToArray();
                var chatInterface = await ReadRequiredGeneratedFileAsync(generatedFiles, "Oag.ICohereClient.Chat.g.cs");
                var chatStreamInterface = await ReadRequiredGeneratedFileAsync(generatedFiles, "Oag.ICohereClient.ChatAsStream.g.cs");
                var chatStreamClient = await ReadRequiredGeneratedFileAsync(generatedFiles, "Oag.CohereClient.ChatAsStream.g.cs");
                var v2Interface = await ReadRequiredGeneratedFileAsync(generatedFiles, "Oag.IV2Client.Chat2.g.cs");
                var v2StreamInterface = await ReadRequiredGeneratedFileAsync(generatedFiles, "Oag.IV2Client.Chat2AsStream.g.cs");
                var v2StreamClient = await ReadRequiredGeneratedFileAsync(generatedFiles, "Oag.V2Client.Chat2AsStream.g.cs");
                var finetuningInterface = await ReadRequiredGeneratedFileAsync(generatedFiles, "Oag.IFinetuningClient.UpdateFinetunedModel.g.cs");
                var finetuningClient = await ReadRequiredGeneratedFileAsync(generatedFiles, "Oag.FinetuningClient.UpdateFinetunedModel.g.cs");

                chatInterface.Should().Contain("Task<global::Oag.NonStreamedChatResponse> ChatAsync(");
                chatInterface.Should().NotContain("OneOf<global::Oag.NonStreamedChatResponse, global::Oag.StreamedChatResponse");
                chatStreamInterface.Should().Contain("IAsyncEnumerable<global::Oag.StreamedChatResponse> ChatAsStreamAsync(");
                chatStreamInterface.Should().NotContain("OneOf<global::Oag.NonStreamedChatResponse, global::Oag.StreamedChatResponse");

                chatStreamClient.Should().Contain("yield return __streamedResponse;");
                chatStreamClient.Should().Contain("ReadLineAsync()");

                v2Interface.Should().Contain("Task<global::Oag.ChatResponse> Chat2Async(");
                v2Interface.Should().NotContain("OneOf<global::Oag.ChatResponse, global::Oag.StreamedChatResponseV2");
                v2StreamInterface.Should().Contain("IAsyncEnumerable<global::Oag.StreamedChatResponseV2> Chat2AsStreamAsync(");
                v2StreamInterface.Should().NotContain("OneOf<global::Oag.ChatResponse, global::Oag.StreamedChatResponseV2");

                v2StreamClient.Should().Contain("SseParser");
                v2StreamClient.Should().Contain("yield return __streamedResponse;");

                generatedFiles.Should().Contain(path => Path.GetFileName(path) == "Oag.Models.FinetuningUpdateFinetunedModelRequest.g.cs");
                generatedFiles.Should().NotContain(path => Path.GetFileName(path) == "Oag.Models.UpdateFinetunedModelRequest.g.cs");
                finetuningInterface.Should().Contain("global::Oag.FinetuningUpdateFinetunedModelRequest request");
                finetuningInterface.Should().NotContain("global::Oag.UpdateFinetunedModelRequest request");
                finetuningClient.Should().Contain("var __request = new global::Oag.FinetuningUpdateFinetunedModelRequest");
                finetuningClient.Should().NotContain("var __request = new global::Oag.UpdateFinetunedModelRequest");
            });
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
    public async Task Generate_WithEnvironmentFactoryOptions_BuildsAndUpdatesSnippets()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Env Auth
  version: 1.0.0
paths:
  /test:
    get:
      operationId: getTest
      security:
        - apiKeyAuth: []
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  ok:
                    type: boolean
                example:
                  ok: true
components:
  securitySchemes:
    apiKeyAuth:
      type: apiKey
      in: header
      name: X-Custom-Key
""";

        await GenerateFromContentAsync(
            fileName: "env-auth.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "Env",
            clientClassName: "EnvClient",
            expectedGeneratedFile: "Env.EnvClient.Constructors.ApiKeyInHeader.g.cs",
            assertGeneratedOutput: async outputDirectory =>
            {
                var constructorFile = Path.Combine(outputDirectory, "Env.EnvClient.Constructors.ApiKeyInHeader.g.cs");
                var constructorContent = await File.ReadAllTextAsync(constructorFile);
                constructorContent.Should().Contain("public static EnvClient CreateFromEnvironment(");
                constructorContent.Should().Contain("public static bool TryCreateFromEnvironment(");
                constructorContent.Should().Contain("\"PRIMARY_API_KEY\"");
                constructorContent.Should().Contain("\"SECONDARY_API_KEY\"");
                constructorContent.Should().Contain("\"PRIMARY_BASE_URL\"");
                constructorContent.Should().Contain("\"SECONDARY_BASE_URL\"");
                constructorContent.Should().Contain("client.AuthorizeUsingApiKeyInHeader(apiKey);");

                var snippetsFile = Path.Combine(outputDirectory, "autosdk.generated-examples.json");
                File.Exists(snippetsFile).Should().BeTrue();
                var snippetsContent = await File.ReadAllTextAsync(snippetsFile);
                snippetsContent.Should().Contain("using var client = EnvClient.CreateFromEnvironment();");
            },
            additionalArguments:
            [
                "--auth-env-var", "PRIMARY_API_KEY",
                "--api-key-env", "SECONDARY_API_KEY",
                "--base-url-env", "PRIMARY_BASE_URL",
                "--base-url-env-var", "SECONDARY_BASE_URL",
            ]);
    }

    [TestMethod]
    public async Task Generate_WithRawModelData_BuildsTypedExtensionDataHelpers()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Raw Model Data
  version: 1.0.0
paths:
  /models/{id}:
    get:
      operationId: getModel
      parameters:
        - in: path
          name: id
          required: true
          schema:
            type: string
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/ClosedModel'
components:
  schemas:
    ClosedModel:
      type: object
      additionalProperties: false
      properties:
        name:
          type: string
""";

        await GenerateFromContentAsync(
            fileName: "raw-model-data.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "Raw",
            clientClassName: "RawClient",
            assertGeneratedOutput: async outputDirectory =>
            {
                var modelFile = Path.Combine(outputDirectory, "Raw.Models.ClosedModel.g.cs");
                var modelContent = await File.ReadAllTextAsync(modelFile);
                modelContent.Should().Contain("IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties");
                modelContent.Should().Contain("Raw JSON properties that are not explicitly defined in the schema");

                var jsonFile = Path.Combine(outputDirectory, "Raw.Models.ClosedModel.Json.g.cs");
                var jsonContent = await File.ReadAllTextAsync(jsonFile);
                jsonContent.Should().Contain("FromRawUnchecked(");
                jsonContent.Should().Contain("ToRawJson(");

                await File.WriteAllTextAsync(
                    Path.Combine(outputDirectory, "RawModelConsumer.cs"),
                    """
                    #nullable enable

                    namespace Raw;

                    internal static class RawModelConsumer
                    {
                        public static string ReadUnknownProperty()
                        {
                            var model = ClosedModel.FromRawUnchecked(
                                "{\"name\":\"Ada\",\"unknown\":{\"nested\":true}}",
                                SourceGenerationContext.Default)!;

                            return model.AdditionalProperties["unknown"]
                                .GetProperty("nested")
                                .GetRawText();
                        }
                    }
                    """);
            },
            additionalArguments: ["--generate-raw-model-data"]);
    }

    [TestMethod]
    public async Task Generate_WithWebhookVerifier_RunsReplicateStyleVerificationCases()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Webhook Verifier
  version: 1.0.0
paths:
  /ping:
    get:
      operationId: ping
      responses:
        '204':
          description: OK
""";

        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var specPath = Path.Combine(tempDirectory, "webhook.yaml");
        var outputDirectory = Path.Combine(tempDirectory, "Generated");

        try
        {
            Directory.CreateDirectory(tempDirectory);
            await File.WriteAllTextAsync(specPath, spec);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath,
                "--namespace", "Hooks",
                "--clientClassName", "HooksClient",
                "--targetFramework", "net10.0",
                "--output", outputDirectory,
                "--generate-webhook-verifier",
                "--webhook-verifier-class-name", "HooksWebhookVerifier");
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var verifierFile = Path.Combine(outputDirectory, "Hooks.HooksWebhookVerifier.g.cs");
            File.Exists(verifierFile).Should().BeTrue();
            var verifierContent = await File.ReadAllTextAsync(verifierFile);
            verifierContent.Should().Contain("WebhookVerificationError.MalformedSignature");
            verifierContent.Should().Contain("WebhookVerificationError.InvalidSignature");

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "HooksVerifierConsumer.csproj"), """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <OutputType>Exe</OutputType>
                    <TargetFramework>net10.0</TargetFramework>
                    <LangVersion>preview</LangVersion>
                    <Nullable>enable</Nullable>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
                    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
                  </PropertyGroup>
                  <ItemGroup>
                    <Compile Include="Hooks.HooksWebhookVerifier.g.cs" />
                    <Compile Include="Program.cs" />
                  </ItemGroup>
                </Project>
                """);

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "Program.cs"), """
                using System.Net.Http;
                using System.Security.Cryptography;
                using System.Text;
                using Hooks;

                const string secret = "whsec_d2hzZWNfdGVzdA==";
                const string payload = "{\"ok\":true}";
                const string id = "msg_123";
                const long timestamp = 1700000000;

                var verifier = new HooksWebhookVerifier(secret);
                verifier.Clock = () => DateTimeOffset.FromUnixTimeSeconds(timestamp).AddSeconds(1);

                var signature = Sign(secret, id, timestamp.ToString(System.Globalization.CultureInfo.InvariantCulture), payload);
                var validHeaders = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    [HooksWebhookVerifier.IdHeaderName] = id,
                    [HooksWebhookVerifier.TimestampHeaderName] = timestamp.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    [HooksWebhookVerifier.SignatureHeaderName] = "v0,ignored v1," + signature,
                };

                Require(verifier.Verify(validHeaders, payload).IsValid, "valid dictionary signature");
                verifier.VerifyOrThrow(validHeaders, Encoding.UTF8.GetBytes(payload));

                using var request = new HttpRequestMessage(HttpMethod.Post, "https://example.test/webhook");
                request.Headers.TryAddWithoutValidation(HooksWebhookVerifier.IdHeaderName, id);
                request.Headers.TryAddWithoutValidation(HooksWebhookVerifier.TimestampHeaderName, timestamp.ToString(System.Globalization.CultureInfo.InvariantCulture));
                request.Headers.TryAddWithoutValidation(HooksWebhookVerifier.SignatureHeaderName, "v1," + signature);
                Require(verifier.Verify(request, payload).IsValid, "valid request signature");

                var missingSignature = new Dictionary<string, string>(validHeaders, StringComparer.OrdinalIgnoreCase);
                missingSignature.Remove(HooksWebhookVerifier.SignatureHeaderName);
                RequireError(verifier.Verify(missingSignature, payload), WebhookVerificationError.MissingHeader, "missing signature");

                verifier.Clock = () => DateTimeOffset.FromUnixTimeSeconds(timestamp).AddSeconds(600);
                RequireError(verifier.Verify(validHeaders, payload), WebhookVerificationError.StaleTimestamp, "stale timestamp");
                verifier.Clock = () => DateTimeOffset.FromUnixTimeSeconds(timestamp).AddSeconds(1);

                var malformedSignature = new Dictionary<string, string>(validHeaders, StringComparer.OrdinalIgnoreCase)
                {
                    [HooksWebhookVerifier.SignatureHeaderName] = "v1,not-base64",
                };
                RequireError(verifier.Verify(malformedSignature, payload), WebhookVerificationError.MalformedSignature, "malformed signature");

                var invalidSignature = new Dictionary<string, string>(validHeaders, StringComparer.OrdinalIgnoreCase)
                {
                    [HooksWebhookVerifier.SignatureHeaderName] = "v1," + Convert.ToBase64String(Encoding.UTF8.GetBytes("wrong")),
                };
                RequireError(verifier.Verify(invalidSignature, payload), WebhookVerificationError.InvalidSignature, "invalid signature");

                var malformedTimestamp = new Dictionary<string, string>(validHeaders, StringComparer.OrdinalIgnoreCase)
                {
                    [HooksWebhookVerifier.TimestampHeaderName] = "not-a-timestamp",
                };
                RequireError(verifier.Verify(malformedTimestamp, payload), WebhookVerificationError.MalformedTimestamp, "malformed timestamp");

                static string Sign(string secret, string id, string timestamp, string payload)
                {
                    var secretBytes = Convert.FromBase64String(secret.Substring("whsec_".Length));
                    using var hmac = new HMACSHA256(secretBytes);
                    return Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(id + "." + timestamp + "." + payload)));
                }

                static void Require(bool condition, string caseName)
                {
                    if (!condition)
                    {
                        throw new InvalidOperationException(caseName);
                    }
                }

                static void RequireError(WebhookVerificationResult result, WebhookVerificationError expected, string caseName)
                {
                    if (result.IsValid || result.Error != expected)
                    {
                        throw new InvalidOperationException(caseName + ": " + result.Error + " " + result.Message);
                    }
                }
                """);

            var runResult = await RunDotnetAsync(
                outputDirectory,
                "run",
                "--disable-build-servers",
                "--project", Path.Combine(outputDirectory, "HooksVerifierConsumer.csproj"));
            Console.WriteLine(runResult.StandardOutput);
            Console.WriteLine(runResult.StandardError);
            runResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_WithDynamicMultipartHelpers_BuildsComputedAttachmentParts()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Dynamic Multipart Ingestion
  version: 1.0.0
paths:
  /runs/multipart:
    post:
      operationId: ingestRunMultipart
      x-autosdk-dynamic-multipart: true
      requestBody:
        required: true
        content:
          multipart/form-data:
            schema:
              type: object
              additionalProperties:
                type: string
                format: binary
      responses:
        '204':
          description: Accepted
""";

        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var specPath = Path.Combine(tempDirectory, "multipart.yaml");
        var outputDirectory = Path.Combine(tempDirectory, "Generated");

        try
        {
            Directory.CreateDirectory(tempDirectory);
            await File.WriteAllTextAsync(specPath, spec);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath,
                "--namespace", "Ingestion",
                "--clientClassName", "IngestionClient",
                "--targetFramework", "net10.0",
                "--output", outputDirectory,
                "--generate-dynamic-multipart-helpers",
                "--dynamic-multipart-helper-class-name", "TraceMultipartBuilder");
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var helperFile = Path.Combine(outputDirectory, "Ingestion.TraceMultipartBuilder.g.cs");
            File.Exists(helperFile).Should().BeTrue();
            var helperContent = await File.ReadAllTextAsync(helperFile);
            helperContent.Should().Contain("public sealed class TraceMultipartBuilder");
            helperContent.Should().Contain("CreateAttachmentPartName");

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "DynamicMultipartConsumer.csproj"), """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <OutputType>Exe</OutputType>
                    <TargetFramework>net10.0</TargetFramework>
                    <LangVersion>preview</LangVersion>
                    <Nullable>enable</Nullable>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
                    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
                  </PropertyGroup>
                  <ItemGroup>
                    <Compile Include="Ingestion.TraceMultipartBuilder.g.cs" />
                    <Compile Include="Program.cs" />
                  </ItemGroup>
                </Project>
                """);

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "Program.cs"), """
                using System.Text;
                using Ingestion;

                using var builder = new TraceMultipartBuilder();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes("stream-body"));

                builder
                    .AddBytes("run_123", "image", Encoding.UTF8.GetBytes("byte-body"), "image.txt", "text/plain")
                    .AddStream("run_123", "log", stream, "log.txt", "text/plain")
                    .AddExternalUrl("run_123", "external", new Uri("https://example.test/file.txt"));

                Require(builder.Attachments.Count == 3, "attachment count");
                Require(builder.Attachments[0].RunId == "run_123", "run relationship");
                Require(builder.Attachments[0].AttachmentKey == "image", "attachment key");
                Require(builder.Attachments[0].PartName == "run_123.image", "computed byte part");
                Require(builder.Attachments[1].PartName == "run_123.log", "computed stream part");
                Require(builder.Attachments[1].FileName == "log.txt", "stream filename");
                Require(builder.Attachments[2].ContentType == "text/uri-list", "external content type");
                Require(TraceMultipartBuilder.CreatePartName("run_123", "nested", "asset") == "run_123.nested.asset", "nested part name");
                RequireThrows<ArgumentException>(() => TraceMultipartBuilder.CreatePartName("run_123", "bad\"key"), "quoted part segment");

                using var content = builder.Build();
                RequireThrows<InvalidOperationException>(() => builder.AddBytes("run_123", "late", Array.Empty<byte>()), "add after build");

                var body = await content.ReadAsStringAsync();
                Require(content.Headers.ContentType?.MediaType == "multipart/form-data", "multipart content type");
                Require(ContainsDispositionValue(body, "name", "run_123.image"), "byte part name");
                Require(ContainsDispositionValue(body, "filename", "image.txt"), "byte filename");
                Require(body.Contains("byte-body", StringComparison.Ordinal), "byte payload");
                Require(ContainsDispositionValue(body, "name", "run_123.log"), "stream part name");
                Require(body.Contains("stream-body", StringComparison.Ordinal), "stream payload");
                Require(ContainsDispositionValue(body, "name", "run_123.external"), "external part name");
                Require(body.Contains("https://example.test/file.txt", StringComparison.Ordinal), "external payload");

                static void Require(bool condition, string caseName)
                {
                    if (!condition)
                    {
                        throw new InvalidOperationException(caseName);
                    }
                }

                static bool ContainsDispositionValue(string body, string name, string value)
                {
                    return body.Contains(name + "=\"" + value + "\"", StringComparison.Ordinal) ||
                        body.Contains(name + "=" + value, StringComparison.Ordinal);
                }

                static void RequireThrows<TException>(Action action, string caseName)
                    where TException : Exception
                {
                    try
                    {
                        action();
                    }
                    catch (TException)
                    {
                        return;
                    }

                    throw new InvalidOperationException(caseName);
                }
                """);

            var runResult = await RunDotnetAsync(
                outputDirectory,
                "run",
                "--disable-build-servers",
                "--project", Path.Combine(outputDirectory, "DynamicMultipartConsumer.csproj"));
            Console.WriteLine(runResult.StandardOutput);
            Console.WriteLine(runResult.StandardError);
            runResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_WithPromptTemplateHelpers_RendersAndCachesPromptVersions()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Prompt Template Manager
  version: 1.0.0
paths:
  /prompts/{promptId}/versions/{version}:
    get:
      operationId: getPromptVersion
      x-autosdk-prompt-template: true
      parameters:
        - name: promptId
          in: path
          required: true
          schema:
            type: string
        - name: version
          in: path
          required: true
          schema:
            type: string
        - name: environment
          in: query
          schema:
            type: string
      responses:
        '200':
          description: Prompt version
          content:
            application/json:
              schema:
                type: object
                required:
                  - id
                  - body
                  - variables
                properties:
                  id:
                    type: string
                  version:
                    type: string
                  environment:
                    type: string
                  body:
                    type: string
                    example: Hello {{name}}
                  messages:
                    type: array
                    items:
                      type: object
                      required:
                        - role
                        - content
                      properties:
                        role:
                          type: string
                        content:
                          type: string
                  variables:
                    type: object
                    additionalProperties:
                      type: string
                  modelConfig:
                    type: object
                    additionalProperties:
                      type: string
""";

        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var specPath = Path.Combine(tempDirectory, "prompts.yaml");
        var outputDirectory = Path.Combine(tempDirectory, "Generated");

        try
        {
            Directory.CreateDirectory(tempDirectory);
            await File.WriteAllTextAsync(specPath, spec);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath,
                "--namespace", "Prompts",
                "--clientClassName", "PromptsClient",
                "--targetFramework", "net10.0",
                "--output", outputDirectory,
                "--generate-prompt-template-helpers",
                "--prompt-template-helper-class-name", "PromptTemplateManager");
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var helperFile = Path.Combine(outputDirectory, "Prompts.PromptTemplateManager.g.cs");
            File.Exists(helperFile).Should().BeTrue();
            var helperContent = await File.ReadAllTextAsync(helperFile);
            helperContent.Should().Contain("public sealed class PromptTemplateManager");
            helperContent.Should().Contain("RenderMessagesAsync");

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "PromptTemplateConsumer.csproj"), """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <OutputType>Exe</OutputType>
                    <TargetFramework>net10.0</TargetFramework>
                    <LangVersion>preview</LangVersion>
                    <Nullable>enable</Nullable>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
                    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
                  </PropertyGroup>
                  <ItemGroup>
                    <Compile Include="Prompts.PromptTemplateManager.g.cs" />
                    <Compile Include="Program.cs" />
                  </ItemGroup>
                </Project>
                """);

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "Program.cs"), """
                using Prompts;

                var resolverCalls = 0;
                var now = DateTimeOffset.FromUnixTimeSeconds(1700000000);
                var manager = new PromptTemplateManager(
                    (request, cancellationToken) =>
                    {
                        resolverCalls++;
                        Require(request.Id == "support", "request id");
                        Require(request.Version == "v1", "request version");

                        return Task.FromResult(new PromptTemplate(
                            id: request.Id,
                            version: request.Version,
                            environment: request.Environment,
                            body: "Hello {{name}}, {{>signature}} v" + resolverCalls,
                            messages:
                            [
                                new PromptTemplateMessage("system", "You are {{role}}."),
                                new PromptTemplateMessage("user", "Question: {{question}} {{>signature}}"),
                            ],
                            variables: new Dictionary<string, string>(StringComparer.Ordinal)
                            {
                                ["name"] = "Recipient name",
                                ["role"] = "Assistant role",
                                ["question"] = "User question",
                            },
                            metadata: new Dictionary<string, string>(StringComparer.Ordinal)
                            {
                                ["provider"] = "fixture",
                            },
                            modelConfig: new Dictionary<string, string>(StringComparer.Ordinal)
                            {
                                ["model"] = "test-model",
                            }));
                    },
                    cacheTtl: TimeSpan.FromMinutes(5));
                manager.Clock = () => now;

                var variables = new Dictionary<string, string>(StringComparer.Ordinal)
                {
                    ["name"] = "Ada",
                    ["role"] = "assistant",
                    ["question"] = "status?",
                };
                var partials = new Dictionary<string, string>(StringComparer.Ordinal)
                {
                    ["signature"] = "thanks",
                };

                var first = await manager.RenderStringAsync("support", variables, version: "v1", environment: "prod", partials: partials);
                Require(first == "Hello Ada, thanks v1", "string prompt render");
                Require(resolverCalls == 1, "first resolve");

                var second = await manager.RenderStringAsync("support", variables, version: "v1", environment: "prod", partials: partials);
                Require(second == first, "cached string prompt render");
                Require(resolverCalls == 1, "cache hit");

                var refreshed = await manager.RenderStringAsync("support", variables, version: "v1", environment: "prod", partials: partials, refresh: true);
                Require(refreshed == "Hello Ada, thanks v2", "refresh render");
                Require(resolverCalls == 2, "refresh resolve");

                var messages = await manager.RenderMessagesAsync("support", variables, version: "v1", environment: "prod", partials: partials);
                Require(messages.Count == 2, "message count");
                Require(messages[0].Role == "system" && messages[0].Content == "You are assistant.", "system message render");
                Require(messages[1].Role == "user" && messages[1].Content == "Question: status? thanks", "user message render");

                var prompt = await manager.GetPromptVersionAsync("support", "v1", "prod");
                Require(prompt.Metadata["provider"] == "fixture", "metadata preserved");
                Require(prompt.ModelConfig["model"] == "test-model", "model config preserved");
                Require(prompt.Variables.ContainsKey("name"), "variables preserved");

                var missingWasReported = false;
                try
                {
                    await manager.RenderStringAsync(
                        "support",
                        new Dictionary<string, string>(StringComparer.Ordinal),
                        version: "v1",
                        environment: "dev",
                        partials: partials,
                        refresh: true);
                }
                catch (PromptTemplateRenderException ex)
                {
                    missingWasReported = ex.MissingVariables.Contains("name");
                }

                Require(missingWasReported, "missing variable");

                now = now.AddMinutes(6);
                await manager.GetPromptAsync("support", version: "v1", environment: "prod");
                Require(resolverCalls == 4, "expired cache refresh");

                static void Require(bool condition, string caseName)
                {
                    if (!condition)
                    {
                        throw new InvalidOperationException(caseName);
                    }
                }
                """);

            var runResult = await RunDotnetAsync(
                outputDirectory,
                "run",
                "--disable-build-servers",
                "--project", Path.Combine(outputDirectory, "PromptTemplateConsumer.csproj"));
            Console.WriteLine(runResult.StandardOutput);
            Console.WriteLine(runResult.StandardError);
            runResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_WithObservabilityLifecycleHelpers_BatchesFlushesAndShutsDown()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Observability Lifecycle
  version: 1.0.0
paths:
  /traces/batch:
    post:
      operationId: ingestTraceBatch
      x-autosdk-observability-lifecycle: true
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              required:
                - events
              properties:
                events:
                  type: array
                  items:
                    type: object
                    properties:
                      name:
                        type: string
                      eventType:
                        type: string
                      traceId:
                        type: string
                      spanId:
                        type: string
                      body:
                        type: string
                      attributes:
                        type: object
                        additionalProperties:
                          type: string
      responses:
        '202':
          description: Accepted
""";

        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var specPath = Path.Combine(tempDirectory, "telemetry.yaml");
        var outputDirectory = Path.Combine(tempDirectory, "Generated");

        try
        {
            Directory.CreateDirectory(tempDirectory);
            await File.WriteAllTextAsync(specPath, spec);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath,
                "--namespace", "Telemetry",
                "--clientClassName", "TelemetryClient",
                "--targetFramework", "net10.0",
                "--output", outputDirectory,
                "--generate-observability-lifecycle-helpers",
                "--observability-lifecycle-helper-class-name", "TelemetryLifecycle");
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var helperFile = Path.Combine(outputDirectory, "Telemetry.TelemetryLifecycle.g.cs");
            File.Exists(helperFile).Should().BeTrue();
            var helperContent = await File.ReadAllTextAsync(helperFile);
            helperContent.Should().Contain("public sealed class TelemetryLifecycle");
            helperContent.Should().Contain("ObservabilityIngestionOptions");

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "TelemetryLifecycleConsumer.csproj"), """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <OutputType>Exe</OutputType>
                    <TargetFramework>net10.0</TargetFramework>
                    <LangVersion>preview</LangVersion>
                    <Nullable>enable</Nullable>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
                    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
                  </PropertyGroup>
                  <ItemGroup>
                    <Compile Include="Telemetry.TelemetryLifecycle.g.cs" />
                    <Compile Include="Program.cs" />
                  </ItemGroup>
                </Project>
                """);

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "Program.cs"), """
                using Telemetry;

                Environment.SetEnvironmentVariable("AUTOSDK_OBSERVABILITY_BATCH_SIZE", "7");
                Environment.SetEnvironmentVariable("AUTOSDK_OBSERVABILITY_QUEUE_SIZE", "11");
                Environment.SetEnvironmentVariable("AUTOSDK_OBSERVABILITY_FLUSH_INTERVAL_SECONDS", "0");
                Environment.SetEnvironmentVariable("AUTOSDK_OBSERVABILITY_PROJECT", "demo-project");
                Environment.SetEnvironmentVariable("AUTOSDK_OBSERVABILITY_SAMPLING_RATE", "0.5");
                var envOptions = ObservabilityIngestionOptions.FromEnvironment();
                Require(envOptions.BatchSize == 7, "env batch size");
                Require(envOptions.QueueSize == 11, "env queue size");
                Require(envOptions.FlushInterval == TimeSpan.Zero, "env flush interval");
                Require(envOptions.Project == "demo-project", "env project");
                Require(Math.Abs(envOptions.SamplingRate - 0.5) < 0.001, "env sampling rate");

                var batches = new List<IReadOnlyList<ObservabilityIngestionEvent>>();
                var dropped = new List<ObservabilityIngestionEvent>();
                var failed = new List<Exception>();
                var options = new ObservabilityIngestionOptions
                {
                    BatchSize = 10,
                    QueueSize = 2,
                    FlushInterval = TimeSpan.Zero,
                };
                using var lifecycle = new TelemetryLifecycle(
                    (events, cancellationToken) =>
                    {
                        batches.Add(events.ToArray());
                        return Task.CompletedTask;
                    },
                    options);
                lifecycle.EventDropped = dropped.Add;
                lifecycle.FlushFailed = failed.Add;

                Require(lifecycle.EnqueueLog("first", "body-1"), "enqueue first");
                Require(lifecycle.Enqueue(new ObservabilityIngestionEvent(
                    "span-one",
                    eventType: "span",
                    traceId: "trace-1",
                    spanId: "span-1",
                    attributes: new Dictionary<string, string>(StringComparer.Ordinal)
                    {
                        ["http.method"] = "POST",
                    })), "enqueue span");
                Require(!lifecycle.EnqueueLog("dropped", "body-3"), "queue drop");
                Require(dropped.Count == 1, "drop hook");
                Require(lifecycle.QueuedCount == 2, "queued count before flush");

                await lifecycle.FlushAsync();
                Require(batches.Count == 1, "single flush batch");
                Require(batches[0].Count == 2, "flush batch count");
                Require(batches[0][0].EventType == "log", "log event type");
                Require(batches[0][0].Body == "body-1", "log body");
                Require(batches[0][1].TraceId == "trace-1", "trace relationship");
                Require(batches[0][1].Attributes["http.method"] == "POST", "attributes preserved");
                Require(lifecycle.QueuedCount == 0, "queued count after flush");
                Require(failed.Count == 0, "no flush failure");

                var failNextFlush = true;
                var failureHooks = 0;
                using var retryLifecycle = new TelemetryLifecycle(
                    (events, cancellationToken) =>
                    {
                        if (failNextFlush)
                        {
                            failNextFlush = false;
                            throw new InvalidOperationException("ingest failed");
                        }

                        batches.Add(events.ToArray());
                        return Task.CompletedTask;
                    },
                    new ObservabilityIngestionOptions
                    {
                        BatchSize = 10,
                        QueueSize = 5,
                        FlushInterval = TimeSpan.Zero,
                    });
                retryLifecycle.FlushFailed = _ => failureHooks++;
                retryLifecycle.EnqueueException("failure", new InvalidOperationException("boom"));
                try
                {
                    await retryLifecycle.FlushAsync();
                    throw new InvalidOperationException("flush should fail");
                }
                catch (InvalidOperationException ex) when (ex.Message == "ingest failed")
                {
                }

                Require(failureHooks == 1, "flush failure hook");
                Require(retryLifecycle.QueuedCount == 1, "failed batch requeued");
                await retryLifecycle.FlushAsync();
                Require(retryLifecycle.QueuedCount == 0, "requeued batch flushed");

                var shutdownBatches = new List<IReadOnlyList<ObservabilityIngestionEvent>>();
                var shutdownLifecycle = new TelemetryLifecycle(
                    (events, cancellationToken) =>
                    {
                        shutdownBatches.Add(events.ToArray());
                        return Task.CompletedTask;
                    },
                    new ObservabilityIngestionOptions
                    {
                        BatchSize = 10,
                        QueueSize = 10,
                        FlushInterval = TimeSpan.Zero,
                    });
                shutdownLifecycle.EnqueueLog("shutdown-event");
                await shutdownLifecycle.ShutdownAsync();
                Require(shutdownBatches.Count == 1, "shutdown drains queue");
                RequireThrows<InvalidOperationException>(() => shutdownLifecycle.EnqueueLog("after-shutdown"), "enqueue after shutdown");
                shutdownLifecycle.Dispose();

                var sampledDrops = 0;
                using var sampledLifecycle = new TelemetryLifecycle(
                    (events, cancellationToken) => Task.CompletedTask,
                    new ObservabilityIngestionOptions
                    {
                        BatchSize = 10,
                        QueueSize = 10,
                        FlushInterval = TimeSpan.Zero,
                        SamplingRate = 0,
                    });
                sampledLifecycle.EventDropped = _ => sampledDrops++;
                Require(!sampledLifecycle.EnqueueLog("sampled-out"), "sampling drop");
                Require(sampledDrops == 1, "sampling drop hook");

                static void Require(bool condition, string caseName)
                {
                    if (!condition)
                    {
                        throw new InvalidOperationException(caseName);
                    }
                }

                static void RequireThrows<TException>(Action action, string caseName)
                    where TException : Exception
                {
                    try
                    {
                        action();
                    }
                    catch (TException)
                    {
                        return;
                    }

                    throw new InvalidOperationException(caseName);
                }
                """);

            var runResult = await RunDotnetAsync(
                outputDirectory,
                "run",
                "--disable-build-servers",
                "--project", Path.Combine(outputDirectory, "TelemetryLifecycleConsumer.csproj"));
            Console.WriteLine(runResult.StandardOutput);
            Console.WriteLine(runResult.StandardError);
            runResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_WithPredictionWorkflowHelpers_RunsWaitPollFailureTimeoutAndCancelCases()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Prediction Workflows
  version: 1.0.0
paths:
  /predictions:
    post:
      operationId: createPrediction
      x-autosdk-prediction-workflow:
        startOperationId: createPrediction
        statusField: status
        resultField: output
        reloadLink: urls.get
        cancelLink: urls.cancel
      parameters:
        - name: Prefer
          in: header
          schema:
            type: string
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/PredictionRequest'
      responses:
        '201':
          description: Created
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Prediction'
  /predictions/{predictionId}:
    get:
      operationId: getPrediction
      parameters:
        - name: predictionId
          in: path
          required: true
          schema:
            type: string
      responses:
        '200':
          description: Prediction
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Prediction'
  /predictions/{predictionId}/cancel:
    post:
      operationId: cancelPrediction
      parameters:
        - name: predictionId
          in: path
          required: true
          schema:
            type: string
      responses:
        '200':
          description: Canceled prediction
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Prediction'
  /acts/{actorId}/runs:
    post:
      operationId: startActorRun
      x-autosdk-prediction-workflow:
        startOperationId: startActorRun
        statusField: status
        resultField: defaultDatasetId
        waitQueryParameter: waitForFinish
        reloadOperationId: getActorRun
      parameters:
        - name: actorId
          in: path
          required: true
          schema:
            type: string
        - name: waitForFinish
          in: query
          schema:
            type: integer
            format: int32
      responses:
        '201':
          description: Actor run
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/ActorRun'
  /actor-runs/{runId}:
    get:
      operationId: getActorRun
      parameters:
        - name: runId
          in: path
          required: true
          schema:
            type: string
      responses:
        '200':
          description: Actor run
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/ActorRun'
components:
  schemas:
    PredictionRequest:
      type: object
      properties:
        input:
          type: object
          additionalProperties:
            type: string
    Prediction:
      type: object
      required:
        - id
        - status
      properties:
        id:
          type: string
        status:
          type: string
          enum:
            - starting
            - processing
            - succeeded
            - failed
            - canceled
        output:
          type: string
        urls:
          type: object
          properties:
            get:
              type: string
              format: uri
            cancel:
              type: string
              format: uri
            stream:
              type: string
              format: uri
    ActorRun:
      type: object
      properties:
        id:
          type: string
        status:
          type: string
        defaultDatasetId:
          type: string
""";

        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var specPath = Path.Combine(tempDirectory, "predictions.yaml");
        var outputDirectory = Path.Combine(tempDirectory, "Generated");

        try
        {
            Directory.CreateDirectory(tempDirectory);
            await File.WriteAllTextAsync(specPath, spec);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath,
                "--namespace", "Jobs",
                "--clientClassName", "JobsClient",
                "--targetFramework", "net10.0",
                "--output", outputDirectory,
                "--generate-prediction-workflow-helpers",
                "--prediction-workflow-helper-class-name", "PredictionWorkflowRunner");
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var helperFile = Path.Combine(outputDirectory, "Jobs.PredictionWorkflowRunner.g.cs");
            File.Exists(helperFile).Should().BeTrue();
            var helperContent = await File.ReadAllTextAsync(helperFile);
            helperContent.Should().Contain("public sealed class PredictionWorkflowRunner");
            helperContent.Should().Contain("PredictionWorkflowMetadata");
            Directory.GetFiles(outputDirectory, "*.g.cs")
                .Select(Path.GetFileName)
                .Any(static name => name?.Contains("CreatePrediction", StringComparison.Ordinal) == true)
                .Should().BeTrue("raw create endpoint generation remains additive");
            Directory.GetFiles(outputDirectory, "*.g.cs")
                .Select(Path.GetFileName)
                .Any(static name => name?.Contains("GetPrediction", StringComparison.Ordinal) == true)
                .Should().BeTrue("raw reload endpoint generation remains additive");

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "PredictionWorkflowConsumer.csproj"), """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <OutputType>Exe</OutputType>
                    <TargetFramework>net10.0</TargetFramework>
                    <LangVersion>preview</LangVersion>
                    <Nullable>enable</Nullable>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
                    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
                  </PropertyGroup>
                  <ItemGroup>
                    <Compile Include="Jobs.PredictionWorkflowRunner.g.cs" />
                    <Compile Include="Program.cs" />
                  </ItemGroup>
                </Project>
                """);

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "Program.cs"), """
                using Jobs;

                var metadata = new PredictionWorkflowMetadata
                {
                    StartOperationId = "createPrediction",
                    ReloadOperationId = "getPrediction",
                    CancelOperationId = "cancelPrediction",
                    WaitQueryParameterName = "waitForFinish",
                    ResultPropertyName = "output",
                };
                metadata.SuccessStatuses.Clear();
                metadata.SuccessStatuses.Add("ready");
                var metadataOptions = metadata.CreateOptions();
                Require(metadataOptions.SuccessStatuses.Contains("ready"), "metadata success status");
                Require(metadataOptions.PreferWaitHeaderValue == "wait", "metadata wait header");

                var options = new PredictionWorkflowOptions
                {
                    PollInterval = TimeSpan.Zero,
                    Timeout = TimeSpan.FromSeconds(5),
                };

                var immediateRunner = new PredictionWorkflowRunner<string, PredictionEnvelope, string>(
                    createAsync: (request, cancellationToken) => Task.FromResult(new PredictionEnvelope("immediate", "succeeded", "done")),
                    reloadAsync: (envelope, cancellationToken) => throw new InvalidOperationException("immediate success should not reload"),
                    resultSelector: envelope => envelope.Output,
                    statusSelector: envelope => envelope.Status,
                    options: options);
                var immediate = await immediateRunner.RunAsync("cat");
                Require(immediate.Result == "done", "immediate result projection");
                Require(immediate.CompletedSynchronously, "immediate sync completion");
                Require(immediate.PollCount == 0, "immediate poll count");
                Require((await immediateRunner.RunForResultAsync("cat")) == "done", "run for result");
                Require((await immediateRunner.CreateAndWaitForEnvelopeAsync("cat")).Id == "immediate", "create and wait envelope");

                var reloads = new Queue<PredictionEnvelope>(new[]
                {
                    new PredictionEnvelope("polling", "processing", ""),
                    new PredictionEnvelope("polling", "succeeded", "polled-output"),
                });
                var pollingRunner = new PredictionWorkflowRunner<string, PredictionEnvelope, string>(
                    createAsync: (request, cancellationToken) => Task.FromResult(new PredictionEnvelope("polling", "starting", "")),
                    reloadAsync: (envelope, cancellationToken) => Task.FromResult(reloads.Dequeue()),
                    resultSelector: envelope => envelope.Output,
                    statusSelector: envelope => envelope.Status,
                    options: options);
                var polled = await pollingRunner.RunAsync("cat");
                Require(polled.Result == "polled-output", "polling result projection");
                Require(!polled.CompletedSynchronously, "polling async completion");
                Require(polled.PollCount == 2, "polling reload count");

                var failedRunner = new PredictionWorkflowRunner<string, PredictionEnvelope, string>(
                    createAsync: (request, cancellationToken) => Task.FromResult(new PredictionEnvelope("failed", "failed", "")),
                    reloadAsync: (envelope, cancellationToken) => throw new InvalidOperationException("failed state should not reload"),
                    resultSelector: envelope => envelope.Output,
                    statusSelector: envelope => envelope.Status,
                    options: options);
                var failedWasRaised = false;
                try
                {
                    await failedRunner.RunAsync("cat");
                }
                catch (PredictionWorkflowException ex) when (ex.Status == "failed" && ex.Envelope is PredictionEnvelope)
                {
                    failedWasRaised = true;
                }
                Require(failedWasRaised, "failed terminal exception");

                var timeoutRunner = new PredictionWorkflowRunner<string, PredictionEnvelope, string>(
                    createAsync: (request, cancellationToken) => Task.FromResult(new PredictionEnvelope("timeout", "processing", "")),
                    reloadAsync: (envelope, cancellationToken) => Task.FromResult(envelope),
                    resultSelector: envelope => envelope.Output,
                    statusSelector: envelope => envelope.Status,
                    options: new PredictionWorkflowOptions
                    {
                        PollInterval = TimeSpan.FromMilliseconds(5),
                        Timeout = TimeSpan.FromMilliseconds(1),
                    });
                var timeoutWasRaised = false;
                try
                {
                    await timeoutRunner.RunAsync("cat");
                }
                catch (PredictionWorkflowTimeoutException ex) when (ex.LastStatus == "processing" && ex.LastEnvelope is PredictionEnvelope)
                {
                    timeoutWasRaised = true;
                }
                Require(timeoutWasRaised, "processing timeout");

                using var cts = new CancellationTokenSource();
                var cancelCalled = false;
                var reloadCalls = 0;
                var cancelRunner = new PredictionWorkflowRunner<string, PredictionEnvelope, string>(
                    createAsync: (request, cancellationToken) => Task.FromResult(new PredictionEnvelope("cancel", "processing", "")),
                    reloadAsync: async (envelope, cancellationToken) =>
                    {
                        reloadCalls++;
                        cts.Cancel();
                        await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
                        return envelope;
                    },
                    resultSelector: envelope => envelope.Output,
                    statusSelector: envelope => envelope.Status,
                    cancelAsync: (envelope, cancellationToken) =>
                    {
                        cancelCalled = envelope.Id == "cancel";
                        return Task.CompletedTask;
                    },
                    options: options);
                var cancellationWasRaised = false;
                try
                {
                    await cancelRunner.RunAsync("cat", cancelOnCancellation: true, cancellationToken: cts.Token);
                }
                catch (OperationCanceledException)
                {
                    cancellationWasRaised = true;
                }
                Require(cancellationWasRaised, "operation cancellation");
                Require(cancelCalled, "cancel link delegate invoked");
                Require(reloadCalls == 1, "cancel reload count");

                var resourceCancelCalled = false;
                var actions = new PredictionResourceActions<PredictionEnvelope>(
                    reloadAsync: (envelope, cancellationToken) => Task.FromResult(envelope with { Status = "succeeded" }),
                    cancelAsync: (envelope, cancellationToken) =>
                    {
                        resourceCancelCalled = envelope.Id == "resource";
                        return Task.CompletedTask;
                    });
                var reloaded = await actions.ReloadAsync(new PredictionEnvelope("resource", "processing", ""));
                Require(reloaded.Status == "succeeded", "resource reload action");
                await actions.CancelAsync(new PredictionEnvelope("resource", "processing", ""));
                Require(resourceCancelCalled, "resource cancel action");

                static void Require(bool condition, string caseName)
                {
                    if (!condition)
                    {
                        throw new InvalidOperationException(caseName);
                    }
                }

                internal sealed record PredictionEnvelope(string Id, string Status, string Output);
                """);

            var runResult = await RunDotnetAsync(
                outputDirectory,
                "run",
                "--disable-build-servers",
                "--project", Path.Combine(outputDirectory, "PredictionWorkflowConsumer.csproj"));
            Console.WriteLine(runResult.StandardOutput);
            Console.WriteLine(runResult.StandardError);
            runResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_WithEvaluationWorkflowHelpers_RunsDatasetScoringFailuresAndBatchPublishCases()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Evaluation Workflows
  version: 1.0.0
paths:
  /datasets/{datasetId}/items:
    get:
      operationId: listDatasetItems
      x-autosdk-evaluation-workflow:
        datasetItemsOperationId: listDatasetItems
        createExperimentOperationId: createExperiment
        createExperimentItemsOperationId: batchCreateExperimentItems
        batchCreateScoresOperationId: batchCreateScores
      parameters:
        - name: datasetId
          in: path
          required: true
          schema:
            type: string
        - name: cursor
          in: query
          schema:
            type: string
      responses:
        '200':
          description: Dataset items
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/DatasetItemPage'
          links:
            createExperiment:
              operationId: createExperiment
  /experiments:
    post:
      operationId: createExperiment
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/CreateExperimentRequest'
      responses:
        '201':
          description: Experiment
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Experiment'
          links:
            createItems:
              operationId: batchCreateExperimentItems
              parameters:
                experimentId: $response.body#/id
  /experiments/{experimentId}/items:
    post:
      operationId: batchCreateExperimentItems
      parameters:
        - name: experimentId
          in: path
          required: true
          schema:
            type: string
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/ExperimentItemBatch'
      responses:
        '202':
          description: Accepted
          links:
            createScores:
              operationId: batchCreateScores
              parameters:
                experimentId: $request.path.experimentId
  /experiments/{experimentId}/scores:
    post:
      operationId: batchCreateScores
      parameters:
        - name: experimentId
          in: path
          required: true
          schema:
            type: string
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/ScoreBatch'
      responses:
        '202':
          description: Accepted
  /feedback/batch:
    post:
      operationId: batchCreateFeedback
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/FeedbackBatch'
      responses:
        '202':
          description: Accepted
components:
  schemas:
    DatasetItemPage:
      type: object
      properties:
        items:
          type: array
          items:
            $ref: '#/components/schemas/DatasetItem'
        nextCursor:
          type: string
    DatasetItem:
      type: object
      required:
        - id
        - input
      properties:
        id:
          type: string
        input:
          type: string
        expected:
          type: string
    CreateExperimentRequest:
      type: object
      properties:
        name:
          type: string
        datasetId:
          type: string
    Experiment:
      type: object
      required:
        - id
      properties:
        id:
          type: string
        name:
          type: string
    ExperimentItemBatch:
      type: object
      properties:
        items:
          type: array
          items:
            type: object
            properties:
              datasetItemId:
                type: string
              output:
                type: string
              traceId:
                type: string
              spanId:
                type: string
              runId:
                type: string
    ScoreBatch:
      type: object
      properties:
        scores:
          type: array
          items:
            $ref: '#/components/schemas/Score'
    Score:
      type: object
      properties:
        name:
          type: string
        value:
          type: number
          format: double
        label:
          type: string
        traceId:
          type: string
        runId:
          type: string
    FeedbackBatch:
      type: object
      properties:
        feedback:
          type: array
          items:
            type: object
            properties:
              traceId:
                type: string
              comment:
                type: string
""";

        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        var specPath = Path.Combine(tempDirectory, "evaluations.yaml");
        var outputDirectory = Path.Combine(tempDirectory, "Generated");

        try
        {
            Directory.CreateDirectory(tempDirectory);
            await File.WriteAllTextAsync(specPath, spec);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));

            var generateResult = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "generate", specPath,
                "--namespace", "Evaluations",
                "--clientClassName", "EvaluationsClient",
                "--targetFramework", "net10.0",
                "--output", outputDirectory,
                "--generate-evaluation-workflow-helpers",
                "--evaluation-workflow-helper-class-name", "DatasetEvaluationRunner");
            Console.WriteLine(generateResult.StandardOutput);
            Console.WriteLine(generateResult.StandardError);
            generateResult.ExitCode.Should().Be(0);

            var helperFile = Path.Combine(outputDirectory, "Evaluations.DatasetEvaluationRunner.g.cs");
            File.Exists(helperFile).Should().BeTrue();
            var helperContent = await File.ReadAllTextAsync(helperFile);
            helperContent.Should().Contain("public sealed class DatasetEvaluationRunner");
            helperContent.Should().Contain("EvaluationWorkflowMetadata");
            Directory.GetFiles(outputDirectory, "*.g.cs")
                .Select(Path.GetFileName)
                .Any(static name => name?.Contains("ListDatasetItems", StringComparison.Ordinal) == true)
                .Should().BeTrue("raw dataset listing generation remains additive");
            Directory.GetFiles(outputDirectory, "*.g.cs")
                .Select(Path.GetFileName)
                .Any(static name => name?.Contains("BatchCreateScores", StringComparison.Ordinal) == true)
                .Should().BeTrue("raw score batch generation remains additive");

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "EvaluationWorkflowConsumer.csproj"), """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <OutputType>Exe</OutputType>
                    <TargetFramework>net10.0</TargetFramework>
                    <LangVersion>preview</LangVersion>
                    <Nullable>enable</Nullable>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
                    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
                  </PropertyGroup>
                  <ItemGroup>
                    <Compile Include="Evaluations.DatasetEvaluationRunner.g.cs" />
                    <Compile Include="Program.cs" />
                  </ItemGroup>
                </Project>
                """);

            await File.WriteAllTextAsync(Path.Combine(outputDirectory, "Program.cs"), """
                using Evaluations;

                var metadata = new EvaluationWorkflowMetadata
                {
                    ListDatasetItemsOperationId = "listDatasetItems",
                    CreateExperimentOperationId = "createExperiment",
                    CreateExperimentItemsOperationId = "batchCreateExperimentItems",
                    BatchCreateScoresOperationId = "batchCreateScores",
                    BatchCreateFeedbackOperationId = "batchCreateFeedback",
                };
                metadata.ScorerNames.Add("length");
                metadata.ScorerNames.Add("guard");
                Require(metadata.TraceIdPropertyName == "traceId", "trace metadata");
                Require(metadata.ScorerNames.Count == 2, "scorer metadata");

                var active = 0;
                var maxActive = 0;
                var experimentCreates = 0;
                var gate = new object();
                var published = new List<IReadOnlyList<EvaluationItemResult<string, string>>>();
                var scorers = new[]
                {
                    EvaluationScorer<string, string>.FromValue(
                        "length",
                        (context, cancellationToken) => Task.FromResult<double?>(context.Output.Length)),
                    new EvaluationScorer<string, string>(
                        "guard",
                        (context, cancellationToken) =>
                        {
                            if (context.Item == "scorer-fails")
                            {
                                throw new InvalidOperationException("score failed");
                            }

                            return Task.FromResult(new EvaluationScore("guard", 1, label: "ok"));
                        }),
                };

                var runner = new DatasetEvaluationRunner<string, string>(
                    taskAsync: async (context, cancellationToken) =>
                    {
                        var current = Interlocked.Increment(ref active);
                        lock (gate)
                        {
                            if (current > maxActive)
                            {
                                maxActive = current;
                            }
                        }

                        try
                        {
                            await Task.Delay(25, cancellationToken);
                            if (context.Item == "task-fails")
                            {
                                throw new InvalidOperationException("task failed");
                            }

                            return new EvaluationTaskResult<string>(
                                "output-" + context.Item,
                                traceId: "trace-" + context.Index,
                                spanId: "span-" + context.Index,
                                runId: "run-" + context.Index);
                        }
                        finally
                        {
                            Interlocked.Decrement(ref active);
                        }
                    },
                    scorers: scorers,
                    publishBatchAsync: (batch, cancellationToken) =>
                    {
                        published.Add(batch.ToArray());
                        return Task.CompletedTask;
                    },
                    createExperimentAsync: cancellationToken =>
                    {
                        experimentCreates++;
                        return Task.FromResult<string?>("exp-1");
                    },
                    options: new EvaluationWorkflowOptions
                    {
                        MaxConcurrency = 2,
                        PublishBatchSize = 2,
                    });

                var result = await runner.RunAsync(new[] { "ok", "task-fails", "scorer-fails", "later" });
                Require(experimentCreates == 1, "created experiment");
                Require(result.ExperimentId == "exp-1", "experiment id");
                Require(result.TotalCount == 4, "total count");
                Require(result.SucceededCount == 2, "succeeded count");
                Require(result.FailedCount == 2, "failed count");
                Require(!result.IsSuccessful, "not successful");
                Require(result.Items[0].TraceId == "trace-0", "trace id preserved");
                Require(result.Items[0].RunId == "run-0", "run id preserved");
                Require(result.Items[1].Exception?.Message == "task failed", "task failure captured");
                Require(result.Items[2].Output == "output-scorer-fails", "scorer failure keeps output");
                Require(result.Items[2].Scores.Count == 1, "scorer failure keeps earlier scores");
                Require(result.Items[2].Exceptions[0].Message == "score failed", "scorer failure captured");
                Require(result.Items[3].Output == "output-later", "later item still processed");
                Require(result.Scores.Count == 5, "aggregated scores");
                Require(result.Exceptions.Count == 2, "aggregated exceptions");
                Require(result.PublishedBatchCount == 2, "published batches");
                Require(published.Count == 2, "publish callback count");
                Require(published.Sum(static batch => batch.Count) == 4, "published all item results");
                Require(maxActive <= 2, "max concurrency");

                var explicitExperiment = await runner.RunAsync(new[] { "ok" }, experimentId: "exp-existing");
                Require(explicitExperiment.ExperimentId == "exp-existing", "explicit experiment id");
                Require(experimentCreates == 1, "existing experiment skips create");

                static void Require(bool condition, string caseName)
                {
                    if (!condition)
                    {
                        throw new InvalidOperationException(caseName);
                    }
                }
                """);

            var runResult = await RunDotnetAsync(
                outputDirectory,
                "run",
                "--disable-build-servers",
                "--project", Path.Combine(outputDirectory, "EvaluationWorkflowConsumer.csproj"));
            Console.WriteLine(runResult.StandardOutput);
            Console.WriteLine(runResult.StandardError);
            runResult.ExitCode.Should().Be(0);
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_WithSecuritySchemeOverride_ReplacesAuthAndSuppressesDuplicateParameters()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Auth Override
  version: 1.0.0
components:
  securitySchemes:
    queryKey:
      type: apiKey
      in: query
      name: api_key
paths:
  /chat:
    get:
      operationId: getChat
      security:
        - queryKey: []
      parameters:
        - in: header
          name: Authorization
          schema:
            type: string
        - in: query
          name: keep
          schema:
            type: string
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  ok:
                    type: boolean
""";

        await GenerateFromContentAsync(
            fileName: "security-override.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "AuthOverride",
            clientClassName: "AuthOverrideClient",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("AuthenticationHeaderValue(");
                content.Should().Contain("\"Bearer\"");
                content.Should().NotContain("ApiKeyInQuery");
                content.Should().NotContain("string? authorization = default");
                content.Should().Contain("string? keep = default");
            },
            additionalArguments: ["--security-scheme", "Http:Header:Bearer"]);
    }

    [TestMethod]
    public async Task Generate_WithRemainingOfficialSecuritySchemes_BuildsAndEmitsSupport()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Official Security Schemes
  version: 1.0.0
paths:
  /cookie:
    get:
      operationId: getCookie
      security:
        - cookieAuth: []
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  ok:
                    type: boolean
  /oidc:
    get:
      operationId: getOidc
      security:
        - oidc: []
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  ok:
                    type: boolean
  /mtls:
    get:
      operationId: getMutualTls
      security:
        - mtlsAuth: []
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  ok:
                    type: boolean
components:
  securitySchemes:
    cookieAuth:
      type: apiKey
      in: cookie
      name: session
    oidc:
      type: openIdConnect
      openIdConnectUrl: https://example.com/.well-known/openid-configuration
    mtlsAuth:
      type: mutualTLS
""";

        await GenerateFromContentAsync(
            fileName: "official-security-schemes.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "OfficialSecurity",
            clientClassName: "OfficialSecurityClient",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("TryAddWithoutValidation(\"Cookie\", string.Join(\"; \", __cookies))");
                content.Should().Contain("public string OpenIdConnectDiscoveryUrl => \"https://example.com/.well-known/openid-configuration\"");
                content.Should().Contain("__authorization.Type == \"OpenIdConnect\"");
                content.Should().Contain("public void AuthorizeUsingMutualTls()");
                content.Should().Contain("public void ConfigureMutualTlsClientCertificate(");
                content.Should().Contain("_ownedHttpClientHandler = new global::System.Net.Http.HttpClientHandler();");
            });
    }

    [TestMethod]
    public async Task Generate_WithOpenApi32QueryStringCookieAndAdditionalOperations_BuildsAndEmitsSupport()
    {
        const string spec = """
openapi: 3.2.0
info:
  title: OpenApi32
  version: 1.0.0
servers:
  - url: https://example.com
paths:
  /search:
    query:
      operationId: querySearch
      parameters:
        - in: querystring
          name: filters
          required: false
          content:
            application/x-www-form-urlencoded:
              schema:
                type: object
                properties:
                  q:
                    type: string
                  page:
                    type: integer
      responses:
        '200':
          description: OK
    additionalOperations:
      purge:
        operationId: purgeSearch
        responses:
          '204':
            description: Purged
  /cookies:
    get:
      operationId: getCookies
      parameters:
        - in: cookie
          name: prefs
          style: cookie
          schema:
            type: object
            properties:
              theme:
                type: string
              pageSize:
                type: integer
      responses:
        '200':
          description: OK
""";

        await GenerateFromContentAsync(
            fileName: "openapi32-parameters.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "OpenApi32",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("method: new global::System.Net.Http.HttpMethod(\"QUERY\")");
                content.Should().Contain("method: new global::System.Net.Http.HttpMethod(\"purge\")");
                content.Should().Contain("__pathBuilder = __pathBuilder.AddRawQueryString(string.Join(\"&\", __queryStringSegments_filters));");
                content.Should().Contain("__queryStringSegments_filters.Add(\"q=\" + global::System.Uri.EscapeDataString(__filters_Q ?? string.Empty));");
                content.Should().Contain("__queryStringSegments_filters.Add(\"page=\" + global::System.Uri.EscapeDataString(global::System.Convert.ToString(__filters_Page, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty));");
                content.Should().Contain("__httpRequest.Headers.TryAddWithoutValidation(\"Cookie\", string.Join(\"; \", __cookies));");
                content.Should().Contain("__cookies.Add(\"theme=\" + (__prefs_Theme ?? string.Empty))");
                content.Should().Contain("__cookies.Add(\"pageSize=\" + (global::System.Convert.ToString(__prefs_PageSize, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty))");
            });
    }

    [TestMethod]
    public async Task Generate_WithOpenApi32SequentialMediaTypesAndItemSchema_BuildsAndEmitsStreamingSupport()
    {
        const string spec = """
openapi: 3.2.0
info:
  title: OpenApi32Streaming
  version: 1.0.0
servers:
  - url: https://example.com
components:
  schemas:
    StreamChunk:
      type: object
      properties:
        delta:
          type: string
  mediaTypes:
    StreamChunkSequence:
      itemSchema:
        $ref: '#/components/schemas/StreamChunk'
paths:
  /ingest:
    post:
      operationId: ingestChunks
      requestBody:
        required: true
        content:
          application/jsonl:
            $ref: '#/components/mediaTypes/StreamChunkSequence'
      responses:
        '202':
          description: Accepted
  /events:
    get:
      operationId: streamEvents
      responses:
        '200':
          description: OK
          content:
            text/event-stream:
              $ref: '#/components/mediaTypes/StreamChunkSequence'
  /records:
    get:
      operationId: streamRecords
      responses:
        '200':
          description: OK
          content:
            application/json-seq:
              schema:
                type: array
                items:
                  $ref: '#/components/schemas/StreamChunk'
""";

        await GenerateFromContentAsync(
            fileName: "openapi32-streaming.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "OpenApi32Streaming",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("global::System.Collections.Generic.IList<global::OpenApi32Streaming.StreamChunk> request");
                content.Should().Contain("var __httpRequestContentBuilder = new global::System.Text.StringBuilder();");
                content.Should().Contain("foreach (var __requestItem in request)");
                content.Should().Contain("__httpRequestContentBuilder.Append('\\n');");
                content.Should().Contain("mediaType: \"application/jsonl\"");
                content.Should().Contain("IAsyncEnumerable<global::OpenApi32Streaming.StreamChunk> StreamEventsAsync(");
                content.Should().Contain("SseParser");
                content.Should().Contain("IAsyncEnumerable<global::OpenApi32Streaming.StreamChunk> StreamRecordsAsync(");
                content.Should().Contain("if (__character == '\\u001e')");
            });
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
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);
                content.Should().Contain("public string? EqualsValue");
                content.Should().NotContain("public new string? Equals");
            });
    }

    [TestMethod]
    public async Task Generate_WithServerVariableDefaults_UsesResolvedBaseUrl()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: Server Vars
  version: 1.0.0
servers:
  - url: https://{region}.example.com/{version}
    variables:
      region:
        default: us
        enum: [us, eu]
      version:
        default: v1
paths:
  /ping:
    get:
      operationId: ping
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  ok:
                    type: boolean
""";

        await GenerateFromContentAsync(
            fileName: "server-variables.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "ServerVars",
            clientClassName: "ServerVarsClient",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("public const string DefaultBaseUrl = \"https://us.example.com/v1\";");
                content.Should().NotContain("DefaultBaseUrl = \"https://{region}.example.com/{version}\"");
            });
    }

    [TestMethod]
    public async Task Generate_WithOpenApi31NumericExclusiveBounds_Builds()
    {
        const string spec = """
{
  "openapi": "3.1.0",
  "info": {
    "title": "NumericBounds",
    "version": "1.0.0"
  },
  "paths": {
    "/generate": {
      "post": {
        "operationId": "generateText",
        "requestBody": {
          "required": true,
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/GenerateRequest"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "OK",
            "content": {
              "application/json": {
                "schema": {
                  "type": "object",
                  "properties": {
                    "ok": {
                      "type": "boolean"
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  },
  "components": {
    "schemas": {
      "GenerateRequest": {
        "type": "object",
        "properties": {
          "best_of": {
            "type": "integer",
            "minimum": 0,
            "exclusiveMinimum": 0
          },
          "frequency_penalty": {
            "type": "number",
            "exclusiveMinimum": -2
          },
          "top_p": {
            "type": "number",
            "maximum": 1,
            "exclusiveMinimum": 0
          }
        }
      }
    }
  }
}
""";

        await GenerateFromContentAsync(
            fileName: "openapi-31-numeric-exclusive-bounds.json",
            specContent: spec,
            targetFramework: "net10.0");
    }

    [TestMethod]
    public async Task Generate_WithHugeUnionTypeInfoPropertyName_Builds()
    {
        var policyNames = new[]
        {
            "NewModerateModerateRequestPolicieToxicity",
            "NewModerateModerateRequestPoliciePersonalInformation",
            "NewModerateModerateRequestPolicieToxicitySevere",
            "NewModerateModerateRequestPolicieHate",
            "NewModerateModerateRequestPolicieIllicit",
            "NewModerateModerateRequestPolicieIllicitDrugs",
            "NewModerateModerateRequestPolicieIllicitAlcohol",
            "NewModerateModerateRequestPolicieIllicitFirearms",
            "NewModerateModerateRequestPolicieIllicitTobacco",
            "NewModerateModerateRequestPolicieIllicitGambling",
            "NewModerateModerateRequestPolicieCannabis",
            "NewModerateModerateRequestPolicieAdult",
            "NewModerateModerateRequestPolicieCrypto",
            "NewModerateModerateRequestPolicieSexual",
            "NewModerateModerateRequestPolicieFlirtation",
            "NewModerateModerateRequestPolicieProfanity",
            "NewModerateModerateRequestPolicieViolence",
            "NewModerateModerateRequestPolicieSelfHarm",
            "NewModerateModerateRequestPolicieSpam",
            "NewModerateModerateRequestPolicieSelfPromotion",
            "NewModerateModerateRequestPoliciePolitical",
            "NewModerateModerateRequestPolicieReligion",
            "NewModerateModerateRequestPolicieCodeAbuse",
            "NewModerateModerateRequestPoliciePiiMasking",
            "NewModerateModerateRequestPolicieUrlMasking",
            "NewModerateModerateRequestPolicieGuideline",
        };
        var anyOfRefs = string.Join(
            Environment.NewLine,
            policyNames.Select(name => $"                - $ref: '#/components/schemas/{name}'"));
        var policySchemas = string.Join(
            Environment.NewLine + Environment.NewLine,
            policyNames.Select(name => $$"""
    {{name}}:
      type: object
      properties:
        enabled:
          type: boolean
"""));
        var spec = $$"""
openapi: 3.0.3
info:
  title: HugeUnion
  version: 1.0.0
paths:
  /moderate:
    post:
      operationId: moderate
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/ModerateRequest'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  ok:
                    type: boolean
components:
  schemas:
    ModerateRequest:
      type: object
      required:
        - content
      properties:
        content:
          type: string
        policies:
          type: array
          items:
            anyOf:
{{anyOfRefs}}

{{policySchemas}}
""";

        await GenerateFromContentAsync(
            fileName: "huge-union-typeinfo.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "HugeUnion",
            assertGeneratedOutput: async outputDirectory =>
            {
                var contextFile = Path.Combine(outputDirectory, "HugeUnion.JsonSerializerContext.g.cs");
                var contextTypesFile = Path.Combine(outputDirectory, "HugeUnion.JsonSerializerContextTypes.g.cs");

                File.Exists(contextFile).Should().BeTrue();
                File.Exists(contextTypesFile).Should().BeTrue();

                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("TypeInfoPropertyName =");
                content.Should().Contain("JsonSerializerContext { get; set; } = global::HugeUnion.SourceGenerationContext.Default;");
            });
    }

    [TestMethod]
    public async Task Generate_WithHugeUnionDeprecatedConverterTypes_SuppressesCS0618_AndBuilds()
    {
        var policyNames = new[]
        {
            "NewModerateModerateRequestPolicieToxicity",
            "NewModerateModerateRequestPoliciePersonalInformation",
            "NewModerateModerateRequestPolicieToxicitySevere",
            "NewModerateModerateRequestPolicieHate",
            "NewModerateModerateRequestPolicieIllicit",
            "NewModerateModerateRequestPolicieIllicitDrugs",
            "NewModerateModerateRequestPolicieIllicitAlcohol",
            "NewModerateModerateRequestPolicieIllicitFirearms",
            "NewModerateModerateRequestPolicieIllicitTobacco",
            "NewModerateModerateRequestPolicieIllicitGambling",
            "NewModerateModerateRequestPolicieCannabis",
            "NewModerateModerateRequestPolicieAdult",
            "NewModerateModerateRequestPolicieCrypto",
            "NewModerateModerateRequestPolicieSexual",
            "NewModerateModerateRequestPolicieFlirtation",
            "NewModerateModerateRequestPolicieProfanity",
            "NewModerateModerateRequestPolicieViolence",
            "NewModerateModerateRequestPolicieSelfHarm",
            "NewModerateModerateRequestPolicieSpam",
            "NewModerateModerateRequestPolicieSelfPromotion",
            "NewModerateModerateRequestPoliciePolitical",
            "NewModerateModerateRequestPolicieReligion",
            "NewModerateModerateRequestPolicieCodeAbuse",
            "NewModerateModerateRequestPoliciePiiMasking",
            "NewModerateModerateRequestPolicieUrlMasking",
            "NewModerateModerateRequestPolicieGuideline",
        };
        var deprecatedPolicy = policyNames[0];
        var anyOfRefs = string.Join(
            Environment.NewLine,
            policyNames.Select(name => $"                - $ref: '#/components/schemas/{name}'"));
        var policySchemas = string.Join(
            Environment.NewLine + Environment.NewLine,
            policyNames.Select(name => $$"""
    {{name}}:
      type: object
      {{(name == deprecatedPolicy ? "deprecated: true" : string.Empty)}}
      properties:
        enabled:
          type: boolean
"""));
        var spec = $$"""
openapi: 3.0.3
info:
  title: HugeUnionDeprecated
  version: 1.0.0
paths:
  /moderate:
    post:
      operationId: moderate
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/ModerateRequest'
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  ok:
                    type: boolean
components:
  schemas:
    ModerateRequest:
      type: object
      required:
        - content
      properties:
        content:
          type: string
        policies:
          type: array
          items:
            anyOf:
{{anyOfRefs}}

{{policySchemas}}
""";

        await GenerateFromContentAsync(
            fileName: "huge-union-deprecated.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "HugeUnionDeprecated",
            assertGeneratedOutput: async outputDirectory =>
            {
                var contextFile = Path.Combine(outputDirectory, "HugeUnionDeprecated.JsonSerializerContext.g.cs");
                var contextTypesFile = Path.Combine(outputDirectory, "HugeUnionDeprecated.JsonSerializerContextTypes.g.cs");

                File.Exists(contextFile).Should().BeTrue();
                File.Exists(contextTypesFile).Should().BeTrue();

                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("TypeInfoPropertyName =");
                content.Should().Contain("#pragma warning disable CS0618 // Type or member is obsolete");
                content.Should().Contain(deprecatedPolicy);
                content.Should().Contain("JsonSerializerContext { get; set; } = global::HugeUnionDeprecated.SourceGenerationContext.Default;");
            });
    }

    [TestMethod]
    public async Task Generate_WithInlineAllOf_DoesNotEmitReflectionValidation()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: InlineAllOf
  version: 1.0.0
paths:
  /compose:
    post:
      operationId: compose
      requestBody:
        required: true
        content:
          application/json:
            schema:
              allOf:
                - $ref: '#/components/schemas/BaseRequest'
                - $ref: '#/components/schemas/ExtraRequest'
      responses:
        '200':
          description: OK
components:
  schemas:
    BaseRequest:
      type: object
      required:
        - id
      properties:
        id:
          type: string
    ExtraRequest:
      type: object
      required:
        - enabled
      properties:
        enabled:
          type: boolean
""";

        await GenerateFromContentAsync(
            fileName: "inline-allof-trim.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "InlineAllOf",
            assertGeneratedOutput: async outputDirectory =>
            {
                var allOfFile = Path.Combine(outputDirectory, "InlineAllOf.AllOf.2.g.cs");
                var converterFile = Path.Combine(outputDirectory, "InlineAllOf.JsonConverters.AllOf2.g.cs");

                File.Exists(allOfFile).Should().BeTrue();
                File.Exists(converterFile).Should().BeTrue();

                var allOfContent = await File.ReadAllTextAsync(allOfFile);
                var converterContent = await File.ReadAllTextAsync(converterFile);

                allOfContent.Should().Contain("public readonly partial struct AllOf<T1, T2>");
                allOfContent.Should().Contain("private static bool RequiresValue<TValue>()");
                allOfContent.Should().NotContain("DynamicallyAccessedMembers");
                allOfContent.Should().NotContain("GetProperties(");
                allOfContent.Should().NotContain("CustomAttributes");
                converterContent.Should().Contain("public class AllOfJsonConverter<T1, T2>");
                converterContent.Should().NotContain("DynamicallyAccessedMembers");
            });
    }

    [TestMethod]
    public async Task Generate_WithLargeJsonSerializerContext_SplitsIntoChunkResolvers()
    {
        var schemas = new StringBuilder();
        const int schemaCount = 520;
        for (var index = 0; index < schemaCount; index++)
        {
            schemas.AppendLine($"""
    Model{index}:
      type: object
      properties:
        value:
          type: string
""");
        }

        var spec = $$"""
openapi: 3.0.3
info:
  title: LargeContext
  version: 1.0.0
paths:
  /model:
    get:
      operationId: getModel
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/Model0'
components:
  schemas:
{{schemas}}
""";

        await GenerateFromContentAsync(
            fileName: "large-json-context.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "LargeContext",
            assertGeneratedOutput: async outputDirectory =>
            {
                var contextFile = Path.Combine(outputDirectory, "LargeContext.JsonSerializerContext.g.cs");
                File.Exists(contextFile).Should().BeTrue();

                var contextContent = await File.ReadAllTextAsync(contextFile);
                contextContent.Should().Contain("internal sealed partial class SourceGenerationContextChunk0");
                contextContent.Should().Contain("internal sealed partial class SourceGenerationContextChunk1");
                contextContent.Should().Contain("global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(");
                contextContent.Should().Contain("public static SourceGenerationContext Default { get; } = new(DefaultOptions);");
                Regex.Matches(contextContent, "\\[global::System.Text.Json.Serialization.JsonSerializable").Count
                    .Should().BeGreaterThan(schemaCount);
            });
    }

    [TestMethod]
    public async Task Trim_WhenValidationBuildFails_ReturnsNonZeroExitCode()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var csprojPath = Path.Combine(tempDirectory, "Broken.csproj");
            await File.WriteAllTextAsync(
                csprojPath,
                """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <TargetFramework>net10.0</TargetFramework>
                  </PropertyGroup>
                </Project>
                """);
            await File.WriteAllTextAsync(
                Path.Combine(tempDirectory, "Broken.cs"),
                "this is not valid csharp");

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var result = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "trim",
                csprojPath,
                "--target-framework", "net10.0");

            Console.WriteLine(result.StandardOutput);
            Console.WriteLine(result.StandardError);

            result.ExitCode.Should().Be(1);
            result.StandardError.Should().Contain("Build failed");
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Trim_WithAnalysisModeAll_DoesNotFailGeneratedTemporaryProgram()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            await File.WriteAllTextAsync(
                Path.Combine(tempDirectory, "Directory.Build.props"),
                """
                <Project>
                  <PropertyGroup>
                    <EnableNETAnalyzers>true</EnableNETAnalyzers>
                    <AnalysisLevel>latest</AnalysisLevel>
                    <AnalysisMode>All</AnalysisMode>
                    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
                  </PropertyGroup>
                </Project>
                """);

            var csprojPath = Path.Combine(tempDirectory, "TrimTarget.csproj");
            await File.WriteAllTextAsync(
                csprojPath,
                """
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <TargetFramework>net10.0</TargetFramework>
                  </PropertyGroup>
                </Project>
                """);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var result = await RunDotnetAsync(
                repositoryDirectory,
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                "trim",
                csprojPath,
                "--target-framework", "net10.0");

            Console.WriteLine(result.StandardOutput);
            Console.WriteLine(result.StandardError);

            result.ExitCode.Should().Be(0);
            (result.StandardOutput + result.StandardError).Should().NotContain("CA1303");
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task Generate_WithFernRequestName_UsesRequestModelName()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: FernRequestName
  version: 1.0.0
paths:
  /finetuning/{id}:
    patch:
      operationId: updateFinetunedModel
      x-fern-request-name: FinetuningUpdateFinetunedModelRequest
      parameters:
        - name: id
          in: path
          required: true
          schema:
            type: string
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/UpdateFinetunedModelRequest'
      responses:
        '200':
          description: OK
components:
  schemas:
    UpdateFinetunedModelRequest:
      type: object
      properties:
        name:
          type: string
""";

        await GenerateFromContentAsync(
            fileName: "fern-request-name.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "G",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("FinetuningUpdateFinetunedModelRequest");
                content.Should().NotContain("class UpdateFinetunedModelRequest");
                content.Should().Contain("global::G.FinetuningUpdateFinetunedModelRequest request");
            });
    }

    [TestMethod]
    public async Task Generate_WithFernTypeLiteralAndDateTime_UsesTypedOutput()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: FernType
  version: 1.0.0
paths:
  /oauth/token:
    post:
      operationId: getToken
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              properties:
                client_id:
                  type: string
                client_secret:
                  type: string
                grant_type:
                  x-fern-type: literal<"client_credentials">
              required:
                - client_id
                - client_secret
                - grant_type
      responses:
        '200':
          description: OK
  /transcript:
    get:
      operationId: getTranscript
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  created:
                    type: string
                    x-fern-type: datetime
                  completed:
                    x-fern-type: optional<datetime>
""";

        await GenerateFromContentAsync(
            fileName: "fern-type.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "G",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().NotContain("class GetTokenRequestGrantType");
                content.Should().NotContain("object grantType");
                content.Should().Contain("string grantType = \"client_credentials\"");
                content.Should().Contain("public string GrantType { get; set; } = \"client_credentials\";");
                content.Should().Contain("public global::System.DateTime? Created { get; set; }");
                content.Should().Contain("public global::System.DateTime? Completed { get; set; }");
            });
    }

    [TestMethod]
    public async Task Generate_WithRequiredNullableAnyOfRequestProperty_Builds()
    {
        const string spec = """
openapi: 3.1.0
info:
  title: portkey-repro
  version: 1.0.0
paths:
  /prompts/{promptId}/completions:
    post:
      operationId: createPromptCompletion
      parameters:
        - in: path
          name: promptId
          required: true
          schema:
            type: string
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/CreatePromptCompletionRequest'
      responses:
        '200':
          description: ok
components:
  schemas:
    CreatePromptCompletionRequest:
      type: object
      required:
        - variables
      properties:
        variables:
          anyOf:
            - type: object
              additionalProperties: {}
            - type: 'null'
        stream:
          type: boolean
""";

        await GenerateFromContentAsync(
            fileName: "required-nullable-anyof.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("public object? Variables { get; set; }");
                content.Should().NotContain("public required object? Variables { get; set; }");
                content.Should().Contain("object? variables");
                content.Should().Contain("Variables = variables,");
            });
    }

    [TestMethod]
    public async Task Generate_WithDiscriminatorOneOf_EmitsTryPickSwitchHelpers_AndBuildsNullableFlow()
    {
        const string spec = """
openapi: 3.0.3
info:
  title: UnionHelpers
  version: 1.0.0
paths:
  /events:
    get:
      operationId: listEvents
      responses:
        '200':
          description: ok
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/StreamEvent'
components:
  schemas:
    StreamEvent:
      discriminator:
        propertyName: type
        mapping:
          message: '#/components/schemas/MessageEvent'
          tool_call: '#/components/schemas/ToolCallEvent'
          error: '#/components/schemas/ErrorEvent'
      oneOf:
        - $ref: '#/components/schemas/MessageEvent'
        - $ref: '#/components/schemas/ToolCallEvent'
        - $ref: '#/components/schemas/ErrorEvent'
    MessageEvent:
      type: object
      required:
        - type
        - text
      properties:
        type:
          type: string
          enum:
            - message
        text:
          type: string
    ToolCallEvent:
      type: object
      required:
        - type
        - tool_name
      properties:
        type:
          type: string
          enum:
            - tool_call
        tool_name:
          type: string
    ErrorEvent:
      type: object
      required:
        - type
        - message
      properties:
        type:
          type: string
          enum:
            - error
        message:
          type: string
""";

        await GenerateFromContentAsync(
            fileName: "discriminator-oneof-helpers.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("public bool TryPickMessage(");
                content.Should().Contain("[global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]");
                content.Should().Contain("public void Switch(");

                await File.WriteAllTextAsync(
                    Path.Combine(outputDirectory, "UnionConsumer.cs"),
                    """
                    #nullable enable
                    namespace Oag;

                    internal static class UnionConsumer
                    {
                        public static string ReadMessage(StreamEvent value)
                        {
                            if (value.TryPickMessage(out var message))
                            {
                                return message.Text;
                            }

                            return string.Empty;
                        }

                        public static string Describe(StreamEvent value)
                        {
                            return value.Match(
                                message: x => x.Text,
                                toolCall: x => x.ToolName,
                                error: x => x.Message) ?? string.Empty;
                        }

                        public static string DescribeWithSwitch(StreamEvent value)
                        {
                            var result = string.Empty;
                            value.Switch(
                                message: x => result = x.Text,
                                toolCall: x => result = x.ToolName,
                                error: x => result = x.Message);
                            return result;
                        }
                    }
                    """);
            });
    }

    [TestMethod]
    public async Task Generate_WithRequiredNonNullableObjectProperty_FromAllOfRequest_Builds()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: portkey-allof-repro
  version: 1.0.0
paths:
  /prompts/{promptId}/completions:
    post:
      operationId: createPromptCompletion
      parameters:
        - in: path
          name: promptId
          required: true
          schema:
            type: string
      requestBody:
        required: true
        content:
          application/json:
            schema:
              allOf:
                - type: object
                  required:
                    - variables
                  properties:
                    variables:
                      type: object
                    stream:
                      type: boolean
                      default: false
                    hyperparameters:
                      oneOf:
                        - type: string
                        - type: integer
      responses:
        '200':
          description: ok
""";

        await GenerateFromContentAsync(
            fileName: "required-non-nullable-object-allof.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("public required object Variables { get; set; }");
                content.Should().Contain("object variables");
                content.Should().Contain("Variables = variables,");
            });
    }

    [TestMethod]
    public async Task Generate_WithCompositeAllOfRequest_DoesNotFlattenWrapperProperties()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: composite-allof-repro
  version: 1.0.0
paths:
  /test:
    post:
      operationId: createComposite
      requestBody:
        required: true
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/CompositeRequest'
      responses:
        '200':
          description: ok
components:
  schemas:
    BaseRequest:
      type: object
      properties:
        id:
          type: string
    CompositeRequest:
      type: object
      allOf:
        - $ref: '#/components/schemas/BaseRequest'
        - type: object
          properties:
            extra:
              type: string
""";

        await GenerateFromContentAsync(
            fileName: "composite-allof-request.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().NotContain("Extra = extra,");
                content.Should().NotContain("Id = id,");
            });
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
    public async Task Generate_WithSymbolicEnumValues_UsesReadableNamesAndBuilds()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: SymbolicEnum
  version: 1.0.0
paths:
  /operator:
    get:
      operationId: getOperator
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/OperatorWrapper'
components:
  schemas:
    TraceFilterOperator:
      type: string
      enum:
        - "="
        - "!="
        - '&&'
        - '||'
        - ">"
        - ">="
        - "<"
        - "<="
        - "+"
        - "-"
        - "*"
        - "/"
    OperatorWrapper:
      type: object
      properties:
        op:
          $ref: '#/components/schemas/TraceFilterOperator'
""";

        await GenerateFromContentAsync(
            fileName: "symbolic-enum.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                var content = string.Join("\n\n", generatedContents);

                content.Should().Contain("public enum TraceFilterOperator");
                content.Should().Contain("Eq,");
                content.Should().Contain("Neq,");
                content.Should().Contain("And,");
                content.Should().Contain("Or,");
                content.Should().Contain("Gte,");
                content.Should().Contain("Multiply,");
                content.Should().Contain("Divide,");

                content.Should().Contain("\"=\" => TraceFilterOperator.Eq");
                content.Should().Contain("\"!=\" => TraceFilterOperator.Neq");
                content.Should().Contain("\"&&\" => TraceFilterOperator.And");
                content.Should().Contain("\"||\" => TraceFilterOperator.Or");
                content.Should().Contain("\">=\" => TraceFilterOperator.Gte");
                content.Should().Contain("\"*\" => TraceFilterOperator.Multiply");
                content.Should().Contain("\"/\" => TraceFilterOperator.Divide");
            });
    }

    [TestMethod]
    public async Task Generate_DoesNotEmitDoubleDotGeneratedFileNames()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: HintNameRegression
  version: 1.0.0
paths:
  /ping:
    get:
      operationId: ping
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/PingResponse'
components:
  schemas:
    PingResponse:
      type: object
      properties:
        ok:
          type: boolean
""";

        await GenerateFromContentAsync(
            fileName: "hint-name-regression.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "G",
            assertGeneratedOutput: outputDirectory =>
            {
                var generatedFiles = Directory.EnumerateFiles(outputDirectory, "*", SearchOption.AllDirectories)
                    .Select(Path.GetFileName)
                    .ToArray();

                generatedFiles.Should().NotContain(x => x != null && x.Contains("..", StringComparison.Ordinal));
                generatedFiles.Should().Contain("G.JsonSerializerContext.g.cs");
                return Task.CompletedTask;
            });
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

    [TestMethod]
    public async Task Generate_WithNamespaceDelimiter_GeneratesNestedModelNamespaces()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: NamespaceDelimiter
  version: 1.0.0
paths:
  /pets/{id}:
    get:
      operationId: getPet
      parameters:
        - in: path
          name: id
          required: true
          schema:
            type: string
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/PetStore.Pet'
components:
  schemas:
    PetStore.Kind:
      type: string
      enum:
        - cat
        - dog
    PetStore.Pet:
      type: object
      properties:
        id:
          type: string
        kind:
          $ref: '#/components/schemas/PetStore.Kind'
""";

        await GenerateFromContentAsync(
            fileName: "namespace-delimiter.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "G",
            assertGeneratedOutput: async outputDirectory =>
            {
                var petFile = Path.Combine(outputDirectory, "G.PetStore.Models.Pet.g.cs");
                var kindFile = Path.Combine(outputDirectory, "G.PetStore.Models.Kind.g.cs");

                File.Exists(petFile).Should().BeTrue();
                File.Exists(kindFile).Should().BeTrue();

                var petContent = await File.ReadAllTextAsync(petFile);
                petContent.Should().Contain("namespace G.PetStore");
                petContent.Should().Contain("public sealed partial class Pet");

                Directory.EnumerateFiles(outputDirectory, "*", SearchOption.AllDirectories)
                    .Select(Path.GetFileName)
                    .Should()
                    .OnlyHaveUniqueItems();
            },
            additionalArguments: ["--namespace-delimiter", "."]);
    }

    [TestMethod]
    public async Task Generate_WithNamespaceDelimiterAndExcludedDottedModel_UsesExternalType()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: NamespaceDelimiterExternal
  version: 1.0.0
paths:
  /pets/{id}:
    get:
      operationId: getPet
      parameters:
        - in: path
          name: id
          required: true
          schema:
            type: string
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                $ref: '#/components/schemas/PetStore.Pet'
components:
  schemas:
    PetStore.Pet:
      type: object
      properties:
        id:
          type: string
""";

        await GenerateFromContentAsync(
            fileName: "namespace-delimiter-external.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            namespaceValue: "G",
            clientClassName: "TestClient",
            assertGeneratedOutput: async outputDirectory =>
            {
                var modelFile = Path.Combine(outputDirectory, "G.PetStore.Models.Pet.g.cs");

                File.Exists(modelFile).Should().BeFalse();
                var generatedContents = await Task.WhenAll(
                    Directory.EnumerateFiles(outputDirectory, "*.g.cs", SearchOption.AllDirectories)
                        .Select(path => File.ReadAllTextAsync(path)));
                string.Join("\n\n", generatedContents).Should().Contain("global::PetStore.Pet");

                await File.WriteAllTextAsync(
                    Path.Combine(outputDirectory, "ExternalPet.cs"),
                    """
                    namespace PetStore;

                    /// <summary>
                    /// External Pet type supplied by the consuming project.
                    /// </summary>
                    public sealed partial class Pet
                    {
                    }
                    """);
            },
            additionalArguments:
            [
                "--namespace-delimiter", ".",
                "--exclude-models", "PetStore.Pet",
            ]);
    }

    [TestMethod]
    public async Task Generate_WithDerivedAllOfInheritedPropertyCollision_Builds()
    {
        const string spec = """
openapi: 3.0.1
info:
  title: opik-mini
  version: 1.0.0
paths: {}
components:
  schemas:
    Feedback:
      required:
        - name
        - type
      type: object
      properties:
        id:
          type: string
          format: uuid
          readOnly: true
        name:
          minLength: 1
          type: string
        createdAt:
          type: string
          format: date-time
          readOnly: true
        type:
          type: string
          enum:
            - boolean
      discriminator:
        propertyName: type
        mapping:
          boolean: '#/components/schemas/BooleanFeedbackDefinition'
    BooleanFeedbackDefinition:
      required:
        - details
        - name
        - type
      type: object
      allOf:
        - $ref: '#/components/schemas/Feedback'
        - type: object
          properties:
            details:
              $ref: '#/components/schemas/BooleanFeedbackDetail'
            created_at:
              type: string
              format: date-time
              readOnly: true
    BooleanFeedbackDetail:
      type: object
      properties:
        trueLabel:
          type: string
""";

        await GenerateFromContentAsync(
            fileName: "derived-allof-inheritance.yaml",
            specContent: spec,
            targetFramework: "net10.0",
            assertGeneratedOutput: async outputDirectory =>
            {
                var modelFile = Path.Combine(outputDirectory, "Oag.Models.BooleanFeedbackDefinition.g.cs");
                var content = await File.ReadAllTextAsync(modelFile);

                content.Should().Contain("public new global::System.DateTime? CreatedAt");
                content.Should().Contain("string name");
                content.Should().Contain("base.Name = name");
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

    private static async Task<string> ReadRequiredGeneratedFileAsync(
        IEnumerable<string> generatedFiles,
        string fileNameSuffix)
    {
        var path = generatedFiles.Single(path => string.Equals(Path.GetFileName(path), fileNameSuffix, StringComparison.Ordinal));
        return await File.ReadAllTextAsync(path);
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

    private static async Task AssertProtoInputShowsGrpcNotSupportedMessageAsync(
        string commandName,
        params string[] additionalArguments)
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var protoPath = Path.Combine(tempDirectory, "greeter.proto");
            await File.WriteAllTextAsync(
                protoPath,
                """
                syntax = "proto3";

                package demo;

                service Greeter {
                  rpc SayHello (HelloRequest) returns (HelloReply);
                }

                message HelloRequest {
                  string name = 1;
                }

                message HelloReply {
                  string message = 1;
                }
                """);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var arguments = new List<string>
            {
                "run",
                "--disable-build-servers",
                "--no-launch-profile",
                "--project", "src/libs/AutoSDK.CLI",
                commandName,
                protoPath,
            };
            arguments.AddRange(additionalArguments.Select(argument =>
                string.Equals(argument, "Generated", StringComparison.Ordinal)
                    ? Path.Combine(tempDirectory, argument)
                    : argument));

            var result = await RunDotnetAsync(repositoryDirectory, arguments.ToArray());

            result.ExitCode.Should().Be(1);
            result.StandardError.Should().Contain("gRPC .proto inputs are not supported by this command.");
            result.StandardError.Should().NotContain("OpenAPI specification version");
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
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

    [TestMethod]
    public async Task SourceGeneratorsProps_Restore_WithCentralPackageManagement()
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var propsPath = Path.Combine(
                    repositoryDirectory,
                    "src",
                    "libs",
                    "AutoSDK.SourceGenerators",
                    "AutoSDK.SourceGenerators.props")
                .Replace('\\', '/');
            var escapedPropsPath = System.Security.SecurityElement.Escape(propsPath)!;

            await File.WriteAllTextAsync(
                Path.Combine(tempDirectory, "Directory.Packages.props"),
                """
                <Project>
                  <PropertyGroup>
                    <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>
                  </PropertyGroup>
                </Project>
                """);
            await File.WriteAllTextAsync(
                Path.Combine(tempDirectory, "Test.csproj"),
                $$"""
                <Project Sdk="Microsoft.NET.Sdk">
                  <Import Project="{{escapedPropsPath}}" />

                  <PropertyGroup>
                    <TargetFramework>net9.0</TargetFramework>
                  </PropertyGroup>
                </Project>
                """);

            var restoreResult = await RunDotnetAsync(
                tempDirectory,
                "restore",
                "--disable-build-servers",
                Path.Combine(tempDirectory, "Test.csproj"));

            Console.WriteLine(restoreResult.StandardOutput);
            Console.WriteLine(restoreResult.StandardError);

            restoreResult.ExitCode.Should().Be(0);
            restoreResult.StandardError.Should().NotContain("NU1008");

            var assetsPath = Path.Combine(tempDirectory, "obj", "project.assets.json");
            File.Exists(assetsPath).Should().BeTrue();

            var projectAssets = await File.ReadAllTextAsync(assetsPath);
            projectAssets.Should().Contain("System.Net.ServerSentEvents/10.0.5");
        }
        finally
        {
            TryDeleteDirectory(tempDirectory);
        }
    }

    [TestMethod]
    public async Task SourceGeneratorsProps_Restore_WithCentralPackageManagement_AddsOptInMicrosoftExtensionsPackages()
    {
        await AssertSourceGeneratorsPropsRestoreWithMicrosoftExtensionsPackagesAsync(
            managePackageVersionsCentrally: true);
    }

    [TestMethod]
    public async Task SourceGeneratorsProps_Restore_WithoutCentralPackageManagement_AddsOptInMicrosoftExtensionsPackages()
    {
        await AssertSourceGeneratorsPropsRestoreWithMicrosoftExtensionsPackagesAsync(
            managePackageVersionsCentrally: false);
    }

    private static async Task AssertSourceGeneratorsPropsRestoreWithMicrosoftExtensionsPackagesAsync(
        bool managePackageVersionsCentrally)
    {
        var tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        try
        {
            Directory.CreateDirectory(tempDirectory);

            var currentDirectory = Directory.GetCurrentDirectory();
            var repositoryDirectory = Path.GetFullPath(Path.Combine(currentDirectory, "../../../../../.."));
            var propsPath = Path.Combine(
                    repositoryDirectory,
                    "src",
                    "libs",
                    "AutoSDK.SourceGenerators",
                    "AutoSDK.SourceGenerators.props")
                .Replace('\\', '/');
            var escapedPropsPath = System.Security.SecurityElement.Escape(propsPath)!;
            var targetsPath = Path.Combine(
                    repositoryDirectory,
                    "src",
                    "libs",
                    "AutoSDK.SourceGenerators",
                    "AutoSDK.SourceGenerators.targets")
                .Replace('\\', '/');
            var escapedTargetsPath = System.Security.SecurityElement.Escape(targetsPath)!;

            if (managePackageVersionsCentrally)
            {
                await File.WriteAllTextAsync(
                    Path.Combine(tempDirectory, "Directory.Packages.props"),
                    """
                    <Project>
                      <PropertyGroup>
                        <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>
                      </PropertyGroup>
                    </Project>
                    """);
            }

            await File.WriteAllTextAsync(
                Path.Combine(tempDirectory, "Test.csproj"),
                $$"""
                <Project Sdk="Microsoft.NET.Sdk">
                  <Import Project="{{escapedPropsPath}}" />

                  <PropertyGroup>
                    <TargetFramework>net10.0</TargetFramework>
                    <AutoSDK_GenerateDependencyInjection>true</AutoSDK_GenerateDependencyInjection>
                    <AutoSDK_GenerateConfigurationBinding>true</AutoSDK_GenerateConfigurationBinding>
                    <AutoSDK_GenerateHttpResilienceExtensions>true</AutoSDK_GenerateHttpResilienceExtensions>
                  </PropertyGroup>

                  <Import Project="{{escapedTargetsPath}}" />
                </Project>
                """);

            var restoreResult = await RunDotnetAsync(
                tempDirectory,
                "restore",
                "--disable-build-servers",
                Path.Combine(tempDirectory, "Test.csproj"));

            Console.WriteLine(restoreResult.StandardOutput);
            Console.WriteLine(restoreResult.StandardError);

            restoreResult.ExitCode.Should().Be(0);
            restoreResult.StandardError.Should().NotContain("NU1008");

            var assetsPath = Path.Combine(tempDirectory, "obj", "project.assets.json");
            File.Exists(assetsPath).Should().BeTrue();

            var projectAssets = await File.ReadAllTextAsync(assetsPath);
            projectAssets.Should().Contain("Microsoft.Extensions.Http/10.0.6");
            projectAssets.Should().Contain("Microsoft.Extensions.Options.ConfigurationExtensions/10.0.6");
            projectAssets.Should().Contain("Microsoft.Extensions.Http.Resilience/10.5.0");
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
        return await RunDotnetAsync(
            workingDirectory,
            environment: null,
            arguments).ConfigureAwait(false);
    }

    private static async Task<(int ExitCode, string StandardOutput, string StandardError)> RunDotnetAsync(
        string workingDirectory,
        IReadOnlyDictionary<string, string>? environment,
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

        if (environment != null)
        {
            foreach (var pair in environment)
            {
                process.StartInfo.Environment[pair.Key] = pair.Value;
            }
        }

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

    private static void AssertAutoSdkGrpcSupportFilesExist(string outputDirectory)
    {
        File.Exists(Path.Combine(outputDirectory, "AutoSdkGrpcClient.cs")).Should().BeTrue();
        File.Exists(Path.Combine(outputDirectory, "AutoSdkGrpcClientFactory.cs")).Should().BeTrue();
        File.Exists(Path.Combine(outputDirectory, "AutoSdkGrpcClientOptions.cs")).Should().BeTrue();
        File.Exists(Path.Combine(outputDirectory, "AutoSdkGrpcCallOptionsInterceptor.cs")).Should().BeTrue();
        File.Exists(Path.Combine(outputDirectory, "AutoSdkGrpcServiceCollectionExtensions.cs")).Should().BeTrue();
        File.Exists(Path.Combine(outputDirectory, "GrpcChannelFactory.cs")).Should().BeTrue();
    }

    private static async Task<(int ExitCode, string StandardOutput, string StandardError)> BuildAutoSdkGrpcConsumerAsync(
        string tempDirectory,
        string generatedProjectPath,
        string rootNamespace,
        string clientTypeName)
    {
        var consumerDirectory = Path.Combine(tempDirectory, "Consumer");
        Directory.CreateDirectory(consumerDirectory);

        var escapedProjectPath = System.Security.SecurityElement.Escape(Path.GetFullPath(generatedProjectPath))!;
        await File.WriteAllTextAsync(
            Path.Combine(consumerDirectory, "Consumer.csproj"),
            $$"""
            <Project Sdk="Microsoft.NET.Sdk">
              <PropertyGroup>
                <OutputType>Exe</OutputType>
                <TargetFramework>net10.0</TargetFramework>
                <ImplicitUsings>enable</ImplicitUsings>
                <Nullable>enable</Nullable>
              </PropertyGroup>

              <ItemGroup>
                <ProjectReference Include="{{escapedProjectPath}}" />
                <PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="10.0.1" />
              </ItemGroup>
            </Project>
            """);

        await File.WriteAllTextAsync(
            Path.Combine(consumerDirectory, "Program.cs"),
            $$"""
            using {{rootNamespace}};
            using Microsoft.Extensions.DependencyInjection;

            var services = new ServiceCollection();
            services.AddAutoSdkGrpcClient<{{clientTypeName}}>(options =>
            {
                options.Address = "https://localhost:5001";
                options.UseBearerToken("token");
                options.AddHeader("x-correlation-id", "integration-test");
                options.WithDefaultDeadline(TimeSpan.FromSeconds(5));
                options.WithRetry(maxAttempts: 3);
            });

            using var provider = services.BuildServiceProvider();
            var typedClient = provider.GetRequiredService<{{clientTypeName}}>();

            using var directClient = AutoSdkGrpcClientFactory.Create<{{clientTypeName}}>(options =>
            {
                options.Address = "https://localhost:5001";
                options.UseApiKey("secret", "x-api-key");
            });

            return typedClient != null && directClient.Client != null ? 0 : 1;
            """);

        return await RunDotnetAsync(
            consumerDirectory,
            "build",
            "--disable-build-servers",
            Path.Combine(consumerDirectory, "Consumer.csproj")).ConfigureAwait(false);
    }

    private static async Task WriteGreeterProtoTreeAsync(string rootDirectory)
    {
        Directory.CreateDirectory(rootDirectory);
        var messagesDirectory = Path.Combine(rootDirectory, "messages");
        Directory.CreateDirectory(messagesDirectory);

        await File.WriteAllTextAsync(
            Path.Combine(rootDirectory, "greeter.proto"),
            """
            syntax = "proto3";

            package demo;
            option csharp_namespace = "Demo.Grpc";

            import "messages/common.proto";

            service Greeter {
              rpc SayHello (demo.messages.HelloRequest) returns (demo.messages.HelloReply);
            }
            """);
        await File.WriteAllTextAsync(
            Path.Combine(messagesDirectory, "common.proto"),
            """
            syntax = "proto3";

            package demo.messages;

            message HelloRequest {
              string name = 1;
            }

            message HelloReply {
              string message = 1;
            }
            """);
    }

    private static FileDescriptorProto CreateGreeterFileDescriptorProto()
    {
        return new FileDescriptorProto
        {
            Name = "demo/greeter.proto",
            Package = "demo",
            Syntax = "proto3",
            Options = new Google.Protobuf.Reflection.FileOptions
            {
                CsharpNamespace = "Demo.Grpc",
            },
            MessageType =
            {
                new DescriptorProto
                {
                    Name = "HelloRequest",
                    Field =
                    {
                        new FieldDescriptorProto
                        {
                            Name = "name",
                            Number = 1,
                            Label = FieldDescriptorProto.Types.Label.Optional,
                            Type = FieldDescriptorProto.Types.Type.String,
                        },
                    },
                },
                new DescriptorProto
                {
                    Name = "HelloReply",
                    Field =
                    {
                        new FieldDescriptorProto
                        {
                            Name = "message",
                            Number = 1,
                            Label = FieldDescriptorProto.Types.Label.Optional,
                            Type = FieldDescriptorProto.Types.Type.String,
                        },
                    },
                },
            },
            Service =
            {
                new ServiceDescriptorProto
                {
                    Name = "Greeter",
                    Method =
                    {
                        new MethodDescriptorProto
                        {
                            Name = "SayHello",
                            InputType = ".demo.HelloRequest",
                            OutputType = ".demo.HelloReply",
                        },
                    },
                },
            },
        };
    }

    private static async Task WriteFakeBufAsync(string directory)
    {
        Directory.CreateDirectory(directory);

        var shellScriptPath = Path.Combine(directory, "buf");
        await File.WriteAllTextAsync(
            shellScriptPath,
            """
            #!/bin/sh
            set -eu
            if [ "$1" != "export" ]; then
              echo "expected export command" >&2
              exit 2
            fi
            shift
            shift
            OUT=""
            while [ "$#" -gt 0 ]; do
              if [ "$1" = "-o" ]; then
                OUT="$2"
                shift 2
                continue
              fi
              shift
            done
            if [ -z "$OUT" ]; then
              echo "missing -o" >&2
              exit 3
            fi
            mkdir -p "$OUT/messages"
            cp "$AUTOSDK_FAKE_BUF_SOURCE/greeter.proto" "$OUT/greeter.proto"
            cp "$AUTOSDK_FAKE_BUF_SOURCE/messages/common.proto" "$OUT/messages/common.proto"
            """);

        if (!OperatingSystem.IsWindows())
        {
            File.SetUnixFileMode(
                shellScriptPath,
                UnixFileMode.UserRead |
                UnixFileMode.UserWrite |
                UnixFileMode.UserExecute |
                UnixFileMode.GroupRead |
                UnixFileMode.GroupExecute |
                UnixFileMode.OtherRead |
                UnixFileMode.OtherExecute);
        }

        await File.WriteAllTextAsync(
            Path.Combine(directory, "buf.cmd"),
            """
            @echo off
            setlocal
            if not "%~1"=="export" exit /b 2
            shift
            shift
            set "OUT="
            :loop
            if "%~1"=="" goto done
            if "%~1"=="-o" (
              set "OUT=%~2"
              shift
            )
            shift
            goto loop
            :done
            if "%OUT%"=="" exit /b 3
            if not exist "%OUT%\messages" mkdir "%OUT%\messages"
            copy /Y "%AUTOSDK_FAKE_BUF_SOURCE%\greeter.proto" "%OUT%\greeter.proto" >nul
            copy /Y "%AUTOSDK_FAKE_BUF_SOURCE%\messages\common.proto" "%OUT%\messages\common.proto" >nul
            exit /b 0
            """);
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
