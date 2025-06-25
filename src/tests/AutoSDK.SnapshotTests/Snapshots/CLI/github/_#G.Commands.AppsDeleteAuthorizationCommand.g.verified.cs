//HintName: G.Commands.AppsDeleteAuthorizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsDeleteAuthorizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string clientId,
            string accessToken,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClientId { get; } = new(
            name: "clientId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> AccessToken { get; } = new(
            name: "accessToken")
        {
            Description = "",
        };

        public AppsDeleteAuthorizationCommand(G.IApi client) : base(
            name: "apps",
            description: @"OAuth and GitHub application owners can revoke a grant for their application and a specific user. You must provide a valid OAuth `access_token` as an input parameter and the grant for the token's owner will be deleted.
Deleting an application's grant will also delete all OAuth tokens associated with the application for the user. Once deleted, the application will have no access to the user's account and will no longer be listed on [the application authorizations settings screen within GitHub](https://github.com/settings/applications#authorized).")
        {
            _client = client;

            Arguments.Add(ClientId);
            Arguments.Add(AccessToken);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var clientId = parseResult.GetRequiredValue(ClientId);
            var accessToken = parseResult.GetRequiredValue(AccessToken);

            Validate(
                parseResult: parseResult,
                clientId: clientId,
                accessToken: accessToken,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Apps.AppsDeleteAuthorizationAsync(
                clientId: clientId,
                accessToken: accessToken,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}