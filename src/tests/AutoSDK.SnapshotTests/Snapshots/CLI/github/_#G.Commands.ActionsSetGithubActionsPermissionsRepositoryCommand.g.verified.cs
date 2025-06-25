//HintName: G.Commands.ActionsSetGithubActionsPermissionsRepositoryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsSetGithubActionsPermissionsRepositoryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            bool enabled,
            global::G.AllowedActions? allowedActions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<bool> Enabled { get; } = new(
            name: "enabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AllowedActions?> AllowedActions { get; } = new(
            name: "allowedActions")
        {
            Description = "",
        };
        public ActionsSetGithubActionsPermissionsRepositoryCommand(G.IApi client) : base(
            name: "actions",
            description: @"Sets the GitHub Actions permissions policy for enabling GitHub Actions and allowed actions and reusable workflows in the repository.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Enabled);
            Options.Add(AllowedActions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var enabled = parseResult.GetRequiredValue(Enabled);
            var allowedActions = parseResult.GetRequiredValue(AllowedActions);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                enabled: enabled,
                allowedActions: allowedActions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsSetGithubActionsPermissionsRepositoryAsync(
                owner: owner,
                repo: repo,
                enabled: enabled,
                allowedActions: allowedActions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}