using System.Collections.Immutable;
using System.CommandLine;
using System.Text;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;
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

    private Option<string[]> ApiKeyEnvVars { get; } = new("--api-key-env-var")
    {
        DefaultValueFactory = _ => Array.Empty<string>(),
        Description = "Environment variable used for API keys. Repeatable.",
        AllowMultipleArgumentsPerToken = true,
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
        Options.Add(ApiKeyEnvVars);
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
            SecuritySchemes = parseResult.GetRequiredValue(SecuritySchemes).ToImmutableArray(),
            BaseUrl = parseResult.GetRequiredValue(BaseUrl),
            OpenApiOverrides = parseResult.GetRequiredValue(OpenApiOverrides).ToImmutableArray(),
        };

        Console.WriteLine("Preparing generated endpoint model...");
        var data = CSharpPipeline.PrepareAndEnrich(((yaml, settings), GlobalSettings: settings));

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
            baseUrlEnvVar,
            data,
            parseResult.GetRequiredValue(ApiOnly));

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
    string BaseUrlEnvVar,
    ImmutableArray<CliProjectAuthorization> Authorizations,
    ImmutableArray<CliProjectTag> Tags,
    bool ApiOnly)
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
        string baseUrlEnvVar,
        AutoSDK.Models.Data data,
        bool apiOnly)
    {
        var projectName = SanitizeProjectName(packageId);
        var authorizations = data.Authorizations
            .Select(CliProjectAuthorization.Create)
            .Distinct()
            .ToImmutableArray();
        var usedTagCommandNames = new HashSet<string>(StringComparer.Ordinal);
        var usedTagClassNames = new HashSet<string>(StringComparer.Ordinal);
        var tags = data.Methods
            .Where(static x => !string.IsNullOrWhiteSpace(x.Path))
            .GroupBy(static x => string.IsNullOrWhiteSpace(x.Tag.Name) ? "default" : x.Tag.Name)
            .OrderBy(static x => x.Key, StringComparer.OrdinalIgnoreCase)
            .Select(group => CliProjectTag.Create(group, usedTagCommandNames, usedTagClassNames))
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
            baseUrlEnvVar,
            authorizations,
            tags,
            apiOnly);
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

