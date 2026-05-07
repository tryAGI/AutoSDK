using System.Collections.Immutable;
using System.CommandLine;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;

namespace AutoSDK.CLI.Commands;

internal sealed class GenerateCommand : Command
{
    private Argument<string> Input { get; } = new(
        name: "input")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Input file path",
    };
    
    private Option<string> Output { get; } = new(
        name: "--output",
        aliases: ["-o"])
    {
        DefaultValueFactory = _ => "Generated",
        Description = "Output file path",
    };

    private Option<string[]> GrpcInputs { get; } = new(
        name: "--grpc-input")
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "Additional gRPC/protobuf inputs to scaffold alongside the primary OpenAPI/AsyncAPI generation path. Repeatable.",
        AllowMultipleArgumentsPerToken = true,
    };

    private Option<string> ApiOutputSubdirectory { get; } = new(
        name: "--api-output-subdirectory")
    {
        DefaultValueFactory = _ => "rest",
        Description = "When using --grpc-input, place the primary OpenAPI/AsyncAPI output under this subdirectory.",
    };

    private Option<string> GrpcOutputSubdirectory { get; } = new(
        name: "--grpc-output-subdirectory")
    {
        DefaultValueFactory = _ => "grpc",
        Description = "When using --grpc-input, place scaffolded gRPC projects under this subdirectory.",
    };
    
    private Option<string> TargetFramework { get; } = new(
        name: "--targetFramework",
        aliases: ["-t"])
    {
        DefaultValueFactory = _ => Settings.Default.TargetFramework,
        Description = "TargetFramework for the generated code",
    };
    
    private Option<string> Namespace { get; } = new(
        name: "--namespace",
        aliases: ["-n"])
    {
        DefaultValueFactory = _ => Settings.Default.Namespace,
        Description = "Namespace for the generated code",
    };
    
    private Option<string> ClientClassName { get; } = new(
        name: "--clientClassName",
        aliases: ["-c"])
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Client class name",
    };
    
    private Option<MethodNamingConvention> MethodNamingConvention { get; } = new(
        name: "--methodNamingConvention",
        aliases: ["-m"])
    {
        DefaultValueFactory = _ => Settings.Default.MethodNamingConvention,
        Description = "Method Naming Convention",
    };
    
    private Option<bool> SingleFile { get; } = new(
        name: "--single-file",
        aliases: ["-s"])
    {
        DefaultValueFactory = _ => false,
        Description = "Generate all models in a single file",
    };
    
    private Option<bool> ExcludeDeprecatedOperations { get; } = new(
        name: "--exclude-deprecated-operations",
        aliases: ["-e"])
    {
        DefaultValueFactory = _ => Settings.Default.ExcludeDeprecatedOperations,
        Description = "Exclude deprecated operations",
    };
    
    private Option<string> ClsCompliantEnumPrefix { get; } = new(
        name: "--clsCompliantEnumPrefix",
        aliases: ["-e"])
    {
        DefaultValueFactory = _ => "x",
        Description = "Prefix for enums which start with a number to make them CLS compliant. Pass empty string to disable prefixing(it will be non-CLS compliant '_')",
    };

    private Option<IdentifierCharacterSet> IdentifierCharacterSetOption { get; } = new(
        name: "--identifier-character-set")
    {
        DefaultValueFactory = _ => Settings.Default.IdentifierCharacterSet,
        Description = "Identifier sanitizer mode: Ascii, UnicodeLetters, or CSharpSpec.",
    };
    
    private Option<bool> IgnoreOpenApiErrors { get; } = new(
        name: "--ignore-openapi-errors")
    {
        DefaultValueFactory = _ => Settings.Default.IgnoreOpenApiErrors,
        Description = "Ignore OpenAPI errors",
    };
    
    private Option<bool> IgnoreOpenApiWarnings { get; } = new(
        name: "--ignore-openapi-warnings")
    {
        DefaultValueFactory = _ => Settings.Default.IgnoreOpenApiWarnings,
        Description = "Ignore OpenAPI warnings",
    };
    
    private Option<bool> GenerateModelValidationMethods { get; } = new(
        name: "--validation")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateModelValidationMethods,
        Description = "Generate validation methods for models",
    };

    private Option<bool> GenerateRawModelData { get; } = new(
        name: "--generate-raw-model-data")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateRawModelData,
        Description = "Generate typed raw JSON extension data and raw model helper methods for forward-compatible models.",
    };

    private Option<bool> ComputeDiscriminators { get; } = new(
        name: "--compute-discriminators")
    {
        DefaultValueFactory = _ => Settings.Default.ComputeDiscriminators,
        Description = "Compute discriminators for polymorphic models",
    };
    
    private Option<bool> GenerateCli { get; } = new(
        name: "--generate-cli")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateCli,
        Description = "Generate CLI for the client",
    };

    private Option<bool> UseSystemNetHttpJson { get; } = new(
        name: "--use-system-net-http-json")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateMethodsUsingSystemNetHttpJson,
        Description = "Generate System.Text.Json HTTP method bodies via System.Net.Http.Json helpers where safe.",
    };

    private Option<bool> GenerateWebhookVerifier { get; } = new(
        name: "--generate-webhook-verifier")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateWebhookVerifier,
        Description = "Generate an opt-in HMAC webhook signature verifier.",
    };

    private Option<string> WebhookVerifierClassName { get; } = new(
        name: "--webhook-verifier-class-name")
    {
        DefaultValueFactory = _ => Settings.Default.WebhookVerifierClassName,
        Description = "Class name for the generated webhook verifier.",
    };

    private Option<string> WebhookIdHeaderName { get; } = new(
        name: "--webhook-id-header")
    {
        DefaultValueFactory = _ => Settings.Default.WebhookIdHeaderName,
        Description = "Webhook id header name used by the generated verifier.",
    };

    private Option<string> WebhookTimestampHeaderName { get; } = new(
        name: "--webhook-timestamp-header")
    {
        DefaultValueFactory = _ => Settings.Default.WebhookTimestampHeaderName,
        Description = "Webhook timestamp header name used by the generated verifier.",
    };

    private Option<string> WebhookSignatureHeaderName { get; } = new(
        name: "--webhook-signature-header")
    {
        DefaultValueFactory = _ => Settings.Default.WebhookSignatureHeaderName,
        Description = "Webhook signature header name used by the generated verifier.",
    };

    private Option<string> WebhookSignatureVersion { get; } = new(
        name: "--webhook-signature-version")
    {
        DefaultValueFactory = _ => Settings.Default.WebhookSignatureVersion,
        Description = "Webhook signature version prefix used by the generated verifier.",
    };

    private Option<int> WebhookTimestampToleranceSeconds { get; } = new(
        name: "--webhook-timestamp-tolerance-seconds")
    {
        DefaultValueFactory = _ => Settings.Default.WebhookTimestampToleranceSeconds,
        Description = "Webhook timestamp tolerance in seconds used by the generated verifier.",
    };

    private Option<bool> GenerateDynamicMultipartHelpers { get; } = new(
        name: "--generate-dynamic-multipart-helpers")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateDynamicMultipartHelpers,
        Description = "Generate opt-in dynamic multipart attachment helper APIs.",
    };

    private Option<string> DynamicMultipartHelperClassName { get; } = new(
        name: "--dynamic-multipart-helper-class-name")
    {
        DefaultValueFactory = _ => Settings.Default.DynamicMultipartHelperClassName,
        Description = "Class name for the generated dynamic multipart helper.",
    };

    private Option<bool> GeneratePromptTemplateHelpers { get; } = new(
        name: "--generate-prompt-template-helpers")
    {
        DefaultValueFactory = _ => Settings.Default.GeneratePromptTemplateHelpers,
        Description = "Generate opt-in prompt template manager helper APIs.",
    };

    private Option<string> PromptTemplateHelperClassName { get; } = new(
        name: "--prompt-template-helper-class-name")
    {
        DefaultValueFactory = _ => Settings.Default.PromptTemplateHelperClassName,
        Description = "Class name for the generated prompt template helper.",
    };

    private Option<bool> GenerateObservabilityLifecycleHelpers { get; } = new(
        name: "--generate-observability-lifecycle-helpers")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateObservabilityLifecycleHelpers,
        Description = "Generate opt-in observability ingestion lifecycle helper APIs.",
    };

    private Option<string> ObservabilityLifecycleHelperClassName { get; } = new(
        name: "--observability-lifecycle-helper-class-name")
    {
        DefaultValueFactory = _ => Settings.Default.ObservabilityLifecycleHelperClassName,
        Description = "Class name for the generated observability lifecycle helper.",
    };

    private Option<bool> GeneratePredictionWorkflowHelpers { get; } = new(
        name: "--generate-prediction-workflow-helpers")
    {
        DefaultValueFactory = _ => Settings.Default.GeneratePredictionWorkflowHelpers,
        Description = "Generate opt-in prediction/job create-wait-result workflow helper APIs.",
    };

    private Option<string> PredictionWorkflowHelperClassName { get; } = new(
        name: "--prediction-workflow-helper-class-name")
    {
        DefaultValueFactory = _ => Settings.Default.PredictionWorkflowHelperClassName,
        Description = "Class name for the generated prediction workflow helper.",
    };

    private Option<string[]> SecuritySchemes { get; } = new(
        name: "--security-scheme")
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "Security scheme as 'Type:Location:Name' (e.g., 'ApiKey:Header:x-api-key', 'Http:Header:Bearer'). Repeatable.",
        AllowMultipleArgumentsPerToken = true,
    };

    private Option<string[]> AuthorizationEnvironmentVariables { get; } = new(
        name: "--auth-env-var",
        aliases: ["--api-key-env", "--api-key-env-var"])
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "Credential environment variable name for the generated root-client environment factory. Repeatable.",
        AllowMultipleArgumentsPerToken = true,
    };

    private Option<string> BaseUrl { get; } = new(
        name: "--base-url")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Server base URL to inject (e.g., 'https://api.elevenlabs.io'). Useful for specs missing a servers field.",
    };

    private Option<string[]> BaseUrlEnvironmentVariables { get; } = new(
        name: "--base-url-env-var",
        aliases: ["--base-url-env"])
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "Base URL environment variable name for the generated root-client environment factory. Repeatable.",
        AllowMultipleArgumentsPerToken = true,
    };

    private Option<string[]> OpenApiOverrides { get; } = new(
        name: "--openapi-override")
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "OpenAPI override as 'path=action'. Actions: object, dictionary, remove. Repeatable.",
        AllowMultipleArgumentsPerToken = true,
    };

    private Option<string> WebSocketClientClassName { get; } = new(
        name: "--websocket-class-name")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Override class name for the generated WebSocket client (AsyncAPI specs only). " +
                      "For single-channel specs, used as the full class name. " +
                      "For multi-channel specs, used as a prefix (e.g., 'Deepgram' produces 'DeepgramListenV1RealtimeClient').",
    };

    private Option<string> JsonSerializerContextName { get; } = new(
        name: "--json-serializer-context")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Override the JsonSerializerContext class name (default: SourceGenerationContext). Useful when generating multiple specs to the same project.",
    };

    private Option<string> TypesNamespace { get; } = new(
        name: "--types-namespace")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Namespace to use for type references instead of the main namespace. Used for cross-namespace schema referencing where models live in a different namespace.",
    };

    private Option<string> NamespaceDelimiter { get; } = new(
        name: "--namespace-delimiter")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Optional single-character delimiter for splitting component schema ids into namespaces (for example '.' turns PetStore.Pet into namespace PetStore and class Pet).",
    };

    private Option<string[]> IncludeModels { get; } = new(
        name: "--include-models")
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "Only include these component model ids. Repeatable or pass multiple values.",
        AllowMultipleArgumentsPerToken = true,
    };

    private Option<string[]> ExcludeModels { get; } = new(
        name: "--exclude-models")
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "Exclude these component model ids. Repeatable or pass multiple values.",
        AllowMultipleArgumentsPerToken = true,
    };

    private Option<ExcludedModelNamespaceMode> ExcludedModelNamespaceMode { get; } = new(
        name: "--excluded-model-namespace-mode")
    {
        DefaultValueFactory = _ => AutoSDK.Models.ExcludedModelNamespaceMode.External,
        Description = "How filtered-out dotted models are referenced when --namespace-delimiter is enabled: External or SdkRoot.",
    };

    private Option<bool> GenerateModels { get; } = new(
        name: "--generate-models")
    {
        DefaultValueFactory = _ => true,
        Description = "Generate model classes, enums, and JSON converters. Set to false when referencing types from an existing namespace via --types-namespace.",
    };

    private Option<string> Language { get; } = new(
        name: "--language")
    {
        DefaultValueFactory = _ => "csharp",
        Description = "Generation backend. Currently supported: csharp.",
    };

    public GenerateCommand() : base(name: "generate", description: "Generates client SDK code from OpenAPI/AsyncAPI, or scaffolds a C# gRPC project from a local .proto, descriptor set, or Buf module input.")
    {
        Arguments.Add(Input);
        Options.Add(Output);
        Options.Add(GrpcInputs);
        Options.Add(ApiOutputSubdirectory);
        Options.Add(GrpcOutputSubdirectory);
        Options.Add(TargetFramework);
        Options.Add(Namespace);
        Options.Add(ClientClassName);
        Options.Add(MethodNamingConvention);
        Options.Add(SingleFile);
        Options.Add(ExcludeDeprecatedOperations);
        Options.Add(ClsCompliantEnumPrefix);
        Options.Add(IdentifierCharacterSetOption);
        Options.Add(IgnoreOpenApiErrors);
        Options.Add(IgnoreOpenApiWarnings);
        Options.Add(GenerateModelValidationMethods);
        Options.Add(GenerateRawModelData);
        Options.Add(ComputeDiscriminators);
        Options.Add(GenerateCli);
        Options.Add(UseSystemNetHttpJson);
        Options.Add(GenerateWebhookVerifier);
        Options.Add(WebhookVerifierClassName);
        Options.Add(WebhookIdHeaderName);
        Options.Add(WebhookTimestampHeaderName);
        Options.Add(WebhookSignatureHeaderName);
        Options.Add(WebhookSignatureVersion);
        Options.Add(WebhookTimestampToleranceSeconds);
        Options.Add(GenerateDynamicMultipartHelpers);
        Options.Add(DynamicMultipartHelperClassName);
        Options.Add(GeneratePromptTemplateHelpers);
        Options.Add(PromptTemplateHelperClassName);
        Options.Add(GenerateObservabilityLifecycleHelpers);
        Options.Add(ObservabilityLifecycleHelperClassName);
        Options.Add(GeneratePredictionWorkflowHelpers);
        Options.Add(PredictionWorkflowHelperClassName);
        Options.Add(SecuritySchemes);
        Options.Add(AuthorizationEnvironmentVariables);
        Options.Add(BaseUrl);
        Options.Add(BaseUrlEnvironmentVariables);
        Options.Add(OpenApiOverrides);
        Options.Add(WebSocketClientClassName);
        Options.Add(JsonSerializerContextName);
        Options.Add(TypesNamespace);
        Options.Add(NamespaceDelimiter);
        Options.Add(IncludeModels);
        Options.Add(ExcludeModels);
        Options.Add(ExcludedModelNamespaceMode);
        Options.Add(GenerateModels);
        Options.Add(Language);

        SetAction(HandleAsync);
    }

    private async Task HandleAsync(ParseResult parseResult)
    {
        string input = parseResult.GetRequiredValue(Input);
        string output = parseResult.GetRequiredValue(Output);
        bool singleFile = parseResult.GetRequiredValue(SingleFile);
        string language = parseResult.GetRequiredValue(Language);
        var grpcInputs = parseResult.GetRequiredValue(GrpcInputs).ToImmutableArray();
        var apiOutputSubdirectory = parseResult.GetRequiredValue(ApiOutputSubdirectory);
        var grpcOutputSubdirectory = parseResult.GetRequiredValue(GrpcOutputSubdirectory);
        
        var namespaceValue = parseResult.GetRequiredValue(Namespace);
        var contextName = parseResult.GetRequiredValue(JsonSerializerContextName);
        var contextClassName = string.IsNullOrWhiteSpace(contextName)
            ? "SourceGenerationContext"
            : contextName;

        var generateModels = parseResult.GetRequiredValue(GenerateModels);
        var typesNamespaceValue = parseResult.GetRequiredValue(TypesNamespace);
        var namespaceDelimiterValue = parseResult.GetRequiredValue(NamespaceDelimiter);

        if (!string.IsNullOrEmpty(namespaceDelimiterValue) && namespaceDelimiterValue.Length != 1)
        {
            throw new ArgumentException("--namespace-delimiter must be empty or a single character.");
        }

        if (grpcInputs.Any(static value => string.IsNullOrWhiteSpace(value)))
        {
            throw new ArgumentException("--grpc-input values must be non-empty.");
        }

        if (string.IsNullOrWhiteSpace(apiOutputSubdirectory))
        {
            throw new ArgumentException("--api-output-subdirectory must be non-empty.");
        }

        if (string.IsNullOrWhiteSpace(grpcOutputSubdirectory))
        {
            throw new ArgumentException("--grpc-output-subdirectory must be non-empty.");
        }

        if (string.Equals(
                NormalizePath(apiOutputSubdirectory).TrimEnd('/'),
                NormalizePath(grpcOutputSubdirectory).TrimEnd('/'),
                StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException("--api-output-subdirectory and --grpc-output-subdirectory must be different.");
        }

        if (!generateModels && string.IsNullOrWhiteSpace(typesNamespaceValue))
        {
            Console.WriteLine("Warning: --generate-models false without --types-namespace means no model files will be generated and type references will use the main namespace. This is likely a misconfiguration. Consider adding --types-namespace to reference types from an existing namespace.");
        }

        Settings settings = Settings.Default with
        {
            TargetFramework = parseResult.GetRequiredValue(TargetFramework),
            Namespace = namespaceValue,
            ClassName = parseResult.GetRequiredValue(ClientClassName),
            ClsCompliantEnumPrefix = parseResult.GetRequiredValue(ClsCompliantEnumPrefix),
            IdentifierCharacterSet = parseResult.GetRequiredValue(IdentifierCharacterSetOption),
            MethodNamingConvention = parseResult.GetRequiredValue(MethodNamingConvention),
            ExcludeDeprecatedOperations = parseResult.GetRequiredValue(ExcludeDeprecatedOperations),
            JsonSerializerContext = $"{namespaceValue}.{contextClassName}",
            GenerateJsonSerializerContextTypes = true,
            GenerateModels = generateModels,
            IncludeModels = parseResult.GetRequiredValue(IncludeModels).ToImmutableArray(),
            ExcludeModels = parseResult.GetRequiredValue(ExcludeModels).ToImmutableArray(),
            NamespaceDelimiter = namespaceDelimiterValue,
            ExcludedModelNamespaceMode = parseResult.GetRequiredValue(ExcludedModelNamespaceMode),
            ComputeDiscriminators = parseResult.GetRequiredValue(ComputeDiscriminators),
            GenerateModelValidationMethods = parseResult.GetRequiredValue(GenerateModelValidationMethods),
            GenerateRawModelData = parseResult.GetRequiredValue(GenerateRawModelData),
            IgnoreOpenApiErrors = parseResult.GetRequiredValue(IgnoreOpenApiErrors),
            IgnoreOpenApiWarnings = parseResult.GetRequiredValue(IgnoreOpenApiWarnings),
            GenerateMethodsUsingSystemNetHttpJson = parseResult.GetRequiredValue(UseSystemNetHttpJson),
            GenerateWebhookVerifier = parseResult.GetRequiredValue(GenerateWebhookVerifier),
            WebhookVerifierClassName = parseResult.GetRequiredValue(WebhookVerifierClassName),
            WebhookIdHeaderName = parseResult.GetRequiredValue(WebhookIdHeaderName),
            WebhookTimestampHeaderName = parseResult.GetRequiredValue(WebhookTimestampHeaderName),
            WebhookSignatureHeaderName = parseResult.GetRequiredValue(WebhookSignatureHeaderName),
            WebhookSignatureVersion = parseResult.GetRequiredValue(WebhookSignatureVersion),
            WebhookTimestampToleranceSeconds = parseResult.GetRequiredValue(WebhookTimestampToleranceSeconds),
            GenerateDynamicMultipartHelpers = parseResult.GetRequiredValue(GenerateDynamicMultipartHelpers),
            DynamicMultipartHelperClassName = parseResult.GetRequiredValue(DynamicMultipartHelperClassName),
            GeneratePromptTemplateHelpers = parseResult.GetRequiredValue(GeneratePromptTemplateHelpers),
            PromptTemplateHelperClassName = parseResult.GetRequiredValue(PromptTemplateHelperClassName),
            GenerateObservabilityLifecycleHelpers = parseResult.GetRequiredValue(GenerateObservabilityLifecycleHelpers),
            ObservabilityLifecycleHelperClassName = parseResult.GetRequiredValue(ObservabilityLifecycleHelperClassName),
            GeneratePredictionWorkflowHelpers = parseResult.GetRequiredValue(GeneratePredictionWorkflowHelpers),
            PredictionWorkflowHelperClassName = parseResult.GetRequiredValue(PredictionWorkflowHelperClassName),
            FromCli = true,
            GenerateCli = parseResult.GetRequiredValue(GenerateCli),
            SecuritySchemes = parseResult.GetRequiredValue(SecuritySchemes).ToImmutableArray(),
            AuthorizationEnvironmentVariables = parseResult.GetRequiredValue(AuthorizationEnvironmentVariables).ToImmutableArray(),
            BaseUrl = parseResult.GetRequiredValue(BaseUrl),
            BaseUrlEnvironmentVariables = parseResult.GetRequiredValue(BaseUrlEnvironmentVariables).ToImmutableArray(),
            OpenApiOverrides = parseResult.GetRequiredValue(OpenApiOverrides).ToImmutableArray(),
            GenerateWebSocketClient = true,
            WebSocketClientClassName = parseResult.GetRequiredValue(WebSocketClientClassName),
            TypesNamespace = typesNamespaceValue,
        };
            
        if (!string.Equals(language, "csharp", StringComparison.OrdinalIgnoreCase))
        {
            throw new NotSupportedException($"Unsupported language '{language}'. Currently only 'csharp' is supported.");
        }

        var isPrimaryGrpcInput = GrpcProjectScaffolder.CanHandleInput(input);
        if (grpcInputs.Length > 0 && isPrimaryGrpcInput)
        {
            throw new ArgumentException(
                "Mixed-mode generation expects the primary input to be OpenAPI/AsyncAPI. " +
                "Use --grpc-input for the protobuf sidecars and keep the main input as the REST spec.");
        }

        if (isPrimaryGrpcInput)
        {
            Console.WriteLine($"Loading {input}...");
            Console.WriteLine("Scaffolding gRPC project...");
            await GrpcProjectScaffolder.ScaffoldAsync(
                input,
                output,
                settings.Namespace,
                settings.TargetFramework).ConfigureAwait(false);
            Console.WriteLine("Done.");
            return;
        }

        Console.WriteLine($"Loading {input}...");

        using var client = new HttpClient();
        var yaml = input.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? await client.GetStringAsync(new Uri(input)).ConfigureAwait(false)
            : await File.ReadAllTextAsync(input).ConfigureAwait(false);

        var name = Path.GetFileNameWithoutExtension(input);

        if (string.IsNullOrWhiteSpace(settings.Namespace))
        {
            settings = settings with
            {
                Namespace = name.ToPropertyName()
                    .UseWordSeparator('\\', '-', '.', '_', '/'),
            };
        }
        if (string.IsNullOrWhiteSpace(settings.ClassName))
        {
            settings = settings with
            {
                ClassName = $"{name.ToPropertyName()
                    .UseWordSeparator('\\', '-', '.', '_', '/')}Client",
            };
        }

        var specFormat = SpecFormatDetector.DetectFormat(yaml);
        if (specFormat == SpecFormat.GrpcProto)
        {
            Console.WriteLine("Scaffolding gRPC project...");
            await GrpcProjectScaffolder.ScaffoldAsync(
                input,
                output,
                settings.Namespace,
                settings.TargetFramework,
                protoText: yaml).ConfigureAwait(false);
            Console.WriteLine("Done.");
            return;
        }

        Console.WriteLine("Generating...");

        var data = CSharpPipeline.PrepareAndEnrich(
            ((yaml, settings), GlobalSettings: settings));

        if (settings.GenerateJsonSerializerContextTypes &&
            string.IsNullOrWhiteSpace(data.Converters.Settings.JsonSerializerContext))
        {
            Console.WriteLine("Warning: Disabled generated System.Text.Json source-generation context because some union-heavy types exceeded compiler metadata limits.");
        }

        var files = CSharpLanguagePlugin.Instance
            .GenerateFiles(data)
            .Where(x => !x.IsEmpty)
            .ToArray();

        var apiOutput = grpcInputs.Length > 0
            ? Path.Combine(output, apiOutputSubdirectory)
            : output;

        Directory.CreateDirectory(apiOutput);
        
        if (singleFile)
        {
            var text = string.Join(Environment.NewLine, files.Select(x => x.Text));
            await File.WriteAllTextAsync(Path.Combine(apiOutput, $"{name}.cs"), text).ConfigureAwait(false);
        }
        else
        {
            foreach (var file in files)
            {
                await File.WriteAllTextAsync(Path.Combine(apiOutput, file.Name), file.Text).ConfigureAwait(false);
            }
        }

        if (specFormat == SpecFormat.OpenApi)
        {
            var document = yaml.GetOpenApiDocument(settings);
            var schemas = document.GetSchemas(settings);
            var operations = document.GetOperations(settings, settings, schemas);
            if (settings.ExcludeDeprecatedOperations)
            {
                operations = operations
                    .Where(static operation => !operation.Operation.IsDeprecated())
                    .ToArray();
            }

            var snippetManifest = Sources.SnippetManifest(operations, data.Methods.ToArray());
            if (!snippetManifest.IsEmpty)
            {
                await File.WriteAllTextAsync(
                    Path.Combine(output, snippetManifest.Name),
                    snippetManifest.Text).ConfigureAwait(false);
            }
        }

        if (grpcInputs.Length > 0)
        {
            await ScaffoldMixedModeGrpcInputsAsync(
                grpcInputs,
                output,
                grpcOutputSubdirectory,
                settings.Namespace,
                settings.TargetFramework).ConfigureAwait(false);

            await File.WriteAllTextAsync(
                Path.Combine(output, "README.md"),
                RenderMixedModeReadme(
                    input,
                    apiOutputSubdirectory,
                    grpcOutputSubdirectory,
                    grpcInputs),
                cancellationToken: default).ConfigureAwait(false);
        }
        
        Console.WriteLine("Done.");
    }

    private static async Task ScaffoldMixedModeGrpcInputsAsync(
        ImmutableArray<string> grpcInputs,
        string output,
        string grpcOutputSubdirectory,
        string namespaceValue,
        string targetFramework)
    {
        var grpcRoot = Path.Combine(output, grpcOutputSubdirectory);
        Directory.CreateDirectory(grpcRoot);

        foreach (var grpcInput in grpcInputs)
        {
            var projectName = GrpcProjectScaffolder.GetSuggestedProjectName(grpcInput);
            var grpcOutput = Path.Combine(grpcRoot, projectName);

            Console.WriteLine($"Scaffolding gRPC project for {grpcInput}...");
            await GrpcProjectScaffolder.ScaffoldAsync(
                grpcInput,
                grpcOutput,
                namespaceValue,
                targetFramework).ConfigureAwait(false);
        }
    }

    private static string RenderMixedModeReadme(
        string primaryInput,
        string apiOutputSubdirectory,
        string grpcOutputSubdirectory,
        ImmutableArray<string> grpcInputs)
    {
        var grpcProjectLines = string.Join(
            Environment.NewLine,
            grpcInputs.Select(grpcInput =>
                $"- `{NormalizePath(Path.Combine(grpcOutputSubdirectory, GrpcProjectScaffolder.GetSuggestedProjectName(grpcInput)))}` from `{grpcInput}`"));

        return $$"""
                 # Mixed OpenAPI + gRPC Output

                 This layout was generated by AutoSDK from one primary REST/OpenAPI-style input plus additional protobuf inputs.

                 ## Included

                 - primary input: `{{primaryInput}}`
                 - API output: `{{NormalizePath(apiOutputSubdirectory)}}`
                 {{grpcProjectLines}}

                 ## Usage

                 1. Consume the OpenAPI/AsyncAPI-generated C# files from `{{NormalizePath(apiOutputSubdirectory)}}`
                 2. Build each scaffolded gRPC project under `{{NormalizePath(grpcOutputSubdirectory)}}`
                 3. Keep the split layout if you want deterministic file boundaries between REST and gRPC outputs

                 ## Notes

                 - Use `--api-output-subdirectory` and `--grpc-output-subdirectory` to customize the mixed-mode layout
                 - Existing `--namespace` and proto `csharp_namespace` settings still control the generated namespaces inside each output
                 """;
    }

    private static string NormalizePath(string path)
    {
        return path.Replace('\\', '/');
    }
}
