using System.Collections.Immutable;
using System.CommandLine;
using System.Text;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;
using AutoSDK.Naming.Parameters;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

namespace AutoSDK.CLI.Commands;

[System.Diagnostics.CodeAnalysis.SuppressMessage(
    "Performance",
    "CA1812:Avoid uninstantiated internal classes",
    Justification = "Instantiated by the top-level AutoSDK.CLI program.")]
internal sealed class CliProjectCommand : Command
{
    private Argument<string> Input { get; } = new("input")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Input OpenAPI file path or URL.",
    };

    private Option<string> Output { get; } = new("--output", ["-o"])
    {
        DefaultValueFactory = _ => "Cli",
        Description = "Output directory for the generated CLI project.",
    };

    private Option<string> SdkProject { get; } = new("--sdk-project")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Path to the SDK library .csproj referenced by the generated CLI tool.",
    };

    private Option<string> TargetFramework { get; } = new("--targetFramework", ["-t"])
    {
        DefaultValueFactory = _ => Settings.Default.TargetFramework,
        Description = "TargetFramework for the generated CLI project.",
    };

    private Option<string> Namespace { get; } = new("--namespace", ["-n"])
    {
        DefaultValueFactory = _ => Settings.Default.Namespace,
        Description = "Namespace of the referenced SDK.",
    };

    private Option<string> ClientClassName { get; } = new("--clientClassName", ["-c"])
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "SDK root client class name.",
    };

    private Option<string> PackageId { get; } = new("--package-id")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "NuGet package id for the generated CLI tool. Defaults to <SdkPackageId>.CLI.",
    };

    private Option<string> RootNamespace { get; } = new("--root-namespace")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Root namespace for generated CLI sources. Defaults to a sanitized package id.",
    };

    private Option<string> ToolCommandName { get; } = new("--tool-command-name")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "dotnet tool command name. Defaults to tryagi-<sdk-kebab>.",
    };

    private Option<string> UserSecretsId { get; } = new("--user-secrets-id")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "UserSecretsId used by generated auth runtime. Defaults to a generated stable-looking id.",
    };

    private Option<bool> ApiOnly { get; } = new("--api-only")
    {
        DefaultValueFactory = _ => false,
        Description = "Generate only self-contained generated api command sources for an existing manual CLI project.",
    };

    private Option<bool> KeepApiGroup { get; } = new("--cli-keep-api-group")
    {
        DefaultValueFactory = _ => false,
        Description = "Nest generated commands under a top-level 'api' group (legacy layout). By default tag groups are added to the root directly.",
    };

    private Option<string[]> ApiKeyEnvVars { get; } = new("--api-key-env-var")
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "Environment variable used for API keys. Repeatable.",
        AllowMultipleArgumentsPerToken = true,
    };

    private Option<bool> CredentialFile { get; } = new("--cli-credential-file")
    {
        DefaultValueFactory = _ => false,
        Description = "Enable ~/.<sdk>/apiKey.txt API key fallback in the generated auth runtime.",
    };

    private Option<string> BaseUrlEnvVar { get; } = new("--base-url-env-var")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Environment variable used for the API base URL.",
    };

    private Option<bool> ExcludeDeprecatedOperations { get; } = new("--exclude-deprecated-operations", ["-e"])
    {
        DefaultValueFactory = _ => Settings.Default.ExcludeDeprecatedOperations,
        Description = "Exclude deprecated operations.",
    };

    private Option<bool> IgnoreOpenApiErrors { get; } = new("--ignore-openapi-errors")
    {
        DefaultValueFactory = _ => Settings.Default.IgnoreOpenApiErrors,
        Description = "Ignore OpenAPI errors.",
    };

    private Option<bool> IgnoreOpenApiWarnings { get; } = new("--ignore-openapi-warnings")
    {
        DefaultValueFactory = _ => Settings.Default.IgnoreOpenApiWarnings,
        Description = "Ignore OpenAPI warnings.",
    };

    private Option<string[]> SecuritySchemes { get; } = new("--security-scheme")
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "Security scheme as 'Type:Location:Name' (e.g. 'Http:Header:Bearer'). Repeatable.",
        AllowMultipleArgumentsPerToken = true,
    };

    private Option<string> BaseUrl { get; } = new("--base-url")
    {
        DefaultValueFactory = _ => string.Empty,
        Description = "Server base URL to inject into specs missing a server.",
    };

    private Option<string[]> OpenApiOverrides { get; } = new("--openapi-override")
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "OpenAPI override as 'path=action'. Actions: object, dictionary, remove. Repeatable.",
        AllowMultipleArgumentsPerToken = true,
    };

    private Option<string> JsonSerializerContextName { get; } = new("--json-serializer-context")
    {
        DefaultValueFactory = _ => "SourceGenerationContext",
        Description = "JsonSerializerContext type name or fully-qualified type used by the SDK.",
    };

    public CliProjectCommand() : base(
        name: "cli-project",
        description: "Generates a runnable PackAsTool CLI project for an AutoSDK-generated SDK.")
    {
        Arguments.Add(Input);
        Options.Add(Output);
        Options.Add(SdkProject);
        Options.Add(TargetFramework);
        Options.Add(Namespace);
        Options.Add(ClientClassName);
        Options.Add(PackageId);
        Options.Add(RootNamespace);
        Options.Add(ToolCommandName);
        Options.Add(UserSecretsId);
        Options.Add(ApiOnly);
        Options.Add(KeepApiGroup);
        Options.Add(ApiKeyEnvVars);
        Options.Add(CredentialFile);
        Options.Add(BaseUrlEnvVar);
        Options.Add(ExcludeDeprecatedOperations);
        Options.Add(IgnoreOpenApiErrors);
        Options.Add(IgnoreOpenApiWarnings);
        Options.Add(SecuritySchemes);
        Options.Add(BaseUrl);
        Options.Add(OpenApiOverrides);
        Options.Add(JsonSerializerContextName);
        SetAction(HandleAsync);
    }

    private async Task<int> HandleAsync(ParseResult parseResult)
    {
        var input = parseResult.GetRequiredValue(Input);
        var output = parseResult.GetRequiredValue(Output);
        var sdkProject = parseResult.GetRequiredValue(SdkProject);

        if (string.IsNullOrWhiteSpace(input))
        {
            await Console.Error.WriteLineAsync("Input OpenAPI file path or URL is required.").ConfigureAwait(false);
            return 1;
        }

        if (string.IsNullOrWhiteSpace(sdkProject))
        {
            await Console.Error.WriteLineAsync("--sdk-project is required.").ConfigureAwait(false);
            return 1;
        }

        var outputPath = Path.GetFullPath(output);
        var sdkProjectPath = Path.GetFullPath(sdkProject);
        var inputName = GetInputName(input);

        Console.WriteLine($"Loading {input}...");
        var yaml = await LoadInputAsync(input).ConfigureAwait(false);
        if (SpecFormatDetector.DetectFormat(yaml) == SpecFormat.GrpcProto)
        {
            await Console.Error.WriteLineAsync(SpecFormatDetector.GrpcProtoCommandNotSupportedMessage).ConfigureAwait(false);
            return 1;
        }

        var namespaceValue = parseResult.GetRequiredValue(Namespace);
        if (string.IsNullOrWhiteSpace(namespaceValue))
        {
            namespaceValue = inputName.ToPropertyName().UseWordSeparator('\\', '-', '.', '_', '/');
        }

        var clientClassName = parseResult.GetRequiredValue(ClientClassName);
        if (string.IsNullOrWhiteSpace(clientClassName))
        {
            clientClassName = $"{inputName.ToPropertyName().UseWordSeparator('\\', '-', '.', '_', '/')}Client";
        }

        var contextName = parseResult.GetRequiredValue(JsonSerializerContextName);
        var contextFullName = contextName.Contains('.', StringComparison.Ordinal)
            ? contextName
            : $"{namespaceValue}.{contextName}";

        var settings = Settings.Default with
        {
            TargetFramework = parseResult.GetRequiredValue(TargetFramework),
            Namespace = namespaceValue,
            ClassName = clientClassName,
            MethodNamingConvention = MethodNamingConvention.OperationId,
            ExcludeDeprecatedOperations = parseResult.GetRequiredValue(ExcludeDeprecatedOperations),
            IgnoreOpenApiErrors = parseResult.GetRequiredValue(IgnoreOpenApiErrors),
            IgnoreOpenApiWarnings = parseResult.GetRequiredValue(IgnoreOpenApiWarnings),
            GenerateJsonSerializerContextTypes = true,
            JsonSerializerContext = contextFullName,
            GenerateCli = false,
            FromCli = true,
            AutoDetectStatusPolling = true,
            SecuritySchemes = parseResult.GetRequiredValue(SecuritySchemes).ToImmutableArray(),
            BaseUrl = parseResult.GetRequiredValue(BaseUrl),
            OpenApiOverrides = parseResult.GetRequiredValue(OpenApiOverrides).ToImmutableArray(),
        };

        Console.WriteLine("Preparing generated endpoint model...");
        var openApiDocument = yaml.GetOpenApiDocument(settings);
        var data = CSharpPipeline.PrepareAndEnrich(((yaml, settings), GlobalSettings: settings));
        var metadata = CliProjectMetadata.Create(openApiDocument, data);

        var sdkProjectName = Path.GetFileNameWithoutExtension(sdkProjectPath);
        var sdkSlug = CliProjectScaffolder.ToKebabCase(RemoveTryAgiPrefix(RemoveClientSuffix(sdkProjectName)));
        var packageId = parseResult.GetRequiredValue(PackageId);
        if (string.IsNullOrWhiteSpace(packageId))
        {
            packageId = $"{sdkProjectName}.CLI";
        }

        var toolCommandName = parseResult.GetRequiredValue(ToolCommandName);
        if (string.IsNullOrWhiteSpace(toolCommandName))
        {
            toolCommandName = $"tryagi-{sdkSlug}";
        }

        var rootNamespace = parseResult.GetRequiredValue(RootNamespace);
        if (string.IsNullOrWhiteSpace(rootNamespace))
        {
            rootNamespace = CliProjectModel.SanitizeNamespace(packageId);
        }

        var userSecretsId = parseResult.GetRequiredValue(UserSecretsId);
        if (string.IsNullOrWhiteSpace(userSecretsId))
        {
            userSecretsId = $"autosdk-cli-{Guid.NewGuid():N}";
        }

        var apiKeyEnvVars = parseResult.GetRequiredValue(ApiKeyEnvVars)
            .Where(static x => !string.IsNullOrWhiteSpace(x))
            .Distinct(StringComparer.Ordinal)
            .ToArray();
        if (apiKeyEnvVars.Length == 0)
        {
            apiKeyEnvVars = GetDefaultApiKeyEnvVars(sdkSlug);
        }

        var credentialFileDirectoryName = parseResult.GetRequiredValue(CredentialFile)
            ? $".{sdkSlug}"
            : string.Empty;

        var baseUrlEnvVar = parseResult.GetRequiredValue(BaseUrlEnvVar);
        if (string.IsNullOrWhiteSpace(baseUrlEnvVar))
        {
            baseUrlEnvVar = $"{ToEnvPrefix(sdkSlug)}_BASE_URL";
        }

        var model = CliProjectModel.Create(
            outputPath,
            sdkProjectPath,
            packageId,
            rootNamespace,
            toolCommandName,
            settings.TargetFramework,
            namespaceValue,
            clientClassName,
            contextFullName,
            userSecretsId,
            apiKeyEnvVars,
            credentialFileDirectoryName,
            baseUrlEnvVar,
            data,
            metadata,
            parseResult.GetRequiredValue(ApiOnly),
            parseResult.GetRequiredValue(KeepApiGroup));

        Console.WriteLine(model.ApiOnly
            ? $"Writing generated API command sources to {outputPath}..."
            : $"Writing CLI project to {outputPath}...");
        await CliProjectScaffolder.WriteAsync(model).ConfigureAwait(false);
        Console.WriteLine("Done.");
        return 0;
    }

    private static async Task<string> LoadInputAsync(string input)
    {
        if (input.StartsWith("http", StringComparison.OrdinalIgnoreCase))
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(new Uri(input)).ConfigureAwait(false);
        }

        return await File.ReadAllTextAsync(input).ConfigureAwait(false);
    }

    private static string GetInputName(string input)
    {
        if (Uri.TryCreate(input, UriKind.Absolute, out var uri) &&
            !string.IsNullOrWhiteSpace(uri.LocalPath))
        {
            return Path.GetFileNameWithoutExtension(uri.LocalPath);
        }

        return Path.GetFileNameWithoutExtension(input);
    }

    private static string RemoveTryAgiPrefix(string value)
    {
        return value.StartsWith("tryAGI.", StringComparison.Ordinal)
            ? value["tryAGI.".Length..]
            : value;
    }

    private static string RemoveClientSuffix(string value)
    {
        return value.EndsWith("Client", StringComparison.Ordinal)
            ? value[..^"Client".Length]
            : value;
    }

    private static string[] GetDefaultApiKeyEnvVars(string sdkSlug)
    {
        return string.Equals(sdkSlug, "runway", StringComparison.Ordinal)
            ? ["RUNWAY_API_KEY", "RUNWAYML_API_SECRET"]
            : [$"{ToEnvPrefix(sdkSlug)}_API_KEY"];
    }

    private static string ToEnvPrefix(string sdkSlug)
    {
        return sdkSlug.Replace('-', '_').ToUpperInvariant();
    }
}

