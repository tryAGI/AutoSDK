//HintName: G.Commands.AppPublicServiceChatCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceChatCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            string catalogId,
            string conversationUid,
            string message,
            long? topK,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ChatResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"Namespace ID",
        };

        private global::System.CommandLine.Argument<string> AppId { get; } = new(
            name: "appId")
        {
            Description = @"App ID",
        };

        private global::System.CommandLine.Argument<string> CatalogId { get; } = new(
            name: "catalogId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ConversationUid { get; } = new(
            name: "conversationUid")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<long?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"",
        };
        public AppPublicServiceChatCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "app",
            description: @"Chat sends a message asynchronously and streams back the response.
This method is intended for real-time conversation with a chatbot
and the response needs to be processed incrementally.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);
            Arguments.Add(CatalogId);
            Arguments.Add(ConversationUid);
            Arguments.Add(Message);
            Options.Add(TopK);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var appId = parseResult.GetRequiredValue(AppId);
            var catalogId = parseResult.GetRequiredValue(CatalogId);
            var conversationUid = parseResult.GetRequiredValue(ConversationUid);
            var message = parseResult.GetRequiredValue(Message);
            var topK = parseResult.GetRequiredValue(TopK);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                catalogId: catalogId,
                conversationUid: conversationUid,
                message: message,
                topK: topK,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceChatAsync(
                namespaceId: namespaceId,
                appId: appId,
                catalogId: catalogId,
                conversationUid: conversationUid,
                message: message,
                topK: topK,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}