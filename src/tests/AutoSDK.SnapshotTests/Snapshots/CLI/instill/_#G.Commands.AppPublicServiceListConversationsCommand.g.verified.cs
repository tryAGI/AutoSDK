//HintName: G.Commands.AppPublicServiceListConversationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceListConversationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            int? pageSize,
            string? pageToken,
            string? conversationUid,
            string? conversationId,
            bool? ifAll,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListConversationsResponse response,
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

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"page size",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"page token",
        };

        private global::System.CommandLine.Option<string?> ConversationUid { get; } = new(
            name: "conversationUid")
        {
            Description = @"conversation_uid this is optional, if provided, only the conversation with the given conversation_uid will be returned
first check conversation_uid, then check conversation_id, then check if_all",
        };

        private global::System.CommandLine.Option<string?> ConversationId { get; } = new(
            name: "conversationId")
        {
            Description = @"conversation_id this is optional, if provided, only the conversation with the given conversation_id will be returned",
        };

        private global::System.CommandLine.Option<bool?> IfAll { get; } = new(
            name: "ifAll")
        {
            Description = @"If true, all conversations will be returned. This has higher priority over conversation_id, page_size, and page_token.",
        };
        public AppPublicServiceListConversationsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "app",
            description: @"Returns a paginated list of conversations.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);
            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(ConversationUid);
            Options.Add(ConversationId);
            Options.Add(IfAll);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var appId = parseResult.GetRequiredValue(AppId);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var conversationUid = parseResult.GetRequiredValue(ConversationUid);
            var conversationId = parseResult.GetRequiredValue(ConversationId);
            var ifAll = parseResult.GetRequiredValue(IfAll);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                pageSize: pageSize,
                pageToken: pageToken,
                conversationUid: conversationUid,
                conversationId: conversationId,
                ifAll: ifAll,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceListConversationsAsync(
                namespaceId: namespaceId,
                appId: appId,
                pageSize: pageSize,
                pageToken: pageToken,
                conversationUid: conversationUid,
                conversationId: conversationId,
                ifAll: ifAll,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}