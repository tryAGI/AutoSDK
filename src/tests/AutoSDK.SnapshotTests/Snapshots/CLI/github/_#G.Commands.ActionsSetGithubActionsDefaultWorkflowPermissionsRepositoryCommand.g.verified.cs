//HintName: G.Commands.ActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.ActionsDefaultWorkflowPermissions? defaultWorkflowPermissions,
            bool? canApprovePullRequestReviews,
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

        private global::System.CommandLine.Option<global::G.ActionsDefaultWorkflowPermissions?> DefaultWorkflowPermissions { get; } = new(
            name: "defaultWorkflowPermissions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> CanApprovePullRequestReviews { get; } = new(
            name: "canApprovePullRequestReviews")
        {
            Description = "",
        };
        public ActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryCommand(G.IApi client) : base(
            name: "actions",
            description: @"Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in a repository, and sets if GitHub Actions
can submit approving pull request reviews.
For more information, see ""[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository).""

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(DefaultWorkflowPermissions);
            Options.Add(CanApprovePullRequestReviews);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var defaultWorkflowPermissions = parseResult.GetRequiredValue(DefaultWorkflowPermissions);
            var canApprovePullRequestReviews = parseResult.GetRequiredValue(CanApprovePullRequestReviews);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                defaultWorkflowPermissions: defaultWorkflowPermissions,
                canApprovePullRequestReviews: canApprovePullRequestReviews,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryAsync(
                owner: owner,
                repo: repo,
                defaultWorkflowPermissions: defaultWorkflowPermissions,
                canApprovePullRequestReviews: canApprovePullRequestReviews,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}