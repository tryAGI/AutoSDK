//HintName: G.Commands.CodespacesDeleteFromOrganizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesDeleteFromOrganizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string username,
            string codespaceName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> CodespaceName { get; } = new(
            name: "codespaceName")
        {
            Description = "",
        };

        public CodespacesDeleteFromOrganizationCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Deletes a user's codespace.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Username);
            Arguments.Add(CodespaceName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var username = parseResult.GetRequiredValue(Username);
            var codespaceName = parseResult.GetRequiredValue(CodespaceName);

            Validate(
                parseResult: parseResult,
                org: org,
                username: username,
                codespaceName: codespaceName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Codespaces.CodespacesDeleteFromOrganizationAsync(
                org: org,
                username: username,
                codespaceName: codespaceName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}