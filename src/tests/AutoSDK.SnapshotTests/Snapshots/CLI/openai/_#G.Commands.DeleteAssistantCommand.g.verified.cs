//HintName: G.Commands.DeleteAssistantCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteAssistantCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string assistantId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeleteAssistantResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AssistantId { get; } = new(
            name: "assistantId")
        {
            Description = "",
        };

        public DeleteAssistantCommand(G.IOpenAiClient client) : base(
            name: "delete",
            description: @"")
        {
            _client = client;

            Arguments.Add(AssistantId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var assistantId = parseResult.GetRequiredValue(AssistantId);

            Validate(
                parseResult: parseResult,
                assistantId: assistantId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Assistants.DeleteAssistantAsync(
                assistantId: assistantId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}