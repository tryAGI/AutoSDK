//HintName: G.Commands.BetaMessagesPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BetaMessagesPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? anthropicBeta,
            string? anthropicVersion,
            global::G.Model model,
            global::System.Collections.Generic.IList<global::G.BetaInputMessage> messages,
            int maxTokens,
            global::G.BetaMetadata? metadata,
            global::System.Collections.Generic.IList<string>? stopSequences,
            bool? stream,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.BetaRequestTextBlock>>? system,
            double? temperature,
            global::G.BetaThinkingConfigParam? thinking,
            global::G.BetaToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::G.ToolsItem2>? tools,
            int? topK,
            double? topP,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BetaMessage response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.Model> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.BetaInputMessage>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> AnthropicBeta { get; } = new(
            name: "anthropicBeta")
        {
            Description = @"Optional header to specify the beta version(s) you want to use.

To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = @"The version of the Anthropic API you want to use.

Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).",
        };

        private global::System.CommandLine.Option<global::G.BetaMetadata?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> StopSequences { get; } = new(
            name: "stopSequences")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.BetaRequestTextBlock>>?> System { get; } = new(
            name: "system")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.BetaThinkingConfigParam?> Thinking { get; } = new(
            name: "thinking")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.BetaToolChoice?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ToolsItem2>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"",
        };
        public BetaMessagesPostCommand(G.IApi client) : base(
            name: "beta",
            description: @"Send a structured list of input messages with text and/or image content, and the model will generate the next message in the conversation.

The Messages API can be used for either single queries or stateless multi-turn conversations.

Learn more about the Messages API in our [user guide](/en/docs/initial-setup)")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(Messages);
            Arguments.Add(MaxTokens);
            Options.Add(AnthropicBeta);
            Options.Add(AnthropicVersion);
            Options.Add(Metadata);
            Options.Add(StopSequences);
            Options.Add(Stream);
            Options.Add(System);
            Options.Add(Temperature);
            Options.Add(Thinking);
            Options.Add(ToolChoice);
            Options.Add(Tools);
            Options.Add(TopK);
            Options.Add(TopP);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var anthropicBeta = parseResult.GetRequiredValue(AnthropicBeta);
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);
            var model = parseResult.GetRequiredValue(Model);
            var messages = parseResult.GetRequiredValue(Messages);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var stopSequences = parseResult.GetRequiredValue(StopSequences);
            var stream = parseResult.GetRequiredValue(Stream);
            var system = parseResult.GetRequiredValue(System);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var thinking = parseResult.GetRequiredValue(Thinking);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var tools = parseResult.GetRequiredValue(Tools);
            var topK = parseResult.GetRequiredValue(TopK);
            var topP = parseResult.GetRequiredValue(TopP);

            Validate(
                parseResult: parseResult,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                model: model,
                messages: messages,
                maxTokens: maxTokens,
                metadata: metadata,
                stopSequences: stopSequences,
                stream: stream,
                system: system,
                temperature: temperature,
                thinking: thinking,
                toolChoice: toolChoice,
                tools: tools,
                topK: topK,
                topP: topP,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Messages.BetaMessagesPostAsync(
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                model: model,
                messages: messages,
                maxTokens: maxTokens,
                metadata: metadata,
                stopSequences: stopSequences,
                stream: stream,
                system: system,
                temperature: temperature,
                thinking: thinking,
                toolChoice: toolChoice,
                tools: tools,
                topK: topK,
                topP: topP,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}