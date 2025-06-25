//HintName: G.Commands.AppPublicServiceUpdateMessageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceUpdateMessageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            string conversationId,
            string messageUid,
            string content,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateMessageResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"namespace id",
        };

        private global::System.CommandLine.Argument<string> AppId { get; } = new(
            name: "appId")
        {
            Description = @"app id",
        };

        private global::System.CommandLine.Argument<string> ConversationId { get; } = new(
            name: "conversationId")
        {
            Description = @"conversation id",
        };

        private global::System.CommandLine.Argument<string> MessageUid { get; } = new(
            name: "messageUid")
        {
            Description = @"message uid",
        };

        private global::System.CommandLine.Argument<string> Content { get; } = new(
            name: "content")
        {
            Description = @"",
        };

        public AppPublicServiceUpdateMessageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "app",
            description: @"Updates a message.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);
            Arguments.Add(ConversationId);
            Arguments.Add(MessageUid);
            Arguments.Add(Content);

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
            var content = parseResult.GetRequiredValue(Content);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                messageUid: messageUid,
                content: content,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceUpdateMessageAsync(
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                messageUid: messageUid,
                content: content,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}