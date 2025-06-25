//HintName: G.Commands.GetMessageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetMessageCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string threadId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.MessageObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> MessageId { get; } = new(
            name: "messageId")
        {
            Description = "",
        };

        public GetMessageCommand(G.IOpenAiClient client) : base(
            name: "get",
            description: @"")
        {
            _client = client;

            Arguments.Add(ThreadId);
            Arguments.Add(MessageId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var messageId = parseResult.GetRequiredValue(MessageId);

            Validate(
                parseResult: parseResult,
                threadId: threadId,
                messageId: messageId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Assistants.GetMessageAsync(
                threadId: threadId,
                messageId: messageId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}