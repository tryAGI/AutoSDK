using System.CommandLine;
using Firecrawl;
using tryAGI.OpenAI;

namespace AutoSDK.CLI.Commands.AI;

internal sealed class SpecFromDocsCommand : Command
{
    private Argument<Uri> Input { get; } = new(
        name: "url")
    {
        DefaultValueFactory = _ => new Uri("https://example.com"),
        Description = "Input url",
    };

    private Option<string> Output { get; } = new(
        name: "--output",
        aliases: ["-o"])
    {
        DefaultValueFactory = _ => "generated.yaml",
        Description = "Output file path",
    };
    
    public SpecFromDocsCommand() : base(name: "spec-from-docs", description: "Generates OpenAPI spec from SPA HTML docs.")
    {
        Arguments.Add(Input);
        Options.Add(Output);

        SetAction(HandleAsync);
    }

    private async Task HandleAsync(
        ParseResult parseResult)
    {
        var uri = parseResult.GetRequiredValue(Input);
        var outputPath = parseResult.GetRequiredValue(Output);

        Console.WriteLine($"Loading {uri}...");
        
        using var firecrawlApi = new FirecrawlApp(apiKey:
            Environment.GetEnvironmentVariable("FIRECRAWL_API_KEY") ??
            throw new InvalidOperationException("Please set FIRECRAWL_API_KEY environment variable."));
        var firecrawlResponse = await firecrawlApi.Scraping.ScrapeAndExtractFromUrlAsync(
            new Firecrawl.AllOf<ScrapeAndExtractFromUrlRequest2, ScrapeOptions>
            {
                Value1 = new ScrapeAndExtractFromUrlRequest2
                {
                    Url = uri.ToString(),
                },
                Value2 = new ScrapeOptions
                {
                    WaitFor = 15000,
                }
            }).ConfigureAwait(false);

        var markdown = firecrawlResponse.Data?.Markdown ?? throw new InvalidOperationException("No markdown data found.");
        
        var markdownPath = new FileInfo("temp.md");
        await File.WriteAllTextAsync(markdownPath.FullName, markdown).ConfigureAwait(false);
        
        Console.WriteLine($"Markdown: {new Uri(markdownPath.FullName).AbsoluteUri}");
        
        Console.WriteLine("Generating...");
        
        using var openAiApi = new OpenAiClient(apiKey:
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new InvalidOperationException("Please set OPENAI_API_KEY environment variable."));

        var openAiResponse = await openAiApi.Chat.CreateChatCompletionAsAsync<OpenApiSpecResponse>(
            model: CreateChatCompletionRequestModel.Gpt4o20240806,
            messages:
            [
                "Please convert this markdown to valid OpenAPI 3.0 schema.",
                markdown,
            ],
            strict: true).ConfigureAwait(false);
        if (openAiResponse.Value1 is null)
        {
            throw new InvalidOperationException("No response from OpenAI.");
        }
        
        var yamlSpec = openAiResponse.Value1.YamlSpecFullBody;

        var outputPathInfo = new FileInfo(outputPath);
        await File.WriteAllTextAsync(outputPath, yamlSpec).ConfigureAwait(false);
        
        Console.WriteLine($"Done: {new Uri(outputPathInfo.FullName).AbsoluteUri}");
    }
}

internal sealed class OpenApiSpecResponse
{
    public string YamlSpecFullBody { get; set; } = string.Empty;
}