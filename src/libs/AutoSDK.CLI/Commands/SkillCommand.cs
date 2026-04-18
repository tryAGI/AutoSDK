using System.CommandLine;
using System.Text;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using Microsoft.OpenApi;

#pragma warning disable CA1308  // SKILL.md slugs and command names are intentionally lowercase (kebab-case).

namespace AutoSDK.CLI.Commands;

/// <summary>
/// Generates a Claude-compatible <c>SKILL.md</c> manifest for a generated SDK's CLI tool.
/// The manifest describes what the tool does, how to invoke it via <c>dnx</c>, and lists
/// the command groups (tags) so an agent can route a user's intent to the right subcommand.
/// </summary>
internal sealed class SkillCommand : Command
{
    private Argument<string> Input { get; } = new(
        name: "input")
    {
        Description = "OpenAPI spec path or URL.",
    };

    private Option<string> Output { get; } = new(
        name: "--output",
        aliases: ["-o"])
    {
        DefaultValueFactory = _ => "SKILL.md",
        Description = "Output path for the generated SKILL.md.",
    };

    private Option<string> PackageId { get; } = new(
        name: "--package-id")
    {
        Description = "NuGet package id of the CLI tool (e.g. `tryAGI.OpenAI.CLI`). Used for the dnx command and the skill name.",
    };

    private Option<string?> SkillName { get; } = new(
        name: "--skill-name")
    {
        Description = "Override the skill `name` field in frontmatter. Defaults to a kebab-cased package id.",
    };

    private Option<string?> ApiKeyEnvVar { get; } = new(
        name: "--api-key-env-var")
    {
        Description = "Name of the environment variable the CLI reads its API key from (e.g. `OPENAI_API_KEY`). Defaults to `<PREFIX>_API_KEY` derived from the package id.",
    };

    private Option<string?> Homepage { get; } = new(
        name: "--homepage")
    {
        Description = "Optional homepage/repo URL emitted in the footer.",
    };

    private Option<bool> ExcludeDeprecatedOperations { get; } = new(
        name: "--exclude-deprecated-operations")
    {
        DefaultValueFactory = _ => Settings.Default.ExcludeDeprecatedOperations,
        Description = "Exclude deprecated operations from the command table.",
    };

    private Option<bool> IgnoreOpenApiErrors { get; } = new(
        name: "--ignore-openapi-errors")
    {
        DefaultValueFactory = _ => Settings.Default.IgnoreOpenApiErrors,
    };

    private Option<bool> IgnoreOpenApiWarnings { get; } = new(
        name: "--ignore-openapi-warnings")
    {
        DefaultValueFactory = _ => Settings.Default.IgnoreOpenApiWarnings,
    };

    public SkillCommand() : base(
        name: "skill",
        description: "Generate a Claude SKILL.md manifest for the generated CLI tool from an OpenAPI spec.")
    {
        Arguments.Add(Input);
        Options.Add(Output);
        Options.Add(PackageId);
        Options.Add(SkillName);
        Options.Add(ApiKeyEnvVar);
        Options.Add(Homepage);
        Options.Add(ExcludeDeprecatedOperations);
        Options.Add(IgnoreOpenApiErrors);
        Options.Add(IgnoreOpenApiWarnings);

        SetAction(HandleAsync);
    }

    private async Task HandleAsync(ParseResult parseResult)
    {
        var input = parseResult.GetRequiredValue(Input);
        var output = parseResult.GetRequiredValue(Output);
        var packageId = parseResult.GetRequiredValue(PackageId);
        if (string.IsNullOrWhiteSpace(packageId))
        {
            throw new ArgumentException("--package-id is required (e.g. `tryAGI.OpenAI.CLI`).");
        }

        var skillName = parseResult.GetValue(SkillName) is { Length: > 0 } overrideName
            ? overrideName
            : DeriveSkillName(packageId);
        var apiKeyEnvVar = parseResult.GetValue(ApiKeyEnvVar) is { Length: > 0 } overrideEnv
            ? overrideEnv
            : DeriveEnvVar(packageId);
        var homepage = parseResult.GetValue(Homepage);

        var excludeDeprecatedOperations = parseResult.GetRequiredValue(ExcludeDeprecatedOperations);
        var ignoreOpenApiErrors = parseResult.GetRequiredValue(IgnoreOpenApiErrors);
        var ignoreOpenApiWarnings = parseResult.GetRequiredValue(IgnoreOpenApiWarnings);

        Console.WriteLine($"Loading {input}...");
        using var client = new HttpClient();
        var yaml = input.StartsWith("http", StringComparison.OrdinalIgnoreCase)
            ? await client.GetStringAsync(new Uri(input)).ConfigureAwait(false)
            : await File.ReadAllTextAsync(input).ConfigureAwait(false);

        var specFormat = SpecFormatDetector.DetectFormat(yaml);
        if (specFormat == SpecFormat.GrpcProto)
        {
            await Console.Error.WriteLineAsync(SpecFormatDetector.GrpcProtoCommandNotSupportedMessage).ConfigureAwait(false);
            await Console.Error.FlushAsync().ConfigureAwait(false);
            Environment.Exit(1);
            return;
        }

        var settings = Settings.Default with
        {
            ExcludeDeprecatedOperations = excludeDeprecatedOperations,
            IgnoreOpenApiErrors = ignoreOpenApiErrors,
            IgnoreOpenApiWarnings = ignoreOpenApiWarnings,
        };
        var openApiDocument = yaml.GetOpenApiDocument(settings);
        var schemas = openApiDocument.GetSchemas(settings);
        var operations = openApiDocument.GetOperations(settings, globalSettings: settings, schemas);

        var title = openApiDocument.Info?.Title?.Trim() ?? packageId;
        var summary = FirstParagraph(openApiDocument.Info?.Description);
        var markdown = BuildMarkdown(
            title: title,
            summary: summary,
            skillName: skillName,
            packageId: packageId,
            apiKeyEnvVar: apiKeyEnvVar,
            homepage: homepage,
            operations: operations,
            securitySchemes: (openApiDocument.Components?.SecuritySchemes?.Values ?? [])
                .OfType<OpenApiSecurityScheme>());

        var directory = Path.GetDirectoryName(output);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Directory.CreateDirectory(directory);
        }

