//HintName: G.Commands.CodespacesGetExportDetailsForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesGetExportDetailsForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string codespaceName,
            string exportId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodespaceExportDetails response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CodespaceName { get; } = new(
            name: "codespaceName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ExportId { get; } = new(
            name: "exportId")
        {
            Description = "",
        };

        public CodespacesGetExportDetailsForAuthenticatedUserCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Gets information about an export of a codespace.

OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(CodespaceName);
            Arguments.Add(ExportId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var codespaceName = parseResult.GetRequiredValue(CodespaceName);
            var exportId = parseResult.GetRequiredValue(ExportId);

            Validate(
                parseResult: parseResult,
                codespaceName: codespaceName,
                exportId: exportId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Codespaces.CodespacesGetExportDetailsForAuthenticatedUserAsync(
                codespaceName: codespaceName,
                exportId: exportId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}