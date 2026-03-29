//HintName: G.Commands.OllamaListModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OllamaListModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string baseUrl,
            string? apiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IList<global::G.OllamaModel> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BaseUrl { get; } = new(
            name: "baseUrl")
        {
            Description = @"Base URL of the Ollama instance. May include /v1 suffix which will be automatically removed for connection testing. For inference, use the URL with /v1 suffix for OpenAI-compatible endpoints.",
        };

        private global::System.CommandLine.Option<string?> ApiKey { get; } = new(
            name: "apiKey")
        {
            Description = @"Optional API key for authenticated Ollama instances. If provided, will be sent as Bearer token in Authorization header.",
        };


        public OllamaListModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Fetches the list of models available from the Ollama instance. URL may be provided with or without /v1 suffix (e.g., http://localhost:11434 or http://localhost:11434/v1). The /v1 suffix will be automatically removed for model discovery. For actual LLM inference, use the URL with /v1 suffix for OpenAI-compatible endpoints.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BaseUrl);
            Options.Add(ApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var baseUrl = parseResult.GetRequiredValue(BaseUrl);
            var apiKey = parseResult.GetRequiredValue(ApiKey);

            Validate(
                parseResult: parseResult,
                baseUrl: baseUrl,
                apiKey: apiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Ollama.ListModelsAsync(
                baseUrl: baseUrl,
                apiKey: apiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}