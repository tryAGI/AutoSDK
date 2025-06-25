//HintName: G.Commands.CodespacesCheckPermissionsForDevcontainerCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesCheckPermissionsForDevcontainerCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string @ref,
            string devcontainerPath,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodespacesPermissionsCheckForDevcontainer response,
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

        private global::System.CommandLine.Argument<string> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> DevcontainerPath { get; } = new(
            name: "devcontainerPath")
        {
            Description = "",
        };

        public CodespacesCheckPermissionsForDevcontainerCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Checks whether the permissions defined by a given devcontainer configuration have been accepted by the authenticated user.

OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Ref);
            Arguments.Add(DevcontainerPath);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var @ref = parseResult.GetRequiredValue(Ref);
            var devcontainerPath = parseResult.GetRequiredValue(DevcontainerPath);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                @ref: @ref,
                devcontainerPath: devcontainerPath,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Codespaces.CodespacesCheckPermissionsForDevcontainerAsync(
                owner: owner,
                repo: repo,
                @ref: @ref,
                devcontainerPath: devcontainerPath,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}