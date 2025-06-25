//HintName: G.Commands.OrgsAssignTeamToOrgRoleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsAssignTeamToOrgRoleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            int roleId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> TeamSlug { get; } = new(
            name: "teamSlug")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> RoleId { get; } = new(
            name: "roleId")
        {
            Description = "",
        };

        public OrgsAssignTeamToOrgRoleCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Assigns an organization role to a team in an organization. For more information on organization roles, see ""[Using organization roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/using-organization-roles).""

The authenticated user must be an administrator for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
            Arguments.Add(RoleId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var teamSlug = parseResult.GetRequiredValue(TeamSlug);
            var roleId = parseResult.GetRequiredValue(RoleId);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                roleId: roleId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Orgs.OrgsAssignTeamToOrgRoleAsync(
                org: org,
                teamSlug: teamSlug,
                roleId: roleId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}