internal sealed record CliProjectModel(
    string OutputPath,
    string SdkProjectPath,
    string ProjectName,
    string PackageId,
    string RootNamespace,
    string ToolCommandName,
    string TargetFramework,
    string SdkNamespace,
    string ClientClassName,
    string JsonSerializerContextFullName,
    string UserSecretsId,
    ImmutableArray<string> ApiKeyEnvVars,
    string CredentialFileDirectoryName,
    string BaseUrlEnvVar,
    ImmutableArray<CliProjectAuthorization> Authorizations,
    ImmutableArray<CliProjectOptionSet> OptionSets,
    ImmutableArray<CliProjectTag> Tags,
    bool ApiOnly,
    bool KeepApiGroup)
{
    public static CliProjectModel Create(
        string outputPath,
        string sdkProjectPath,
        string packageId,
        string rootNamespace,
        string toolCommandName,
        string targetFramework,
        string sdkNamespace,
        string clientClassName,
        string jsonSerializerContextFullName,
        string userSecretsId,
        IReadOnlyList<string> apiKeyEnvVars,
        string credentialFileDirectoryName,
        string baseUrlEnvVar,
        AutoSDK.Models.Data data,
        CliProjectMetadata metadata,
        bool apiOnly,
        bool keepApiGroup)
    {
        var projectName = SanitizeProjectName(packageId);
        var authorizations = data.Authorizations
            .Select(CliProjectAuthorization.Create)
            .Distinct()
            .ToImmutableArray();
        var optionSets = CliProjectOptionSet.CreateCandidates(data, metadata);
        var optionSetsByModelType = optionSets.ToDictionary(static x => x.ModelTypeName, static x => x, StringComparer.Ordinal);
        var classesByName = data.Classes
            .Where(static x => !string.IsNullOrWhiteSpace(x.GlobalClassName))
            .ToDictionary(static x => x.GlobalClassName, static x => x, StringComparer.Ordinal);
        var usedTagCommandNames = new HashSet<string>(StringComparer.Ordinal);
        var usedTagClassNames = new HashSet<string>(StringComparer.Ordinal);
        var tags = data.Methods
            .Where(static x => !string.IsNullOrWhiteSpace(x.Path))
            .GroupBy(static x => string.IsNullOrWhiteSpace(x.Tag.Name) ? "default" : x.Tag.Name)
            .OrderBy(static x => x.Key, StringComparer.OrdinalIgnoreCase)
            .Select(group => CliProjectTag.Create(group, usedTagCommandNames, usedTagClassNames, classesByName, optionSetsByModelType, metadata))
            .ToImmutableArray();

        return new CliProjectModel(
            outputPath,
            sdkProjectPath,
            projectName,
            packageId,
            rootNamespace,
            toolCommandName,
            targetFramework,
            sdkNamespace,
            clientClassName,
            jsonSerializerContextFullName,
            userSecretsId,
            apiKeyEnvVars.ToImmutableArray(),
            credentialFileDirectoryName,
            baseUrlEnvVar,
            authorizations,
            optionSets,
            tags,
            apiOnly,
            keepApiGroup);
    }

    private static string SanitizeProjectName(string value)
    {
        var name = string.IsNullOrWhiteSpace(value) ? "Generated.CLI" : value.Trim();
        var builder = new StringBuilder(name.Length);
        foreach (var ch in name)
        {
            builder.Append(char.IsLetterOrDigit(ch) || ch is '.' or '_' or '-' ? ch : '.');
        }

        return builder.ToString().Trim('.');
    }

    public static string SanitizeNamespace(string value)
    {
        var parts = SanitizeProjectName(value)
            .Split(['.', '-'], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        return string.Join(
            ".",
            parts.Select(static part =>
            {
                var propertyName = part.ToPropertyName();
                return char.IsDigit(propertyName[0]) ? $"_{propertyName}" : propertyName;
            }));
    }
}

internal sealed record CliProjectAuthorization(
    string Type,
    string SchemeId,
    string Location,
    string Name)
{
    public static CliProjectAuthorization Create(Authorization authorization)
    {
        return new CliProjectAuthorization(
            authorization.Type?.ToString("G") ?? string.Empty,
            authorization.SchemeId,
            authorization.In?.ToString("G") ?? string.Empty,
            GetAuthorizationRuntimeName(authorization));
    }

    private static string GetAuthorizationRuntimeName(Authorization authorization)
    {
        return (authorization.Type, authorization.Scheme.ToUpperInvariant(), authorization.In) switch
        {
            (SecuritySchemeType.Http, "BEARER", _) => "Bearer",
            (SecuritySchemeType.Http, "BASIC", _) => "Basic",
            (SecuritySchemeType.Http, _, _) => authorization.Scheme,
            (SecuritySchemeType.ApiKey, _, _) => authorization.Name,
            (SecuritySchemeType.OpenIdConnect, _, _) => "Bearer",
            (SecuritySchemeType.MutualTLS, _, _) => authorization.SchemeId,
            _ => string.Empty,
        };
    }
}

internal enum CliProjectWaitMode
{
    Auto,
    Enabled,
    Disabled,
}

internal enum CliProjectFormatHint
{
    Key,
    Hidden,
    Code,
}

internal sealed record CliProjectOperationMetadata(
    CliProjectWaitMode WaitMode,
    ImmutableDictionary<string, CliProjectFormatHint> ResponseFormatHints)
{
    public static CliProjectOperationMetadata Default { get; } = new(
        CliProjectWaitMode.Auto,
        ImmutableDictionary<string, CliProjectFormatHint>.Empty.WithComparers(StringComparer.OrdinalIgnoreCase));
}

internal sealed record CliProjectMetadata(
    ImmutableDictionary<string, CliProjectOperationMetadata> Operations,
    ImmutableHashSet<string> DisabledOptionSetSchemaClassNames)
{
    public static CliProjectMetadata Create(OpenApiDocument openApiDocument, AutoSDK.Models.Data data)
    {
        var operations = new Dictionary<string, CliProjectOperationMetadata>(StringComparer.Ordinal);
        foreach (var path in openApiDocument.Paths ?? new OpenApiPaths())
        {
            foreach (var operation in path.Value.Operations ?? new Dictionary<System.Net.Http.HttpMethod, OpenApiOperation>())
            {
                var metadata = new CliProjectOperationMetadata(
                    GetWaitMode(operation.Value.Extensions),
                    GetResponseFormatHints(
                        operation.Value,
                        openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>()));

                foreach (var key in CreateOperationKeys(operation.Value.OperationId, path.Key, operation.Key))
                {
                    operations[key] = metadata;
                }
            }
        }

        var disabledOptionSetSchemaClassNames = (openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>())
            .Where(static schema =>
                (schema.Value.Extensions?.TryGetValue("x-cli-option-set", out var extension) ?? false) &&
                TryReadExtensionBoolean(extension, out var enabled) &&
                !enabled)
            .Select(schema => schema.Key.ToClassName())
            .Where(static name => !string.IsNullOrWhiteSpace(name))
            .ToImmutableHashSet(StringComparer.Ordinal);

        return new CliProjectMetadata(
            operations.ToImmutableDictionary(StringComparer.Ordinal),
            disabledOptionSetSchemaClassNames);
    }

    public CliProjectOperationMetadata GetOperation(EndPoint endPoint)
    {
        foreach (var key in CreateOperationKeys(endPoint.Id, endPoint.Path, endPoint.HttpMethod))
        {
            if (Operations.TryGetValue(key, out var metadata))
            {
                return metadata;
            }
        }

        return CliProjectOperationMetadata.Default;
    }

    private static ImmutableArray<string> CreateOperationKeys(
        string? operationId,
        string? path,
        System.Net.Http.HttpMethod httpMethod)
    {
        var keys = ImmutableArray.CreateBuilder<string>(3);
        var seen = new HashSet<string>(StringComparer.Ordinal);
        static void AddKey(ImmutableArray<string>.Builder keys, HashSet<string> seen, string? key)
        {
            if (!string.IsNullOrWhiteSpace(key) && seen.Add(key))
            {
                keys.Add(key);
            }
        }

        if (!string.IsNullOrWhiteSpace(operationId))
        {
            AddKey(keys, seen, operationId);
            AddKey(keys, seen, operationId.ToPropertyName());
        }

        AddKey(keys, seen, $"{httpMethod.Method}:{NormalizeOperationPath(path)}");
        return keys.ToImmutable();
    }

    private static string NormalizeOperationPath(string? path)
    {
        if (string.IsNullOrWhiteSpace(path))
        {
            return string.Empty;
        }

        path = path.Trim();
        if (path.StartsWith('$'))
        {
            path = path[1..];
        }

        if (path.Length >= 2 &&
            path[0] == '"' &&
            path[^1] == '"')
        {
            path = path[1..^1];
        }

        return path;
    }

    private static CliProjectWaitMode GetWaitMode(IDictionary<string, IOpenApiExtension>? extensions)
    {
        if (!(extensions?.TryGetValue("x-cli-wait", out var extension) ?? false) ||
            extension is null)
        {
            return CliProjectWaitMode.Auto;
        }

        if (TryReadExtensionBoolean(extension, out var enabled))
        {
            return enabled
                ? CliProjectWaitMode.Enabled
                : CliProjectWaitMode.Disabled;
        }

        return TryReadExtensionString(extension, out var mode) &&
               string.Equals(mode, "always", StringComparison.OrdinalIgnoreCase)
            ? CliProjectWaitMode.Enabled
            : CliProjectWaitMode.Auto;
    }

    private static ImmutableDictionary<string, CliProjectFormatHint> GetResponseFormatHints(
        OpenApiOperation operation,
        IDictionary<string, IOpenApiSchema> componentSchemas)
    {
        var schema = operation.Responses?
            .Where(static response => response.Key.StartsWith('2'))
            .OrderBy(static response => response.Key, StringComparer.Ordinal)
            .SelectMany(static response => response.Value.Content ?? new Dictionary<string, IOpenApiMediaType>())
            .Select(static content => content.Value.Schema)
            .FirstOrDefault(static schema => schema is not null);
        if (schema is null)
        {
            return ImmutableDictionary<string, CliProjectFormatHint>.Empty.WithComparers(StringComparer.OrdinalIgnoreCase);
        }

        var hints = new Dictionary<string, CliProjectFormatHint>(StringComparer.OrdinalIgnoreCase);
        CollectResponseFormatHints(
            schema,
            componentSchemas,
            prefix: null,
            hints,
            visitedReferences: new HashSet<string>(StringComparer.Ordinal));
        return hints.ToImmutableDictionary(StringComparer.OrdinalIgnoreCase);
    }

    private static void CollectResponseFormatHints(
        IOpenApiSchema schema,
        IDictionary<string, IOpenApiSchema> componentSchemas,
        string? prefix,
        Dictionary<string, CliProjectFormatHint> hints,
        HashSet<string> visitedReferences)
    {
        if (schema.IsSchemaReference())
        {
            var referenceId = schema.GetReferenceId();
            if (!string.IsNullOrWhiteSpace(referenceId) && !visitedReferences.Add(referenceId))
            {
                return;
            }

            if (!string.IsNullOrWhiteSpace(referenceId) &&
                componentSchemas.TryGetValue(referenceId, out var referencedSchema))
            {
                schema = referencedSchema;
            }
        }

        schema = schema.ResolveIfRequired();
        foreach (var property in schema.Properties ?? new Dictionary<string, IOpenApiSchema>())
        {
            var propertyPath = string.IsNullOrWhiteSpace(prefix)
                ? property.Key
                : $"{prefix}.{property.Key}";
            if (TryGetFormatHint(property.Value.Extensions, out var hint))
            {
                hints[propertyPath] = hint;
            }

            CollectResponseFormatHints(property.Value, componentSchemas, propertyPath, hints, visitedReferences);
        }

        foreach (var composite in schema.AllOf ?? [])
        {
            CollectResponseFormatHints(composite, componentSchemas, prefix, hints, visitedReferences);
        }

        foreach (var composite in schema.AnyOf ?? [])
        {
            CollectResponseFormatHints(composite, componentSchemas, prefix, hints, visitedReferences);
        }

        foreach (var composite in schema.OneOf ?? [])
        {
            CollectResponseFormatHints(composite, componentSchemas, prefix, hints, visitedReferences);
        }

        if (schema.Items is not null)
        {
            CollectResponseFormatHints(schema.Items, componentSchemas, prefix, hints, visitedReferences);
        }

        if (schema.AdditionalProperties is not null)
        {
            CollectResponseFormatHints(schema.AdditionalProperties, componentSchemas, prefix, hints, visitedReferences);
        }
    }

    private static bool TryGetFormatHint(
        IDictionary<string, IOpenApiExtension>? extensions,
        out CliProjectFormatHint hint)
    {
        hint = default;
        if (!(extensions?.TryGetValue("x-cli-format", out var extension) ?? false) ||
            !TryReadExtensionString(extension, out var value))
        {
            return false;
        }

        switch (value.Trim().ToUpperInvariant())
        {
            case "KEY":
                hint = CliProjectFormatHint.Key;
                return true;
            case "HIDDEN":
                hint = CliProjectFormatHint.Hidden;
                return true;
            case "CODE":
                hint = CliProjectFormatHint.Code;
                return true;
            default:
                return false;
        }
    }

    private static bool TryReadExtensionString(IOpenApiExtension extension, out string value)
    {
        value = string.Empty;
        if (OpenApiExtensions.TryGetExtensionStringValue(extension, out value))
        {
            return true;
        }

        var valueProperty = extension.GetType().GetProperty("Value");
        if (string.Equals(extension.GetType().FullName, "Microsoft.OpenApi.Any.OpenApiString", StringComparison.Ordinal) &&
            valueProperty?.GetValue(extension) is string stringValue &&
            !string.IsNullOrWhiteSpace(stringValue))
        {
            value = stringValue;
            return true;
        }

        return false;
    }

    private static bool TryReadExtensionBoolean(IOpenApiExtension extension, out bool value)
    {
        value = false;
        var valueProperty = extension.GetType().GetProperty("Value");
        if (string.Equals(extension.GetType().FullName, "Microsoft.OpenApi.Any.OpenApiBoolean", StringComparison.Ordinal) &&
            valueProperty?.GetValue(extension) is bool boolValue)
        {
            value = boolValue;
            return true;
        }

        if (OpenApiExtensions.TryGetExtensionJsonNode(extension) is JsonValue jsonValue &&
            jsonValue.TryGetValue<bool>(out value))
        {
            return true;
        }

        return TryReadExtensionString(extension, out var stringValue) &&
               bool.TryParse(stringValue, out value);
    }
}

internal sealed record CliProjectOptionSet(
    string ModelTypeName,
    string ClassName,
    ImmutableArray<MethodParameter> Parameters)
{
    public static ImmutableArray<CliProjectOptionSet> CreateCandidates(
        AutoSDK.Models.Data data,
        CliProjectMetadata metadata)
    {
        var candidates = data.Classes
            .Select(static model =>
            {
                var parameters = model.Properties
                    .Where(IsOptionSetEligibleProperty)
                    .Select(CreateParameter)
                    .ToImmutableArray();
                return new CliProjectOptionSet(
                    model.GlobalClassName,
                    $"{model.ClassName}OptionSet",
                    parameters);
            })
            .Where(optionSet =>
                optionSet.Parameters.Length > 0 &&
                !metadata.DisabledOptionSetSchemaClassNames.Contains(optionSet.ClassName.Replace("OptionSet", string.Empty, StringComparison.Ordinal)))
            .ToArray();
        if (candidates.Length == 0)
        {
            return [];
        }

        var usageCounts = new Dictionary<string, int>(StringComparer.Ordinal);
        foreach (var method in data.Methods)
        {
            if (TryGetDirectModelType(method) is { Length: > 0 } directModelType &&
                candidates.Any(candidate => string.Equals(candidate.ModelTypeName, directModelType, StringComparison.Ordinal)))
            {
                usageCounts.TryGetValue(directModelType, out var count);
                usageCounts[directModelType] = count + 1;
            }

            foreach (var parameter in method.Parameters.Where(static parameter => parameter.Location is null))
            {
                var parameterType = parameter.Type.CSharpTypeWithoutNullability;
                if (!string.IsNullOrWhiteSpace(parameterType) &&
                    candidates.Any(candidate => string.Equals(candidate.ModelTypeName, parameterType, StringComparison.Ordinal)))
                {
                    usageCounts.TryGetValue(parameterType, out var count);
                    usageCounts[parameterType] = count + 1;
                }
            }
        }

        return candidates
            .Where(candidate =>
                usageCounts.TryGetValue(candidate.ModelTypeName, out var count) &&
                count >= 2 &&
                !IsWebhookShape(candidate))
            .ToImmutableArray();
    }

    private static string? TryGetDirectModelType(EndPoint method)
    {
        return !string.IsNullOrWhiteSpace(method.RequestType.CSharpTypeWithoutNullability)
            ? method.RequestType.CSharpTypeWithoutNullability
            : null;
    }

    private static bool IsOptionSetEligibleProperty(PropertyData property)
    {
        if (property.IsReadOnly)
        {
            return false;
        }

        var type = property.Type;
        if (type.IsArray)
        {
            return type.SubTypes.Length == 0 ||
                   IsOptionSetSimpleType(type.SubTypes[0].Unbox<TypeData>());
        }

        return IsOptionSetSimpleType(type);
    }

    private static bool IsOptionSetSimpleType(TypeData type)
    {
        return type.CSharpTypeWithoutNullability is
                   "string" or "bool" or "int" or "long" or "float" or "double" or "decimal" or "Guid" or "DateTime" or "DateTimeOffset" ||
               type.IsEnum ||
               type.IsOpenEnum ||
               type.IsDate ||
               type.IsDateTime ||
               type.IsUnixTimestamp ||
               type.CSharpTypeWithoutNullability.StartsWith("global::System.Guid", StringComparison.Ordinal);
    }

    private static MethodParameter CreateParameter(PropertyData property)
    {
        return (MethodParameter.Default with
        {
            Id = property.Id,
            Name = property.Name,
            Type = (property.Type with
            {
                CSharpTypeNullability =
                    property.Type.IsNullable ||
                    (property.Type.CSharpTypeNullability && !property.IsRequired && !property.IsWriteOnly),
            }).WithCSharpComputedValues(),
            IsRequired = property.IsRequired || property.IsWriteOnly,
            IsMultiPartFormDataFilename = property.IsMultiPartFormDataFilename,
            DefaultValue = property.DefaultValue,
            IsDeprecated = property.IsDeprecated,
            Settings = property.Settings,
            Summary = property.Summary,
            ConverterType = property.ConverterType,
            Description = property.Description,
        }).WithCSharpParameterNames().WithCSharpComputedValues();
    }

    private static bool IsWebhookShape(CliProjectOptionSet optionSet)
    {
        var hasUrl = optionSet.Parameters.Any(static parameter =>
            parameter.Type.CSharpTypeWithoutNullability == "string" &&
            parameter.Id.Contains("url", StringComparison.OrdinalIgnoreCase));
        if (!hasUrl)
        {
            return false;
        }

        var hasHeaders = optionSet.Parameters.Any(static parameter =>
            parameter.Id.Contains("header", StringComparison.OrdinalIgnoreCase) ||
            parameter.ParameterName.Contains("header", StringComparison.OrdinalIgnoreCase));
        var hasMetadata = optionSet.Parameters.Any(static parameter =>
            parameter.Id.Contains("metadata", StringComparison.OrdinalIgnoreCase));
        var hasEvents = optionSet.Parameters.Any(static parameter =>
            parameter.Id.Contains("event", StringComparison.OrdinalIgnoreCase));

        return hasHeaders || hasMetadata || hasEvents;
    }
}

internal sealed record CliProjectDirectOptionSetUsage(
    string InstanceName,
    string ClassName,
    ImmutableArray<MethodParameter> Parameters);

internal sealed record CliProjectNestedOptionSetUsage(
    string InstanceName,
    string ClassName,
    string Prefix,
    string ParameterName,
    string BasePropertyName,
    string ModelTypeName,
    bool IsRequired,
    ImmutableArray<MethodParameter> Parameters);

internal sealed record CliProjectWebhookUsage(
    string Prefix,
    string ParameterName,
    string BasePropertyName,
    string ModelTypeName,
    string? UrlPropertyName,
    bool UrlIsRequired,
    string? HeadersPropertyName,
    string? HeadersTypeName,
    string? MetadataPropertyName,
    string? MetadataTypeName,
    string? EventsPropertyName,
    string? EventsTypeName,
    ImmutableArray<string> EventValues);

internal sealed record CliProjectTag(
    string Name,
    string CommandName,
    string ClassName,
    ImmutableArray<CliProjectOperation> Operations)
{
    public static CliProjectTag Create(
        IGrouping<string, EndPoint> group,
        HashSet<string> usedCommandNames,
        HashSet<string> usedClassNames,
        IReadOnlyDictionary<string, ModelData> classesByName,
        IReadOnlyDictionary<string, CliProjectOptionSet> optionSetsByModelType,
        CliProjectMetadata metadata)
    {
        var displayName = string.IsNullOrWhiteSpace(group.Key) ? "api" : group.Key;
        var baseCommandName = CliProjectScaffolder.ToKebabCase(displayName);
        if (string.Equals(baseCommandName, "api", StringComparison.Ordinal))
        {
            baseCommandName = "default";
        }

        var commandName = CliProjectScaffolder.MakeUniqueCommandName(baseCommandName, usedCommandNames);
        var usedNames = new HashSet<string>(StringComparer.Ordinal);
        var operations = group
            .OrderBy(static x => x.Id, StringComparer.Ordinal)
            .ThenBy(static x => x.NotAsyncMethodName, StringComparer.Ordinal)
            .Select(endPoint => CliProjectOperation.Create(endPoint, usedNames, classesByName, optionSetsByModelType, metadata))
            .ToImmutableArray();

        return new CliProjectTag(
            displayName,
            commandName,
            CliProjectScaffolder.MakeUniqueTypeName(
                CliProjectScaffolder.ToTypeName($"{displayName}ApiGroupCommand"),
                usedClassNames),
            operations);
    }
}

internal sealed record CliProjectOperation(
    EndPoint EndPoint,
    string CommandName,
    string ClassName,
    ImmutableArray<MethodParameter> PositionalParameters,
    ImmutableArray<MethodParameter> OptionParameters,
    ImmutableArray<CliProjectDirectOptionSetUsage> DirectOptionSets,
    ImmutableArray<CliProjectNestedOptionSetUsage> NestedOptionSets,
    ImmutableArray<CliProjectWebhookUsage> WebhookUsages,
    bool HasDirectRequestBody,
    bool SupportsBaseBody,
    bool SupportsWait,
    ImmutableDictionary<string, CliProjectFormatHint> ResponseFormatHints,
    bool HasResponse,
    string ResponseType,
    bool ResponseIsRawStream,
    bool ResponseIsEnumerableStream,
    bool ResponseIsByteArray,
    bool SupportsOutputDirectory,
    string OutputDirectoryItemsPropertyName)
{
    public static CliProjectOperation Create(
        EndPoint endPoint,
        HashSet<string> usedNames,
        IReadOnlyDictionary<string, ModelData> classesByName,
        IReadOnlyDictionary<string, CliProjectOptionSet> optionSetsByModelType,
        CliProjectMetadata metadata)
    {
        string baseName;
        if (!string.IsNullOrWhiteSpace(endPoint.CliCommandName))
        {
            // Explicit x-cli-command-name override wins verbatim (kebab-normalized), no tag-strip
            // — the spec author chose this name deliberately (AutoSDK #345).
            baseName = CliProjectScaffolder.ToKebabCase(endPoint.CliCommandName);
        }
        else
        {
            baseName = CliProjectScaffolder.ToKebabCase(string.IsNullOrWhiteSpace(endPoint.Id) ? endPoint.NotAsyncMethodName : endPoint.Id);

            // The scaffolder always nests each operation command under its tag group (see the
            // GroupBy on Tag.Name when building tags), so an operation id that repeats the tag
            // (common with Fern/Stainless specs, e.g. tag "Crawling" + op "crawlingCancelCrawl")
            // produces a redundant "crawling crawling-cancel-crawl" surface. Strip the leading tag
            // token so it reads "crawling cancel-crawl" (AutoSDK #345).
            baseName = CliProjectScaffolder.StripRedundantTagPrefix(baseName, endPoint.Tag);
        }

        var commandName = CliProjectScaffolder.MakeUniqueCommandName(baseName, usedNames);

        // Mirror the source-generator CLI path (Sources.CLI.Command.cs): the SDK's flattened
        // convenience overload exposes each top-level request-body property as an individual
        // parameter (Location == null). Including them turns every scalar/enum/array body field
        // into a per-field --flag instead of a single --request-json blob, and the command binds
        // straight to that overload (AutoSDK #339).
        var cliParameters = endPoint.Parameters
            .Where(static x => x is { IsDeprecated: false } or { IsRequired: true } or { IsDeprecated: true, Location: not null })
            .Where(x => !(endPoint.ForcedRequestStreamValue is not null && IsRequestStreamParameter(x)))
            .ToArray();
        var responseType = GetResponseType(endPoint);

        // A request body that did NOT flatten into individual parameters — a raw scalar/array/enum
        // body, or a composite (allOf/oneOf) request type AutoSDK keeps as a single object — has no
        // per-field flags, so it still needs the opaque --request-json/--request-file escape hatch
        // and binds via `request:`. (Was: only the scalar/array/enum/binary case, which silently
        // dropped composite object bodies like Firecrawl's scrape AllOf<...> request — AutoSDK #339.)
        var hasRequestBody = !string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType);
        var hasFlattenedBodyParameters = cliParameters.Any(static x => x.Location is null);
        var hasDirectRequestBody = hasRequestBody && !hasFlattenedBodyParameters;

        // Choose which parameters read as positional arguments vs. flags (AutoSDK #340). Path
        // template parameters are the natural positionals; failing that, a single required string
        // body property that names a resource (id/name/slug/url/...) is hoisted so the surface
        // reads `scrape <url>` / `get <id>`. Every other required parameter stays a flag (marked
        // Required = true by GenerateParameterField) rather than an opaque positional, so commands
        // don't degrade into `create <name> <quantity> <colour>` ordering puzzles.
        var positionalParameters = SelectPositionalParameters(cliParameters);
        var allOptionParameters = cliParameters
            .Where(x => !positionalParameters.Contains(x))
            .ToImmutableArray();
        var directOptionSets = CreateDirectOptionSetUsages(endPoint, allOptionParameters, optionSetsByModelType);
        var nestedOptionSets = CreateNestedOptionSetUsages(allOptionParameters, optionSetsByModelType);
        var webhookUsages = CreateWebhookUsages(allOptionParameters, classesByName);
        var consumedDirectParameterNames = directOptionSets
            .SelectMany(static usage => usage.Parameters)
            .Select(static parameter => parameter.ParameterName)
            .ToHashSet(StringComparer.Ordinal);
        var consumedNestedParameterNames = nestedOptionSets
            .Select(static usage => usage.ParameterName)
            .ToHashSet(StringComparer.Ordinal);
        var consumedWebhookParameterNames = webhookUsages
            .Select(static usage => usage.ParameterName)
            .ToHashSet(StringComparer.Ordinal);
        var optionParameters = allOptionParameters
            .Where(parameter =>
                !consumedDirectParameterNames.Contains(parameter.ParameterName) &&
                !consumedNestedParameterNames.Contains(parameter.ParameterName) &&
                !consumedWebhookParameterNames.Contains(parameter.ParameterName))
            .ToImmutableArray();

        // When an object body has at least one plain-optional field, offer --request-json /
        // --request-file as a base body whose values fill those fields unless a per-field flag
        // overrides them (AutoSDK #343). Required and positional fields still come from CLI args,
        // so this composes with the #340 positional hoisting rather than fighting it.
        var supportsBaseBody = !hasDirectRequestBody &&
            allOptionParameters.Any(IsMergeableBaseBodyField);
        var (supportsOutputDirectory, outputDirectoryItemsPropertyName) = DetectOutputDirectorySupport(endPoint, classesByName);

        return new CliProjectOperation(
            endPoint,
            commandName,
            CliProjectScaffolder.ToTypeName($"{endPoint.CliCommandClassName}ApiCommand"),
            positionalParameters,
            optionParameters,
            directOptionSets,
            nestedOptionSets,
            webhookUsages,
            hasDirectRequestBody,
            supportsBaseBody,
            ResolveWaitSupport(endPoint, metadata.GetOperation(endPoint).WaitMode),
            metadata.GetOperation(endPoint).ResponseFormatHints,
            !string.IsNullOrWhiteSpace(responseType),
            responseType,
            endPoint.RawStream,
            endPoint.EnumerableStream,
            endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability == "byte[]",
            supportsOutputDirectory,
            outputDirectoryItemsPropertyName);
    }

    // Common resource-identifier property names worth hoisting to a positional argument when an
    // operation has no path template (AutoSDK #340 heuristics 4/5).
    private static readonly HashSet<string> ResourceIdentifierNames = new(StringComparer.OrdinalIgnoreCase)
    {
        "id", "name", "slug", "key", "url", "uri",
    };

    private static ImmutableArray<MethodParameter> SelectPositionalParameters(MethodParameter[] cliParameters)
    {
        // Heuristics 2/3: path-template parameters become positional, in declaration order
        // (`/parents/{parentId}/children/{childId}` -> `<parentId> <childId>`).
        var pathParameters = cliParameters
            .Where(static x => x.Location == ParameterLocation.Path)
            .ToImmutableArray();
        if (pathParameters.Length > 0)
        {
            return pathParameters;
        }

        // Heuristics 4/5: with no path templates, hoist a single required string body property that
        // names a resource (id/name/slug/url/...). Only when exactly one qualifies — otherwise the
        // choice is ambiguous and everything stays a flag.
        var resourceCandidates = cliParameters
            .Where(static x =>
                x.Location is null &&
                x.IsRequired &&
                !x.HasSchemaDefault &&
                x.Type.CSharpTypeWithoutNullability is "string" &&
                IsResourceIdentifierParameter(x))
            .ToImmutableArray();

        return resourceCandidates.Length == 1
            ? resourceCandidates
            : ImmutableArray<MethodParameter>.Empty;
    }

    private static bool IsResourceIdentifierParameter(MethodParameter parameter)
    {
        return ResourceIdentifierNames.Contains(parameter.Id) ||
               ResourceIdentifierNames.Contains(parameter.Name) ||
               ResourceIdentifierNames.Contains(parameter.ParameterName);
    }

    // A request-body field (Location == null) that is plain-optional (nullable option, no schema
    // default) — the fields a base body can fill when no per-field flag is supplied (AutoSDK #343).
    internal static bool IsMergeableBaseBodyField(MethodParameter parameter)
    {
        return parameter.Location is null && !parameter.IsRequired && !parameter.HasSchemaDefault;
    }

    private static bool IsRequestStreamParameter(MethodParameter parameter)
    {
        return parameter.Location is null &&
               string.Equals(parameter.Id, "stream", StringComparison.OrdinalIgnoreCase);
    }

    // The request DTO property name for a body parameter (mirrors Sources.Methods.GetRequestPropertyName).
    internal static string BaseBodyPropertyName(MethodParameter parameter)
    {
        return parameter.Name.StartsWith("request", StringComparison.Ordinal)
            ? parameter.Name.Replace("request", string.Empty, StringComparison.Ordinal)
            : parameter.Name;
    }

    private static ImmutableArray<CliProjectDirectOptionSetUsage> CreateDirectOptionSetUsages(
        EndPoint endPoint,
        ImmutableArray<MethodParameter> optionParameters,
        IReadOnlyDictionary<string, CliProjectOptionSet> optionSetsByModelType)
    {
        if (!optionSetsByModelType.TryGetValue(endPoint.RequestType.CSharpTypeWithoutNullability, out var optionSet))
        {
            return [];
        }

        var parameters = optionSet.Parameters
            .SelectMany(optionSetParameter => optionParameters.Where(parameter => parameter.ParameterName == optionSetParameter.ParameterName))
            .ToImmutableArray();
        if (parameters.Length == 0)
        {
            return [];
        }

        return
        [
            new CliProjectDirectOptionSetUsage(
                InstanceName: $"{optionSet.ClassName}Options",
                ClassName: optionSet.ClassName,
                Parameters: parameters),
        ];
    }

    private static ImmutableArray<CliProjectNestedOptionSetUsage> CreateNestedOptionSetUsages(
        ImmutableArray<MethodParameter> optionParameters,
        IReadOnlyDictionary<string, CliProjectOptionSet> optionSetsByModelType)
    {
        return optionParameters
            .Where(static parameter => parameter.Location is null)
            .Select(parameter =>
            {
                return optionSetsByModelType.TryGetValue(parameter.Type.CSharpTypeWithoutNullability, out var optionSet)
                    ? new CliProjectNestedOptionSetUsage(
                        InstanceName: $"{parameter.Name.ToPropertyName()}Options",
                        ClassName: optionSet.ClassName,
                        Prefix: NormalizeNestedPrefix(parameter.Id),
                        ParameterName: parameter.ParameterName,
                        BasePropertyName: BaseBodyPropertyName(parameter),
                        ModelTypeName: parameter.Type.CSharpTypeWithoutNullability,
                        IsRequired: parameter.IsRequired && !parameter.HasSchemaDefault,
                        Parameters: optionSet.Parameters)
                    : null;
            })
            .Where(static usage => usage is not null)
            .Select(static usage => usage!)
            .ToImmutableArray();
    }

    private static string NormalizeNestedPrefix(string parameterId)
    {
        var prefix = CliProjectScaffolder.ToKebabCase(parameterId);
        return prefix.EndsWith("-options", StringComparison.Ordinal)
            ? prefix[..^"-options".Length]
            : prefix;
    }

    private static ImmutableArray<CliProjectWebhookUsage> CreateWebhookUsages(
        ImmutableArray<MethodParameter> optionParameters,
        IReadOnlyDictionary<string, ModelData> classesByName)
    {
        static bool HasProperty(PropertyData property) => !string.IsNullOrWhiteSpace(property.Name);

        return optionParameters
            .Where(static parameter => parameter.Location is null)
            .Select(parameter =>
            {
                if (!classesByName.TryGetValue(parameter.Type.CSharpTypeWithoutNullability, out var model))
                {
                    return null;
                }

                var urlProperty = model.Properties.FirstOrDefault(static property =>
                    property.Type.CSharpTypeWithoutNullability == "string" &&
                    (property.Id.Contains("url", StringComparison.OrdinalIgnoreCase) ||
                     property.Id.Contains("endpoint", StringComparison.OrdinalIgnoreCase) ||
                     property.Id.Contains("callback", StringComparison.OrdinalIgnoreCase) ||
                     property.Id.Contains("webhook", StringComparison.OrdinalIgnoreCase)));
                if (!HasProperty(urlProperty))
                {
                    return null;
                }

                var headersProperty = model.Properties.FirstOrDefault(static property =>
                    property.Id.Contains("header", StringComparison.OrdinalIgnoreCase) &&
                    property.Type.CSharpTypeWithoutNullability.Contains("Dictionary<string, string>", StringComparison.Ordinal));
                var metadataProperty = model.Properties.FirstOrDefault(static property =>
                    property.Id.Contains("metadata", StringComparison.OrdinalIgnoreCase));
                var eventsProperty = model.Properties.FirstOrDefault(static property =>
                    property.Type.IsArray &&
                    property.Id.Contains("event", StringComparison.OrdinalIgnoreCase));
                if (!HasProperty(headersProperty) &&
                    !HasProperty(metadataProperty) &&
                    !HasProperty(eventsProperty))
                {
                    return null;
                }

                var eventValues = HasProperty(eventsProperty) && eventsProperty.Type.SubTypes.Length > 0
                    ? ImmutableArray.CreateRange(eventsProperty.Type.SubTypes[0].Unbox<TypeData>().EnumValues)
                    : [];

                return new CliProjectWebhookUsage(
                    Prefix: CliProjectScaffolder.ToKebabCase(parameter.Id),
                    ParameterName: parameter.ParameterName,
                    BasePropertyName: BaseBodyPropertyName(parameter),
                    ModelTypeName: parameter.Type.CSharpTypeWithoutNullability,
                    UrlPropertyName: HasProperty(urlProperty) ? urlProperty.Name : null,
                    UrlIsRequired: HasProperty(urlProperty) && urlProperty.IsRequired,
                    HeadersPropertyName: HasProperty(headersProperty) ? headersProperty.Name : null,
                    HeadersTypeName: HasProperty(headersProperty) ? headersProperty.Type.CSharpType : null,
                    MetadataPropertyName: HasProperty(metadataProperty) ? metadataProperty.Name : null,
                    MetadataTypeName: HasProperty(metadataProperty) ? metadataProperty.Type.CSharpType : null,
                    EventsPropertyName: HasProperty(eventsProperty) ? eventsProperty.Name : null,
                    EventsTypeName: HasProperty(eventsProperty) ? eventsProperty.Type.CSharpType : null,
                    EventValues: eventValues);
            })
            .Where(static usage => usage is not null)
            .Select(static usage => usage!)
            .ToImmutableArray();
    }

    private static bool ResolveWaitSupport(EndPoint endPoint, CliProjectWaitMode waitMode)
    {
        return waitMode switch
        {
            CliProjectWaitMode.Enabled => endPoint.HasLocationWaitCompanion,
            CliProjectWaitMode.Disabled => false,
            _ => endPoint.HasLocationWaitCompanion,
        };
    }

    private static (bool SupportsOutputDirectory, string ItemsPropertyName) DetectOutputDirectorySupport(
        EndPoint endPoint,
        IReadOnlyDictionary<string, ModelData> classesByName)
    {
        var responseType = endPoint.SuccessResponse.Type;
        if (responseType == TypeData.Default || endPoint.RawStream || endPoint.EnumerableStream)
        {
            return (false, string.Empty);
        }

        if (responseType.IsArray)
        {
            return (true, "$self");
        }

        if (classesByName.TryGetValue(responseType.CSharpTypeWithoutNullability, out var responseClass))
        {
            PropertyData? itemsProperty = null;
            foreach (var property in responseClass.Properties)
            {
                if (!property.Type.IsArray)
                {
                    continue;
                }

                if (itemsProperty is not null)
                {
                    return (false, string.Empty);
                }

                itemsProperty = property;
            }

            if (itemsProperty is not null)
            {
                return (true, itemsProperty.Value.Name);
            }
        }

        return (false, string.Empty);
    }

    private static string GetResponseType(EndPoint endPoint)
    {
        if (endPoint.SuccessResponse.Type == TypeData.Default)
        {
            return string.Empty;
        }

        return endPoint.RawStream
            ? "global::System.IO.Stream"
            : endPoint.EnumerableStream
                ? endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability
                : endPoint.SuccessResponse.Type.CSharpType;
    }
}

