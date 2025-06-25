//HintName: G.Commands.ActionsSetGithubActionsPermissionsOrganizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsSetGithubActionsPermissionsOrganizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::G.EnabledRepositories enabledRepositories,
            global::G.AllowedActions? allowedActions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.EnabledRepositories> EnabledRepositories { get; } = new(
            name: "enabledRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AllowedActions?> AllowedActions { get; } = new(
            name: "allowedActions")
        {
            Description = "",
        };
        public ActionsSetGithubActionsPermissionsOrganizationCommand(G.IApi client) : base(
            name: "actions",
            description: @"Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(EnabledRepositories);
            Options.Add(AllowedActions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var enabledRepositories = parseResult.GetRequiredValue(EnabledRepositories);
            var allowedActions = parseResult.GetRequiredValue(AllowedActions);

            Validate(
                parseResult: parseResult,
                org: org,
                enabledRepositories: enabledRepositories,
                allowedActions: allowedActions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsSetGithubActionsPermissionsOrganizationAsync(
                org: org,
                enabledRepositories: enabledRepositories,
                allowedActions: allowedActions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}