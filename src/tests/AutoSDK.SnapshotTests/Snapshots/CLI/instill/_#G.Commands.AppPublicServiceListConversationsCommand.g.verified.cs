//HintName: G.Commands.AppPublicServiceListConversationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceListConversationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> AppId { get; } = new(
            name: "appId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ConversationUid { get; } = new(
            name: "conversationUid")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ConversationId { get; } = new(
            name: "conversationId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IfAll { get; } = new(
            name: "ifAll")
        {
            Description = @"",
        };
        public AppPublicServiceListConversationsCommand(G.IApi client) : base(
            name: "app",
            description: @"Returns a paginated list of conversations.")
        {
            _client = client;

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