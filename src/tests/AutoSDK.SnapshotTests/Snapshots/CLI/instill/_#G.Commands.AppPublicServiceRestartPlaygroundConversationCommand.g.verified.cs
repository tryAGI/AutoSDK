//HintName: G.Commands.AppPublicServiceRestartPlaygroundConversationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceRestartPlaygroundConversationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RestartPlaygroundConversationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"The namespace id.",
        };

        private global::System.CommandLine.Argument<string> AppId { get; } = new(
            name: "appId")
        {
            Description = @"The app id.",
        };

        public AppPublicServiceRestartPlaygroundConversationCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "app",
            description: @"Creates a new conversation and uses the auth user UID as creator UID and
auto-generates a new conversation ID on the behalf of auth user.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var appId = parseResult.GetRequiredValue(AppId);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceRestartPlaygroundConversationAsync(
                namespaceId: namespaceId,
                appId: appId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}