//HintName: G.Commands.AppPublicServiceUpdateConversationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceUpdateConversationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            string conversationId,
            string? newConversationId,
            string? lastUsedCatalogUid,
            long? lastUsedTopK,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateConversationResponse response,
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

        private global::System.CommandLine.Option<string?> NewConversationId { get; } = new(
            name: "newConversationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> LastUsedCatalogUid { get; } = new(
            name: "lastUsedCatalogUid")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<long?> LastUsedTopK { get; } = new(
            name: "lastUsedTopK")
        {
            Description = "",
        };
        public AppPublicServiceUpdateConversationCommand(G.IApi client) : base(
            name: "app",
            description: @"Updates a conversation.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);
            Arguments.Add(ConversationId);
            Options.Add(NewConversationId);
            Options.Add(LastUsedCatalogUid);
            Options.Add(LastUsedTopK);

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
            var newConversationId = parseResult.GetRequiredValue(NewConversationId);
            var lastUsedCatalogUid = parseResult.GetRequiredValue(LastUsedCatalogUid);
            var lastUsedTopK = parseResult.GetRequiredValue(LastUsedTopK);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                newConversationId: newConversationId,
                lastUsedCatalogUid: lastUsedCatalogUid,
                lastUsedTopK: lastUsedTopK,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceUpdateConversationAsync(
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                newConversationId: newConversationId,
                lastUsedCatalogUid: lastUsedCatalogUid,
                lastUsedTopK: lastUsedTopK,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}