internal static class CliProjectScaffolder
{
    public static async Task WriteAsync(CliProjectModel model)
    {
        Directory.CreateDirectory(model.OutputPath);
        Directory.CreateDirectory(Path.Combine(model.OutputPath, "Commands"));

        if (!model.ApiOnly)
        {
            await WriteFileAsync(model, $"{model.ProjectName}.csproj", GenerateProjectFile(model)).ConfigureAwait(false);
            await WriteFileAsync(model, "Program.cs", GenerateProgram(model)).ConfigureAwait(false);
        }

        await WriteFileAsync(model, "CliOptions.cs", GenerateCliOptions(model)).ConfigureAwait(false);
        await WriteFileAsync(model, "CliException.cs", GenerateCliException(model)).ConfigureAwait(false);
        await WriteFileAsync(model, "CliRuntime.cs", GenerateCliRuntime(model)).ConfigureAwait(false);
        if (!model.ApiOnly)
        {
            await WriteFileAsync(model, Path.Combine("Commands", "AuthCommand.cs"), GenerateAuthCommand(model)).ConfigureAwait(false);
        }

        await WriteFileAsync(model, Path.Combine("Commands", "ApiCommand.g.cs"), GenerateApiCommand(model)).ConfigureAwait(false);
        foreach (var optionSet in model.OptionSets)
        {
            await WriteFileAsync(model, Path.Combine("Commands", $"{optionSet.ClassName}.g.cs"), GenerateOptionSet(model, optionSet)).ConfigureAwait(false);
        }

        foreach (var tag in model.Tags)
        {
            await WriteFileAsync(model, Path.Combine("Commands", $"{tag.ClassName}.g.cs"), GenerateTagCommand(model, tag)).ConfigureAwait(false);
            foreach (var operation in tag.Operations)
            {
                await WriteFileAsync(model, Path.Combine("Commands", $"{operation.ClassName}.g.cs"), GenerateOperationCommand(model, operation)).ConfigureAwait(false);
            }
        }
    }

