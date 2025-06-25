//HintName: G.Commands.CodespacesPublishForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesPublishForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string codespaceName,
            string? name,
            bool? @private,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodespaceWithFullRepository response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CodespaceName { get; } = new(
            name: "codespaceName")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Private { get; } = new(
            name: "@private")
        {
            Description = "",
        };
        public CodespacesPublishForAuthenticatedUserCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Publishes an unpublished codespace, creating a new repository and assigning it to the codespace.

The codespace's token is granted write permissions to the repository, allowing the user to push their changes.

This will fail for a codespace that is already published, meaning it has an associated repository.

OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(CodespaceName);
            Options.Add(Name);
            Options.Add(Private);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var codespaceName = parseResult.GetRequiredValue(CodespaceName);
            var name = parseResult.GetRequiredValue(Name);
            var @private = parseResult.GetRequiredValue(Private);

            Validate(
                parseResult: parseResult,
                codespaceName: codespaceName,
                name: name,
                @private: @private,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Codespaces.CodespacesPublishForAuthenticatedUserAsync(
                codespaceName: codespaceName,
                name: name,
                @private: @private,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}