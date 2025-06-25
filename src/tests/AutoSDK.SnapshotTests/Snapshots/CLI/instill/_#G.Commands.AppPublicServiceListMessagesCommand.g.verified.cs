//HintName: G.Commands.AppPublicServiceListMessagesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceListMessagesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            string conversationId,
            int? latestK,
            int? pageSize,
            string? pageToken,
            bool? includeSystemMessages,
            bool? ifAll,
            string? messageUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListMessagesResponse response,
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

        private global::System.CommandLine.Argument<string> ConversationId { get; } = new(
            name: "conversationId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> LatestK { get; } = new(
            name: "latestK")
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

        private global::System.CommandLine.Option<bool?> IncludeSystemMessages { get; } = new(
            name: "includeSystemMessages")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IfAll { get; } = new(
            name: "ifAll")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> MessageUid { get; } = new(
            name: "messageUid")
        {
            Description = @"",
        };
        public AppPublicServiceListMessagesCommand(G.IApi client) : base(
            name: "app",
            description: @"Returns a paginated list of messages.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);
            Arguments.Add(ConversationId);
            Options.Add(LatestK);
            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(IncludeSystemMessages);
            Options.Add(IfAll);
            Options.Add(MessageUid);

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
            var latestK = parseResult.GetRequiredValue(LatestK);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var includeSystemMessages = parseResult.GetRequiredValue(IncludeSystemMessages);
            var ifAll = parseResult.GetRequiredValue(IfAll);
            var messageUid = parseResult.GetRequiredValue(MessageUid);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                latestK: latestK,
                pageSize: pageSize,
                pageToken: pageToken,
                includeSystemMessages: includeSystemMessages,
                ifAll: ifAll,
                messageUid: messageUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceListMessagesAsync(
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                latestK: latestK,
                pageSize: pageSize,
                pageToken: pageToken,
                includeSystemMessages: includeSystemMessages,
                ifAll: ifAll,
                messageUid: messageUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}