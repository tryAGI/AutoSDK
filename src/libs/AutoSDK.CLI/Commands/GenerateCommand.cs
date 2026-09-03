using System.Collections.Immutable;
using System.CommandLine;
using System.Diagnostics;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;
using AutoSDK.Packaging;

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

    private Option<bool> GenerateHttpExceptionHierarchy { get; } = new(
        name: "--generate-http-exception-hierarchy")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateHttpExceptionHierarchy,
        Description = "Generate opt-in typed HTTP exception subclasses (AuthenticationException, RateLimitException, etc.) routed by status code so consumers can catch by intent instead of switching on StatusCode.",
    };

    private Option<bool> GenerateIdempotencyHelpers { get; } = new(
        name: "--generate-idempotency-helpers")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateIdempotencyHelpers,
        Description = "Add an optional idempotencyKey parameter to every POST/PUT/PATCH/DELETE operation even when the spec doesn't declare x-fern-idempotent / x-idempotency. The SDK auto-generates a key when the caller passes null, via the configurable CreateIdempotencyKey delegate.",
    };

    private Option<string> IdempotencyHeaderName { get; } = new(
        name: "--idempotency-header-name")
    {
        DefaultValueFactory = _ => Settings.Default.IdempotencyHeaderName,
        Description = "Header name written when --generate-idempotency-helpers is on (or when the spec sets x-idempotency without naming a header). Default: Idempotency-Key.",
    };

    private Option<bool> GenerateRetryHandler { get; } = new(
        name: "--generate-retry-handler")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateRetryHandler,
        Description = "Default AutoSDKRetryOptions to vendor-SDK defaults (3 attempts, 500ms exponential backoff, retry on 408/409/429/5xx + HttpRequestException + SocketException, honor Retry-After). Consumers can still override per-call via AutoSDKRequestOptions.",
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

    private Option<bool> GenerateMultipartUploadHelpers { get; } = new(
        name: "--generate-multipart-upload-helpers")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateMultipartUploadHelpers,
        Description = "Emit a typed AutoSDKUploadFile runtime helper (Filename + Content + ContentType) with FromBytes/FromStream/FromPath static factories and built-in MIME-type guessing. Used to replace hand-rolled MultipartFormDataContent in consumer code.",
    };

    private Option<string> MultipartUploadHelperClassName { get; } = new(
        name: "--multipart-upload-helper-class-name")
    {
        DefaultValueFactory = _ => Settings.Default.MultipartUploadHelperClassName,
        Description = "Class name for the generated typed multipart upload helper (default: AutoSDKUploadFile).",
    };

    private Option<bool> GeneratePolymorphicArrayHelpers { get; } = new(
        name: "--generate-polymorphic-array-helpers")
    {
        DefaultValueFactory = _ => Settings.Default.GeneratePolymorphicArrayHelpers,
        Description = "Emit an AutoSDKPolymorphicFormat<TBase> base class plus a reusable JsonConverter that round-trips array items shaped as oneOf{string-enum, object-with-type-const}. Consumer code hand-models the variant subclasses and registers them via [AutoSDKPolymorphicFormatVariant(\"name\", typeof(...))].",
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

    private Option<bool> GenerateEvaluationWorkflowHelpers { get; } = new(
        name: "--generate-evaluation-workflow-helpers")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateEvaluationWorkflowHelpers,
        Description = "Generate opt-in dataset evaluation and experiment workflow helper APIs.",
    };

    private Option<string> EvaluationWorkflowHelperClassName { get; } = new(
        name: "--evaluation-workflow-helper-class-name")
    {
        DefaultValueFactory = _ => Settings.Default.EvaluationWorkflowHelperClassName,
        Description = "Class name for the generated evaluation workflow helper.",
    };

    private Option<bool> GenerateCloudSigningHelpers { get; } = new(
        name: "--generate-cloud-signing-helpers")
    {
        DefaultValueFactory = _ => Settings.Default.GenerateCloudSigningHelpers,
        Description = "Generate opt-in cloud credential and request-signing helper adapters.",
    };

    private Option<string> CloudSigningHelperClassName { get; } = new(
        name: "--cloud-signing-helper-class-name")
    {
        DefaultValueFactory = _ => Settings.Default.CloudSigningHelperClassName,
        Description = "Class name for the generated cloud signing helper factory.",
    };

    private Option<bool> AutoDetectStatusPolling { get; } = new(
        name: "--auto-detect-status-polling")
    {
        DefaultValueFactory = _ => Settings.Default.AutoDetectStatusPolling,
        Description = "Auto-emit a polling helper for GET endpoints whose response shape exposes a status enum/const property with a terminal-success state (succeeded/completed/done/finished).",
    };

    private Option<bool> GeneratePageableHelpers { get; } = new(
        name: "--generate-pageable-helpers")
    {
        DefaultValueFactory = _ => Settings.Default.GeneratePageableHelpers,
        Description = "Emit an AutoSDKPager runtime helper with OffsetAsync and CursorAsync overloads that turn raw page methods into IAsyncEnumerable<TItem> streams.",
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

    private Option<bool> DirectionAwareJsonGenerationMode { get; } = new(
        name: "--direction-aware-json-generation-mode")
    {
        DefaultValueFactory = _ => Settings.Default.DirectionAwareJsonGenerationMode,
        Description = "Infer per-type serialization direction from the operation graph and emit the narrowest safe JsonSourceGenerationMode on each [JsonSerializable] registration. " +
                      "Types reached only through responses drop their unused fast-path serializer; types reached in both directions keep the default mode.",
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

    private Option<bool> Diagnostics { get; } = new(
        name: "--diagnostics")
    {
        DefaultValueFactory = _ => false,
        Description = "Print generation phase timings, allocations, and generated-file write statistics to stderr.",
    };

    private Option<bool> CleanStaleFiles { get; } = new(
        name: "--clean-stale-files")
    {
        DefaultValueFactory = _ => false,
        Description = "Delete stale AutoSDK-generated .g.cs, single-file, and snippet-manifest outputs that are no longer produced. Use only with a dedicated generated output directory.",
    };

    private Option<bool> SplitByTags { get; } = new(
        name: "--split-by-tags")
    {
        DefaultValueFactory = _ => false,
        Description = "Emit a family of per-tag projects/packages instead of one project: a shared '<package-id>.Core', one package per OpenAPI tag, a base package that reassembles the full SDK, a solution, and a deterministic autosdk-packages.json manifest. Consumers can then reference only the tags they use.",
    };

    private Option<string> PackageId { get; } = new(
        name: "--package-id")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Base NuGet package id for --split-by-tags, e.g. 'tryAGI.GitHub'. Tag packages become '<package-id>.<Tag>' and shared code lands in '<package-id>.Core'. Defaults to the namespace.",
    };

    private Option<string> PackagesOutput { get; } = new(
        name: "--packages-output")
    {
        DefaultValueFactory = _ => "GeneratedPackages",
        Description = "Directory the --split-by-tags package family is written to, relative to --output.",
    };

    private Option<string> PackageMap { get; } = new(
        name: "--package-map")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Path to a JSON file of the form {\"tags\":{\"<tag>\":\"<PackageSuffix>\"}} that overrides --split-by-tags package names. Several tags may map to the same suffix to group them into one package.",
    };

    private Option<string> StrongNamePublicKey { get; } = new(
        name: "--strong-name-public-key")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Hex-encoded strong-name public key of the generated assemblies. When set, --split-by-tags keeps shared runtime members internal and emits InternalsVisibleTo across the family instead of widening them to public.",
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
        Options.Add(GenerateHttpExceptionHierarchy);
        Options.Add(GenerateIdempotencyHelpers);
        Options.Add(IdempotencyHeaderName);
        Options.Add(GenerateRetryHandler);
        Options.Add(GenerateWebhookVerifier);
        Options.Add(WebhookVerifierClassName);
        Options.Add(WebhookIdHeaderName);
        Options.Add(WebhookTimestampHeaderName);
        Options.Add(WebhookSignatureHeaderName);
        Options.Add(WebhookSignatureVersion);
        Options.Add(WebhookTimestampToleranceSeconds);
        Options.Add(GenerateDynamicMultipartHelpers);
        Options.Add(DynamicMultipartHelperClassName);
        Options.Add(GenerateMultipartUploadHelpers);
        Options.Add(MultipartUploadHelperClassName);
        Options.Add(GeneratePolymorphicArrayHelpers);
        Options.Add(GeneratePromptTemplateHelpers);
        Options.Add(PromptTemplateHelperClassName);
        Options.Add(GenerateObservabilityLifecycleHelpers);
        Options.Add(ObservabilityLifecycleHelperClassName);
        Options.Add(GeneratePredictionWorkflowHelpers);
        Options.Add(PredictionWorkflowHelperClassName);
        Options.Add(GenerateEvaluationWorkflowHelpers);
        Options.Add(EvaluationWorkflowHelperClassName);
        Options.Add(GenerateCloudSigningHelpers);
        Options.Add(CloudSigningHelperClassName);
        Options.Add(AutoDetectStatusPolling);
        Options.Add(GeneratePageableHelpers);
        Options.Add(SecuritySchemes);
        Options.Add(AuthorizationEnvironmentVariables);
        Options.Add(BaseUrl);
        Options.Add(BaseUrlEnvironmentVariables);
        Options.Add(OpenApiOverrides);
        Options.Add(WebSocketClientClassName);
        Options.Add(JsonSerializerContextName);
        Options.Add(DirectionAwareJsonGenerationMode);
        Options.Add(TypesNamespace);
        Options.Add(NamespaceDelimiter);
        Options.Add(IncludeModels);
        Options.Add(ExcludeModels);
        Options.Add(ExcludedModelNamespaceMode);
        Options.Add(GenerateModels);
        Options.Add(Language);
        Options.Add(Diagnostics);
        Options.Add(CleanStaleFiles);
        Options.Add(SplitByTags);
        Options.Add(PackageId);
        Options.Add(PackagesOutput);
        Options.Add(PackageMap);
        Options.Add(StrongNamePublicKey);

        SetAction(HandleAsync);
    }

    private async Task HandleAsync(ParseResult parseResult)
    {
        var totalTime = Stopwatch.StartNew();
        string input = parseResult.GetRequiredValue(Input);
        string output = parseResult.GetRequiredValue(Output);
        bool singleFile = parseResult.GetRequiredValue(SingleFile);
        bool diagnosticsEnabled = parseResult.GetRequiredValue(Diagnostics);
        bool cleanStaleFiles = parseResult.GetRequiredValue(CleanStaleFiles);
        var allocationStart = GetAllocatedBytes(diagnosticsEnabled);
        string language = parseResult.GetRequiredValue(Language);
        var grpcInputs = parseResult.GetRequiredValue(GrpcInputs).ToImmutableArray();
        var apiOutputSubdirectory = parseResult.GetRequiredValue(ApiOutputSubdirectory);
        var grpcOutputSubdirectory = parseResult.GetRequiredValue(GrpcOutputSubdirectory);
        
        var splitByTags = parseResult.GetRequiredValue(SplitByTags);
        var packageIdValue = parseResult.GetRequiredValue(PackageId);
        var packagesOutputValue = parseResult.GetRequiredValue(PackagesOutput);
        var packageMapValue = parseResult.GetRequiredValue(PackageMap);
        var strongNamePublicKeyValue = parseResult.GetRequiredValue(StrongNamePublicKey).Trim();

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

        if (splitByTags)
        {
            if (singleFile)
            {
                throw new ArgumentException("--split-by-tags and --single-file are mutually exclusive.");
            }

            if (grpcInputs.Length > 0)
            {
                throw new ArgumentException("--split-by-tags does not support mixed-mode gRPC generation. Generate the gRPC sidecars separately.");
            }

            // --generate-cli replaces model/client generation rather than adding to it, so the
            // family would have no clients to split and its Core would hold command classes that
            // reference tag clients — the one direction the graph must never point.
            if (parseResult.GetRequiredValue(GenerateCli))
            {
                throw new ArgumentException("--split-by-tags and --generate-cli are mutually exclusive. Generate the SDK family first, then run 'autosdk cli-project' against it.");
            }

            if (string.IsNullOrWhiteSpace(packagesOutputValue))
            {
                throw new ArgumentException("--packages-output must be non-empty.");
            }

            if (!string.IsNullOrEmpty(strongNamePublicKeyValue) &&
                !strongNamePublicKeyValue.All(Uri.IsHexDigit))
            {
                throw new ArgumentException("--strong-name-public-key must be the hex-encoded public key, with no '0x' prefix or separators.");
            }

            if (!string.IsNullOrWhiteSpace(packageMapValue) && !File.Exists(packageMapValue))
            {
                throw new ArgumentException($"--package-map file '{packageMapValue}' does not exist.");
            }
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
            DirectionAwareJsonGenerationMode = parseResult.GetRequiredValue(DirectionAwareJsonGenerationMode),
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
            GenerateHttpExceptionHierarchy = parseResult.GetRequiredValue(GenerateHttpExceptionHierarchy),
            GenerateIdempotencyHelpers = parseResult.GetRequiredValue(GenerateIdempotencyHelpers),
            IdempotencyHeaderName = parseResult.GetRequiredValue(IdempotencyHeaderName),
            GenerateRetryHandler = parseResult.GetRequiredValue(GenerateRetryHandler),
            GenerateWebhookVerifier = parseResult.GetRequiredValue(GenerateWebhookVerifier),
            WebhookVerifierClassName = parseResult.GetRequiredValue(WebhookVerifierClassName),
            WebhookIdHeaderName = parseResult.GetRequiredValue(WebhookIdHeaderName),
            WebhookTimestampHeaderName = parseResult.GetRequiredValue(WebhookTimestampHeaderName),
            WebhookSignatureHeaderName = parseResult.GetRequiredValue(WebhookSignatureHeaderName),
            WebhookSignatureVersion = parseResult.GetRequiredValue(WebhookSignatureVersion),
            WebhookTimestampToleranceSeconds = parseResult.GetRequiredValue(WebhookTimestampToleranceSeconds),
            GenerateDynamicMultipartHelpers = parseResult.GetRequiredValue(GenerateDynamicMultipartHelpers),
            DynamicMultipartHelperClassName = parseResult.GetRequiredValue(DynamicMultipartHelperClassName),
            GenerateMultipartUploadHelpers = parseResult.GetRequiredValue(GenerateMultipartUploadHelpers),
            MultipartUploadHelperClassName = parseResult.GetRequiredValue(MultipartUploadHelperClassName),
            GeneratePolymorphicArrayHelpers = parseResult.GetRequiredValue(GeneratePolymorphicArrayHelpers),
            GeneratePromptTemplateHelpers = parseResult.GetRequiredValue(GeneratePromptTemplateHelpers),
            PromptTemplateHelperClassName = parseResult.GetRequiredValue(PromptTemplateHelperClassName),
            GenerateObservabilityLifecycleHelpers = parseResult.GetRequiredValue(GenerateObservabilityLifecycleHelpers),
            ObservabilityLifecycleHelperClassName = parseResult.GetRequiredValue(ObservabilityLifecycleHelperClassName),
            GeneratePredictionWorkflowHelpers = parseResult.GetRequiredValue(GeneratePredictionWorkflowHelpers),
            PredictionWorkflowHelperClassName = parseResult.GetRequiredValue(PredictionWorkflowHelperClassName),
            GenerateEvaluationWorkflowHelpers = parseResult.GetRequiredValue(GenerateEvaluationWorkflowHelpers),
            EvaluationWorkflowHelperClassName = parseResult.GetRequiredValue(EvaluationWorkflowHelperClassName),
            GenerateCloudSigningHelpers = parseResult.GetRequiredValue(GenerateCloudSigningHelpers),
            CloudSigningHelperClassName = parseResult.GetRequiredValue(CloudSigningHelperClassName),
            AutoDetectStatusPolling = parseResult.GetRequiredValue(AutoDetectStatusPolling),
            GeneratePageableHelpers = parseResult.GetRequiredValue(GeneratePageableHelpers),
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
            SplitByTags = splitByTags,
            BasePackageId = packageIdValue,
            PackageMapPath = packageMapValue,
            StrongNamePublicKey = strongNamePublicKeyValue,
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

        var setupElapsed = totalTime.Elapsed;
        Console.WriteLine($"Loading {input}...");

        using var client = new HttpClient();
        var inputReadTime = Stopwatch.StartNew();
        var yaml = input.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? await client.GetStringAsync(new Uri(input)).ConfigureAwait(false)
            : await File.ReadAllTextAsync(input).ConfigureAwait(false);
        inputReadTime.Stop();

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

        var packagesRoot = splitByTags
            ? Path.Combine(output, packagesOutputValue)
            : string.Empty;
        var apiOutput = grpcInputs.Length > 0
            ? Path.Combine(output, apiOutputSubdirectory)
            : output;

        // The tag overrides live in a file that Settings records only by path, and the packages
        // root comes from an option that never reaches Settings at all. Both reshape the output
        // tree, so both have to be read before the cache is consulted and folded into its key --
        // otherwise editing the map in place is a cache hit that leaves a stale family on disk.
        IReadOnlyDictionary<string, string>? tagPackageOverrides = null;
        var packagingInputs = string.Empty;
        if (splitByTags)
        {
            tagPackageOverrides = string.IsNullOrWhiteSpace(packageMapValue)
                ? null
                : await PackageMapFile.ReadAsync(packageMapValue).ConfigureAwait(false);
            packagingInputs = DescribePackagingInputs(packagesOutputValue, tagPackageOverrides);
        }
        var staleCandidates = cleanStaleFiles
            ? (splitByTags
                ? CollectStalePackageFamilyFiles(packagesRoot).ToArray()
                : CollectStaleGeneratedFiles(apiOutput, output, name).ToArray())
            : [];
        var generatorFingerprint = string.Empty;
        var cacheValidation = new GenerationCacheValidation(false, "mixed_mode_disabled", default, []);
        var cacheLockTime = Stopwatch.StartNew();
        var cacheLock = await GenerationCache
            .AcquireOutputLockAsync(output)
            .ConfigureAwait(false);
        await using var cacheLockScope = cacheLock.ConfigureAwait(false);
        cacheLockTime.Stop();
        var cacheValidationTime = Stopwatch.StartNew();
        var allocationBeforeCache = GetAllocatedBytes(diagnosticsEnabled);
        if (grpcInputs.IsEmpty)
        {
            generatorFingerprint = GenerationCache.CreateGeneratorFingerprint(
                yaml,
                settings,
                singleFile,
                name,
                packagingInputs);
            cacheValidation = await GenerationCache.TryValidateAsync(
                output,
                generatorFingerprint,
                staleCandidates,
                rejectUnexpectedGeneratedFiles: cleanStaleFiles).ConfigureAwait(false);
        }
        cacheValidationTime.Stop();
        var allocationAfterCacheValidation = GetAllocatedBytes(diagnosticsEnabled);

        if (cacheValidation.Hit)
        {
            totalTime.Stop();
            var cacheHitAllocationEnd = GetAllocatedBytes(diagnosticsEnabled);
            if (diagnosticsEnabled)
            {
                await new GenerationDiagnostics(
                    CacheHit: true,
                    CacheReason: cacheValidation.Reason,
                    CacheLockAcquired: cacheLock.Acquired,
                    CacheLockReason: cacheLock.Reason,
                    Total: totalTime.Elapsed,
                    Setup: setupElapsed,
                    InputRead: inputReadTime.Elapsed,
                    CacheLockWait: cacheLockTime.Elapsed,
                    CacheValidation: cacheValidationTime.Elapsed,
                    Pipeline: TimeSpan.Zero,
                    Render: TimeSpan.Zero,
                    SnippetManifest: TimeSpan.Zero,
                    NormalizeCompareWriteAndCleanup: TimeSpan.Zero,
                    CacheWrite: TimeSpan.Zero,
                    CoreTimes: default,
                    RenderPhases: [],
                    RenderHotspots: [],
                    Files: cacheValidation.Files,
                    TotalAllocatedBytes: cacheHitAllocationEnd - allocationStart,
                    CacheAllocatedBytes: cacheHitAllocationEnd - allocationBeforeCache,
                    PipelineAllocatedBytes: 0,
                    RenderAllocatedBytes: 0,
                    SnippetAllocatedBytes: 0,
                    WriteAllocatedBytes: 0)
                    .WriteAsync(Console.Error).ConfigureAwait(false);
            }

            Console.WriteLine("Generation cache hit.");
            Console.WriteLine("Done.");
            return;
        }

        Console.WriteLine("Generating...");

        var allocationBeforePipeline = GetAllocatedBytes(diagnosticsEnabled);
        var pipelineTime = Stopwatch.StartNew();
        var (data, coreResult) = CSharpPipeline.PrepareAndEnrichWithCoreResult(
            ((yaml, settings), GlobalSettings: settings));
        pipelineTime.Stop();
        var allocationAfterPipeline = GetAllocatedBytes(diagnosticsEnabled);

        if (settings.GenerateJsonSerializerContextTypes &&
            string.IsNullOrWhiteSpace(data.Converters.Settings.JsonSerializerContext))
        {
            Console.WriteLine("Warning: Disabled generated System.Text.Json source-generation context because some union-heavy types exceeded compiler metadata limits.");
        }

        if (ShouldWarnAboutEmptyGeneratedSurface(settings, data))
        {
            Console.WriteLine("Warning: No endpoint or model files were generated. Check that the input specification contains supported paths/schemas and that any upstream fetch step succeeded.");
        }

        if (settings.DirectionAwareJsonGenerationMode &&
            !data.Types.IsEmpty)
        {
            Console.WriteLine(JsonSerializationDirectionAnalyzer.CreateReport(data).ToString());
        }

        var renderTime = Stopwatch.StartNew();
        var renderResult = diagnosticsEnabled
            ? CSharpPipeline.GenerateFilesWithDiagnostics(data)
            : new CSharpRenderResult(
                CSharpLanguagePlugin.Instance.GenerateFiles(data).Where(x => !x.IsEmpty).ToArray(),
                []);
        var files = renderResult.Files;
        renderTime.Stop();
        var allocationAfterRender = GetAllocatedBytes(diagnosticsEnabled);
        var renderHotspots = diagnosticsEnabled
            ? files
                .OrderByDescending(static file => file.Text.Length)
                .Take(5)
                .Select(static file => new RenderHotspot(file.Name, file.Text.Length))
                .ToArray()
            : [];

        var generatedOutputs = new List<GeneratedOutputFile>(files.Count + 2);
        PackagePlan? packagePlan = null;
        if (splitByTags)
        {
            if (!PackagePlanner.TryCreate(data, tagPackageOverrides, out var plan, out var planError))
            {
                throw new InvalidOperationException(planError);
            }

            packagePlan = plan;
            foreach (var file in files)
            {
                generatedOutputs.Add(new GeneratedOutputFile(
                    Path.Combine(
                        packagesRoot,
                        plan!.Value.ResolvePackageId(file.Name),
                        PackageFamilyScaffolder.GeneratedDirectoryName,
                        file.Name),
                    file.Text));
            }

            foreach (var (relativePath, text) in PackageFamilyScaffolder.CreateFiles(plan!.Value, strongNamePublicKeyValue))
            {
                generatedOutputs.Add(new GeneratedOutputFile(Path.Combine(packagesRoot, relativePath), text));
            }
        }
        else if (singleFile)
        {
            var text = string.Join(Environment.NewLine, files.Select(x => x.Text));
            generatedOutputs.Add(new GeneratedOutputFile(Path.Combine(apiOutput, $"{name}.cs"), text));
        }
        else
        {
            foreach (var file in files)
            {
                generatedOutputs.Add(new GeneratedOutputFile(Path.Combine(apiOutput, file.Name), file.Text));
            }
        }

        var snippetManifestTime = Stopwatch.StartNew();
        if (specFormat == SpecFormat.OpenApi)
        {
            var document = coreResult.OpenApiDocument ??
                throw new InvalidOperationException("The OpenAPI pipeline did not retain its parsed document.");
            var operations = document.GetOperations(settings, settings, coreResult.Schemas);
            if (settings.ExcludeDeprecatedOperations)
            {
                operations = operations
                    .Where(static operation => !operation.Operation.IsDeprecated())
                    .ToArray();
            }

            var snippetManifest = Sources.SnippetManifest(operations, data.Methods.ToArray());
            if (!snippetManifest.IsEmpty)
            {
                generatedOutputs.Add(new GeneratedOutputFile(
                    Path.Combine(output, snippetManifest.Name),
                    snippetManifest.Text));
            }
        }
        snippetManifestTime.Stop();
        var allocationAfterSnippet = GetAllocatedBytes(diagnosticsEnabled);

        if (grpcInputs.Length > 0)
        {
            generatedOutputs.Add(new GeneratedOutputFile(
                Path.Combine(output, "README.md"),
                RenderMixedModeReadme(
                    input,
                    apiOutputSubdirectory,
                    grpcOutputSubdirectory,
                    grpcInputs)));
        }

        var writeTime = Stopwatch.StartNew();
        var writeResult = await GeneratedFileWriter.WriteAsync(
            generatedOutputs,
            staleCandidates,
            deleteStaleFiles: cleanStaleFiles,
            cachedFiles: cacheValidation.KnownFiles,
            collectDiagnostics: diagnosticsEnabled).ConfigureAwait(false);
        writeTime.Stop();
        var allocationAfterWrite = GetAllocatedBytes(diagnosticsEnabled);

        if (cleanStaleFiles && packagePlan is not null)
        {
            RemoveStalePackageDirectories(packagesRoot, packagePlan.Value);
        }

        if (packagePlan is not null)
        {
            Console.WriteLine(
                $"Generated {packagePlan.Value.Packages.Length} packages into {packagesRoot} " +
                $"({packagePlan.Value.TagPackages.Count()} tag package(s) plus Core and the base package).");
        }

        var cacheWriteTime = Stopwatch.StartNew();
        if (grpcInputs.IsEmpty)
        {
            await GenerationCache.SaveAsync(
                output,
                generatorFingerprint,
                writeResult.CacheFiles).ConfigureAwait(false);
        }
        cacheWriteTime.Stop();

        if (grpcInputs.Length > 0)
        {
            await ScaffoldMixedModeGrpcInputsAsync(
                grpcInputs,
                output,
                grpcOutputSubdirectory,
                settings.Namespace,
                settings.TargetFramework).ConfigureAwait(false);
        }

        totalTime.Stop();
        var allocationEnd = GetAllocatedBytes(diagnosticsEnabled);
        if (diagnosticsEnabled)
        {
            await new GenerationDiagnostics(
                CacheHit: false,
                CacheReason: cacheValidation.Reason,
                CacheLockAcquired: cacheLock.Acquired,
                CacheLockReason: cacheLock.Reason,
                Total: totalTime.Elapsed,
                Setup: setupElapsed,
                InputRead: inputReadTime.Elapsed,
                CacheLockWait: cacheLockTime.Elapsed,
                CacheValidation: cacheValidationTime.Elapsed,
                Pipeline: pipelineTime.Elapsed,
                Render: renderTime.Elapsed,
                SnippetManifest: snippetManifestTime.Elapsed,
                NormalizeCompareWriteAndCleanup: writeTime.Elapsed,
                CacheWrite: cacheWriteTime.Elapsed,
                CoreTimes: data.Times,
                RenderPhases: renderResult.Phases,
                RenderHotspots: renderHotspots,
                Files: writeResult,
                TotalAllocatedBytes: allocationEnd - allocationStart,
                CacheAllocatedBytes:
                    (allocationAfterCacheValidation - allocationBeforeCache) +
                    (allocationEnd - allocationAfterWrite),
                PipelineAllocatedBytes: allocationAfterPipeline - allocationBeforePipeline,
                RenderAllocatedBytes: allocationAfterRender - allocationAfterPipeline,
                SnippetAllocatedBytes: allocationAfterSnippet - allocationAfterRender,
                WriteAllocatedBytes: allocationAfterWrite - allocationAfterSnippet)
                .WriteAsync(Console.Error).ConfigureAwait(false);
        }

        Console.WriteLine("Done.");
    }

    private static long GetAllocatedBytes(bool diagnosticsEnabled)
    {
        return diagnosticsEnabled ? GC.GetTotalAllocatedBytes(precise: true) : 0;
    }

    /// <summary>
    /// A deterministic description of the split-by-tags inputs that shape the output tree but are
    /// not carried by <c>Settings</c>, for the generation cache key.
    /// </summary>
    /// <remarks>
    /// Describes the <em>parsed</em> overrides rather than the file's bytes, so reformatting the
    /// map or reordering its keys is still a cache hit while a genuine remapping is not.
    /// </remarks>
    private static string DescribePackagingInputs(
        string packagesOutput,
        IReadOnlyDictionary<string, string>? tagPackageOverrides)
    {
        return tagPackageOverrides is null
            ? packagesOutput
            : packagesOutput + "\n" + string.Join(
                "\n",
                tagPackageOverrides
                    .OrderBy(static x => x.Key, StringComparer.Ordinal)
                    .Select(static x => $"{x.Key}={x.Value}"));
    }

    /// <summary>
    /// AutoSDK-owned files under a split-by-tags packages root that a regeneration may no longer
    /// produce: generated sources, the per-package projects, the solution and the manifest.
    /// </summary>
    /// <remarks>
    /// Deliberately narrow. Anything else a repository keeps under the packages root — hand-written
    /// extensions, README files, test projects — is not AutoSDK's to delete.
    /// </remarks>
    private static IEnumerable<string> CollectStalePackageFamilyFiles(string packagesRoot)
    {
        if (!Directory.Exists(packagesRoot))
        {
            yield break;
        }

        foreach (var path in Directory.EnumerateFiles(packagesRoot, "*.g.cs", SearchOption.AllDirectories))
        {
            yield return path;
        }

        foreach (var path in Directory.EnumerateFiles(packagesRoot, "*.csproj", SearchOption.AllDirectories))
        {
            yield return path;
        }

        foreach (var path in Directory.EnumerateFiles(packagesRoot, "*.slnx", SearchOption.TopDirectoryOnly))
        {
            yield return path;
        }

        var manifest = Path.Combine(packagesRoot, PackageFamilyScaffolder.ManifestFileName);
        if (File.Exists(manifest))
        {
            yield return manifest;
        }
    }

    /// <summary>
    /// Removes package directories the current plan no longer contains, after stale files inside
    /// them have already been deleted.
    /// </summary>
    /// <remarks>
    /// Only directories that are empty once stale-file cleanup has run are removed, so a directory
    /// still holding user-owned files is preserved rather than silently discarded.
    /// </remarks>
    private static void RemoveStalePackageDirectories(string packagesRoot, PackagePlan plan)
    {
        if (!Directory.Exists(packagesRoot))
        {
            return;
        }

        var expected = new HashSet<string>(
            plan.Packages.Select(static x => x.DirectoryName),
            StringComparer.OrdinalIgnoreCase);

        // Materialized up front: deleting while a lazy enumeration is in flight is not safe.
        foreach (var directory in Directory.GetDirectories(packagesRoot))
        {
            if (expected.Contains(Path.GetFileName(directory)))
            {
                continue;
            }

            // Only files count as content. Stale-file cleanup leaves the empty `Generated` folder
            // behind, and treating that as user content would keep every retired package forever.
            if (Directory.EnumerateFiles(directory, "*", SearchOption.AllDirectories).Any())
            {
                Console.WriteLine(
                    $"Warning: '{directory}' is no longer part of the generated package family but still contains files. Leaving it in place.");
                continue;
            }

            Directory.Delete(directory, recursive: true);
        }
    }

    private static IEnumerable<string> CollectStaleGeneratedFiles(
        string apiOutput,
        string output,
        string inputName)
    {
        if (Directory.Exists(apiOutput))
        {
            foreach (var path in Directory.EnumerateFiles(apiOutput, "*.g.cs", SearchOption.AllDirectories))
            {
                yield return path;
            }
        }

        var priorSingleFile = Path.Combine(apiOutput, $"{inputName}.cs");
        if (File.Exists(priorSingleFile))
        {
            yield return priorSingleFile;
        }

        var priorSnippetManifest = Path.Combine(output, "autosdk.generated-examples.json");
        if (File.Exists(priorSnippetManifest))
        {
            yield return priorSnippetManifest;
        }
    }

    private static bool ShouldWarnAboutEmptyGeneratedSurface(
        Settings settings,
        AutoSDK.Models.Data data)
    {
        if (!settings.GenerateSdk &&
            !settings.GenerateModels &&
            !settings.GenerateMethods &&
            !settings.GenerateWebSocketClient)
        {
            return false;
        }

        return data.Methods.IsEmpty &&
               data.Classes.IsEmpty &&
               data.Enums.IsEmpty &&
               data.AnyOfs.IsEmpty &&
               data.WebSocketOperations.IsEmpty;
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
