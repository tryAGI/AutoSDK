//HintName: G.Commands.AppsResetTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsResetTokenCommand : global::System.CommandLine.Command
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
            global::G.Authorization response,
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

        public AppsResetTokenCommand(G.IApi client) : base(
            name: "apps",
            description: @"OAuth applications and GitHub applications with OAuth authorizations can use this API method to reset a valid OAuth token without end-user involvement. Applications must save the ""token"" property in the response because changes take effect immediately. Invalid tokens will return `404 NOT FOUND`.")
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
            var response = await _client.Apps.AppsResetTokenAsync(
                clientId: clientId,
                accessToken: accessToken,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}