//HintName: G.Commands.CompletePostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CompletePostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? anthropicVersion,
            global::G.Model model,
            string prompt,
            int maxTokensToSample,
            global::System.Collections.Generic.IList<string>? stopSequences,
            double? temperature,
            double? topP,
            int? topK,
            global::G.Metadata? metadata,
            bool? stream,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CompletionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.Model> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> MaxTokensToSample { get; } = new(
            name: "maxTokensToSample")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = @"The version of the Anthropic API you want to use.

Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> StopSequences { get; } = new(
            name: "stopSequences")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.Metadata?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"",
        };
        public CompletePostCommand(G.IApi client) : base(
            name: "complete",
            description: @"[Legacy] Create a Text Completion.

The Text Completions API is a legacy API. We recommend using the [Messages API](https://docs.anthropic.com/en/api/messages) going forward.

Future models and features will not be compatible with Text Completions. See our [migration guide](https://docs.anthropic.com/en/api/migrating-from-text-completions-to-messages) for guidance in migrating from Text Completions to Messages.")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(Prompt);
            Arguments.Add(MaxTokensToSample);
            Options.Add(AnthropicVersion);
            Options.Add(StopSequences);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(TopK);
            Options.Add(Metadata);
            Options.Add(Stream);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);
            var model = parseResult.GetRequiredValue(Model);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var maxTokensToSample = parseResult.GetRequiredValue(MaxTokensToSample);
            var stopSequences = parseResult.GetRequiredValue(StopSequences);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var topK = parseResult.GetRequiredValue(TopK);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var stream = parseResult.GetRequiredValue(Stream);

            Validate(
                parseResult: parseResult,
                anthropicVersion: anthropicVersion,
                model: model,
                prompt: prompt,
                maxTokensToSample: maxTokensToSample,
                stopSequences: stopSequences,
                temperature: temperature,
                topP: topP,
                topK: topK,
                metadata: metadata,
                stream: stream,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TextCompletions.CompletePostAsync(
                anthropicVersion: anthropicVersion,
                model: model,
                prompt: prompt,
                maxTokensToSample: maxTokensToSample,
                stopSequences: stopSequences,
                temperature: temperature,
                topP: topP,
                topK: topK,
                metadata: metadata,
                stream: stream,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}