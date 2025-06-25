//HintName: G.Commands.ActionsGetGithubActionsDefaultWorkflowPermissionsOrganizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsGetGithubActionsDefaultWorkflowPermissionsOrganizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActionsGetDefaultWorkflowPermissions response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        public ActionsGetGithubActionsDefaultWorkflowPermissionsOrganizationCommand(G.IApi client) : base(
            name: "actions",
            description: @"Gets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an organization,
as well as whether GitHub Actions can submit approving pull request reviews. For more information, see
""[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization).""

OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);

            Validate(
                parseResult: parseResult,
                org: org,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsGetGithubActionsDefaultWorkflowPermissionsOrganizationAsync(
                org: org,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}