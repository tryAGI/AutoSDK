//HintName: G.Commands.MessagesPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MessagesPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? anthropicVersion,
            global::G.Model model,
            global::System.Collections.Generic.IList<global::G.InputMessage> messages,
            int maxTokens,
            global::G.Metadata? metadata,
            global::System.Collections.Generic.IList<string>? stopSequences,
            bool? stream,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.RequestTextBlock>>? system,
            double? temperature,
            global::G.ThinkingConfigParam? thinking,
            global::G.ToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.Tool, global::G.BashTool20250124, global::G.TextEditor20250124>>? tools,
            int? topK,
            double? topP,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Message response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.Model> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.InputMessage>> Messages { get; } = new(
            name: "messages")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.Metadata?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> StopSequences { get; } = new(
            name: "stopSequences")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.RequestTextBlock>>?> System { get; } = new(
            name: "system")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ThinkingConfigParam?> Thinking { get; } = new(
            name: "thinking")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ToolChoice?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.OneOf<global::G.Tool, global::G.BashTool20250124, global::G.TextEditor20250124>>?> Tools { get; } = new(
            name: "tools")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = "",
        };
        public MessagesPostCommand(G.IApi client) : base(
            name: "messages",
            description: @"Send a structured list of input messages with text and/or image content, and the model will generate the next message in the conversation.

The Messages API can be used for either single queries or stateless multi-turn conversations.

Learn more about the Messages API in our [user guide](/en/docs/initial-setup)")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(Messages);
            Arguments.Add(MaxTokens);
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
            var response = await _client.Messages.MessagesPostAsync(
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