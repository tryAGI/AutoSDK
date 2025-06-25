//HintName: G.Commands.MessagesCountTokensPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MessagesCountTokensPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? anthropicVersion,
            global::G.ToolChoice? toolChoice,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.Tool, global::G.BashTool20250124, global::G.TextEditor20250124>>? tools,
            global::System.Collections.Generic.IList<global::G.InputMessage> messages,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.RequestTextBlock>>? system,
            global::G.ThinkingConfigParam? thinking,
            global::G.Model model,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CountMessageTokensResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.InputMessage>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.Model> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = @"The version of the Anthropic API you want to use.

Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).",
        };

        private global::System.CommandLine.Option<global::G.ToolChoice?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.OneOf<global::G.Tool, global::G.BashTool20250124, global::G.TextEditor20250124>>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.RequestTextBlock>>?> System { get; } = new(
            name: "system")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ThinkingConfigParam?> Thinking { get; } = new(
            name: "thinking")
        {
            Description = @"",
        };
        public MessagesCountTokensPostCommand(G.IApi client) : base(
            name: "messages",
            description: @"Count the number of tokens in a Message.

The Token Count API can be used to count the number of tokens in a Message, including tools, images, and documents, without creating it.

Learn more about token counting in our [user guide](/en/docs/build-with-claude/token-counting)")
        {
            _client = client;

            Arguments.Add(Messages);
            Arguments.Add(Model);
            Options.Add(AnthropicVersion);
            Options.Add(ToolChoice);
            Options.Add(Tools);
            Options.Add(System);
            Options.Add(Thinking);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var tools = parseResult.GetRequiredValue(Tools);
            var messages = parseResult.GetRequiredValue(Messages);
            var system = parseResult.GetRequiredValue(System);
            var thinking = parseResult.GetRequiredValue(Thinking);
            var model = parseResult.GetRequiredValue(Model);

            Validate(
                parseResult: parseResult,
                anthropicVersion: anthropicVersion,
                toolChoice: toolChoice,
                tools: tools,
                messages: messages,
                system: system,
                thinking: thinking,
                model: model,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Messages.MessagesCountTokensPostAsync(
                anthropicVersion: anthropicVersion,
                toolChoice: toolChoice,
                tools: tools,
                messages: messages,
                system: system,
                thinking: thinking,
                model: model,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}