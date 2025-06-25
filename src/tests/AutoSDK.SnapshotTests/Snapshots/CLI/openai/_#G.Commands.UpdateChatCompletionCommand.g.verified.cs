//HintName: G.Commands.UpdateChatCompletionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateChatCompletionCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string completionId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateChatCompletionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CompletionId { get; } = new(
            name: "completionId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };

        public UpdateChatCompletionCommand(G.IOpenAiClient client) : base(
            name: "update",
            description: @"")
        {
            _client = client;

            Arguments.Add(CompletionId);
            Arguments.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var completionId = parseResult.GetRequiredValue(CompletionId);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                completionId: completionId,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.UpdateChatCompletionAsync(
                completionId: completionId,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}