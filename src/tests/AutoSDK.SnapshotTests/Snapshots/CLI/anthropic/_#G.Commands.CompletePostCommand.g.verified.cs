//HintName: G.Commands.CompletePostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CompletePostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The prompt that you want Claude to complete.

For proper response generation you will need to format your prompt using alternating `\n\nHuman:` and `\n\nAssistant:` conversational turns. For example:

```
""\n\nHuman: {userQuestion}\n\nAssistant:""
```

See [prompt validation](https://docs.anthropic.com/en/api/prompt-validation) and our guide to [prompt design](https://docs.anthropic.com/en/docs/intro-to-prompting) for more details.",
        };

        private global::System.CommandLine.Argument<int> MaxTokensToSample { get; } = new(
            name: "maxTokensToSample")
        {
            Description = @"The maximum number of tokens to generate before stopping.

Note that our models may stop _before_ reaching this maximum. This parameter only specifies the absolute maximum number of tokens to generate.",
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
            Description = @"Sequences that will cause the model to stop generating.

Our models stop on `""\n\nHuman:""`, and may include additional built-in stop sequences in the future. By providing the stop_sequences parameter, you may include additional strings that will cause the model to stop generating.",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Amount of randomness injected into the response.

Defaults to `1.0`. Ranges from `0.0` to `1.0`. Use `temperature` closer to `0.0` for analytical / multiple choice, and closer to `1.0` for creative and generative tasks.

Note that even with `temperature` of `0.0`, the results will not be fully deterministic.",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"Use nucleus sampling.

In nucleus sampling, we compute the cumulative distribution over all the options for each subsequent token in decreasing probability order and cut it off once it reaches a particular probability specified by `top_p`. You should either alter `temperature` or `top_p`, but not both.

Recommended for advanced use cases only. You usually only need to use `temperature`.",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"Only sample from the top K options for each subsequent token.

Used to remove ""long tail"" low probability responses. [Learn more technical details here](https://towardsdatascience.com/how-to-sample-from-language-models-682bceb97277).

Recommended for advanced use cases only. You usually only need to use `temperature`.",
        };

        private global::System.CommandLine.Option<global::G.Metadata?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"An object describing metadata about the request.",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"Whether to incrementally stream the response using server-sent events.

See [streaming](https://docs.anthropic.com/en/api/streaming) for details.",
        };
        public CompletePostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "complete",
            description: @"[Legacy] Create a Text Completion.

The Text Completions API is a legacy API. We recommend using the [Messages API](https://docs.anthropic.com/en/api/messages) going forward.

Future models and features will not be compatible with Text Completions. See our [migration guide](https://docs.anthropic.com/en/api/migrating-from-text-completions-to-messages) for guidance in migrating from Text Completions to Messages.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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