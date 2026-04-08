using System.Diagnostics;
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
    public async Task Generate_WithInlineAllOf_PropagatesTrimAnnotations()
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

                allOfContent.Should().Contain("public readonly partial struct AllOf<[global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(");
                allOfContent.Should().Contain("private static bool RequiresValue<[global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(");
                allOfContent.Should().Contain("private static class RequirementCache<[global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(");
                converterContent.Should().Contain("public class AllOfJsonConverter<[global::System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(");
            });
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
