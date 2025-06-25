//HintName: G.Commands.ActionsGetGithubActionsPermissionsOrganizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsGetGithubActionsPermissionsOrganizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActionsOrganizationPermissions response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        public ActionsGetGithubActionsPermissionsOrganizationCommand(G.IApi client) : base(
            name: "actions",
            description: @"Gets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.

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
            var response = await _client.Actions.ActionsGetGithubActionsPermissionsOrganizationAsync(
                org: org,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}