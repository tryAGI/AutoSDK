//HintName: G.Commands.AppPublicServiceCreateMessageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceCreateMessageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            string conversationId,
            string content,
            string role,
            global::G.MessageType type,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateMessageResponse response,
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

        private global::System.CommandLine.Argument<string> Content { get; } = new(
            name: "content")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Role { get; } = new(
            name: "role")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.MessageType> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };
        public AppPublicServiceCreateMessageCommand(G.IApi client) : base(
            name: "app",
            description: @"Creates a message.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);
            Arguments.Add(ConversationId);
            Arguments.Add(Content);
            Arguments.Add(Role);
            Options.Add(Type);

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
            var content = parseResult.GetRequiredValue(Content);
            var role = parseResult.GetRequiredValue(Role);
            var type = parseResult.GetRequiredValue(Type);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                content: content,
                role: role,
                type: type,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceCreateMessageAsync(
                namespaceId: namespaceId,
                appId: appId,
                conversationId: conversationId,
                content: content,
                role: role,
                type: type,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}