        await File.WriteAllTextAsync(output, markdown).ConfigureAwait(false);
        Console.WriteLine($"Wrote SKILL.md to {output} ({markdown.Length} chars, {operations.Count} operations).");
    }

    private static string DeriveSkillName(string packageId)
    {
        // tryAGI.OpenAI.CLI → tryagi-openai
        var withoutCli = packageId;
        if (withoutCli.EndsWith(".CLI", StringComparison.OrdinalIgnoreCase))
        {
            withoutCli = withoutCli[..^4];
        }
        else if (withoutCli.EndsWith(".Cli", StringComparison.Ordinal))
        {
            withoutCli = withoutCli[..^4];
        }

        return withoutCli.Replace('.', '-').ToLowerInvariant();
    }

    private static string DeriveEnvVar(string packageId)
    {
        // tryAGI.OpenAI.CLI → OPENAI_API_KEY (strip company prefix + .CLI suffix)
        var core = packageId;
        if (core.EndsWith(".CLI", StringComparison.OrdinalIgnoreCase))
        {
            core = core[..^4];
        }

        // Take the last dot-separated segment as the conventional vendor name.
        var lastSegment = core.Split('.').LastOrDefault(s => !string.IsNullOrWhiteSpace(s)) ?? core;
        return $"{lastSegment.ToUpperInvariant()}_API_KEY";
    }

    private static string FirstParagraph(string? description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            return string.Empty;
        }

        var trimmed = description.Trim();
        var doubleNewline = trimmed.IndexOf("\n\n", StringComparison.Ordinal);
        return doubleNewline > 0 ? trimmed[..doubleNewline].Trim() : trimmed;
    }

    private static string BuildMarkdown(
        string title,
        string summary,
        string skillName,
        string packageId,
        string apiKeyEnvVar,
        string? homepage,
        IReadOnlyCollection<OperationContext> operations,
        IEnumerable<OpenApiSecurityScheme> securitySchemes)
    {
        var builder = new StringBuilder();
        var descriptionLine = string.IsNullOrWhiteSpace(summary)
            ? $"Call the {title} API from the command line. Zero-install via `dnx {packageId}`. Requires an API key via `${apiKeyEnvVar}`."
            : $"{OneLine(summary)} Invoke any endpoint via `dnx {packageId} <group> <command>`. Requires an API key via `${apiKeyEnvVar}`.";

        builder.AppendLine("---");
        builder.Append("name: ").AppendLine(skillName);
        builder.Append("description: ").AppendLine(descriptionLine);
        builder.AppendLine("---");
        builder.AppendLine();
        builder.Append("# ").Append(title).AppendLine(" CLI");
        builder.AppendLine();

        if (!string.IsNullOrWhiteSpace(summary))
        {
            builder.AppendLine(summary).AppendLine();
        }

        builder.AppendLine("## Installation (zero-install)");
        builder.AppendLine();
        builder.AppendLine("Prerequisite: .NET 10 SDK.");
        builder.AppendLine();
        builder.AppendLine("```bash");
        builder.Append("dnx ").Append(packageId).AppendLine(" --help");
        builder.Append("dnx ").Append(packageId).AppendLine(" --version <version> -- <command>");
        builder.AppendLine("```");
        builder.AppendLine();

        builder.AppendLine("## Credentials");
        builder.AppendLine();
        builder.Append("Set your API key in the `").Append(apiKeyEnvVar).AppendLine("` environment variable, or persist it via:");
        builder.AppendLine();
        builder.AppendLine("```bash");
        builder.Append("dnx ").Append(packageId).AppendLine(" auth set <your-key>");
        builder.AppendLine("```");
        builder.AppendLine();

        var schemeDescriptions = DescribeSchemes(securitySchemes).ToList();
        if (schemeDescriptions.Count > 0)
        {
            builder.AppendLine("Detected auth schemes:");
            foreach (var line in schemeDescriptions)
            {
                builder.Append("- ").AppendLine(line);
            }
            builder.AppendLine();
        }

        builder.AppendLine("## Commands");
        builder.AppendLine();
        builder.AppendLine("| Group | Command | Description |");
        builder.AppendLine("|-------|---------|-------------|");

        var rows = operations
            .Where(op => op.Operation?.Deprecated != true)
            .GroupBy(op => GetGroupKey(op), StringComparer.Ordinal)
            .OrderBy(g => g.Key, StringComparer.Ordinal);

        foreach (var group in rows)
        {
            var groupSlug = (string.IsNullOrWhiteSpace(group.Key) ? "default" : group.Key).ToLowerInvariant();
            foreach (var operation in group.OrderBy(x => GetAction(x), StringComparer.Ordinal))
            {
                var action = GetAction(operation);
                var summaryText = operation.Operation?.Summary ?? operation.Operation?.Description ?? string.Empty;
                var description = Escape(OneLine(summaryText));
                builder.Append("| `").Append(groupSlug).Append("` | `").Append(action).Append("` | ")
                    .Append(description).AppendLine(" |");
            }
        }

        builder.AppendLine();
        builder.AppendLine("Run `--help` on any group or command to see required arguments:");
        builder.AppendLine();
        builder.AppendLine("```bash");
        builder.Append("dnx ").Append(packageId).AppendLine(" <group> --help");
        builder.Append("dnx ").Append(packageId).AppendLine(" <group> <command> --help");
        builder.AppendLine("```");
        builder.AppendLine();

        builder.AppendLine("## For agents");
        builder.AppendLine();
        builder.AppendLine("When the user asks to perform an operation against this API:");
        builder.AppendLine("1. Prefer this CLI over writing ad-hoc code — invocations are reproducible.");
        builder.Append("2. Before the first call, verify credentials with `dnx ").Append(packageId).AppendLine(" auth show`.");
        builder.Append("3. If no credentials are found, ask the user for their ").Append(title).AppendLine(" API key.");
        builder.AppendLine("4. Use `--json` to get structured output for downstream parsing.");

        if (!string.IsNullOrWhiteSpace(homepage))
        {
            builder.AppendLine();
            builder.AppendLine("## Links");
            builder.AppendLine();
            builder.Append("- Home: ").AppendLine(homepage);
            builder.Append("- Package: https://www.nuget.org/packages/").AppendLine(packageId);
        }

        return builder.ToString();
    }

    private static string GetGroupKey(OperationContext operation)
    {
        if (!string.IsNullOrWhiteSpace(operation.Tag.SingularizedName))
        {
            return operation.Tag.SingularizedName;
        }

        if (!string.IsNullOrWhiteSpace(operation.Tag.Name))
        {
            return operation.Tag.Name;
        }

        return operation.Tags.FirstOrDefault() ?? "default";
    }

    private static string GetAction(OperationContext operation)
    {
        if (!string.IsNullOrWhiteSpace(operation.MethodName))
        {
            return KebabCase(operation.MethodName);
        }

        if (!string.IsNullOrWhiteSpace(operation.Operation?.OperationId))
        {
            return KebabCase(operation.Operation.OperationId);
        }

        var method = operation.OperationType?.Method?.ToLowerInvariant() ?? "op";
        var path = (operation.OperationPath ?? string.Empty)
            .Trim('/')
            .Replace('/', '-')
            .Replace("{", "", StringComparison.Ordinal)
            .Replace("}", "", StringComparison.Ordinal);
        return string.IsNullOrWhiteSpace(path) ? method : $"{method}-{path}";
    }

    private static string KebabCase(string pascalOrCamel)
    {
        if (string.IsNullOrEmpty(pascalOrCamel))
        {
            return string.Empty;
        }

        var sb = new StringBuilder(pascalOrCamel.Length + 8);
        for (var i = 0; i < pascalOrCamel.Length; i++)
        {
            var ch = pascalOrCamel[i];
            if (char.IsUpper(ch) && i > 0 && !char.IsUpper(pascalOrCamel[i - 1]))
            {
                sb.Append('-');
            }

            sb.Append(char.ToLowerInvariant(ch));
        }

        return sb.ToString();
    }

    private static IEnumerable<string> DescribeSchemes(IEnumerable<OpenApiSecurityScheme> schemes)
    {
        foreach (var scheme in schemes)
        {
            var kind = scheme.Type?.ToString() ?? "unknown";
            var detail = scheme switch
            {
                { Scheme: { Length: > 0 } s, Type: SecuritySchemeType.Http } => FormattableString.Invariant($"HTTP `{s}`"),
                { Name: { Length: > 0 } n, Type: SecuritySchemeType.ApiKey } => FormattableString.Invariant($"ApiKey header `{n}`"),
                { Type: SecuritySchemeType.OAuth2 } => "OAuth2",
                _ => kind,
            };
            yield return detail;
        }
    }

    private static string OneLine(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        return value.Replace('\r', ' ').Replace('\n', ' ').Trim();
    }

    private static string Escape(string value)
    {
        return value.Replace("|", "\\|", StringComparison.Ordinal);
    }
}
