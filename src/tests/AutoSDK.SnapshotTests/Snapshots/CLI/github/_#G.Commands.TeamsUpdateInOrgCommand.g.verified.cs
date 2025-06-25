//HintName: G.Commands.TeamsUpdateInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsUpdateInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string teamSlug,
            string? name,
            string? description,
            global::G.TeamsUpdateInOrgRequestPrivacy? privacy,
            global::G.TeamsUpdateInOrgRequestNotificationSetting? notificationSetting,
            global::G.TeamsUpdateInOrgRequestPermission? permission,
            int? parentTeamId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TeamFull response,
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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsUpdateInOrgRequestPrivacy?> Privacy { get; } = new(
            name: "privacy")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsUpdateInOrgRequestNotificationSetting?> NotificationSetting { get; } = new(
            name: "notificationSetting")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsUpdateInOrgRequestPermission?> Permission { get; } = new(
            name: "permission")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> ParentTeamId { get; } = new(
            name: "parentTeamId")
        {
            Description = "",
        };
        public TeamsUpdateInOrgCommand(G.IApi client) : base(
            name: "teams",
            description: @"To edit a team, the authenticated user must either be an organization owner or a team maintainer.

> [!NOTE]
> You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}`.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(TeamSlug);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(Privacy);
            Options.Add(NotificationSetting);
            Options.Add(Permission);
            Options.Add(ParentTeamId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var teamSlug = parseResult.GetRequiredValue(TeamSlug);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var privacy = parseResult.GetRequiredValue(Privacy);
            var notificationSetting = parseResult.GetRequiredValue(NotificationSetting);
            var permission = parseResult.GetRequiredValue(Permission);
            var parentTeamId = parseResult.GetRequiredValue(ParentTeamId);

            Validate(
                parseResult: parseResult,
                org: org,
                teamSlug: teamSlug,
                name: name,
                description: description,
                privacy: privacy,
                notificationSetting: notificationSetting,
                permission: permission,
                parentTeamId: parentTeamId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.TeamsUpdateInOrgAsync(
                org: org,
                teamSlug: teamSlug,
                name: name,
                description: description,
                privacy: privacy,
                notificationSetting: notificationSetting,
                permission: permission,
                parentTeamId: parentTeamId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}