    public static string ToKebabCase(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return "api";
        }

        var builder = new StringBuilder(value.Length + 8);
        var previousWasSeparator = true;
        var previousWasLowerOrDigit = false;
        foreach (var ch in value)
        {
            if (char.IsLetterOrDigit(ch))
            {
                if (char.IsUpper(ch) && previousWasLowerOrDigit && !previousWasSeparator)
                {
                    builder.Append('-');
                }

                builder.Append(char.ToLowerInvariant(ch));
                previousWasSeparator = false;
                previousWasLowerOrDigit = char.IsLower(ch) || char.IsDigit(ch);
                continue;
            }

            if (!previousWasSeparator)
            {
                builder.Append('-');
                previousWasSeparator = true;
            }

            previousWasLowerOrDigit = false;
        }

        return builder.ToString().Trim('-') is { Length: > 0 } result ? result : "api";
    }

    // Removes a leading tag-name token from an already-kebab-cased command name when the command
    // is nested under that tag group, so the tag isn't repeated in the CLI surface (AutoSDK #345).
    // Matches the tag's name and its singularized form (case-insensitive, kebab-normalized).
    public static string StripRedundantTagPrefix(string kebabName, Tag tag)
    {
        foreach (var candidate in new[] { tag.Name, tag.SingularizedName })
        {
            if (string.IsNullOrWhiteSpace(candidate))
            {
                continue;
            }

            var tagKebab = ToKebabCase(candidate);
            if (tagKebab.Length > 0 &&
                kebabName.Length > tagKebab.Length + 1 &&
                kebabName.StartsWith(tagKebab + "-", StringComparison.Ordinal))
            {
                var remainder = kebabName.Substring(tagKebab.Length + 1);
                if (remainder.StartsWith("and-", StringComparison.Ordinal) ||
                    remainder.StartsWith("or-", StringComparison.Ordinal))
                {
                    continue;
                }

                return remainder;
            }
        }

        return kebabName;
    }

    public static string ToTypeName(string value)
    {
        var builder = new StringBuilder(value.Length);
        var capitalizeNext = true;

        foreach (var ch in value)
        {
            if (!char.IsLetterOrDigit(ch))
            {
                capitalizeNext = true;
                continue;
            }

            builder.Append(capitalizeNext ? char.ToUpperInvariant(ch) : ch);
            capitalizeNext = false;
        }

        if (builder.Length == 0)
        {
            return "ApiCommand";
        }

        if (char.IsDigit(builder[0]))
        {
            builder.Insert(0, '_');
        }

        return builder.ToString();
    }

    public static string MakeUniqueCommandName(
        string commandName,
        HashSet<string> usedNames)
    {
        if (usedNames.Add(commandName))
        {
            return commandName;
        }

        for (var index = 2; ; index++)
        {
            var candidate = $"{commandName}-{index}";
            if (usedNames.Add(candidate))
            {
                return candidate;
            }
        }
    }

    public static string MakeUniqueTypeName(
        string typeName,
        HashSet<string> usedNames)
    {
        if (usedNames.Add(typeName))
        {
            return typeName;
        }

        for (var index = 2; ; index++)
        {
            var candidate = $"{typeName}{index}";
            if (usedNames.Add(candidate))
            {
                return candidate;
            }
        }
    }

    private static async Task WriteFileAsync(CliProjectModel model, string relativePath, string content)
    {
        var path = Path.Combine(model.OutputPath, relativePath);
        var directory = Path.GetDirectoryName(path);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        await File.WriteAllTextAsync(path, NormalizeGeneratedContent(content)).ConfigureAwait(false);
    }

    private static string NormalizeGeneratedContent(string content)
    {
        var normalized = content.Replace("\r\n", "\n", StringComparison.Ordinal);
        var endsWithNewLine = normalized.EndsWith('\n');
        var lines = normalized.Split('\n');
        var builder = new StringBuilder(normalized.Length);
        var count = endsWithNewLine ? lines.Length - 1 : lines.Length;

        for (var index = 0; index < count; index++)
        {
            builder.Append(lines[index].TrimEnd(' ', '\t'));
            builder.Append('\n');
        }

        if (!endsWithNewLine && lines.Length > 0)
        {
            builder.Length--;
        }

        return builder.ToString();
    }

    private static string GenerateProjectFile(CliProjectModel model)
    {
        var relativeSdkProject = NormalizePath(Path.GetRelativePath(model.OutputPath, model.SdkProjectPath));

        return $"""
                <Project Sdk="Microsoft.NET.Sdk">
                  <PropertyGroup>
                    <OutputType>Exe</OutputType>
                    <TargetFramework>{XmlEscape(model.TargetFramework)}</TargetFramework>
                    <ImplicitUsings>enable</ImplicitUsings>
                    <Nullable>enable</Nullable>
                    <LangVersion>preview</LangVersion>
                    <PackAsTool>true</PackAsTool>
                    <PackageId>{XmlEscape(model.PackageId)}</PackageId>
                    <ToolCommandName>{XmlEscape(model.ToolCommandName)}</ToolCommandName>
                    <UserSecretsId>{XmlEscape(model.UserSecretsId)}</UserSecretsId>
                  </PropertyGroup>
                  <ItemGroup>
                    <PackageReference Include="System.CommandLine" Version="2.0.7" />
                    <ProjectReference Include="{XmlEscape(relativeSdkProject)}" />
                  </ItemGroup>
                </Project>
                """;
    }

    private static string GenerateProgram(CliProjectModel model)
    {
        // By default the tag groups are top-level subcommands (firecrawl crawl cancel ...). With
        // --cli-keep-api-group they stay nested under a legacy "api" group (AutoSDK #345). The
        // ApiCommand aggregate is generated either way, so api-only consumers can still wire it.
        var endpointSubcommands = model.KeepApiGroup
            ? "rootCommand.Subcommands.Add(ApiCommand.Create());"
            : string.Join(
                "\n",
                model.Tags.Select(tag => $"rootCommand.Subcommands.Add({tag.ClassName}.Create());"));

        return $$"""
                 #nullable enable

                 using System.CommandLine;
                 using {{model.RootNamespace}};
                 using {{model.RootNamespace}}.Commands;

                 var rootCommand = new RootCommand({{Literal($"CLI tool for the {model.SdkNamespace} SDK.")}});
                 rootCommand.Options.Add(CliOptions.ApiKey);
                 rootCommand.Options.Add(CliOptions.BaseUrl);
                 rootCommand.Options.Add(CliOptions.Json);
                 rootCommand.Options.Add(CliOptions.Output);
                 rootCommand.Options.Add(CliOptions.OutputDirectory);
                 rootCommand.Subcommands.Add(AuthCommand.Create());
                 {{endpointSubcommands}}

                 return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);
                 """;
    }

    private static string GenerateCliOptions(CliProjectModel model)
    {
        var apiKeyDescription = string.IsNullOrWhiteSpace(model.CredentialFileDirectoryName)
            ? "API key. Falls back to configured environment variables and dotnet user-secrets."
            : "API key. Falls back to configured environment variables, dotnet user-secrets, and the optional credential file.";

        return $$"""
                 #nullable enable

                 using System.CommandLine;

                 namespace {{model.RootNamespace}};

                 internal static class CliOptions
                 {
                     public static Option<string?> ApiKey { get; } = new("--api-key", ["-k"])
                     {
                         Description = {{Literal(apiKeyDescription)}},
                         Recursive = true,
                     };

                     public static Option<string?> BaseUrl { get; } = new("--base-url")
                     {
                         Description = "Override the API base URL.",
                         Recursive = true,
                     };

                     public static Option<bool> Json { get; } = new("--json")
                     {
                         Description = "Render structured responses as raw JSON instead of human-readable text.",
                         Recursive = true,
                     };

                     public static Option<string?> Output { get; } = new("--output", ["-o"])
                     {
                         Description = "Write response content to this file path instead of stdout.",
                         Recursive = true,
                     };

                     public static Option<string?> OutputDirectory { get; } = new("--output-dir")
                     {
                         Description = "Write one file per returned item when the response contains multiple resources.",
                         Recursive = true,
                     };
                 }
                 """;
    }

    private static string GenerateCliException(CliProjectModel model)
    {
        return $$"""
                 #nullable enable

                 namespace {{model.RootNamespace}};

                 internal sealed class CliException : Exception
                 {
                     public CliException()
                     {
                     }

                     public CliException(string message) : base(message)
                     {
                     }

                     public CliException(string message, Exception innerException) : base(message, innerException)
                     {
                     }
                 }
                 """;
    }

    private static string GenerateCliRuntime(CliProjectModel model)
    {
        var envVarArray = string.Join(", ", model.ApiKeyEnvVars.Select(static x => Literal(x)));
        var authorizations = model.Authorizations.Select(authorization => $$"""
                    new global::{{model.SdkNamespace}}.EndPointAuthorization
                    {
                        Type = "{{authorization.Type}}",
                        SchemeId = "{{authorization.SchemeId}}",
                        Location = "{{authorization.Location}}",
                        Name = "{{authorization.Name}}",
                        Value = apiKey,
                    },
            """).Inject();
        var createPollingOptionsMethod = model.Tags
            .SelectMany(static tag => tag.Operations)
            .Any(static operation => operation.SupportsWait)
            ? $$"""

                     public static global::{{model.SdkNamespace}}.AutoSDKPollingOptions CreatePollingOptions(TimeSpan pollInterval, TimeSpan waitTimeout)
                     {
                         if (pollInterval <= TimeSpan.Zero)
                         {
                             throw new CliException("--poll-interval must be greater than zero.");
                         }

                         if (waitTimeout <= TimeSpan.Zero)
                         {
                             throw new CliException("--wait-timeout must be greater than zero.");
                         }

                         var maxAttempts = (int)Math.Ceiling(waitTimeout.TotalMilliseconds / pollInterval.TotalMilliseconds);
                         return new global::{{model.SdkNamespace}}.AutoSDKPollingOptions
                         {
                             Interval = pollInterval,
                             MaxAttempts = Math.Max(maxAttempts, 1),
                         };
                     }
            """
            : string.Empty;

        return $$"""
                 #nullable enable

                 using System.CommandLine;
                 using System.CommandLine.Parsing;
                 using System.Globalization;
                 using System.Text;
                 using System.Text.Json;
                 using System.Text.Json.Nodes;
                 using System.Text.Json.Serialization;

                 namespace {{model.RootNamespace}};

                 internal static class CliRuntime
                 {
                     private const string UserSecretsId = "{{model.UserSecretsId}}";
                     private const string UserSecretApiKeyName = "{{model.ApiKeyEnvVars.FirstOrDefault() ?? "API_KEY"}}";
                     private static readonly string[] ApiKeyEnvironmentVariables = [{{envVarArray}}];
                     private const string CredentialFileDirectoryName = "{{model.CredentialFileDirectoryName}}";

                     public static async Task<global::{{model.SdkNamespace}}.{{model.ClientClassName}}> CreateClientAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
                     {
                         var apiKey = await TryResolveApiKeyAsync(parseResult, cancellationToken).ConfigureAwait(false);
                         var authorizations = string.IsNullOrWhiteSpace(apiKey)
                             ? new global::System.Collections.Generic.List<global::{{model.SdkNamespace}}.EndPointAuthorization>()
                             : new global::System.Collections.Generic.List<global::{{model.SdkNamespace}}.EndPointAuthorization>
                             {
                 {{authorizations}}
                             };
                         var baseUri = ResolveBaseUri(parseResult);

                         return new global::{{model.SdkNamespace}}.{{model.ClientClassName}}(
                             httpClient: null,
                             baseUri: baseUri,
                             authorizations: authorizations,
                             disposeHttpClient: true);
                     }

                     [System.Diagnostics.CodeAnalysis.SuppressMessage(
                         "Design",
                         "CA1031:Do not catch general exception types",
                         Justification = "Generated CLI commands map unexpected failures to a stable exit code.")]
                     public static async Task<int> RunAsync(Func<Task> action, CancellationToken cancellationToken = default)
                     {
                         try
                         {
                             await action().ConfigureAwait(false);
                             return 0;
                         }
                         catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
                         {
                             await Console.Error.WriteLineAsync("Canceled.").ConfigureAwait(false);
                             return 130;
                         }
                         catch (global::{{model.SdkNamespace}}.ApiException exception)
                         {
                             await WriteApiExceptionAsync(exception).ConfigureAwait(false);
                             return 2;
                         }
                         catch (CliException exception)
                         {
                             await Console.Error.WriteLineAsync(exception.Message).ConfigureAwait(false);
                             return 1;
                         }
                         catch (Exception exception)
                         {
                             await Console.Error.WriteLineAsync(exception.Message).ConfigureAwait(false);
                             return 1;
                         }
                     }

                     public static async Task<string?> TryResolveApiKeyAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
                     {
                         var probe = await ProbeAuthAsync(parseResult, cancellationToken).ConfigureAwait(false);
                         return probe.Active?.RawValue;
                     }

                     public static async Task<AuthStatusInfo> GetAuthStatusAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
                     {
                         var probe = await ProbeAuthAsync(parseResult, cancellationToken).ConfigureAwait(false);
                         return new AuthStatusInfo(
                             Authenticated: probe.Active is not null,
                             Source: probe.Active?.DisplayName ?? "none",
                             ApiKeyHint: probe.Active is { RawValue.Length: > 0 } active ? MaskSecret(active.RawValue) : null,
                             Path: probe.Active?.Path,
                             Sources: probe.Sources
                                 .Select(static source => new AuthSourceStatus(
                                     source.DisplayName,
                                     source.Present,
                                     source.Present ? CliRuntime.MaskSecret(source.RawValue!) : null,
                                     source.Path))
                                 .ToArray());
                     }

                     public static async Task WriteUserSecretAsync(string name, string value, CancellationToken cancellationToken = default)
                     {
                         var path = GetUserSecretsPath();
                         var directory = Path.GetDirectoryName(path);
                         if (!string.IsNullOrWhiteSpace(directory))
                         {
                             Directory.CreateDirectory(directory);
                         }

                         var values = await ReadUserSecretsAsync(cancellationToken).ConfigureAwait(false);
                         values[name] = value;
                         var json = PrettyJson(JsonSerializer.Serialize(values, UserSecretsJsonContext.Default.DictionaryStringString));
                         await File.WriteAllTextAsync(path, json, cancellationToken).ConfigureAwait(false);
                     }

                     public static async Task ClearUserSecretAsync(string name, CancellationToken cancellationToken = default)
                     {
                         var path = GetUserSecretsPath();
                         if (!File.Exists(path))
                         {
                             return;
                         }

                         var values = await ReadUserSecretsAsync(cancellationToken).ConfigureAwait(false);
                         if (!values.Remove(name))
                         {
                             return;
                         }

                         var json = PrettyJson(JsonSerializer.Serialize(values, UserSecretsJsonContext.Default.DictionaryStringString));
                         await File.WriteAllTextAsync(path, json, cancellationToken).ConfigureAwait(false);
                     }

                     public static string GetUserSecretApiKeyName() => UserSecretApiKeyName;

                     public static string GetUserSecretsPath()
                     {
                         var userSecretsRoot = OperatingSystem.IsWindows()
                             ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft", "UserSecrets")
                             : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".microsoft", "usersecrets");

                         return Path.Combine(userSecretsRoot, UserSecretsId, "secrets.json");
                     }

                     public static string? GetCredentialFilePath()
                     {
                         if (string.IsNullOrWhiteSpace(CredentialFileDirectoryName))
                         {
                             return null;
                         }

                         var userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                         return string.IsNullOrWhiteSpace(userProfile)
                             ? null
                             : Path.Combine(userProfile, CredentialFileDirectoryName, "apiKey.txt");
                     }

                     public static bool WasSpecified(ParseResult parseResult, Symbol symbol)
                     {
                         return parseResult.GetResult(symbol) is not null;
                     }

                     public static Option<bool?> CreateNullableBoolOption(string name, string description, params string[] aliases)
                     {
                         var option = new Option<bool?>(name, aliases)
                         {
                             Description = description + " Specify true/false; presence alone implies true; omit to inherit.",
                             Arity = ArgumentArity.ZeroOrOne,
                         };

                         option.CustomParser = result =>
                         {
                             if (result.Tokens.Count == 0)
                             {
                                 return true;
                             }

                             if (result.Tokens.Count == 1)
                             {
                                 var raw = result.Tokens[0].Value.Trim();
                                 if (bool.TryParse(raw, out var boolValue))
                                 {
                                     return boolValue;
                                 }

                                 switch (raw.ToUpperInvariant())
                                 {
                                     case "1":
                                     case "YES":
                                     case "Y":
                                     case "ON":
                                         return true;
                                     case "0":
                                     case "NO":
                                     case "N":
                                     case "OFF":
                                         return false;
                                 }
                             }

                             result.AddError($"Option '{name}' expects true or false.");
                             return null;
                         };

                         return option;
                     }

                     public static TimeSpan ParseDuration(string value, string optionName)
                     {
                         if (TimeSpan.TryParse(value, CultureInfo.InvariantCulture, out var timeSpan))
                         {
                             return timeSpan;
                         }

                         if (value.EndsWith("ms", StringComparison.OrdinalIgnoreCase) &&
                             double.TryParse(value[..^2], NumberStyles.Float, CultureInfo.InvariantCulture, out var milliseconds))
                         {
                             return TimeSpan.FromMilliseconds(milliseconds);
                         }

                         if (EndsWithUnit(value, 's') &&
                             double.TryParse(value[..^1], NumberStyles.Float, CultureInfo.InvariantCulture, out var seconds))
                         {
                             return TimeSpan.FromSeconds(seconds);
                         }

                         if (EndsWithUnit(value, 'm') &&
                             double.TryParse(value[..^1], NumberStyles.Float, CultureInfo.InvariantCulture, out var minutes))
                         {
                             return TimeSpan.FromMinutes(minutes);
                         }

                         if (EndsWithUnit(value, 'h') &&
                             double.TryParse(value[..^1], NumberStyles.Float, CultureInfo.InvariantCulture, out var hours))
                         {
                             return TimeSpan.FromHours(hours);
                         }

                         throw new CliException($"Unable to parse duration '{value}' for option '{optionName}'.");
                     }

                 {{createPollingOptionsMethod}}

                     public static async Task<string?> ReadInputAsync(
                         ParseResult parseResult,
                         Option<string?> inputOption,
                         Option<string?> requestJsonOption,
                         Option<string?> requestFileOption,
                         bool required = false,
                         CancellationToken cancellationToken = default)
                     {
                         var hasInput = WasSpecified(parseResult, inputOption);
                         var hasRequestJson = WasSpecified(parseResult, requestJsonOption);
                         var hasRequestFile = WasSpecified(parseResult, requestFileOption);
                         var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);

                         if (specifiedCount > 1)
                         {
                             throw new CliException("Specify at most one of --input, --request-json, or --request-file.");
                         }

                         if (specifiedCount == 0)
                         {
                             if (required)
                             {
                                 throw new CliException("Specify --input, --request-json, or --request-file.");
                             }

                             return null;
                         }

                         if (hasRequestJson)
                         {
                             await WriteDeprecatedOptionWarningAsync("--request-json", "--input").ConfigureAwait(false);
                             return parseResult.GetValue(requestJsonOption);
                         }

                         if (hasRequestFile)
                         {
                             await WriteDeprecatedOptionWarningAsync("--request-file", "--input").ConfigureAwait(false);
                             return await ReadFileOrStdinAsync(parseResult.GetValue(requestFileOption)!, cancellationToken).ConfigureAwait(false);
                         }

                         return await ReadFlexibleInputAsync(parseResult.GetValue(inputOption)!, cancellationToken).ConfigureAwait(false);
                     }

                     public static async Task<T> ReadRequestAsync<T>(
                         ParseResult parseResult,
                         Option<string?> inputOption,
                         Option<string?> requestJsonOption,
                         Option<string?> requestFileOption,
                         JsonSerializerContext context,
                         CancellationToken cancellationToken = default)
                     {
                         var requestJson = await ReadInputAsync(
                             parseResult,
                             inputOption,
                             requestJsonOption,
                             requestFileOption,
                             required: true,
                             cancellationToken).ConfigureAwait(false);

                         var value = JsonSerializer.Deserialize(requestJson ?? throw new CliException("Request input is required."), typeof(T), context);
                         return value is T typed
                             ? typed
                             : throw new CliException($"Unable to deserialize request JSON as {typeof(T).Name}.");
                     }

                     public static async Task<T?> ReadRequestOrDefaultAsync<T>(
                         ParseResult parseResult,
                         Option<string?> inputOption,
                         Option<string?> requestJsonOption,
                         Option<string?> requestFileOption,
                         JsonSerializerContext context,
                         CancellationToken cancellationToken = default)
                     {
                         var requestJson = await ReadInputAsync(
                             parseResult,
                             inputOption,
                             requestJsonOption,
                             requestFileOption,
                             cancellationToken: cancellationToken).ConfigureAwait(false);
                         if (string.IsNullOrWhiteSpace(requestJson))
                         {
                             return default;
                         }

                         var value = JsonSerializer.Deserialize(requestJson!, typeof(T), context);
                         return value is T typed
                             ? typed
                             : throw new CliException($"Unable to deserialize request JSON as {typeof(T).Name}.");
                     }

                     public static T DeserializeJsonValue<T>(string json, JsonSerializerContext context)
                     {
                         _ = context;
                         return JsonSerializer.Deserialize<T>(json) ??
                             throw new CliException($"Unable to deserialize generated CLI value as {typeof(T).Name}.");
                     }

                     public static string SerializeKeyValuePairs(IEnumerable<string> pairs)
                     {
                         var objectNode = new JsonObject();
                         foreach (var pair in pairs)
                         {
                             var separatorIndex = pair.IndexOf('=', StringComparison.Ordinal);
                             if (separatorIndex <= 0 || separatorIndex == pair.Length - 1)
                             {
                                 throw new CliException($"Expected KEY=VALUE but received '{pair}'.");
                             }

                             var key = pair[..separatorIndex].Trim();
                             var value = pair[(separatorIndex + 1)..].Trim();
                             if (string.IsNullOrWhiteSpace(key))
                             {
                                 throw new CliException($"Expected KEY=VALUE but received '{pair}'.");
                             }

                             objectNode[key] = value;
                         }

                         return objectNode.ToJsonString();
                     }

                     public static string SerializeStringArray(IEnumerable<string> values)
                     {
                         return JsonSerializer.Serialize(values.ToArray());
                     }

                     public static async Task WriteJsonAsync<T>(ParseResult parseResult, T value, JsonSerializerContext context, CancellationToken cancellationToken = default)
                     {
                         var json = JsonSerializer.Serialize(value, typeof(T), context);
                         await WriteTextAsync(parseResult, PrettyJson(json), cancellationToken: cancellationToken).ConfigureAwait(false);
                     }

                     public static async Task WriteJsonLineAsync<T>(ParseResult parseResult, T value, JsonSerializerContext context, CancellationToken cancellationToken = default)
                     {
                         var json = JsonSerializer.Serialize(value, typeof(T), context);
                         await WriteTextAsync(parseResult, json + Environment.NewLine, append: true, cancellationToken: cancellationToken).ConfigureAwait(false);
                     }

                     public static async Task WriteResponseAsync<T>(
                         ParseResult parseResult,
                         T value,
                         JsonSerializerContext context,
                         Func<ParseResult, T, JsonSerializerContext, bool, string>? formatter = null,
                         CancellationToken cancellationToken = default)
                     {
                         if (parseResult.GetValue(CliOptions.Json))
                         {
                             await WriteJsonAsync(parseResult, value, context, cancellationToken).ConfigureAwait(false);
                             return;
                         }

                         var truncateLongStrings = string.IsNullOrWhiteSpace(parseResult.GetValue(CliOptions.Output));
                         var text = formatter is null
                             ? FormatHumanReadable(value, context, truncateLongStrings)
                             : formatter(parseResult, value, context, truncateLongStrings);
                         await WriteTextAsync(parseResult, text, cancellationToken: cancellationToken).ConfigureAwait(false);
                     }

                     public static async Task WriteResponseLineAsync<T>(
                         ParseResult parseResult,
                         T value,
                         JsonSerializerContext context,
                         Func<ParseResult, T, JsonSerializerContext, bool, string>? formatter = null,
                         CancellationToken cancellationToken = default)
                     {
                         if (parseResult.GetValue(CliOptions.Json))
                         {
                             await WriteJsonLineAsync(parseResult, value, context, cancellationToken).ConfigureAwait(false);
                             return;
                         }

                         var truncateLongStrings = string.IsNullOrWhiteSpace(parseResult.GetValue(CliOptions.Output));
                         var text = formatter is null
                             ? FormatHumanReadable(value, context, truncateLongStrings)
                             : formatter(parseResult, value, context, truncateLongStrings);
                         await WriteTextAsync(parseResult, text + Environment.NewLine, append: true, cancellationToken: cancellationToken).ConfigureAwait(false);
                     }

                     public static async Task<bool> TryWriteOutputDirectoryAsync<T>(
                         ParseResult parseResult,
                         T value,
                         JsonSerializerContext context,
                         string itemsPropertyName,
                         CancellationToken cancellationToken = default)
                     {
                         var outputDirectory = parseResult.GetValue(CliOptions.OutputDirectory);
                         if (string.IsNullOrWhiteSpace(outputDirectory))
                         {
                             return false;
                         }

                         var rootNode = ToJsonNode(value, typeof(T), context);
                         var items = itemsPropertyName == "$self"
                             ? rootNode as JsonArray
                             : rootNode?[itemsPropertyName] as JsonArray;
                         if (items is null)
                         {
                             throw new CliException("The response does not contain a writable item collection for --output-dir.");
                         }

                         await WriteItemFilesAsync(outputDirectory, items, cancellationToken).ConfigureAwait(false);
                         return true;
                     }

                     public static async Task WriteSuccessAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
                     {
                         if (parseResult.GetValue(CliOptions.Json))
                         {
                             await WriteTextAsync(parseResult, "{\n  \"success\": true\n}", cancellationToken: cancellationToken).ConfigureAwait(false);
                             return;
                         }

                         await WriteTextAsync(parseResult, "success: true", cancellationToken: cancellationToken).ConfigureAwait(false);
                     }

                     public static async Task WriteBinaryAsync(ParseResult parseResult, byte[] bytes, CancellationToken cancellationToken = default)
                     {
                         var outputPath = parseResult.GetValue(CliOptions.Output);
                         if (string.IsNullOrWhiteSpace(outputPath))
                         {
                             throw new CliException("Binary responses require --output.");
                         }

                         await WriteBytesAsync(outputPath, bytes, cancellationToken).ConfigureAwait(false);
                     }

                     public static async Task WriteStreamAsync(ParseResult parseResult, Stream stream, CancellationToken cancellationToken = default)
                     {
                         var outputPath = parseResult.GetValue(CliOptions.Output);
                         if (string.IsNullOrWhiteSpace(outputPath))
                         {
                             throw new CliException("Stream responses require --output.");
                         }

                         var directory = Path.GetDirectoryName(outputPath);
                         if (!string.IsNullOrWhiteSpace(directory))
                         {
                             Directory.CreateDirectory(directory);
                         }

                         var file = File.Create(outputPath);
                         await using (file.ConfigureAwait(false))
                         {
                             await stream.CopyToAsync(file, cancellationToken).ConfigureAwait(false);
                         }
                     }

                     public static string MaskSecret(string secret)
                     {
                         return secret.Length < 12 ? "***" : $"{secret[..4]}...{secret[^4..]}";
                     }

                     private static Uri? ResolveBaseUri(ParseResult parseResult)
                     {
                         var baseUrl = parseResult.GetValue(CliOptions.BaseUrl);
                         if (string.IsNullOrWhiteSpace(baseUrl))
                         {
                             baseUrl = Environment.GetEnvironmentVariable("{{model.BaseUrlEnvVar}}");
                         }

                         return string.IsNullOrWhiteSpace(baseUrl) ? null : new Uri(baseUrl, UriKind.Absolute);
                     }

                     private static async Task<string?> ReadUserSecretAsync(string name, CancellationToken cancellationToken = default)
                     {
                         var values = await ReadUserSecretsAsync(cancellationToken).ConfigureAwait(false);
                         return values.TryGetValue(name, out var value) && !string.IsNullOrWhiteSpace(value) ? value : null;
                     }

                     private static async Task<string?> ReadCredentialFileAsync(CancellationToken cancellationToken = default)
                     {
                         var path = GetCredentialFilePath();
                         if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                         {
                             return null;
                         }

                         var value = await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false);
                         return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
                     }

                     private static async Task<Dictionary<string, string>> ReadUserSecretsAsync(CancellationToken cancellationToken = default)
                     {
                         var path = GetUserSecretsPath();
                         if (!File.Exists(path))
                         {
                             return new Dictionary<string, string>(StringComparer.Ordinal);
                         }

                         var json = await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false);
                         if (string.IsNullOrWhiteSpace(json))
                         {
                             return new Dictionary<string, string>(StringComparer.Ordinal);
                         }

                         return JsonSerializer.Deserialize(json, UserSecretsJsonContext.Default.DictionaryStringString) ??
                             new Dictionary<string, string>(StringComparer.Ordinal);
                     }

                     private static async Task WriteTextAsync(ParseResult parseResult, string text, bool append = false, CancellationToken cancellationToken = default)
                     {
                         var outputPath = parseResult.GetValue(CliOptions.Output);
                         if (string.IsNullOrWhiteSpace(outputPath))
                         {
                             await Console.Out.WriteAsync(text).ConfigureAwait(false);
                             if (!text.EndsWith(Environment.NewLine, StringComparison.Ordinal))
                             {
                                 await Console.Out.WriteLineAsync().ConfigureAwait(false);
                             }

                             return;
                         }

                         var directory = Path.GetDirectoryName(outputPath);
                         if (!string.IsNullOrWhiteSpace(directory))
                         {
                             Directory.CreateDirectory(directory);
                         }

                         if (append)
                         {
                             await File.AppendAllTextAsync(outputPath, text, cancellationToken).ConfigureAwait(false);
                         }
                         else
                         {
                             await File.WriteAllTextAsync(outputPath, text, cancellationToken).ConfigureAwait(false);
                         }
                     }

                     private static async Task WriteBytesAsync(string outputPath, byte[] bytes, CancellationToken cancellationToken = default)
                     {
                         var directory = Path.GetDirectoryName(outputPath);
                         if (!string.IsNullOrWhiteSpace(directory))
                         {
                             Directory.CreateDirectory(directory);
                         }

                         await File.WriteAllBytesAsync(outputPath, bytes, cancellationToken).ConfigureAwait(false);
                     }

                     private static bool EndsWithUnit(string value, char unit)
                     {
                         return value.Length > 1 && value[^1] == unit;
                     }

                     private static async Task WriteDeprecatedOptionWarningAsync(string oldOption, string replacement)
                     {
                         await Console.Error.WriteLineAsync($"Warning: {oldOption} is deprecated; use {replacement}.").ConfigureAwait(false);
                     }

                     private static async Task<string> ReadFlexibleInputAsync(string input, CancellationToken cancellationToken = default)
                     {
                         if (string.IsNullOrWhiteSpace(input))
                         {
                             throw new CliException("Input cannot be empty.");
                         }

                         if (input == "-")
                         {
                             return await Console.In.ReadToEndAsync(cancellationToken).ConfigureAwait(false);
                         }

                         var trimmed = input.TrimStart();
                         if (trimmed.StartsWith('{') || trimmed.StartsWith('['))
                         {
                             return input;
                         }

                         return await ReadFileOrStdinAsync(input, cancellationToken).ConfigureAwait(false);
                     }

                     private static async Task<string> ReadFileOrStdinAsync(string pathOrDash, CancellationToken cancellationToken = default)
                     {
                         if (pathOrDash == "-")
                         {
                             return await Console.In.ReadToEndAsync(cancellationToken).ConfigureAwait(false);
                         }

                         if (!File.Exists(pathOrDash))
                         {
                             throw new CliException($"File not found: {pathOrDash}");
                         }

                         return await File.ReadAllTextAsync(pathOrDash, cancellationToken).ConfigureAwait(false);
                     }

                     private static JsonNode? ToJsonNode<T>(T value, Type type, JsonSerializerContext context)
                     {
                         var json = JsonSerializer.Serialize(value, type, context);
                         return JsonNode.Parse(json);
                     }

                     private static JsonElement ToJsonElement<T>(T value, JsonSerializerContext context)
                     {
                         var json = JsonSerializer.Serialize(value, typeof(T), context);
                         using var document = JsonDocument.Parse(json);
                         return document.RootElement.Clone();
                     }

                     public static string FormatHumanReadable<T>(
                         T value,
                         JsonSerializerContext context,
                         bool truncateLongStrings,
                         IReadOnlyDictionary<string, CliFormatHint>? formatHints = null)
                     {
                         var element = ToJsonElement(value, context);
                         var builder = new StringBuilder();
                         AppendFormattedValue(builder, null, element, 0, truncateLongStrings, formatHints, path: null);
                         return builder.ToString().TrimEnd();
                     }

                     private static void AppendFormattedValue(
                         StringBuilder builder,
                         string? name,
                         JsonElement element,
                         int indent,
                         bool truncateLongStrings,
                         IReadOnlyDictionary<string, CliFormatHint>? formatHints,
                         string? path)
                     {
                         if (ShouldHide(path, formatHints))
                         {
                             return;
                         }

                         if (element.ValueKind == JsonValueKind.String &&
                             HasFormatHint(path, CliFormatHint.Code, formatHints))
                         {
                             AppendCodeBlock(builder, name, element.GetString() ?? string.Empty, indent);
                             return;
                         }

                         switch (element.ValueKind)
                         {
                             case JsonValueKind.Object:
                                 AppendFormattedObject(builder, name, element, indent, truncateLongStrings, formatHints, path);
                                 break;
                             case JsonValueKind.Array:
                                 AppendFormattedArray(builder, name, element, indent, truncateLongStrings, formatHints, path);
                                 break;
                             default:
                                 AppendLine(builder, indent, name is null ? FormatScalar(element, truncateLongStrings) : $"{name}: {FormatScalar(element, truncateLongStrings)}");
                                 break;
                         }
                     }

                     private static void AppendFormattedObject(
                         StringBuilder builder,
                         string? name,
                         JsonElement element,
                         int indent,
                         bool truncateLongStrings,
                         IReadOnlyDictionary<string, CliFormatHint>? formatHints,
                         string? path)
                     {
                         if (name is not null)
                         {
                             AppendLine(builder, indent, $"{name}:");
                             indent += 2;
                         }

                         var properties = element.EnumerateObject()
                             .OrderByDescending(property => HasFormatHint(CombinePath(path, property.Name), CliFormatHint.Key, formatHints))
                             .ThenBy(property => property.Name, StringComparer.OrdinalIgnoreCase)
                             .ToArray();
                         foreach (var property in properties)
                         {
                             AppendFormattedValue(
                                 builder,
                                 property.Name,
                                 property.Value,
                                 indent,
                                 truncateLongStrings,
                                 formatHints,
                                 CombinePath(path, property.Name));
                         }
                     }

                     private static void AppendFormattedArray(
                         StringBuilder builder,
                         string? name,
                         JsonElement element,
                         int indent,
                         bool truncateLongStrings,
                         IReadOnlyDictionary<string, CliFormatHint>? formatHints,
                         string? path)
                     {
                         var items = element.EnumerateArray().ToArray();
                         if (name is not null)
                         {
                             AppendLine(builder, indent, $"{name}:");
                             indent += 2;
                         }

                         if (items.Length == 0)
                         {
                             AppendLine(builder, indent, "[]");
                             return;
                         }

                         if (items.All(static item => item.ValueKind is not JsonValueKind.Object and not JsonValueKind.Array))
                         {
                             foreach (var item in items)
                             {
                                 AppendLine(builder, indent, $"- {FormatScalar(item, truncateLongStrings)}");
                             }

                             return;
                         }

                         for (var index = 0; index < items.Length; index++)
                         {
                             AppendLine(builder, indent, $"{index + 1}.");
                             AppendFormattedValue(builder, null, items[index], indent + 2, truncateLongStrings, formatHints, path);
                         }
                     }

                     private static string FormatScalar(JsonElement element, bool truncateLongStrings)
                     {
                         return element.ValueKind switch
                         {
                             JsonValueKind.String => FormatStringScalar(element.GetString() ?? string.Empty, truncateLongStrings),
                             JsonValueKind.True => "true",
                             JsonValueKind.False => "false",
                             JsonValueKind.Number => element.GetRawText(),
                             JsonValueKind.Null => "null",
                             _ => element.GetRawText(),
                         };
                     }

                     private static string FormatStringScalar(string value, bool truncateLongStrings)
                     {
                         if (DateTimeOffset.TryParse(
                                 value,
                                 CultureInfo.InvariantCulture,
                                 DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal,
                                 out var dateTimeOffset))
                         {
                             return dateTimeOffset.UtcDateTime.ToString("yyyy-MM-dd HH:mm:ss 'UTC'", CultureInfo.InvariantCulture);
                         }

                         if (truncateLongStrings && value.Length > 80)
                         {
                             return value[..77] + "...";
                         }

                         return value;
                     }

                     private static bool ShouldHide(string? path, IReadOnlyDictionary<string, CliFormatHint>? formatHints)
                     {
                         return HasFormatHint(path, CliFormatHint.Hidden, formatHints);
                     }

                     private static bool HasFormatHint(string? path, CliFormatHint expected, IReadOnlyDictionary<string, CliFormatHint>? formatHints)
                     {
                         return !string.IsNullOrWhiteSpace(path) &&
                                formatHints is not null &&
                                formatHints.TryGetValue(path, out var hint) &&
                                hint == expected;
                     }

                     private static string CombinePath(string? prefix, string segment)
                     {
                         return string.IsNullOrWhiteSpace(prefix)
                             ? segment
                             : $"{prefix}.{segment}";
                     }

                     private static void AppendCodeBlock(StringBuilder builder, string? name, string value, int indent)
                     {
                         if (name is not null)
                         {
                             AppendLine(builder, indent, $"{name}:");
                             indent += 2;
                         }

                         foreach (var line in value.Replace("\r\n", "\n", StringComparison.Ordinal).Split('\n'))
                         {
                             AppendLine(builder, indent, line);
                         }
                     }

                     private static void AppendLine(StringBuilder builder, int indent, string value)
                     {
                         builder.Append(' ', indent);
                         builder.AppendLine(value);
                     }

                     private static async Task WriteItemFilesAsync(string outputDirectory, JsonArray items, CancellationToken cancellationToken = default)
                     {
                         Directory.CreateDirectory(outputDirectory);

                         for (var index = 0; index < items.Count; index++)
                         {
                             if (items[index] is not JsonNode itemNode)
                             {
                                 continue;
                             }

                             var itemObject = itemNode as JsonObject;
                             var baseName = itemObject is null
                                 ? $"{index + 1:000}"
                                 : SanitizeFileName(GetOutputItemName(itemObject) ?? $"{index + 1:000}");

                             var wroteStructuredFile = false;
                             if (itemObject is not null)
                             {
                                 wroteStructuredFile |= await TryWriteTextPropertyAsync(itemObject, outputDirectory, baseName, "markdown", ".md", cancellationToken).ConfigureAwait(false);
                                 wroteStructuredFile |= await TryWriteTextPropertyAsync(itemObject, outputDirectory, baseName, "html", ".html", cancellationToken).ConfigureAwait(false);
                                 wroteStructuredFile |= await TryWriteTextPropertyAsync(itemObject, outputDirectory, baseName, "rawHtml", ".raw.html", cancellationToken).ConfigureAwait(false);
                                 wroteStructuredFile |= await TryWriteTextPropertyAsync(itemObject, outputDirectory, baseName, "raw_html", ".raw.html", cancellationToken).ConfigureAwait(false);
                                 wroteStructuredFile |= await TryWriteTextPropertyAsync(itemObject, outputDirectory, baseName, "text", ".txt", cancellationToken).ConfigureAwait(false);

                                 if (TryGetNamedNode(itemObject, out var linksNode, "links") && linksNode is JsonArray links)
                                 {
                                     var linkLines = links
                                         .Select(static node => node?.GetValue<string>())
                                         .Where(static value => !string.IsNullOrWhiteSpace(value))
                                         .ToArray();
                                     if (linkLines.Length > 0)
                                     {
                                         await File.WriteAllTextAsync(
                                             Path.Combine(outputDirectory, $"{baseName}.links.txt"),
                                             string.Join(Environment.NewLine, linkLines),
                                             cancellationToken).ConfigureAwait(false);
                                         wroteStructuredFile = true;
                                     }
                                 }
                             }

                             var json = itemNode.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
                             var fileName = wroteStructuredFile
                                 ? $"{baseName}.metadata.json"
                                 : $"{baseName}.json";
                             await File.WriteAllTextAsync(Path.Combine(outputDirectory, fileName), json, cancellationToken).ConfigureAwait(false);
                         }
                     }

                     private static async Task<bool> TryWriteTextPropertyAsync(
                         JsonObject item,
                         string outputDirectory,
                         string baseName,
                         string propertyName,
                         string extension,
                         CancellationToken cancellationToken)
                     {
                         if (!TryGetNamedNode(item, out var node, propertyName))
                         {
                             return false;
                         }

                         var value = node?.GetValue<string>();
                         if (string.IsNullOrWhiteSpace(value))
                         {
                             return false;
                         }

                         await File.WriteAllTextAsync(
                             Path.Combine(outputDirectory, $"{baseName}{extension}"),
                             value,
                             cancellationToken).ConfigureAwait(false);
                         return true;
                     }

                     private static string? GetOutputItemName(JsonObject item)
                     {
                         if (TryGetNamedNode(item, out var node, "url", "sourceUrl", "source_url", "id"))
                         {
                             return node?.GetValue<string>();
                         }

                         return null;
                     }

                     private static bool TryGetNamedNode(JsonObject item, out JsonNode? node, params string[] names)
                     {
                         foreach (var property in item)
                         {
                             if (names.Any(name => string.Equals(property.Key, name, StringComparison.OrdinalIgnoreCase)))
                             {
                                 node = property.Value;
                                 return true;
                             }
                         }

                         node = null;
                         return false;
                     }

                     private static string SanitizeFileName(string value)
                     {
                         var normalized = value
                             .Replace("https://", string.Empty, StringComparison.OrdinalIgnoreCase)
                             .Replace("http://", string.Empty, StringComparison.OrdinalIgnoreCase)
                             .Replace("www.", string.Empty, StringComparison.OrdinalIgnoreCase);

                         foreach (var invalid in Path.GetInvalidFileNameChars())
                         {
                             normalized = normalized.Replace(invalid, '_');
                         }

                         return normalized;
                     }

                     private static async Task WriteApiExceptionAsync(global::{{model.SdkNamespace}}.ApiException exception)
                     {
                         var builder = new StringBuilder();
                         builder.Append("API error ");
                         builder.Append((int)exception.StatusCode);
                         builder.Append(": ");
                         builder.Append(exception.Message);
                         if (!string.IsNullOrWhiteSpace(exception.ResponseBody))
                         {
                             builder.AppendLine();
                             builder.Append(exception.ResponseBody);
                         }

                         await Console.Error.WriteLineAsync(builder.ToString()).ConfigureAwait(false);
                     }

                     private static string PrettyJson(string json)
                     {
                         using var document = JsonDocument.Parse(json);
                         using var stream = new MemoryStream();
                         using (var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true }))
                         {
                             document.WriteTo(writer);
                         }

                         return Encoding.UTF8.GetString(stream.ToArray());
                     }

                     private static async Task<AuthProbeResult> ProbeAuthAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
                     {
                         var optionSource = new AuthSourceProbe(
                             Source: "option",
                             DisplayName: "flag (--api-key)",
                             RawValue: parseResult.GetValue(CliOptions.ApiKey),
                             Path: null);
                         var sources = new List<AuthSourceProbe>();
                         sources.Add(optionSource);
                         AuthSourceProbe? active = optionSource.Present ? optionSource : null;

                         foreach (var environmentVariable in ApiKeyEnvironmentVariables)
                         {
                             var environmentSource = new AuthSourceProbe(
                                 Source: $"environment:{environmentVariable}",
                                 DisplayName: $"env var {environmentVariable}",
                                 RawValue: Environment.GetEnvironmentVariable(environmentVariable),
                                 Path: null);
                             sources.Add(environmentSource);
                             if (active is null && environmentSource.Present)
                             {
                                 active = environmentSource;
                             }
                         }

                         var userSecretsSource = new AuthSourceProbe(
                             Source: "user-secrets",
                             DisplayName: "user-secrets",
                             RawValue: await ReadUserSecretAsync(UserSecretApiKeyName, cancellationToken).ConfigureAwait(false),
                             Path: GetUserSecretsPath());
                         sources.Add(userSecretsSource);
                         if (active is null && userSecretsSource.Present)
                         {
                             active = userSecretsSource;
                         }

                         if (GetCredentialFilePath() is { Length: > 0 } credentialFilePath)
                         {
                             var credentialFileSource = new AuthSourceProbe(
                                 Source: "credential-file",
                                 DisplayName: "credential file",
                                 RawValue: await ReadCredentialFileAsync(cancellationToken).ConfigureAwait(false),
                                 Path: credentialFilePath);
                             sources.Add(credentialFileSource);
                             if (active is null && credentialFileSource.Present)
                             {
                                 active = credentialFileSource;
                             }
                         }

                         return new AuthProbeResult(active, [.. sources]);
                     }
                 }

                 internal enum CliFormatHint
                 {
                     Key,
                     Hidden,
                     Code,
                 }

                 internal sealed record AuthStatusInfo(bool Authenticated, string Source, string? ApiKeyHint, string? Path, AuthSourceStatus[] Sources);
                 internal sealed record AuthSourceStatus(string DisplayName, bool Present, string? ApiKeyHint, string? Path);
                 internal sealed record AuthProbeResult(AuthSourceProbe? Active, AuthSourceProbe[] Sources);
                 internal sealed record AuthSourceProbe(string Source, string DisplayName, string? RawValue, string? Path)
                 {
                     public bool Present => !string.IsNullOrWhiteSpace(RawValue);
                 }

                 [JsonSerializable(typeof(AuthStatusInfo))]
                 [JsonSerializable(typeof(Dictionary<string, string>))]
                 internal sealed partial class UserSecretsJsonContext : JsonSerializerContext;
                 """;
    }

    private static string GenerateAuthCommand(CliProjectModel model)
    {
        return $$"""
                 #nullable enable

                 using System.CommandLine;
                 using System.Text.Json.Serialization;

                 namespace {{model.RootNamespace}}.Commands;

                 internal static class AuthCommand
                 {
                     public static Command Create()
                     {
                         var command = new Command("auth", "Inspect and manage API credentials used by the generated CLI.");
                         command.Subcommands.Add(CreateSetCommand());
                         command.Subcommands.Add(CreateStatusCommand());
                         command.Subcommands.Add(CreateClearCommand());
                         return command;
                     }

                     private static Command CreateSetCommand()
                     {
                         var apiKeyArgument = new Argument<string>("api-key") { Description = "API key to store." };
                         var command = new Command("set", "Store an API key in dotnet user-secrets.");
                         command.Arguments.Add(apiKeyArgument);
                         command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
                             await CliRuntime.RunAsync(async () =>
                             {
                                 var apiKey = parseResult.GetValue(apiKeyArgument) ?? throw new CliException("API key is required.");
                                 await CliRuntime.WriteUserSecretAsync(CliRuntime.GetUserSecretApiKeyName(), apiKey, cancellationToken).ConfigureAwait(false);
                                 await Console.Out.WriteLineAsync($"Stored API key ({CliRuntime.MaskSecret(apiKey)}) at {CliRuntime.GetUserSecretsPath()}.").ConfigureAwait(false);
                             }, cancellationToken).ConfigureAwait(false));
                         return command;
                     }

                     private static Command CreateStatusCommand()
                     {
                         var command = new Command("status", "Show the authentication source order the CLI will use.");
                         command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
                             await CliRuntime.RunAsync(async () =>
                             {
                                 var status = await CliRuntime.GetAuthStatusAsync(parseResult, cancellationToken).ConfigureAwait(false);
                                 if (parseResult.GetValue(CliOptions.Json))
                                 {
                                     await CliRuntime.WriteJsonAsync(
                                         parseResult,
                                         status,
                                         UserSecretsJsonContext.Default,
                                         cancellationToken).ConfigureAwait(false);
                                     return;
                                 }

                                 await Console.Out.WriteLineAsync($"authenticated: {(status.Authenticated ? "true" : "false")}").ConfigureAwait(false);
                                 await Console.Out.WriteLineAsync($"source: {status.Source}").ConfigureAwait(false);
                                 if (!string.IsNullOrWhiteSpace(status.ApiKeyHint))
                                 {
                                     await Console.Out.WriteLineAsync($"api-key: {status.ApiKeyHint}").ConfigureAwait(false);
                                 }
                                 if (!string.IsNullOrWhiteSpace(status.Path))
                                 {
                                     await Console.Out.WriteLineAsync($"path: {status.Path}").ConfigureAwait(false);
                                 }
                                 await Console.Out.WriteLineAsync("sources:").ConfigureAwait(false);
                                 foreach (var source in status.Sources)
                                 {
                                     var line = $"  - {source.DisplayName}: {(source.Present ? "set" : "not present")}";
                                     if (!string.IsNullOrWhiteSpace(source.ApiKeyHint))
                                     {
                                         line += $" ({source.ApiKeyHint})";
                                     }
                                     if (!string.IsNullOrWhiteSpace(source.Path))
                                     {
                                         line += $" [{source.Path}]";
                                     }

                                     await Console.Out.WriteLineAsync(line).ConfigureAwait(false);
                                 }
                             }, cancellationToken).ConfigureAwait(false));
                         return command;
                     }

                     private static Command CreateClearCommand()
                     {
                         var command = new Command("clear", "Clear the API key stored in dotnet user-secrets.");
                         command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
                             await CliRuntime.RunAsync(async () =>
                             {
                                 await CliRuntime.ClearUserSecretAsync(CliRuntime.GetUserSecretApiKeyName(), cancellationToken).ConfigureAwait(false);
                                 await Console.Out.WriteLineAsync($"Cleared API key at {CliRuntime.GetUserSecretsPath()}.").ConfigureAwait(false);
                             }, cancellationToken).ConfigureAwait(false));
                         return command;
                     }
                 }
                 """;
    }

    private static string GenerateApiCommand(CliProjectModel model)
    {
        var addApiOnlyOptions = model.ApiOnly
            ? """
                        command.Options.Add(CliOptions.ApiKey);
                        command.Options.Add(CliOptions.BaseUrl);
                        command.Options.Add(CliOptions.Json);
                        command.Options.Add(CliOptions.Output);
                        command.Options.Add(CliOptions.OutputDirectory);
              """
            : string.Empty;

        return $$"""
                 #nullable enable

                 using System.CommandLine;

                 namespace {{model.RootNamespace}}.Commands;

                 internal static class ApiCommand
                 {
                     public static Command Create()
                     {
                         var command = new Command("api", "Generated endpoint commands.");
                 {{addApiOnlyOptions}}
                 {{model.Tags.Select(tag => $@"
                         command.Subcommands.Add({tag.ClassName}.Create());").Inject()}}
                         return command;
                     }
                 }
                 """;
    }

    private static string GenerateTagCommand(CliProjectModel model, CliProjectTag tag)
    {
        return $$"""
                 #nullable enable

                 using System.CommandLine;

                 namespace {{model.RootNamespace}}.Commands;

                 internal static class {{tag.ClassName}}
                 {
                     public static Command Create()
                     {
                         var command = new Command({{Literal(tag.CommandName)}}, {{Literal($"{tag.Name} endpoint commands.")}});
                 {{tag.Operations.Select(operation => $@"
                         command.Subcommands.Add({operation.ClassName}.Create());").Inject()}}
                         return command;
                     }
                 }
                 """;
    }

    private static string GenerateOptionSet(CliProjectModel model, CliProjectOptionSet optionSet)
    {
        var constructorParameters = string.Join(
            ",\n                     ",
            optionSet.Parameters.Select(parameter => $"Option<{parameter.Type.CSharpType}> {ParameterSymbolName(parameter)}"));
        var constructorArguments = string.Join(
            ",\n",
            optionSet.Parameters.Select(parameter =>
                $"                {ParameterSymbolName(parameter)}: {GenerateOptionFactoryExpression(parameter, "normalizedPrefix")}"));

        return $$"""
                 #nullable enable

                 using System.CommandLine;

                 namespace {{model.RootNamespace}}.Commands;

                 internal sealed record {{optionSet.ClassName}}(
                     {{constructorParameters}})
                 {
                     public static {{optionSet.ClassName}} Create(string? prefix = null)
                     {
                         var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
                             ? string.Empty
                             : prefix.Trim().Trim('-') + "-";
                         return new {{optionSet.ClassName}}(
                         {{constructorArguments}}
                         );
                     }
                 }
                 """;
    }

    private static string GenerateOptionFactoryExpression(MethodParameter parameter, string prefixVariableName)
    {
        var nameExpression = $"$\"--{{{prefixVariableName}}}{ToKebabCase(parameter.Id)}\"";
        var isNullableBoolOption =
            !parameter.IsRequired &&
            !parameter.HasSchemaDefault &&
            parameter.Type.CSharpTypeWithoutNullability == "bool" &&
            parameter.Type.CSharpType.Contains('?', StringComparison.Ordinal);
        if (isNullableBoolOption)
        {
            return $"CliRuntime.CreateNullableBoolOption(name: {nameExpression}, description: {Literal(parameter.Description)})";
        }

        var requiredProperty = parameter.IsRequired && !parameter.HasSchemaDefault
            ? "\n                    Required = true,"
            : string.Empty;
        var defaultProperty = parameter.HasSchemaDefault
            ? $"\n                    DefaultValueFactory = _ => {parameter.ParameterDefaultValue},"
            : string.Empty;
        return $@"new Option<{parameter.Type.CSharpType}>({nameExpression})
                {{
                    Description = {Literal(parameter.Description)},{requiredProperty}{defaultProperty}
                }}";
    }

    private sealed record CliProjectRequestSourceOptions(
        string InputSymbol,
        string InputOptionName,
        string RequestJsonSymbol,
        string RequestJsonOptionName,
        string RequestFileSymbol,
        string RequestFileOptionName)
    {
        public static CliProjectRequestSourceOptions Create(CliProjectOperation operation)
        {
            var optionNames = GetGeneratedOptionNames(operation);
            var input = ChooseRequestSourceOption(
                defaultSymbol: "Input",
                defaultOptionName: "--input",
                alternatives:
                [
                    ("RequestInput", "--request-input"),
                    ("BodyInput", "--body-input"),
                ],
                optionNames);
            var requestJson = ChooseRequestSourceOption(
                defaultSymbol: "RequestJson",
                defaultOptionName: "--request-json",
                alternatives:
                [
                    ("RequestBodyJson", "--request-body-json"),
                    ("BodyJson", "--body-json"),
                ],
                optionNames);
            var requestFile = ChooseRequestSourceOption(
                defaultSymbol: "RequestFile",
                defaultOptionName: "--request-file",
                alternatives:
                [
                    ("RequestBodyFile", "--request-body-file"),
                    ("BodyFile", "--body-file"),
                ],
                optionNames);

            return new CliProjectRequestSourceOptions(
                input.Symbol,
                input.OptionName,
                requestJson.Symbol,
                requestJson.OptionName,
                requestFile.Symbol,
                requestFile.OptionName);
        }

        private static HashSet<string> GetGeneratedOptionNames(CliProjectOperation operation)
        {
            var optionNames = new HashSet<string>(StringComparer.Ordinal);
            foreach (var parameter in operation.OptionParameters)
            {
                optionNames.Add($"--{ToKebabCase(parameter.Id)}");
            }

            foreach (var parameter in operation.DirectOptionSets.SelectMany(static usage => usage.Parameters))
            {
                optionNames.Add($"--{ToKebabCase(parameter.Id)}");
            }

            foreach (var usage in operation.NestedOptionSets)
            {
                foreach (var parameter in usage.Parameters)
                {
                    optionNames.Add($"--{usage.Prefix}-{ToKebabCase(parameter.Id)}");
                }
            }

            foreach (var usage in operation.WebhookUsages)
            {
                optionNames.Add($"--{usage.Prefix}-url");
                if (!string.IsNullOrWhiteSpace(usage.HeadersPropertyName))
                {
                    optionNames.Add($"--{usage.Prefix}-header");
                }

                if (!string.IsNullOrWhiteSpace(usage.MetadataPropertyName))
                {
                    optionNames.Add($"--{usage.Prefix}-metadata");
                }

                if (!string.IsNullOrWhiteSpace(usage.EventsPropertyName))
                {
                    optionNames.Add($"--{usage.Prefix}-event");
                }
            }

            return optionNames;
        }

        private static (string Symbol, string OptionName) ChooseRequestSourceOption(
            string defaultSymbol,
            string defaultOptionName,
            IReadOnlyList<(string Symbol, string OptionName)> alternatives,
            HashSet<string> usedOptionNames)
        {
            if (!usedOptionNames.Contains(defaultOptionName))
            {
                return (defaultSymbol, defaultOptionName);
            }

            foreach (var alternative in alternatives)
            {
                if (!usedOptionNames.Contains(alternative.OptionName))
                {
                    return alternative;
                }
            }

            var suffix = 2;
            while (true)
            {
                var optionName = $"{defaultOptionName}-{suffix}";
                if (!usedOptionNames.Contains(optionName))
                {
                    return ($"{defaultSymbol}{suffix}", optionName);
                }

                suffix++;
            }
        }
    }

    private static string GenerateOperationCommand(CliProjectModel model, CliProjectOperation operation)
    {
        var endPoint = operation.EndPoint;
        var description = string.IsNullOrWhiteSpace(endPoint.Summary) ? endPoint.Description : endPoint.Summary;
        var requestSourceOptions = CliProjectRequestSourceOptions.Create(operation);
        var reusableFields = operation.DirectOptionSets
            .Select(GenerateDirectOptionSetFieldDeclaration)
            .Concat(operation.NestedOptionSets.Select(GenerateNestedOptionSetFieldDeclaration))
            .Concat(operation.WebhookUsages.Select(GenerateWebhookFieldDeclaration))
            .Inject();
        var responseFormatterMembers = GenerateResponseFormatterMembers(operation);
        // Emit all field declarations through a single Inject() so they're separated by a blank
        // line. Injecting required and optional fields separately concatenated the two blocks with
        // no newline (`};    private static ...`).
        var fields = operation.PositionalParameters
            .Select(parameter => GenerateParameterField(parameter, required: true))
            .Concat(operation.OptionParameters.Select(parameter => GenerateParameterField(parameter, required: false)))
            .Concat(string.IsNullOrWhiteSpace(reusableFields) ? [] : [reusableFields])
            .Inject();
        var addSymbols = operation.PositionalParameters
            .Select(parameter => $@"
                        command.Arguments.Add({ParameterSymbolName(parameter)});")
            .Concat(operation.OptionParameters.Select(parameter => $@"
                        command.Options.Add({ParameterSymbolName(parameter)});"))
            .Concat(operation.DirectOptionSets.Select(GenerateDirectOptionSetAddSymbols))
            .Concat(operation.NestedOptionSets.Select(GenerateNestedOptionSetAddSymbols))
            .Concat(operation.WebhookUsages.Select(GenerateWebhookAddSymbols))
            .Inject();
        var requestFields = operation.HasDirectRequestBody || operation.SupportsBaseBody
            ? $$"""

                    private static Option<string?> {{requestSourceOptions.InputSymbol}} { get; } = new({{Literal(requestSourceOptions.InputOptionName)}})
                    {
                        Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
                    };

                    private static Option<string?> {{requestSourceOptions.RequestJsonSymbol}} { get; } = new({{Literal(requestSourceOptions.RequestJsonOptionName)}})
                    {
                        Description = "Request body as JSON.",
                        Hidden = true,
                    };

                    private static Option<string?> {{requestSourceOptions.RequestFileSymbol}} { get; } = new({{Literal(requestSourceOptions.RequestFileOptionName)}})
                    {
                        Description = "Path to a JSON request file, or '-' for stdin.",
                        Hidden = true,
                    };
              """
            : string.Empty;
        var waitFields = operation.SupportsWait
            ? """

                    private static Option<bool> Wait { get; } = new("--wait")
                    {
                        Description = "Poll the generated wait helper until the resource reaches a terminal state.",
                    };

                    private static Option<string> PollInterval { get; } = new("--poll-interval")
                    {
                        Description = "Polling interval, for example 250ms, 2s, 30m, or 01:00:00.",
                        DefaultValueFactory = _ => "2s",
                    };

                    private static Option<string> WaitTimeout { get; } = new("--wait-timeout")
                    {
                        Description = "Maximum time to wait before timing out, for example 30m or 00:30:00.",
                        DefaultValueFactory = _ => "30m",
                    };
              """
            : string.Empty;
        var addRequestOptions = operation.HasDirectRequestBody
            ? $$"""
                        command.Options.Add({{requestSourceOptions.InputSymbol}});
                        command.Options.Add({{requestSourceOptions.RequestJsonSymbol}});
                        command.Options.Add({{requestSourceOptions.RequestFileSymbol}});
                        command.Validators.Add(result =>
                        {
                            var hasInput = result.GetResult({{requestSourceOptions.InputSymbol}}) is not null;
                            var hasRequestJson = result.GetResult({{requestSourceOptions.RequestJsonSymbol}}) is not null;
                            var hasRequestFile = result.GetResult({{requestSourceOptions.RequestFileSymbol}}) is not null;
                            var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
                            if (specifiedCount != 1)
                            {
                                result.AddError({{Literal($"Specify exactly one of {requestSourceOptions.InputOptionName}, {requestSourceOptions.RequestJsonOptionName}, or {requestSourceOptions.RequestFileOptionName}.")}});
                            }
                        });
              """
            : operation.SupportsBaseBody
                ? $$"""
                            command.Options.Add({{requestSourceOptions.InputSymbol}});
                            command.Options.Add({{requestSourceOptions.RequestJsonSymbol}});
                            command.Options.Add({{requestSourceOptions.RequestFileSymbol}});
                            command.Validators.Add(result =>
                            {
                                var hasInput = result.GetResult({{requestSourceOptions.InputSymbol}}) is not null;
                                var hasRequestJson = result.GetResult({{requestSourceOptions.RequestJsonSymbol}}) is not null;
                                var hasRequestFile = result.GetResult({{requestSourceOptions.RequestFileSymbol}}) is not null;
                                var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
                                if (specifiedCount > 1)
                                {
                                    result.AddError({{Literal($"Specify at most one of {requestSourceOptions.InputOptionName}, {requestSourceOptions.RequestJsonOptionName}, or {requestSourceOptions.RequestFileOptionName}.")}});
                                }
                            });
                  """
                : string.Empty;
        var addWaitOptions = operation.SupportsWait
            ? """
                        command.Options.Add(Wait);
                        command.Options.Add(PollInterval);
                        command.Options.Add(WaitTimeout);
              """
            : string.Empty;
        // The optional base body must be read before the per-field parse lines that merge into it,
        // so it's emitted as the first parse statement (AutoSDK #343).
        var baseBodyRead = operation.SupportsBaseBody
            ? new[]
            {
                $@"
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<{endPoint.RequestType.CSharpTypeWithoutNullability}>(
                            parseResult,
                            {requestSourceOptions.InputSymbol},
                            {requestSourceOptions.RequestJsonSymbol},
                            {requestSourceOptions.RequestFileSymbol},
                            global::{model.JsonSerializerContextFullName}.Default,
                            cancellationToken).ConfigureAwait(false);",
            }
            : Array.Empty<string>();
        var parseParameters = baseBodyRead
            .Concat(operation.PositionalParameters
                .Select(parameter => $@"
                        var {parameter.ParameterName} = parseResult.GetRequiredValue({ParameterSymbolName(parameter)});"))
            .Concat(operation.OptionParameters.Select(parameter =>
                operation.SupportsBaseBody && CliProjectOperation.IsMergeableBaseBodyField(parameter)
                    ? $@"
                        var {parameter.ParameterName} = {GenerateBaseBodyMergeExpression(ParameterSymbolName(parameter), "__requestBase", CliProjectOperation.BaseBodyPropertyName(parameter))};"
                    : $@"
                        var {parameter.ParameterName} = parseResult.{((parameter.IsRequired || parameter.HasSchemaDefault) ? "GetRequiredValue" : "GetValue")}({ParameterSymbolName(parameter)});"))
            .Concat(operation.DirectOptionSets.Select(usage => GenerateDirectOptionSetParseLines(operation, usage)))
            .Concat(operation.NestedOptionSets.Select(usage => GenerateNestedOptionSetParseLines(operation, usage)))
            .Concat(operation.WebhookUsages.Select(usage => GenerateWebhookParseLines(model, operation, usage)))
            .Inject();
        var requestRead = operation.HasDirectRequestBody
            ? $@"
                        var request = await CliRuntime.ReadRequestAsync<{endPoint.RequestType.CSharpTypeWithoutNullability}>(
                            parseResult,
                            {requestSourceOptions.InputSymbol},
                            {requestSourceOptions.RequestJsonSymbol},
                            {requestSourceOptions.RequestFileSymbol},
                            global::{model.JsonSerializerContextFullName}.Default,
                            cancellationToken).ConfigureAwait(false);"
            : string.Empty;
        var waitReads = operation.SupportsWait
            ? """
                        var wait = parseResult.GetValue(Wait);
                        var pollInterval = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(PollInterval), PollInterval.Name) : default;
                        var waitTimeout = wait ? CliRuntime.ParseDuration(parseResult.GetRequiredValue(WaitTimeout), WaitTimeout.Name) : default;
              """
            : string.Empty;
        var waitInvocation = GenerateWaitInvocationAndWrite(model, operation);
        var invocation = GenerateInvocation(operation);
        var responseWrite = GenerateResponseWrite(model, operation);

        return $$"""
                 #nullable enable
                 #pragma warning disable CS0618

                 using System.CommandLine;

                 namespace {{model.RootNamespace}}.Commands;

                 internal static partial class {{operation.ClassName}}
                 {
                 {{fields}}{{requestFields}}{{waitFields}}{{responseFormatterMembers}}

                     public static Command Create()
                     {
                         var command = new Command({{Literal(operation.CommandName)}}, {{Literal(description)}});
                 {{addSymbols}}
                 {{addRequestOptions}}
                 {{addWaitOptions}}
                         command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
                             await CliRuntime.RunAsync(async () =>
                             {
                 {{parseParameters}}{{requestRead}}{{waitReads}}
                                 using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);
                 {{waitInvocation}}
                 {{invocation}}
                 {{responseWrite}}
                             }, cancellationToken).ConfigureAwait(false));
                         return command;
                     }
                 }
                 """;
    }

    private static string GenerateParameterField(MethodParameter parameter, bool required)
    {
        var isNullableBoolOption =
            !required &&
            !parameter.IsRequired &&
            !parameter.HasSchemaDefault &&
            parameter.Type.CSharpTypeWithoutNullability == "bool" &&
            parameter.Type.CSharpType.Contains('?', StringComparison.Ordinal);
        if (isNullableBoolOption)
        {
            return $@"
    private static Option<bool?> {ParameterSymbolName(parameter)} {{ get; }} = CliRuntime.CreateNullableBoolOption(
        name: {Literal($"--{ToKebabCase(parameter.Id)}")},
        description: {Literal(parameter.Description)});
";
        }

        var symbolType = required ? "Argument" : "Option";
        var nameExpression = required ? Literal(ToKebabCase(parameter.Id)) : Literal($"--{ToKebabCase(parameter.Id)}");
        var requiredProperty = !required && parameter.IsRequired && !parameter.HasSchemaDefault
            ? "\n        Required = true,"
            : string.Empty;
        var defaultProperty = !required && parameter.HasSchemaDefault
            ? $"\n        DefaultValueFactory = _ => {parameter.ParameterDefaultValue},"
            : string.Empty;

        return $@"
    private static {symbolType}<{parameter.Type.CSharpType}> {ParameterSymbolName(parameter)} {{ get; }} = new(
        name: {nameExpression})
    {{
        Description = {Literal(parameter.Description)},{requiredProperty}{defaultProperty}
    }};
";
    }

    private static string GenerateDirectOptionSetFieldDeclaration(CliProjectDirectOptionSetUsage usage)
    {
        return $@"
    private static readonly {usage.ClassName} {usage.InstanceName} = {usage.ClassName}.Create();
";
    }

    private static string GenerateNestedOptionSetFieldDeclaration(CliProjectNestedOptionSetUsage usage)
    {
        return $@"
    private static readonly {usage.ClassName} {usage.InstanceName} = {usage.ClassName}.Create({Literal(usage.Prefix)});
";
    }

    private static string GenerateDirectOptionSetAddSymbols(CliProjectDirectOptionSetUsage usage)
    {
        return usage.Parameters
            .Select(parameter => $@"
                        command.Options.Add({usage.InstanceName}.{ParameterSymbolName(parameter)});")
            .Inject();
    }

    private static string GenerateNestedOptionSetAddSymbols(CliProjectNestedOptionSetUsage usage)
    {
        return usage.Parameters
            .Select(parameter => $@"
                        command.Options.Add({usage.InstanceName}.{ParameterSymbolName(parameter)});")
            .Inject();
    }

    private static string GenerateWebhookFieldDeclaration(CliProjectWebhookUsage usage)
    {
        var declarations = new List<string>
        {
            $@"
    private static Option<string?> {WebhookUrlSymbolName(usage)} {{ get; }} = new(
        name: {Literal($"--{usage.Prefix}-url")})
    {{
        Description = ""Webhook target URL."",
    }};
"
        };

        if (!string.IsNullOrWhiteSpace(usage.HeadersPropertyName))
        {
            declarations.Add($@"
    private static Option<string[]> {WebhookHeadersSymbolName(usage)} {{ get; }} = new(
        name: {Literal($"--{usage.Prefix}-header")})
    {{
        Description = ""Repeatable KEY=VALUE header to send with the webhook request."",
        AllowMultipleArgumentsPerToken = true,
    }};
");
        }

        if (!string.IsNullOrWhiteSpace(usage.MetadataPropertyName))
        {
            declarations.Add($@"
    private static Option<string[]> {WebhookMetadataSymbolName(usage)} {{ get; }} = new(
        name: {Literal($"--{usage.Prefix}-metadata")})
    {{
        Description = ""Repeatable KEY=VALUE metadata entry attached to the webhook."",
        AllowMultipleArgumentsPerToken = true,
    }};
");
        }

        if (!string.IsNullOrWhiteSpace(usage.EventsPropertyName))
        {
            var description = usage.EventValues.Length > 0
                ? $"Repeatable event name. Allowed values: {string.Join(", ", usage.EventValues)}."
                : "Repeatable event name.";
            declarations.Add($@"
    private static Option<string[]> {WebhookEventsSymbolName(usage)} {{ get; }} = new(
        name: {Literal($"--{usage.Prefix}-event")})
    {{
        Description = {Literal(description)},
        AllowMultipleArgumentsPerToken = true,
    }};
");
        }

        return string.Concat(declarations);
    }

    private static string GenerateWebhookAddSymbols(CliProjectWebhookUsage usage)
    {
        var lines = new List<string>
        {
            $@"
                        command.Options.Add({WebhookUrlSymbolName(usage)});"
        };
        if (!string.IsNullOrWhiteSpace(usage.HeadersPropertyName))
        {
            lines.Add($@"
                        command.Options.Add({WebhookHeadersSymbolName(usage)});");
        }

        if (!string.IsNullOrWhiteSpace(usage.MetadataPropertyName))
        {
            lines.Add($@"
                        command.Options.Add({WebhookMetadataSymbolName(usage)});");
        }

        if (!string.IsNullOrWhiteSpace(usage.EventsPropertyName))
        {
            lines.Add($@"
                        command.Options.Add({WebhookEventsSymbolName(usage)});");
        }

        return string.Concat(lines);
    }

    private static string GenerateDirectOptionSetParseLines(CliProjectOperation operation, CliProjectDirectOptionSetUsage usage)
    {
        return usage.Parameters
            .Select(parameter =>
                operation.SupportsBaseBody && CliProjectOperation.IsMergeableBaseBodyField(parameter)
                    ? $@"
                        var {parameter.ParameterName} = {GenerateBaseBodyMergeExpression($"{usage.InstanceName}.{ParameterSymbolName(parameter)}", "__requestBase", CliProjectOperation.BaseBodyPropertyName(parameter))};"
                    : $@"
                        var {parameter.ParameterName} = parseResult.{((parameter.IsRequired || parameter.HasSchemaDefault) ? "GetRequiredValue" : "GetValue")}({usage.InstanceName}.{ParameterSymbolName(parameter)});")
            .Inject();
    }

    private static string GenerateBaseBodyMergeExpression(
        string optionExpression,
        string baseObjectExpression,
        string basePropertyName)
    {
        return $"CliRuntime.WasSpecified(parseResult, {optionExpression}) ? parseResult.GetValue({optionExpression}) : {baseObjectExpression} is not null ? {baseObjectExpression}.{basePropertyName} : default";
    }

    private static string GenerateNestedOptionSetParseLines(CliProjectOperation operation, CliProjectNestedOptionSetUsage usage)
    {
        var baseAccessor = operation.SupportsBaseBody
            ? $"__{usage.ParameterName}Base"
            : "null";
        var baseAccessorDeclaration = operation.SupportsBaseBody
            ? $@"
                        var {baseAccessor} = __requestBase?.{usage.BasePropertyName};"
            : string.Empty;
        var valueLines = usage.Parameters
            .Select(parameter =>
            {
                var optionExpression = $"{usage.InstanceName}.{ParameterSymbolName(parameter)}";
                var valueExpression = operation.SupportsBaseBody && CliProjectOperation.IsMergeableBaseBodyField(parameter)
                    ? GenerateBaseBodyMergeExpression(optionExpression, baseAccessor, CliProjectOperation.BaseBodyPropertyName(parameter))
                    : $"parseResult.GetValue({optionExpression})";
                return $@"
                        var {usage.ParameterName}{ParameterSymbolName(parameter)} = {valueExpression};";
            })
            .Inject();
        var specifiedExpression = usage.Parameters
            .Select(parameter => $"CliRuntime.WasSpecified(parseResult, {usage.InstanceName}.{ParameterSymbolName(parameter)})")
            .ToArray();
        var assignments = usage.Parameters
            .Select(parameter => $@"
                                {CliProjectOperation.BaseBodyPropertyName(parameter)} = {usage.ParameterName}{ParameterSymbolName(parameter)}{(parameter.IsRequired && !parameter.HasSchemaDefault ? "!" : string.Empty)},")
            .Inject();

        return $@"
{baseAccessorDeclaration}{valueLines}
                        var __{usage.ParameterName}Specified = {string.Join(" || ", specifiedExpression)};
                        var {usage.ParameterName} =
                            __{usage.ParameterName}Specified || {baseAccessor} is not null
                                ? new {usage.ModelTypeName}
                                {{
{assignments}
                                }}
                                : {baseAccessor};";
    }

    private static string GenerateWebhookParseLines(
        CliProjectModel model,
        CliProjectOperation operation,
        CliProjectWebhookUsage usage)
    {
        var baseAccessor = operation.SupportsBaseBody
            ? $"__requestBase?.{usage.BasePropertyName}"
            : "null";
        var lines = new List<string>
        {
            $@"
                        var {usage.ParameterName}WebhookUrl = parseResult.GetValue({WebhookUrlSymbolName(usage)}){(operation.SupportsBaseBody ? $" ?? {baseAccessor}?.{usage.UrlPropertyName}" : string.Empty)};"
        };
        var specifiedExpressions = new List<string> { $"CliRuntime.WasSpecified(parseResult, {WebhookUrlSymbolName(usage)})" };

        if (!string.IsNullOrWhiteSpace(usage.HeadersPropertyName))
        {
            lines.Add($@"
                        var __{usage.ParameterName}HeadersSpecified = CliRuntime.WasSpecified(parseResult, {WebhookHeadersSymbolName(usage)});
                        var {usage.ParameterName}WebhookHeaders = __{usage.ParameterName}HeadersSpecified
                            ? CliRuntime.DeserializeJsonValue<{usage.HeadersTypeName}>(
                                CliRuntime.SerializeKeyValuePairs(parseResult.GetValue({WebhookHeadersSymbolName(usage)}) ?? Array.Empty<string>()),
                                global::{model.JsonSerializerContextFullName}.Default)
                            : {baseAccessor}?.{usage.HeadersPropertyName};");
            specifiedExpressions.Add($"__{usage.ParameterName}HeadersSpecified");
        }

        if (!string.IsNullOrWhiteSpace(usage.MetadataPropertyName))
        {
            lines.Add($@"
                        var __{usage.ParameterName}MetadataSpecified = CliRuntime.WasSpecified(parseResult, {WebhookMetadataSymbolName(usage)});
                        var {usage.ParameterName}WebhookMetadata = __{usage.ParameterName}MetadataSpecified
                            ? CliRuntime.DeserializeJsonValue<{usage.MetadataTypeName}>(
                                CliRuntime.SerializeKeyValuePairs(parseResult.GetValue({WebhookMetadataSymbolName(usage)}) ?? Array.Empty<string>()),
                                global::{model.JsonSerializerContextFullName}.Default)
                            : {baseAccessor}?.{usage.MetadataPropertyName};");
            specifiedExpressions.Add($"__{usage.ParameterName}MetadataSpecified");
        }

        if (!string.IsNullOrWhiteSpace(usage.EventsPropertyName))
        {
            lines.Add($@"
                        var __{usage.ParameterName}EventsSpecified = CliRuntime.WasSpecified(parseResult, {WebhookEventsSymbolName(usage)});
                        var {usage.ParameterName}WebhookEvents = __{usage.ParameterName}EventsSpecified
                            ? CliRuntime.DeserializeJsonValue<{usage.EventsTypeName}>(
                                CliRuntime.SerializeStringArray(parseResult.GetValue({WebhookEventsSymbolName(usage)}) ?? Array.Empty<string>()),
                                global::{model.JsonSerializerContextFullName}.Default)
                            : {baseAccessor}?.{usage.EventsPropertyName};");
            specifiedExpressions.Add($"__{usage.ParameterName}EventsSpecified");
        }

        var assignments = new List<string>
        {
            $@"
                                {usage.UrlPropertyName} = {(
                                    usage.UrlIsRequired
                                        ? $"__{usage.ParameterName}WebhookUrlRequired"
                                        : $"{usage.ParameterName}WebhookUrl")},"
        };
        if (!string.IsNullOrWhiteSpace(usage.HeadersPropertyName))
        {
            assignments.Add($@"
                                {usage.HeadersPropertyName} = {usage.ParameterName}WebhookHeaders,");
        }

        if (!string.IsNullOrWhiteSpace(usage.MetadataPropertyName))
        {
            assignments.Add($@"
                                {usage.MetadataPropertyName} = {usage.ParameterName}WebhookMetadata,");
        }

        if (!string.IsNullOrWhiteSpace(usage.EventsPropertyName))
        {
            assignments.Add($@"
                                {usage.EventsPropertyName} = {usage.ParameterName}WebhookEvents,");
        }

        return $@"
{string.Concat(lines)}
                        var __{usage.ParameterName}Specified = {string.Join(" || ", specifiedExpressions)};
                        if (__{usage.ParameterName}Specified && string.IsNullOrWhiteSpace({usage.ParameterName}WebhookUrl))
                        {{
                            throw new CliException(""Specify --{usage.Prefix}-url or include it in the base request body before using other --{usage.Prefix}-* options."");
                        }}
{(usage.UrlIsRequired
    ? $@"
                        var __{usage.ParameterName}WebhookUrlRequired =
                            {usage.ParameterName}WebhookUrl ??
                            throw new CliException(""Specify --{usage.Prefix}-url or include it in the base request body before using other --{usage.Prefix}-* options."");"
    : string.Empty)}

                        var {usage.ParameterName} =
                            __{usage.ParameterName}Specified || {baseAccessor} is not null
                                ? new {usage.ModelTypeName}
                                {{
{string.Concat(assignments)}
                                }}
                                : {baseAccessor};";
    }

    private static string GenerateResponseFormatterMembers(CliProjectOperation operation)
    {
        if (!operation.HasResponse || operation.ResponseIsRawStream || operation.ResponseIsEnumerableStream || operation.ResponseIsByteArray)
        {
            return string.Empty;
        }

        var hints = operation.ResponseFormatHints.Count == 0
            ? string.Empty
            : operation.ResponseFormatHints
                .OrderBy(static hint => hint.Key, StringComparer.OrdinalIgnoreCase)
                .Select(hint => $@"
            [""{hint.Key}""] = CliFormatHint.{hint.Value},")
                .Inject();

        return $@"

                    private static string FormatResponse(ParseResult parseResult, {operation.ResponseType} value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {{
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {{
                            return text;
                        }}

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {{{hints}
                        }};
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }}

                    static partial void CustomizeResponseText(ParseResult parseResult, {operation.ResponseType} value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);
";
    }

    private static string WebhookUrlSymbolName(CliProjectWebhookUsage usage) => $"{usage.ParameterName.ToPropertyName()}WebhookUrl";
    private static string WebhookHeadersSymbolName(CliProjectWebhookUsage usage) => $"{usage.ParameterName.ToPropertyName()}WebhookHeader";
    private static string WebhookMetadataSymbolName(CliProjectWebhookUsage usage) => $"{usage.ParameterName.ToPropertyName()}WebhookMetadata";
    private static string WebhookEventsSymbolName(CliProjectWebhookUsage usage) => $"{usage.ParameterName.ToPropertyName()}WebhookEvent";

    private static string GenerateWaitInvocationAndWrite(CliProjectModel model, CliProjectOperation operation)
    {
        if (!operation.SupportsWait)
        {
            return string.Empty;
        }

        var endPoint = operation.EndPoint;
        var target = endPoint.Settings.GroupByTags && !string.IsNullOrWhiteSpace(endPoint.Tag.SafeName)
            ? $"client.{endPoint.Tag.SafeName}.{endPoint.NotAsyncMethodName}WaitAsync"
            : $"client.{endPoint.NotAsyncMethodName}WaitAsync";
        var arguments = operation.PositionalParameters
            .Concat(operation.OptionParameters)
            .Concat(operation.DirectOptionSets.SelectMany(static usage => usage.Parameters))
            .Select(static parameter => $@"
                                        {parameter.ParameterName}: {parameter.ParameterName},")
            .Concat(operation.NestedOptionSets.Select(static usage => $@"
                                        {usage.ParameterName}: {usage.ParameterName}{(usage.IsRequired ? "!" : string.Empty)},"))
            .Concat(operation.WebhookUsages.Select(static usage => $@"
                                        {usage.ParameterName}: {usage.ParameterName},"))
            .Inject();
        var requestArgument = operation.HasDirectRequestBody
            ? @"
                                        request: request,"
            : string.Empty;

        if (!string.IsNullOrWhiteSpace(endPoint.LocationWaitCompanion.SiblingReturnType.CSharpType))
        {
            return $@"
                                if (wait)
                                {{
                                    var pollingOptions = CliRuntime.CreatePollingOptions(pollInterval, waitTimeout);
                                    var waitResponse = await {target}(
{arguments}{requestArgument}
                                        pollingOptions: pollingOptions,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    await CliRuntime.WriteResponseAsync(
                                        parseResult,
                                        waitResponse,
                                        global::{model.JsonSerializerContextFullName}.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    return;
                                }}";
        }

        return $@"
                                if (wait)
                                {{
                                    var pollingOptions = CliRuntime.CreatePollingOptions(pollInterval, waitTimeout);
                                    await {target}(
{arguments}{requestArgument}
                                        pollingOptions: pollingOptions,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                    await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);
                                    return;
                                }}";
    }

    private static string GenerateInvocation(CliProjectOperation operation)
    {
        var endPoint = operation.EndPoint;
        var target = endPoint.Settings.GroupByTags && !string.IsNullOrWhiteSpace(endPoint.Tag.SafeName)
            ? $"client.{endPoint.Tag.SafeName}.{endPoint.MethodName}"
            : $"client.{endPoint.MethodName}";
        var arguments = operation.PositionalParameters
            .Concat(operation.OptionParameters)
            .Concat(operation.DirectOptionSets.SelectMany(static usage => usage.Parameters))
            .Select(static parameter => $@"
                                    {parameter.ParameterName}: {parameter.ParameterName},")
            .Concat(operation.NestedOptionSets.Select(static usage => $@"
                                    {usage.ParameterName}: {usage.ParameterName}{(usage.IsRequired ? "!" : string.Empty)},"))
            .Concat(operation.WebhookUsages.Select(static usage => $@"
                                    {usage.ParameterName}: {usage.ParameterName},"))
            .Inject();
        var requestArgument = operation.HasDirectRequestBody
            ? @"
                                    request: request,"
            : string.Empty;

        if (operation.ResponseIsEnumerableStream)
        {
            return $@"
                                var response = {target}(
{arguments}{requestArgument}
                                    cancellationToken: cancellationToken);";
        }

        if (operation.HasResponse)
        {
            return $@"
                                var response = await {target}(
{arguments}{requestArgument}
                                    cancellationToken: cancellationToken).ConfigureAwait(false);";
        }

        return $@"
                                await {target}(
{arguments}{requestArgument}
                                    cancellationToken: cancellationToken).ConfigureAwait(false);";
    }

    private static string GenerateResponseWrite(CliProjectModel model, CliProjectOperation operation)
    {
        if (operation.ResponseIsEnumerableStream)
        {
            return $@"
                                await foreach (var item in response.WithCancellation(cancellationToken).ConfigureAwait(false))
                                {{
                                    await CliRuntime.WriteResponseLineAsync(
                                        parseResult,
                                        item,
                                        global::{model.JsonSerializerContextFullName}.Default,
                                        cancellationToken: cancellationToken).ConfigureAwait(false);
                                }}";
        }

        if (operation.ResponseIsRawStream)
        {
            return @"
                                await using (response.ConfigureAwait(false))
                                {
                                    await CliRuntime.WriteStreamAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
                                }";
        }

        if (operation.ResponseIsByteArray)
        {
            return @"
                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);";
        }

        if (operation.HasResponse)
        {
            var outputDirectoryBranch = operation.SupportsOutputDirectory
                ? $@"
                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::{model.JsonSerializerContextFullName}.Default,
                                        {Literal(operation.OutputDirectoryItemsPropertyName)},
                                        cancellationToken).ConfigureAwait(false))
                                {{"
                : string.Empty;
            var outputDirectoryClose = operation.SupportsOutputDirectory
                ? @"
                                }"
                : string.Empty;
            return $@"
{outputDirectoryBranch}
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::{model.JsonSerializerContextFullName}.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);{outputDirectoryClose}";
        }

        return @"
                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);";
    }

    private static string ParameterSymbolName(MethodParameter parameter)
    {
        return parameter.Name.ToPropertyName() is
            "Name" or "Description" or "Action" or "Children" or "Arguments" or "Options" or "Subcommands" or "Validators" or "Aliases" or
            "TreatUnmatchedTokensAsErrors" or "FirstParent" or "Hidden" or "Parents" or "Command" or
            "Input" or "RequestInput" or "BodyInput" or
            "RequestJson" or "RequestBodyJson" or "BodyJson" or
            "RequestFile" or "RequestBodyFile" or "BodyFile" or
            "Wait" or "PollInterval" or "WaitTimeout"
            ? $"{parameter.Name.ToPropertyName()}Option"
            : parameter.Name.ToPropertyName();
    }

    private static string Literal(string value)
    {
        return $"@\"{(value ?? string.Empty).Replace("\"", "\"\"", StringComparison.Ordinal)}\"";
    }

    private static string NormalizePath(string path)
    {
        return path.Replace('\\', '/');
    }

    private static string XmlEscape(string value)
    {
        return value
            .Replace("&", "&amp;", StringComparison.Ordinal)
            .Replace("<", "&lt;", StringComparison.Ordinal)
            .Replace(">", "&gt;", StringComparison.Ordinal)
            .Replace("\"", "&quot;", StringComparison.Ordinal)
            .Replace("'", "&apos;", StringComparison.Ordinal);
    }
}
