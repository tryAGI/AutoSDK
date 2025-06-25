//HintName: G.Commands.ActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::G.ActionsDefaultWorkflowPermissions? defaultWorkflowPermissions,
            bool? canApprovePullRequestReviews,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
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
        public ActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationCommand(G.IApi client) : base(
            name: "actions",
            description: @"Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an organization, and sets if GitHub Actions
can submit approving pull request reviews. For more information, see
""[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization).""

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(DefaultWorkflowPermissions);
            Options.Add(CanApprovePullRequestReviews);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var defaultWorkflowPermissions = parseResult.GetRequiredValue(DefaultWorkflowPermissions);
            var canApprovePullRequestReviews = parseResult.GetRequiredValue(CanApprovePullRequestReviews);

            Validate(
                parseResult: parseResult,
                org: org,
                defaultWorkflowPermissions: defaultWorkflowPermissions,
                canApprovePullRequestReviews: canApprovePullRequestReviews,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationAsync(
                org: org,
                defaultWorkflowPermissions: defaultWorkflowPermissions,
                canApprovePullRequestReviews: canApprovePullRequestReviews,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}