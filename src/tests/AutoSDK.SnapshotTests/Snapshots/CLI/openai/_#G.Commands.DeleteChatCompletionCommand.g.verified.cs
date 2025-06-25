//HintName: G.Commands.DeleteChatCompletionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteChatCompletionCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string completionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ChatCompletionDeleted response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CompletionId { get; } = new(
            name: "completionId")
        {
            Description = "",
        };

        public DeleteChatCompletionCommand(G.IOpenAiClient client) : base(
            name: "delete",
            description: @"")
        {
            _client = client;

            Arguments.Add(CompletionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var completionId = parseResult.GetRequiredValue(CompletionId);

            Validate(
                parseResult: parseResult,
                completionId: completionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.DeleteChatCompletionAsync(
                completionId: completionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}