//HintName: G.Commands.CodespacesCreateForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesCreateForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Codespace response,
            global::System.Threading.CancellationToken cancellationToken);


        public CodespacesCreateForAuthenticatedUserCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Creates a new codespace, owned by the authenticated user.

This endpoint requires either a `repository_id` OR a `pull_request` but not both.

OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.")
        {
            _client = client;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Codespaces.CodespacesCreateForAuthenticatedUserAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}