internal sealed record CliProjectTag(
    string Name,
    string CommandName,
    string ClassName,
    ImmutableArray<CliProjectOperation> Operations)
{
    public static CliProjectTag Create(
        IGrouping<string, EndPoint> group,
        HashSet<string> usedCommandNames,
        HashSet<string> usedClassNames)
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
            .Select(endPoint => CliProjectOperation.Create(endPoint, usedNames))
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
    ImmutableArray<MethodParameter> RequiredParameters,
    ImmutableArray<MethodParameter> OptionalParameters,
    bool HasRequestBody,
    bool HasResponse,
    string ResponseType,
    bool ResponseIsRawStream,
    bool ResponseIsEnumerableStream,
    bool ResponseIsByteArray)
{
    public static CliProjectOperation Create(EndPoint endPoint, HashSet<string> usedNames)
    {
        var baseName = CliProjectScaffolder.ToKebabCase(string.IsNullOrWhiteSpace(endPoint.Id) ? endPoint.NotAsyncMethodName : endPoint.Id);
        var commandName = CliProjectScaffolder.MakeUniqueCommandName(baseName, usedNames);
        var locationParameters = endPoint.Parameters
            .Where(static x => x.Location is not null)
            .Where(static x => x is { IsDeprecated: false } or { IsRequired: true } or { IsDeprecated: true, Location: not null })
            .ToArray();
        var responseType = GetResponseType(endPoint);

        return new CliProjectOperation(
            endPoint,
            commandName,
            CliProjectScaffolder.ToTypeName($"{endPoint.CliCommandClassName}ApiCommand"),
            locationParameters.Where(static x => x.IsRequired && !x.HasSchemaDefault).ToImmutableArray(),
            locationParameters.Where(static x => !x.IsRequired || x.HasSchemaDefault).ToImmutableArray(),
            !string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType),
            !string.IsNullOrWhiteSpace(responseType),
            responseType,
            endPoint.RawStream,
            endPoint.EnumerableStream,
            endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability == "byte[]");
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
        return $$"""
                 #nullable enable

                 using System.CommandLine;
                 using {{model.RootNamespace}};
                 using {{model.RootNamespace}}.Commands;

                 var rootCommand = new RootCommand({{Literal($"CLI tool for the {model.SdkNamespace} SDK.")}});
                 rootCommand.Options.Add(CliOptions.ApiKey);
                 rootCommand.Options.Add(CliOptions.BaseUrl);
                 rootCommand.Options.Add(CliOptions.Output);
                 rootCommand.Subcommands.Add(AuthCommand.Create());
                 rootCommand.Subcommands.Add(ApiCommand.Create());

                 return await rootCommand.Parse(args).InvokeAsync().ConfigureAwait(false);
                 """;
    }

    private static string GenerateCliOptions(CliProjectModel model)
    {
        return $$"""
                 #nullable enable

                 using System.CommandLine;

                 namespace {{model.RootNamespace}};

                 internal static class CliOptions
                 {
                     public static Option<string?> ApiKey { get; } = new("--api-key", ["-k"])
                     {
                         Description = "API key. Falls back to configured environment variables and dotnet user-secrets.",
                         Recursive = true,
                     };

                     public static Option<string?> BaseUrl { get; } = new("--base-url")
                     {
                         Description = "Override the API base URL.",
                         Recursive = true,
                     };

                     public static Option<string?> Output { get; } = new("--output", ["-o"])
                     {
                         Description = "Write response content to this file path instead of stdout.",
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

        return $$"""
                 #nullable enable

                 using System.CommandLine;
                 using System.CommandLine.Parsing;
                 using System.Text;
                 using System.Text.Json;
                 using System.Text.Json.Serialization;

                 namespace {{model.RootNamespace}};

                 internal static class CliRuntime
                 {
                     private const string UserSecretsId = "{{model.UserSecretsId}}";
                     private const string UserSecretApiKeyName = "{{model.ApiKeyEnvVars.FirstOrDefault() ?? "API_KEY"}}";
                     private static readonly string[] ApiKeyEnvironmentVariables = [{{envVarArray}}];

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
                         if (parseResult.GetValue(CliOptions.ApiKey) is { Length: > 0 } fromOption)
                         {
                             return fromOption;
                         }

                         foreach (var environmentVariable in ApiKeyEnvironmentVariables)
                         {
                             if (Environment.GetEnvironmentVariable(environmentVariable) is { Length: > 0 } fromEnvironment)
                             {
                                 return fromEnvironment;
                             }
                         }

                         return await ReadUserSecretAsync(UserSecretApiKeyName, cancellationToken).ConfigureAwait(false);
                     }

                     public static async Task<AuthStatusInfo> GetAuthStatusAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
                     {
                         if (parseResult.GetValue(CliOptions.ApiKey) is { Length: > 0 } fromOption)
                         {
                             return new AuthStatusInfo(true, "option", MaskSecret(fromOption), null);
                         }

                         foreach (var environmentVariable in ApiKeyEnvironmentVariables)
                         {
                             if (Environment.GetEnvironmentVariable(environmentVariable) is { Length: > 0 } fromEnvironment)
                             {
                                 return new AuthStatusInfo(true, $"environment:{environmentVariable}", MaskSecret(fromEnvironment), null);
                             }
                         }

                         var userSecret = await ReadUserSecretAsync(UserSecretApiKeyName, cancellationToken).ConfigureAwait(false);
                         return string.IsNullOrWhiteSpace(userSecret)
                             ? new AuthStatusInfo(false, "none", null, GetUserSecretsPath())
                             : new AuthStatusInfo(true, "user-secrets", MaskSecret(userSecret), GetUserSecretsPath());
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

                     public static async Task<T> ReadRequestAsync<T>(ParseResult parseResult, Option<string?> requestJsonOption, Option<string?> requestFileOption, JsonSerializerContext context, CancellationToken cancellationToken = default)
                     {
                         var requestJson = parseResult.GetValue(requestJsonOption);
                         if (string.IsNullOrWhiteSpace(requestJson))
                         {
                             var requestFile = parseResult.GetValue(requestFileOption);
                             if (string.IsNullOrWhiteSpace(requestFile))
                             {
                                 throw new CliException("Specify --request-json or --request-file.");
                             }

                             requestJson = requestFile == "-"
                                 ? await Console.In.ReadToEndAsync(cancellationToken).ConfigureAwait(false)
                                 : await File.ReadAllTextAsync(requestFile, cancellationToken).ConfigureAwait(false);
                         }

                         var value = JsonSerializer.Deserialize(requestJson, typeof(T), context);
                         return value is T typed
                             ? typed
                             : throw new CliException($"Unable to deserialize request JSON as {typeof(T).Name}.");
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

                     public static async Task WriteSuccessAsync(ParseResult parseResult, CancellationToken cancellationToken = default)
                     {
                         await WriteTextAsync(parseResult, "{\n  \"success\": true\n}", cancellationToken: cancellationToken).ConfigureAwait(false);
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
                         return secret.Length <= 8 ? new string('*', secret.Length) : $"{secret[..4]}...{secret[^4..]}";
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
                 }

                 internal sealed record AuthStatusInfo(bool Authenticated, string Source, string? ApiKeyHint, string? Path);

                 [JsonSerializable(typeof(Dictionary<string, string>))]
                 internal sealed partial class UserSecretsJsonContext : JsonSerializerContext;
                 """;
    }

    private static string GenerateAuthCommand(CliProjectModel model)
    {
        return $$"""
                 #nullable enable

                 using System.CommandLine;

                 namespace {{model.RootNamespace}}.Commands;

                 internal static class AuthCommand
                 {
                     public static Command Create()
                     {
                         var command = new Command("auth", "Manage API credentials stored in dotnet user-secrets.");
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
                         var command = new Command("status", "Show the authentication source the CLI will use.");
                         command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
                             await CliRuntime.RunAsync(async () =>
                             {
                                 var status = await CliRuntime.GetAuthStatusAsync(parseResult, cancellationToken).ConfigureAwait(false);
                                 await Console.Out.WriteLineAsync($"authenticated: {status.Authenticated.ToString().ToLowerInvariant()}").ConfigureAwait(false);
                                 await Console.Out.WriteLineAsync($"source: {status.Source}").ConfigureAwait(false);
                                 if (!string.IsNullOrWhiteSpace(status.ApiKeyHint))
                                 {
                                     await Console.Out.WriteLineAsync($"api-key: {status.ApiKeyHint}").ConfigureAwait(false);
                                 }
                                 if (!string.IsNullOrWhiteSpace(status.Path))
                                 {
                                     await Console.Out.WriteLineAsync($"path: {status.Path}").ConfigureAwait(false);
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
                        command.Options.Add(CliOptions.Output);
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

    private static string GenerateOperationCommand(CliProjectModel model, CliProjectOperation operation)
    {
        var endPoint = operation.EndPoint;
        var description = string.IsNullOrWhiteSpace(endPoint.Summary) ? endPoint.Description : endPoint.Summary;
        var requiredFields = operation.RequiredParameters.Select(parameter => GenerateParameterField(parameter, required: true)).Inject();
        var optionalFields = operation.OptionalParameters.Select(parameter => GenerateParameterField(parameter, required: false)).Inject();
        var addSymbols = operation.RequiredParameters
            .Select(parameter => $@"
                        command.Arguments.Add({ParameterSymbolName(parameter)});")
            .Concat(operation.OptionalParameters.Select(parameter => $@"
                        command.Options.Add({ParameterSymbolName(parameter)});"))
            .Inject();
        var requestFields = operation.HasRequestBody
            ? """

                    private static Option<string?> RequestJson { get; } = new("--request-json")
                    {
                        Description = "Request body as JSON.",
                    };

                    private static Option<string?> RequestFile { get; } = new("--request-file")
                    {
                        Description = "Path to a JSON request file, or '-' for stdin.",
                    };
              """
            : string.Empty;
        var addRequestOptions = operation.HasRequestBody
            ? """
                        command.Options.Add(RequestJson);
                        command.Options.Add(RequestFile);
                        command.Validators.Add(result =>
                        {
                            var hasRequestJson = result.GetResult(RequestJson) is not null;
                            var hasRequestFile = result.GetResult(RequestFile) is not null;
                            if (hasRequestJson == hasRequestFile)
                            {
                                result.AddError("Specify exactly one of --request-json or --request-file.");
                            }
                        });
              """
            : string.Empty;
        var parseParameters = operation.RequiredParameters
            .Select(parameter => $@"
                        var {parameter.ParameterName} = parseResult.GetRequiredValue({ParameterSymbolName(parameter)});")
            .Concat(operation.OptionalParameters.Select(parameter => $@"
                        var {parameter.ParameterName} = parseResult.{(parameter.HasSchemaDefault ? "GetRequiredValue" : "GetValue")}({ParameterSymbolName(parameter)});"))
            .Inject();
        var requestRead = operation.HasRequestBody
            ? $@"
                        var request = await CliRuntime.ReadRequestAsync<{endPoint.RequestType.CSharpTypeWithoutNullability}>(
                            parseResult,
                            RequestJson,
                            RequestFile,
                            global::{model.JsonSerializerContextFullName}.Default,
                            cancellationToken).ConfigureAwait(false);"
            : string.Empty;
        var invocation = GenerateInvocation(operation);
        var responseWrite = GenerateResponseWrite(model, operation);

        return $$"""
                 #nullable enable

                 using System.CommandLine;

                 namespace {{model.RootNamespace}}.Commands;

                 internal static class {{operation.ClassName}}
                 {
                 {{requiredFields}}{{optionalFields}}{{requestFields}}

                     public static Command Create()
                     {
                         var command = new Command({{Literal(operation.CommandName)}}, {{Literal(description)}});
                 {{addSymbols}}
                 {{addRequestOptions}}
                         command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
                             await CliRuntime.RunAsync(async () =>
                             {
                 {{parseParameters}}{{requestRead}}
                                 using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);
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

    private static string GenerateInvocation(CliProjectOperation operation)
    {
        var endPoint = operation.EndPoint;
        var target = endPoint.Settings.GroupByTags && !string.IsNullOrWhiteSpace(endPoint.Tag.SafeName)
            ? $"client.{endPoint.Tag.SafeName}.{endPoint.MethodName}"
            : $"client.{endPoint.MethodName}";
        var arguments = operation.RequiredParameters
            .Concat(operation.OptionalParameters)
            .Select(static parameter => $@"
                                    {parameter.ParameterName}: {parameter.ParameterName},")
            .Inject();
        var requestArgument = operation.HasRequestBody
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
                                    await CliRuntime.WriteJsonLineAsync(
                                        parseResult,
                                        item,
                                        global::{model.JsonSerializerContextFullName}.Default,
                                        cancellationToken).ConfigureAwait(false);
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
            return $@"
                                await CliRuntime.WriteJsonAsync(
                                    parseResult,
                                    response,
                                    global::{model.JsonSerializerContextFullName}.Default,
                                    cancellationToken).ConfigureAwait(false);";
        }

        return @"
                                await CliRuntime.WriteSuccessAsync(parseResult, cancellationToken).ConfigureAwait(false);";
    }

    private static string ParameterSymbolName(MethodParameter parameter)
    {
        return parameter.Name.ToPropertyName() is
            "Name" or "Description" or "Action" or "Children" or "Arguments" or "Options" or "Subcommands" or "Validators" or "Aliases" or
            "TreatUnmatchedTokensAsErrors" or "FirstParent" or "Hidden" or "Parents" or "Command"
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
