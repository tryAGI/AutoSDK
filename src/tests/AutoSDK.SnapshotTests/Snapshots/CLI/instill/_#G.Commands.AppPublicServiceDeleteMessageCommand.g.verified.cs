//HintName: G.Commands.AppPublicServiceDeleteMessageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceDeleteMessageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            string conversationId,
            string messageUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> AppId { get; } = new(
            name: "appId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ConversationId { get; } = new(
            name: "conversationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> MessageUid { get; } = new(
            name: "messageUid")
        {
            Description = "",
        };

        public AppPublicServiceDeleteMessageCommand(G.IApi client) : base(
            name: "app",
            description: @"Deletes a message.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);
            Arguments.Add(ConversationId);
            Arguments.Add(MessageUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var appId = parseResult.GetRequiredValue(AppId);
            var conversationId = parseResult.GetRequiredValue(ConversationId);
            var messageUid = parseResult.GetRequiredValue(MessageUid);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                messageUid: messageUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceDeleteMessageAsync(
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                messageUid: messageUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}