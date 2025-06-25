//HintName: G.Commands.CreateConvaiConversationsByConversationIdFeedbackCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiConversationsByConversationIdFeedbackCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string conversationId,
            global::G.UserFeedbackScore feedback,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ConversationId { get; } = new(
            name: "conversationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.UserFeedbackScore> Feedback { get; } = new(
            name: "feedback")
        {
            Description = "",
        };

        public CreateConvaiConversationsByConversationIdFeedbackCommand(G.IApi client) : base(
            name: "create",
            description: @"Send the feedback for the given conversation")
        {
            _client = client;

            Arguments.Add(ConversationId);
            Arguments.Add(Feedback);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var conversationId = parseResult.GetRequiredValue(ConversationId);
            var feedback = parseResult.GetRequiredValue(Feedback);

            Validate(
                parseResult: parseResult,
                conversationId: conversationId,
                feedback: feedback,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiConversationsByConversationIdFeedbackAsync(
                conversationId: conversationId,
                feedback: feedback,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}