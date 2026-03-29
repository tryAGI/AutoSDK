//HintName: G.Commands.LLMsTxtGenerateLLMsTxtCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LLMsTxtGenerateLLMsTxtCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string url,
            int? maxUrls,
            bool? showFullText,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GenerateLLMsTxtResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Url { get; } = new(
            name: "url")
        {
            Description = @"The URL to generate LLMs.txt from",
        };

        private global::System.CommandLine.Option<int?> MaxUrls { get; } = new(
            name: "maxUrls")
        {
            Description = @"Maximum number of URLs to analyze",
        };

        private global::System.CommandLine.Option<bool?> ShowFullText { get; } = new(
            name: "showFullText")
        {
            Description = @"Include full text content in the response",
        };


        public LLMsTxtGenerateLLMsTxtCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "generate",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Url);
            Options.Add(MaxUrls);
            Options.Add(ShowFullText);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var url = parseResult.GetRequiredValue(Url);
            var maxUrls = parseResult.GetRequiredValue(MaxUrls);
            var showFullText = parseResult.GetRequiredValue(ShowFullText);

            Validate(
                parseResult: parseResult,
                url: url,
                maxUrls: maxUrls,
                showFullText: showFullText,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.LLMsTxt.GenerateLLMsTxtAsync(
                url: url,
                maxUrls: maxUrls,
                showFullText: showFullText,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}