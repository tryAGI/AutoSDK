//HintName: G.Commands.OrgsCreateInvitationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsCreateInvitationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int? inviteeId,
            string? email,
            global::G.OrgsCreateInvitationRequestRole? role,
            global::System.Collections.Generic.IList<int>? teamIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OrganizationInvitation response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> InviteeId { get; } = new(
            name: "inviteeId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Email { get; } = new(
            name: "email")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgsCreateInvitationRequestRole?> Role { get; } = new(
            name: "role")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<int>?> TeamIds { get; } = new(
            name: "teamIds")
        {
            Description = "",
        };
        public OrgsCreateInvitationCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Invite people to an organization by using their GitHub user ID or their email address. In order to create invitations in an organization, the authenticated user must be an organization owner.

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see ""[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)""
and ""[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).""")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(InviteeId);
            Options.Add(Email);
            Options.Add(Role);
            Options.Add(TeamIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var inviteeId = parseResult.GetRequiredValue(InviteeId);
            var email = parseResult.GetRequiredValue(Email);
            var role = parseResult.GetRequiredValue(Role);
            var teamIds = parseResult.GetRequiredValue(TeamIds);

            Validate(
                parseResult: parseResult,
                org: org,
                inviteeId: inviteeId,
                email: email,
                role: role,
                teamIds: teamIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsCreateInvitationAsync(
                org: org,
                inviteeId: inviteeId,
                email: email,
                role: role,
                teamIds: teamIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}