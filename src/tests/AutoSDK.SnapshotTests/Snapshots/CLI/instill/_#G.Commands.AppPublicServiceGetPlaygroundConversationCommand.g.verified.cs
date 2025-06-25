//HintName: G.Commands.AppPublicServiceGetPlaygroundConversationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceGetPlaygroundConversationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetPlaygroundConversationResponse response,
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

        public AppPublicServiceGetPlaygroundConversationCommand(G.IApi client) : base(
            name: "app",
            description: @"Returns the latest conversation of auth user(e.g. login user and api key user).")
        {
            _client = client;

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
            var response = await _client.App.AppPublicServiceGetPlaygroundConversationAsync(
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