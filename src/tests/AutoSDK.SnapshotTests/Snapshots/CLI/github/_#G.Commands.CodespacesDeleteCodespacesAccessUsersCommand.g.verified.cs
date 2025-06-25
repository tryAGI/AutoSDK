//HintName: G.Commands.CodespacesDeleteCodespacesAccessUsersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesDeleteCodespacesAccessUsersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Collections.Generic.IList<string> selectedUsernames,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> SelectedUsernames { get; } = new(
            name: "selectedUsernames")
        {
            Description = "",
        };

        public CodespacesDeleteCodespacesAccessUsersCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Codespaces for the specified users will no longer be billed to the organization.

To use this endpoint, the access settings for the organization must be set to `selected_members`.
For information on how to change this setting, see ""[Manage access control for organization codespaces](https://docs.github.com/rest/codespaces/organizations#manage-access-control-for-organization-codespaces).""

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(SelectedUsernames);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var selectedUsernames = parseResult.GetRequiredValue(SelectedUsernames);

            Validate(
                parseResult: parseResult,
                org: org,
                selectedUsernames: selectedUsernames,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Codespaces.CodespacesDeleteCodespacesAccessUsersAsync(
                org: org,
                selectedUsernames: selectedUsernames,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}