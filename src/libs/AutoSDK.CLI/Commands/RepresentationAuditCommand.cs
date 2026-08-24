using System.CommandLine;
using System.Text.Json;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.CLI.Commands;

internal sealed class RepresentationAuditCommand : Command
{
    private static readonly JsonSerializerOptions s_jsonOptions = new()
    {
        WriteIndented = true,
    };

    private Argument<string> Input { get; } = new("input")
    {
        Description = "OpenAPI file, URL, or directory containing openapi.json/openapi.yaml files.",
    };

    private Option<string?> Output { get; } = new("--output")
    {
        Description = "Output file. Writes the report to standard output when omitted.",
    };

    private Option<string> Format { get; } = new("--format")
    {
        DefaultValueFactory = _ => "tsv",
        Description = "Machine-readable report format: tsv or json.",
    };

    public RepresentationAuditCommand()
        : base("audit-representations", "Audit OpenAPI request and response representation risks.")
    {
        Arguments.Add(Input);
        Options.Add(Output);
        Options.Add(Format);
        SetAction(HandleAsync);
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Design",
        "CA1031:Do not catch general exception types",
        Justification = "A fleet audit records per-document parse failures and must continue with the remaining specifications.")]
    private async Task HandleAsync(ParseResult parseResult)
    {
        var input = parseResult.GetRequiredValue(Input);
        var output = parseResult.GetValue(Output);
        var format = parseResult.GetRequiredValue(Format).ToUpperInvariant();
        if (format is not ("TSV" or "JSON"))
        {
            throw new ArgumentException("--format must be 'tsv' or 'json'.", nameof(parseResult));
        }

        var sources = ResolveSources(input).ToArray();
        var inputIsDirectory = Directory.Exists(input);
        var findings = new List<RepresentationAuditFinding>();
        using var client = new HttpClient();
        foreach (var source in sources)
        {
            var sourceLabel = inputIsDirectory
                ? Path.GetRelativePath(input, source)
                : source;
            try
            {
                var text = source.StartsWith("http", StringComparison.OrdinalIgnoreCase)
                    ? await client.GetStringAsync(new Uri(source)).ConfigureAwait(false)
                    : await File.ReadAllTextAsync(source).ConfigureAwait(false);
                var settings = Settings.Default with
                {
                    IgnoreOpenApiWarnings = true,
                };
                var document = text.GetOpenApiDocument(settings);
                var schemas = document.GetSchemas(settings);
                var operations = document.GetOperations(settings, settings, schemas);
                findings.AddRange(RepresentationRiskAuditor.Audit(sourceLabel, operations));
            }
            catch (Exception exception)
            {
                findings.Add(new RepresentationAuditFinding(
                    sourceLabel,
                    string.Empty,
                    string.Empty,
                    string.Empty,
                    "document",
                    "parse-error",
                    "error",
                    string.Empty,
                    string.Empty,
                    exception.Message));
            }
        }

        var ordered = findings
            .OrderBy(static finding => finding.Source, StringComparer.Ordinal)
            .ThenBy(static finding => finding.Path, StringComparer.Ordinal)
            .ThenBy(static finding => finding.Method, StringComparer.Ordinal)
            .ThenBy(static finding => finding.Direction, StringComparer.Ordinal)
            .ThenBy(static finding => finding.Code, StringComparer.Ordinal)
            .ThenBy(static finding => finding.MediaTypes, StringComparer.Ordinal)
            .ToArray();
        var report = format == "JSON" ? ToJson(ordered) : ToTsv(ordered);
        if (string.IsNullOrWhiteSpace(output))
        {
            await Console.Out.WriteAsync(report).ConfigureAwait(false);
        }
        else
        {
            var outputDirectory = Path.GetDirectoryName(Path.GetFullPath(output));
            if (!string.IsNullOrEmpty(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            await File.WriteAllTextAsync(output, report).ConfigureAwait(false);
        }

        var counts = ordered
            .GroupBy(static finding => finding.Code, StringComparer.Ordinal)
            .OrderBy(static group => group.Key, StringComparer.Ordinal)
            .Select(static group => $"{group.Key}={group.Count()}");
        await Console.Error.WriteLineAsync(
            $"Representation audit: files={sources.Length}, findings={ordered.Length}" +
            (ordered.Length == 0 ? string.Empty : $" ({string.Join(", ", counts)})")).ConfigureAwait(false);
    }

    private static IEnumerable<string> ResolveSources(string input)
    {
        if (input.StartsWith("http", StringComparison.OrdinalIgnoreCase) || File.Exists(input))
        {
            yield return input;
            yield break;
        }

        if (!Directory.Exists(input))
        {
            throw new FileNotFoundException($"OpenAPI input '{input}' was not found.", input);
        }

        foreach (var file in Directory.EnumerateFiles(input, "*", SearchOption.AllDirectories)
                     .Where(static file =>
                     {
                         var name = Path.GetFileName(file);
                         var extension = Path.GetExtension(file).ToUpperInvariant();
                         return (name.StartsWith("openapi.", StringComparison.OrdinalIgnoreCase) ||
                                 name.Contains(".openapi.", StringComparison.OrdinalIgnoreCase)) &&
                                extension is ".JSON" or ".YAML" or ".YML";
                     })
                     .OrderBy(static file => file, StringComparer.Ordinal))
        {
            yield return file;
        }
    }

    private static string ToJson(IReadOnlyList<RepresentationAuditFinding> findings)
    {
        return JsonSerializer.Serialize(findings, s_jsonOptions) + Environment.NewLine;
    }

    private static string ToTsv(IEnumerable<RepresentationAuditFinding> findings)
    {
        var lines = new List<string>
        {
            "source\toperation_id\tmethod\tpath\tdirection\tcode\tseverity\tselected_media_type\tmedia_types\tdetails",
        };
        lines.AddRange(findings.Select(static finding => string.Join("\t",
            EscapeTsv(finding.Source),
            EscapeTsv(finding.OperationId),
            EscapeTsv(finding.Method),
            EscapeTsv(finding.Path),
            EscapeTsv(finding.Direction),
            EscapeTsv(finding.Code),
            EscapeTsv(finding.Severity),
            EscapeTsv(finding.SelectedMediaType),
            EscapeTsv(finding.MediaTypes),
            EscapeTsv(finding.Details))));
        return string.Join(Environment.NewLine, lines) + Environment.NewLine;
    }

    private static string EscapeTsv(string value)
    {
        return value.Replace('\t', ' ').Replace('\r', ' ').Replace('\n', ' ');
    }
}
