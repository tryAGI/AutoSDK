//HintName: G.Commands.TeamsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string name,
            string? description,
            global::System.Collections.Generic.IList<string>? maintainers,
            global::System.Collections.Generic.IList<string>? repoNames,
            global::G.TeamsCreateRequestPrivacy? privacy,
            global::G.TeamsCreateRequestNotificationSetting? notificationSetting,
            global::G.TeamsCreateRequestPermission? permission,
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Maintainers { get; } = new(
            name: "maintainers")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> RepoNames { get; } = new(
            name: "repoNames")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsCreateRequestPrivacy?> Privacy { get; } = new(
            name: "privacy")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsCreateRequestNotificationSetting?> NotificationSetting { get; } = new(
            name: "notificationSetting")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TeamsCreateRequestPermission?> Permission { get; } = new(
            name: "permission")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> ParentTeamId { get; } = new(
            name: "parentTeamId")
        {
            Description = "",
        };
        public TeamsCreateCommand(G.IApi client) : base(
            name: "teams",
            description: @"To create a team, the authenticated user must be a member or owner of `{org}`. By default, organization members can create teams. Organization owners can limit team creation to organization owners. For more information, see ""[Setting team creation permissions](https://docs.github.com/articles/setting-team-creation-permissions-in-your-organization).""

When you create a new team, you automatically become a team maintainer without explicitly adding yourself to the optional array of `maintainers`. For more information, see ""[About teams](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/about-teams)"".")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Name);
            Options.Add(Description);
            Options.Add(Maintainers);
            Options.Add(RepoNames);
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
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var maintainers = parseResult.GetRequiredValue(Maintainers);
            var repoNames = parseResult.GetRequiredValue(RepoNames);
            var privacy = parseResult.GetRequiredValue(Privacy);
            var notificationSetting = parseResult.GetRequiredValue(NotificationSetting);
            var permission = parseResult.GetRequiredValue(Permission);
            var parentTeamId = parseResult.GetRequiredValue(ParentTeamId);

            Validate(
                parseResult: parseResult,
                org: org,
                name: name,
                description: description,
                maintainers: maintainers,
                repoNames: repoNames,
                privacy: privacy,
                notificationSetting: notificationSetting,
                permission: permission,
                parentTeamId: parentTeamId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.TeamsCreateAsync(
                org: org,
                name: name,
                description: description,
                maintainers: maintainers,
                repoNames: repoNames,
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