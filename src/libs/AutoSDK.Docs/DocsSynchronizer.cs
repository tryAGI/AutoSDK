using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AutoSDK.Docs;

public static class DocsSynchronizer
{
    public static async Task<DocsSyncResult> SyncAsync(
        string solutionDirectory,
        string? configPath = null,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(solutionDirectory))
        {
            throw new ArgumentException("Solution directory must not be empty.", nameof(solutionDirectory));
        }

        var fullSolutionDirectory = Path.GetFullPath(solutionDirectory);
        var config = await DocsConfig.LoadAsync(fullSolutionDirectory, configPath, cancellationToken).ConfigureAwait(false);
        var project = ResolvedProject.Create(fullSolutionDirectory, config);

        Directory.CreateDirectory(project.DocsDirectory);

        return await SyncMetadataExamplesAsync(project, cancellationToken).ConfigureAwait(false);
    }

    private static async Task<DocsSyncResult> SyncMetadataExamplesAsync(
        ResolvedProject project,
        CancellationToken cancellationToken)
    {
        Directory.CreateDirectory(project.OutputDirectory);
        DeleteMarkdownFiles(project.OutputDirectory);

        // Clean up legacy output directories if they exist
        var legacyOutputDirectory = Path.Combine(project.DocsDirectory, "samples");
        DeleteDirectoryIfExists(legacyOutputDirectory);

        var examples = new List<MetadataExampleDocument>();
        if (Directory.Exists(project.ExampleSourceDirectory))
        {
            foreach (var path in Directory.EnumerateFiles(project.ExampleSourceDirectory, "*.cs", SearchOption.AllDirectories))
            {
                var example = await TryLoadMetadataExampleAsync(path, project.ClientClassName, project.ApiKeyVariableName, project.ClientReplacements, cancellationToken).ConfigureAwait(false);
                if (example is not null)
                {
                    examples.Add(example);
                }
            }
            examples = examples
                .OrderBy(x => x.Order)
                .ThenBy(x => x.Title, StringComparer.Ordinal)
                .ToList();
        }

        var readme = NormalizeNewlines(await File.ReadAllTextAsync(project.ReadmePath, cancellationToken).ConfigureAwait(false));
        if (HasMarkerBlock(readme, project.ReadmeExamplesStartMarker, project.ReadmeExamplesEndMarker))
        {
            readme = ReplaceBlock(
                readme,
                project.ReadmeExamplesStartMarker,
                project.ReadmeExamplesEndMarker,
                BuildReadmeExamples(examples));
            await File.WriteAllTextAsync(project.ReadmePath, readme, cancellationToken).ConfigureAwait(false);
        }

        await File.WriteAllTextAsync(Path.Combine(project.DocsDirectory, "index.md"), readme, cancellationToken).ConfigureAwait(false);

        foreach (var example in examples)
        {
            var page = BuildExamplePage(example, project.ExampleIntro);
            var path = Path.Combine(project.OutputDirectory, $"{example.Slug}.md");
            await File.WriteAllTextAsync(path, page, cancellationToken).ConfigureAwait(false);
        }

        var mkDocs = NormalizeNewlines(await File.ReadAllTextAsync(project.MkDocsPath, cancellationToken).ConfigureAwait(false));
        mkDocs = ReplaceBlockOrPlaceholder(
            mkDocs,
            project.MkDocsExamplesStartMarker,
            project.MkDocsExamplesEndMarker,
            "# EXAMPLES #",
            BuildMkDocsExamples(examples.Select(x => (x.Title, $"examples/{x.Slug}.md")).ToList()));
        await File.WriteAllTextAsync(project.MkDocsPath, mkDocs, cancellationToken).ConfigureAwait(false);

        return new DocsSyncResult("metadata", examples.Count, project.OutputDirectory);
    }

    private static async Task<MetadataExampleDocument?> TryLoadMetadataExampleAsync(
        string path,
        string clientClassName,
        string apiKeyVariableName,
        IReadOnlyDictionary<string, string>? clientReplacements,
        CancellationToken cancellationToken = default)
    {
        var text = NormalizeNewlines(await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false));
        var metadata = ExampleMetadata.TryParse(text, path);

        var title = metadata?.Title ?? Path.GetFileNameWithoutExtension(path);
        var order = metadata?.Order ?? 0;
        var slug = metadata?.Slug ?? ExampleMetadata.Slugify(title);
        var description = metadata?.Description ?? string.Empty;

        var body = TryExtractSingleTestMethodBody(text);
        if (body is null)
        {
            return null;
        }

        return new MetadataExampleDocument(
            order,
            title,
            slug,
            description,
            TransformCode(body, clientClassName, apiKeyVariableName, clientReplacements));
    }

    private static string? TryExtractSingleTestMethodBody(string text)
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(text);
        var root = syntaxTree.GetRoot();
        var methods = root
            .DescendantNodes()
            .OfType<MethodDeclarationSyntax>()
            .Where(HasTestMethodAttribute)
            .ToList();

        if (methods.Count != 1)
        {
            return null;
        }

        var method = methods[0];
        if (method.Body is null)
        {
            return null;
        }

        return text[method.Body.OpenBraceToken.Span.End..method.Body.CloseBraceToken.Span.Start];
    }

    private static bool HasTestMethodAttribute(MethodDeclarationSyntax method)
    {
        return method.AttributeLists
            .SelectMany(x => x.Attributes)
            .Select(x => x.Name.ToString())
            .Any(x =>
                x.EndsWith("Test", StringComparison.Ordinal) ||
                x.EndsWith("TestMethod", StringComparison.Ordinal) ||
                x.EndsWith("TestAttribute", StringComparison.Ordinal) ||
                x.EndsWith("TestMethodAttribute", StringComparison.Ordinal));
    }

    private static string TransformCode(
        string code,
        string clientClassName,
        string apiKeyVariableName,
        IReadOnlyDictionary<string, string>? clientReplacements = null)
    {
        var lines = Deindent(code)
            .Split('\n')
            .Select(line => line.TrimEnd())
            .ToList();

        var output = new List<string>(lines.Count);
        var previousWasBlank = false;
        var replacement = $"new {clientClassName}({apiKeyVariableName})";

        foreach (var originalLine in lines)
        {
            var line = originalLine
                .Replace("using var client = GetAuthenticatedClient();", $"using var client = {replacement};", StringComparison.Ordinal)
                .Replace("var client = GetAuthenticatedClient();", $"var client = {replacement};", StringComparison.Ordinal)
                .Replace("GetAuthenticatedClient()", replacement, StringComparison.Ordinal);

            if (clientReplacements is not null)
            {
                foreach (var (pattern, className) in clientReplacements)
                {
                    var customReplacement = $"new {className}({apiKeyVariableName})";
                    line = line
                        .Replace($"using var client = {pattern};", $"using var client = {customReplacement};", StringComparison.Ordinal)
                        .Replace($"var client = {pattern};", $"var client = {customReplacement};", StringComparison.Ordinal)
                        .Replace(pattern, customReplacement, StringComparison.Ordinal);
                }
            }

            line = line.Replace("////", "//", StringComparison.Ordinal);

            var trimmed = line.Trim();
            if (trimmed.Contains(".Should()", StringComparison.Ordinal) ||
                trimmed.Contains(".Should(", StringComparison.Ordinal) ||
                trimmed.StartsWith("Assert.", StringComparison.Ordinal) ||
                trimmed.Contains("GetApiKey()", StringComparison.Ordinal))
            {
                continue;
            }

            if (string.IsNullOrWhiteSpace(line))
            {
                if (previousWasBlank)
                {
                    continue;
                }

                previousWasBlank = true;
                output.Add(string.Empty);
                continue;
            }

            previousWasBlank = false;
            output.Add(line);
        }

        return string.Join('\n', output).Trim();
    }

    private static string BuildReadmeExamples(List<MetadataExampleDocument> examples)
    {
        var builder = new StringBuilder();

        for (var index = 0; index < examples.Count; index++)
        {
            var example = examples[index];
            builder.Append("### ");
            builder.AppendLine(example.Title);
            builder.AppendLine(example.Description);
            builder.AppendLine();
            builder.AppendLine("```csharp");
            builder.AppendLine(example.Code);
            builder.AppendLine("```");

            if (index < examples.Count - 1)
            {
                builder.AppendLine();
            }
        }

        return builder.ToString().TrimEnd();
    }

    private static string BuildExamplePage(MetadataExampleDocument example, string exampleIntro)
    {
        var builder = new StringBuilder();
        builder.Append("# ");
        builder.AppendLine(example.Title);
        builder.AppendLine();
        builder.AppendLine(example.Description);
        builder.AppendLine();
        builder.AppendLine(exampleIntro);
        builder.AppendLine();
        builder.AppendLine("```csharp");
        builder.AppendLine(example.Code);
        builder.AppendLine("```");
        return builder.ToString().TrimEnd();
    }

    private static string BuildMkDocsExamples(List<(string Title, string RelativePath)> entries)
    {
        if (entries.Count == 0)
        {
            return string.Empty;
        }

        var builder = new StringBuilder();
        builder.AppendLine("- Examples:");

        foreach (var entry in entries)
        {
            builder.Append("  - ");
            builder.Append(entry.Title);
            builder.Append(": ");
            builder.AppendLine(entry.RelativePath);
        }

        return builder.ToString().TrimEnd();
    }

    private static bool HasMarkerBlock(string content, string startMarker, string endMarker)
    {
        return content.Contains(startMarker, StringComparison.Ordinal) &&
               content.Contains(endMarker, StringComparison.Ordinal);
    }

    private static string ReplaceBlockOrPlaceholder(
        string content,
        string startMarker,
        string endMarker,
        string placeholder,
        string replacement)
    {
        const string legacyStartMarker = "# START EXAMPLES #";
        const string legacyEndMarker = "# END EXAMPLES #";

        if (HasMarkerBlock(content, startMarker, endMarker))
        {
            return ReplaceBlock(content, startMarker, endMarker, replacement);
        }

        if (HasMarkerBlock(content, legacyStartMarker, legacyEndMarker))
        {
            return ReplaceBlock(content, legacyStartMarker, legacyEndMarker, replacement);
        }

        if (content.Contains(placeholder, StringComparison.Ordinal))
        {
            return content.Replace(placeholder, replacement, StringComparison.Ordinal);
        }

        throw new InvalidOperationException(
            $"Neither marker block '{startMarker}'/'{endMarker}' nor placeholder '{placeholder}' was found.");
    }

    private static string ReplaceBlock(
        string content,
        string startMarker,
        string endMarker,
        string replacement)
    {
        var start = content.IndexOf(startMarker, StringComparison.Ordinal);
        if (start < 0)
        {
            throw new InvalidOperationException($"Start marker '{startMarker}' was not found.");
        }

        var end = content.IndexOf(endMarker, start + startMarker.Length, StringComparison.Ordinal);
        if (end < 0)
        {
            throw new InvalidOperationException($"End marker '{endMarker}' was not found.");
        }

        var before = content[..(start + startMarker.Length)];
        var after = content[end..];

        return $"{before}\n{replacement}\n{after}";
    }

    private static string Deindent(string text)
    {
        var lines = NormalizeNewlines(text).Split('\n').ToList();

        while (lines.Count > 0 && string.IsNullOrWhiteSpace(lines[0]))
        {
            lines.RemoveAt(0);
        }

        while (lines.Count > 0 && string.IsNullOrWhiteSpace(lines[^1]))
        {
            lines.RemoveAt(lines.Count - 1);
        }

        var indentation = lines
            .Where(line => !string.IsNullOrWhiteSpace(line))
            .Select(line => line.TakeWhile(char.IsWhiteSpace).Count())
            .DefaultIfEmpty(0)
            .Min();

        return string.Join(
            '\n',
            lines.Select(line => line.Length >= indentation ? line[indentation..] : line));
    }

    private static string NormalizeNewlines(string text)
    {
        return text.Replace("\r\n", "\n", StringComparison.Ordinal);
    }

    private static void DeleteMarkdownFiles(string directory)
    {
        if (!Directory.Exists(directory))
        {
            return;
        }

        foreach (var path in Directory.EnumerateFiles(directory, "*.md", SearchOption.TopDirectoryOnly))
        {
            File.Delete(path);
        }
    }

    private static void DeleteDirectoryIfExists(string directory)
    {
        if (Directory.Exists(directory))
        {
            Directory.Delete(directory, recursive: true);
        }
    }

    internal sealed record MetadataExampleDocument(
        int Order,
        string Title,
        string Slug,
        string Description,
        string Code);

    internal sealed record ExampleMetadata(int Order, string Title, string Slug, string Description)
    {
        public static ExampleMetadata? TryParse(string text, string path)
        {
            var match = Regex.Match(text, @"^\s*/\*(.*?)\*/", RegexOptions.Singleline);
            if (!match.Success)
            {
                return null;
            }

            var lines = match.Groups[1].Value
                .Replace("\r\n", "\n", StringComparison.Ordinal)
                .Trim()
                .Split('\n')
                .Select(x => x.Trim())
                .ToList();

            var values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var index = 0;

            for (; index < lines.Count; index++)
            {
                var line = lines[index];
                if (string.IsNullOrWhiteSpace(line))
                {
                    index++;
                    break;
                }

                var separatorIndex = line.IndexOf(':', StringComparison.Ordinal);
                if (separatorIndex < 0)
                {
                    // Not valid metadata — treat as no front matter
                    return null;
                }

                var key = line[..separatorIndex].Trim();
                var value = line[(separatorIndex + 1)..].Trim();
                values[key] = value;
            }

            var description = string.Join('\n', lines.Skip(index)).Trim();
            if (!values.TryGetValue("title", out var title) || string.IsNullOrWhiteSpace(title))
            {
                // No title means this isn't valid front matter
                return null;
            }

            var slug = values.TryGetValue("slug", out var explicitSlug) && !string.IsNullOrWhiteSpace(explicitSlug)
                ? explicitSlug
                : Slugify(title);

            var order = values.TryGetValue("order", out var orderValue) && int.TryParse(orderValue, out var parsedOrder)
                ? parsedOrder
                : 0;

            return new ExampleMetadata(order, title, slug, description);
        }

        public static string Slugify(string value)
        {
            var slug = string.Concat(value.Select(char.ToLowerInvariant));
            slug = Regex.Replace(slug, @"[^a-z0-9]+", "-");
            return slug.Trim('-');
        }
    }

    internal sealed record ResolvedProject(
        string SolutionDirectory,
        string ReadmePath,
        string MkDocsPath,
        string DocsDirectory,
        string ExampleSourceDirectory,
        string OutputDirectory,
        string Namespace,
        string BrandName,
        string ClientClassName,
        string ApiKeyVariableName,
        string ExampleIntro,
        string ReadmeExamplesStartMarker,
        string ReadmeExamplesEndMarker,
        string MkDocsExamplesStartMarker,
        string MkDocsExamplesEndMarker,
        IReadOnlyDictionary<string, string>? ClientReplacements)
    {
        public static ResolvedProject Create(string solutionDirectory, DocsConfig config)
        {
            var docsDirectory = Path.Combine(solutionDirectory, "docs");
            var exampleSourceDirectory = ResolvePath(
                solutionDirectory,
                config.ExampleSourceDirectory,
                Path.Combine(solutionDirectory, "src", "tests", "IntegrationTests", "Examples"));
            var outputDirectory = ResolvePath(
                solutionDirectory,
                config.DocsExamplesDirectory,
                Path.Combine(docsDirectory, "examples"));

            var namespaceValue = config.Namespace ?? InferNamespace(solutionDirectory);
            var brandName = config.BrandName ?? namespaceValue;
            var apiKeyVariableName = config.ApiKeyVariableName ?? "apiKey";
            var clientClassName = config.ClientClassName ?? InferClientClassName(solutionDirectory) ?? $"{namespaceValue}Client";
            var exampleIntro = config.ExampleIntro ??
                               $"This example assumes `using {namespaceValue};` is in scope and `{apiKeyVariableName}` contains your {brandName} API key.";

            return new ResolvedProject(
                solutionDirectory,
                Path.Combine(solutionDirectory, "README.md"),
                Path.Combine(solutionDirectory, "mkdocs.yml"),
                docsDirectory,
                exampleSourceDirectory,
                outputDirectory,
                namespaceValue,
                brandName,
                clientClassName,
                apiKeyVariableName,
                exampleIntro,
                config.ReadmeExamplesStartMarker ?? "<!-- EXAMPLES:START -->",
                config.ReadmeExamplesEndMarker ?? "<!-- EXAMPLES:END -->",
                config.MkDocsExamplesStartMarker ?? "# EXAMPLES:START",
                config.MkDocsExamplesEndMarker ?? "# EXAMPLES:END",
                config.ClientReplacements);
        }

        private static string ResolvePath(string solutionDirectory, string? configuredPath, string defaultPath)
        {
            if (string.IsNullOrWhiteSpace(configuredPath))
            {
                return defaultPath;
            }

            return Path.IsPathRooted(configuredPath)
                ? configuredPath
                : Path.GetFullPath(Path.Combine(solutionDirectory, configuredPath));
        }

        private static string InferNamespace(string solutionDirectory)
        {
            var configuredNamespace = TryReadGenerateArgument(solutionDirectory, "--namespace");
            if (!string.IsNullOrWhiteSpace(configuredNamespace))
            {
                return configuredNamespace;
            }

            var libsDirectory = Path.Combine(solutionDirectory, "src", "libs");
            if (Directory.Exists(libsDirectory))
            {
                var project = Directory
                    .EnumerateFiles(libsDirectory, "*.csproj", SearchOption.AllDirectories)
                    .Where(path => !Path.GetFileNameWithoutExtension(path).EndsWith(".Cli", StringComparison.Ordinal))
                    .OrderBy(path => path.Count(x => x == Path.DirectorySeparatorChar || x == Path.AltDirectorySeparatorChar))
                    .ThenBy(path => path, StringComparer.Ordinal)
                    .FirstOrDefault();

                if (!string.IsNullOrWhiteSpace(project))
                {
                    return Path.GetFileNameWithoutExtension(project);
                }
            }

            return new DirectoryInfo(solutionDirectory).Name;
        }

        private static string? InferClientClassName(string solutionDirectory)
        {
            return TryReadGenerateArgument(solutionDirectory, "--clientClassName");
        }

        private static string? TryReadGenerateArgument(string solutionDirectory, string argumentName)
        {
            var libsDirectory = Path.Combine(solutionDirectory, "src", "libs");
            if (!Directory.Exists(libsDirectory))
            {
                return null;
            }

            var scriptPath = Directory
                .EnumerateFiles(libsDirectory, "generate.sh", SearchOption.AllDirectories)
                .OrderBy(path => path.Count(x => x == Path.DirectorySeparatorChar || x == Path.AltDirectorySeparatorChar))
                .ThenBy(path => path, StringComparer.Ordinal)
                .FirstOrDefault();

            if (string.IsNullOrWhiteSpace(scriptPath))
            {
                return null;
            }

            var text = File.ReadAllText(scriptPath);
            var match = Regex.Match(
                text,
                $@"{Regex.Escape(argumentName)}\s+([^\s\\]+)",
                RegexOptions.CultureInvariant);

            return match.Success
                ? match.Groups[1].Value.Trim()
                : null;
        }
    }
}
