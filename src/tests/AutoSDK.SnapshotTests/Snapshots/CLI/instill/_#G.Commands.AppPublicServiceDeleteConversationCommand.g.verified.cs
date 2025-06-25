//HintName: G.Commands.AppPublicServiceDeleteConversationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceDeleteConversationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
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

        public AppPublicServiceDeleteConversationCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "app",
            description: @"Deletes a conversation.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);
            Arguments.Add(ConversationId);

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

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceDeleteConversationAsync(
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}