//HintName: G.Commands.CreateThreadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateThreadCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.CreateMessageRequest>? messages,
            global::G.CreateThreadRequestToolResources? toolResources,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ThreadObject response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.CreateMessageRequest>?> Messages { get; } = new(
            name: "messages")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateThreadRequestToolResources?> ToolResources { get; } = new(
            name: "toolResources")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };
        public CreateThreadCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Options.Add(Messages);
            Options.Add(ToolResources);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var messages = parseResult.GetRequiredValue(Messages);
            var toolResources = parseResult.GetRequiredValue(ToolResources);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                messages: messages,
                toolResources: toolResources,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Assistants.CreateThreadAsync(
                messages: messages,
                toolResources: toolResources,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}