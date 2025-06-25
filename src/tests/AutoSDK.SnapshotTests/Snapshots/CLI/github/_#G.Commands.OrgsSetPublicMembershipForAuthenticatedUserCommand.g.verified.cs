//HintName: G.Commands.OrgsSetPublicMembershipForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsSetPublicMembershipForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        public OrgsSetPublicMembershipForAuthenticatedUserCommand(G.IApi client) : base(
            name: "orgs",
            description: @"The user can publicize their own membership. (A user cannot publicize the membership for another user.)

Note that you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see ""[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method).""")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Username);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var username = parseResult.GetRequiredValue(Username);

            Validate(
                parseResult: parseResult,
                org: org,
                username: username,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Orgs.OrgsSetPublicMembershipForAuthenticatedUserAsync(
                org: org,
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}