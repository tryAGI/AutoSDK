//HintName: G.Commands.CodespacesSetCodespacesAccessCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesSetCodespacesAccessCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::G.CodespacesSetCodespacesAccessRequestVisibility visibility,
            global::System.Collections.Generic.IList<string>? selectedUsernames,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.CodespacesSetCodespacesAccessRequestVisibility> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> SelectedUsernames { get; } = new(
            name: "selectedUsernames")
        {
            Description = "",
        };
        public CodespacesSetCodespacesAccessCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Sets which users can access codespaces in an organization. This is synonymous with granting or revoking codespaces access permissions for users according to the visibility.
OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Visibility);
            Options.Add(SelectedUsernames);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var selectedUsernames = parseResult.GetRequiredValue(SelectedUsernames);

            Validate(
                parseResult: parseResult,
                org: org,
                visibility: visibility,
                selectedUsernames: selectedUsernames,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Codespaces.CodespacesSetCodespacesAccessAsync(
                org: org,
                visibility: visibility,
                selectedUsernames: selectedUsernames,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}