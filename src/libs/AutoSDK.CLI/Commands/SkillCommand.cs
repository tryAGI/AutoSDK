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
/// By default, emits a multifile skill bundle: a concise <c>SKILL.md</c> (agent-loadable)
/// plus <c>commands.md</c> (full per-operation reference) and <c>auth.md</c> (credential
/// setup + detected auth schemes). <c>SKILL.md</c> links to the companion files via relative
/// markdown links so the agent can fetch details on demand.
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
        DefaultValueFactory = _ => "skill",
        Description = "Output directory (multifile mode) or file path ending in `.md` (single-file mode).",
    };

    private Option<bool> SingleFile { get; } = new(
        name: "--single-file")
    {
        DefaultValueFactory = _ => false,
        Description = "Emit one monolithic SKILL.md with all commands inline, instead of splitting into SKILL.md + commands.md + auth.md.",
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
        description: "Generate a Claude SKILL.md manifest (optionally multifile) for the generated CLI tool from an OpenAPI spec.")
    {
        Arguments.Add(Input);
        Options.Add(Output);
        Options.Add(SingleFile);
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
        var singleFile = parseResult.GetRequiredValue(SingleFile);
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

        var context = new BuildContext(
            Title: openApiDocument.Info?.Title?.Trim() ?? packageId,
            Summary: FirstParagraph(openApiDocument.Info?.Description),
            SkillName: skillName,
            PackageId: packageId,
            ApiKeyEnvVar: apiKeyEnvVar,
            Homepage: homepage,
            Operations: operations,
            SecuritySchemes: (openApiDocument.Components?.SecuritySchemes?.Values ?? [])
                .OfType<OpenApiSecurityScheme>()
                .ToList());

        // Single-file: emit a monolithic SKILL.md at the given path.
        if (singleFile || output.EndsWith(".md", StringComparison.OrdinalIgnoreCase))
        {
            var markdown = BuildSingleFile(context);
            var directory = Path.GetDirectoryName(output);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }
            await File.WriteAllTextAsync(output, markdown).ConfigureAwait(false);
            Console.WriteLine($"Wrote {output} ({markdown.Length} chars, {operations.Count} operations).");
            return;
        }

        // Multifile: emit SKILL.md + commands.md + auth.md into the directory.
        Directory.CreateDirectory(output);
        var skillMd = BuildSkillOverview(context, referenceCompanions: true);
        var commandsMd = BuildCommandsReference(context);
        var authMd = BuildAuthReference(context);

        var skillPath = Path.Combine(output, "SKILL.md");
        var commandsPath = Path.Combine(output, "commands.md");
        var authPath = Path.Combine(output, "auth.md");
        await File.WriteAllTextAsync(skillPath, skillMd).ConfigureAwait(false);
        await File.WriteAllTextAsync(commandsPath, commandsMd).ConfigureAwait(false);
        await File.WriteAllTextAsync(authPath, authMd).ConfigureAwait(false);

        Console.WriteLine($"Wrote multifile skill to {output}/");
        Console.WriteLine($"  SKILL.md     {skillMd.Length,7:N0} chars");
        Console.WriteLine($"  commands.md  {commandsMd.Length,7:N0} chars  ({operations.Count} operations)");
        Console.WriteLine($"  auth.md      {authMd.Length,7:N0} chars");
    }

    private sealed record BuildContext(
        string Title,
        string Summary,
        string SkillName,
        string PackageId,
        string ApiKeyEnvVar,
        string? Homepage,
        IReadOnlyCollection<OperationContext> Operations,
        IReadOnlyList<OpenApiSecurityScheme> SecuritySchemes);

    private static string BuildSkillOverview(BuildContext ctx, bool referenceCompanions)
    {
        var builder = new StringBuilder();
        var description = string.IsNullOrWhiteSpace(ctx.Summary)
            ? $"Call the {ctx.Title} API from the command line via `dnx {ctx.PackageId} <group> <command>`. Requires an API key in `${ctx.ApiKeyEnvVar}`."
            : $"{OneLine(ctx.Summary)} Invoke any endpoint via `dnx {ctx.PackageId} <group> <command>`. Requires an API key in `${ctx.ApiKeyEnvVar}`.";

        builder.AppendLine("---");
        builder.Append("name: ").AppendLine(ctx.SkillName);
        builder.Append("description: ").AppendLine(description);
        builder.AppendLine("---");
        builder.AppendLine();
        builder.Append("# ").Append(ctx.Title).AppendLine(" CLI");
        builder.AppendLine();

        if (!string.IsNullOrWhiteSpace(ctx.Summary))
        {
            builder.AppendLine(ctx.Summary).AppendLine();
        }

        builder.AppendLine("## Quickstart");
        builder.AppendLine();
        builder.AppendLine("```bash");
        builder.Append("# one-time: save your API key").AppendLine();
        builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" auth set <your-key>");
        builder.AppendLine();
        builder.AppendLine("# run a command");
        builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" <group> <command> [options]");
        builder.AppendLine();
        builder.AppendLine("# explore");
        builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" --help");
        builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" <group> --help");
        builder.AppendLine("```");
        builder.AppendLine();

        var groups = GroupOperations(ctx.Operations).ToList();
        builder.AppendLine("## Command groups");
        builder.AppendLine();
        builder.AppendLine("| Group | Operations | Summary |");
        builder.AppendLine("|-------|-----------:|---------|");
        foreach (var group in groups)
        {
            var slug = KebabCase(string.IsNullOrWhiteSpace(group.Key) ? "default" : group.Key);
            var summary = Escape(OneLine(group.Summary));
            builder.Append("| `").Append(slug).Append("` | ").Append(group.Count).Append(" | ")
                .Append(summary).AppendLine(" |");
        }
        builder.AppendLine();

        if (referenceCompanions)
        {
            builder.AppendLine("## References");
            builder.AppendLine();
            builder.AppendLine("- [commands.md](./commands.md) — full per-command reference (name, description, HTTP route).");
            builder.AppendLine("- [auth.md](./auth.md) — auth schemes detected in the spec + credential setup.");
            builder.AppendLine();
            builder.AppendLine("The bundled CLI also prints any of these on demand:");
            builder.AppendLine();
            builder.AppendLine("```bash");
            builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" skill          # SKILL.md");
            builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" skill commands # commands.md");
            builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" skill auth     # auth.md");
            builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" skill list     # list bundled skill files");
            builder.AppendLine("```");
            builder.AppendLine();
        }

        builder.AppendLine("## For agents");
        builder.AppendLine();
        builder.AppendLine("When the user asks to perform an operation against this API:");
        builder.AppendLine("1. Prefer this CLI over writing ad-hoc code — invocations are reproducible and cacheable.");
        builder.Append("2. Before the first call, verify credentials with `dnx ").Append(ctx.PackageId).AppendLine(" auth show`. If `source: none`, ask the user for their key.");
        builder.AppendLine("3. Use `--json` to get structured output for downstream parsing.");
        builder.AppendLine("4. For unfamiliar groups/commands, run `--help` on the group rather than guessing.");

        if (!string.IsNullOrWhiteSpace(ctx.Homepage))
        {
            builder.AppendLine();
            builder.AppendLine("## Links");
            builder.AppendLine();
            builder.Append("- Home: ").AppendLine(ctx.Homepage);
            builder.Append("- Package: https://www.nuget.org/packages/").AppendLine(ctx.PackageId);
        }

        return builder.ToString();
    }

    private static string BuildCommandsReference(BuildContext ctx)
    {
        var builder = new StringBuilder();
        builder.Append("# ").Append(ctx.Title).AppendLine(" — commands reference");
        builder.AppendLine();
        builder.AppendLine("Full per-command reference derived from the OpenAPI spec. For the short overview + credentials flow see [SKILL.md](./SKILL.md).");
        builder.AppendLine();

        var groups = GroupOperations(ctx.Operations).ToList();
        foreach (var group in groups)
        {
            var slug = KebabCase(string.IsNullOrWhiteSpace(group.Key) ? "default" : group.Key);
            builder.Append("## `").Append(slug).AppendLine("`");
            builder.AppendLine();
            if (!string.IsNullOrWhiteSpace(group.Summary))
            {
                builder.AppendLine(group.Summary).AppendLine();
            }

            builder.AppendLine("| Command | Route | Description |");
            builder.AppendLine("|---------|-------|-------------|");
            foreach (var operation in group.Operations)
            {
                var action = GetAction(operation);
                var route = $"`{operation.OperationType?.Method ?? "?"} {operation.OperationPath ?? string.Empty}`";
                var summaryText = operation.Operation?.Summary ?? operation.Operation?.Description ?? string.Empty;
                var description = Escape(OneLine(summaryText));
                builder.Append("| `").Append(action).Append("` | ").Append(route).Append(" | ")
                    .Append(description).AppendLine(" |");
            }
            builder.AppendLine();
        }

        builder.AppendLine("## Usage tips");
        builder.AppendLine();
        builder.AppendLine("Every group and command supports `--help`:");
        builder.AppendLine();
        builder.AppendLine("```bash");
        builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" <group> --help");
        builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" <group> <command> --help");
        builder.AppendLine("```");
        builder.AppendLine();
        builder.AppendLine("Pass `--json` to get raw SDK responses (useful for piping into `jq`). Pass `-o <path>` to write the output to a file instead of stdout.");

        return builder.ToString();
    }

    private static string BuildAuthReference(BuildContext ctx)
    {
        var builder = new StringBuilder();
        builder.Append("# ").Append(ctx.Title).AppendLine(" — authentication");
        builder.AppendLine();
        builder.Append("Credentials for `").Append(ctx.PackageId).AppendLine("` are resolved in this order:");
        builder.AppendLine();
        builder.AppendLine("1. `--api-key <key>` command-line flag.");
        builder.Append("2. `").Append(ctx.ApiKeyEnvVar).AppendLine("` environment variable.");
        builder.Append("3. `dotnet user-secrets` stored under id `").Append(ctx.PackageId).AppendLine("`.");
        builder.AppendLine();
        builder.AppendLine("## One-time setup");
        builder.AppendLine();
        builder.AppendLine("```bash");
        builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" auth set <your-key>");
        builder.Append("dnx ").Append(ctx.PackageId).AppendLine(" auth show");
        builder.AppendLine("```");
        builder.AppendLine();

        var schemes = DescribeSchemes(ctx.SecuritySchemes).ToList();
        if (schemes.Count > 0)
        {
            builder.AppendLine("## Detected auth schemes");
            builder.AppendLine();
            foreach (var line in schemes)
            {
                builder.Append("- ").AppendLine(line);
            }
            builder.AppendLine();
        }

        builder.AppendLine("## For agents");
        builder.AppendLine();
        builder.AppendLine("If the user hasn't configured credentials:");
        builder.AppendLine();
        builder.Append("1. Run `dnx ").Append(ctx.PackageId).AppendLine(" auth show`. If it reports `source: none`, ask the user for their key (format and source depend on the provider — see their docs).");
        builder.Append("2. Run `dnx ").Append(ctx.PackageId).AppendLine(" auth set <key>` to persist it.");
        builder.AppendLine("3. Confirm with `auth show` again before retrying the failed command.");
        return builder.ToString();
    }

    private static string BuildSingleFile(BuildContext ctx)
    {
        var builder = new StringBuilder();
        builder.Append(BuildSkillOverview(ctx, referenceCompanions: false));
        builder.AppendLine();
        builder.Append(BuildCommandsReference(ctx));
        builder.AppendLine();
        builder.Append(BuildAuthReference(ctx));
        return builder.ToString();
    }

    private sealed record GroupedOperations(string Key, string Summary, int Count, IReadOnlyList<OperationContext> Operations);

    private static IEnumerable<GroupedOperations> GroupOperations(IReadOnlyCollection<OperationContext> operations)
    {
        return operations
            .Where(op => op.Operation?.Deprecated != true)
            .GroupBy(GetGroupKey, StringComparer.Ordinal)
            .OrderBy(g => g.Key, StringComparer.Ordinal)
            .Select(g =>
            {
                var ordered = g.OrderBy(x => GetAction(x), StringComparer.Ordinal).ToList();
                var tag = g.First().Tag;
                var summary = !string.IsNullOrWhiteSpace(tag.Description)
                    ? tag.Description
                    : tag.DisplayName ?? string.Empty;
                return new GroupedOperations(
                    Key: g.Key,
                    Summary: summary ?? string.Empty,
                    Count: ordered.Count,
                    Operations: ordered);
            });
    }

    private static string DeriveSkillName(string packageId)
    {
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
        var core = packageId;
        if (core.EndsWith(".CLI", StringComparison.OrdinalIgnoreCase))
        {
            core = core[..^4];
        }

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
