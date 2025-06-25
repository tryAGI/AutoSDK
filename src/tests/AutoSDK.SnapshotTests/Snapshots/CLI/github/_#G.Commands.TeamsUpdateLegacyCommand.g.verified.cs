//HintName: G.Commands.TeamsUpdateLegacyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsUpdateLegacyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int teamId,
            string name,
            string? description,
            global::G.TeamsUpdateLegacyRequestPrivacy? privacy,
            global::G.TeamsUpdateLegacyRequestNotificationSetting? notificationSetting,
            global::G.TeamsUpdateLegacyRequestPermission? permission,
            int? parentTeamId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TeamFull response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> TeamId { get; } = new(
            name: "teamId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsUpdateLegacyRequestPrivacy?> Privacy { get; } = new(
            name: "privacy")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsUpdateLegacyRequestNotificationSetting?> NotificationSetting { get; } = new(
            name: "notificationSetting")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsUpdateLegacyRequestPermission?> Permission { get; } = new(
            name: "permission")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> ParentTeamId { get; } = new(
            name: "parentTeamId")
        {
            Description = "",
        };
        public TeamsUpdateLegacyCommand(G.IApi client) : base(
            name: "teams",
            description: @"> [!WARNING]
> **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a team](https://docs.github.com/rest/teams/teams#update-a-team) endpoint.

To edit a team, the authenticated user must either be an organization owner or a team maintainer.

> [!NOTE]
> With nested teams, the `privacy` for parent teams cannot be `secret`.")
        {
            _client = client;

            Arguments.Add(TeamId);
            Arguments.Add(Name);
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
            var teamId = parseResult.GetRequiredValue(TeamId);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var privacy = parseResult.GetRequiredValue(Privacy);
            var notificationSetting = parseResult.GetRequiredValue(NotificationSetting);
            var permission = parseResult.GetRequiredValue(Permission);
            var parentTeamId = parseResult.GetRequiredValue(ParentTeamId);

            Validate(
                parseResult: parseResult,
                teamId: teamId,
                name: name,
                description: description,
                privacy: privacy,
                notificationSetting: notificationSetting,
                permission: permission,
                parentTeamId: parentTeamId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.TeamsUpdateLegacyAsync(
                teamId: teamId,
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