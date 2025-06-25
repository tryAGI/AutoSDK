//HintName: G.Commands.CodespacesUpdateForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesUpdateForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string codespaceName,
            string? machine,
            string? displayName,
            global::System.Collections.Generic.IList<string>? recentFolders,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Codespace response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CodespaceName { get; } = new(
            name: "codespaceName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Machine { get; } = new(
            name: "machine")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> DisplayName { get; } = new(
            name: "displayName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> RecentFolders { get; } = new(
            name: "recentFolders")
        {
            Description = "",
        };
        public CodespacesUpdateForAuthenticatedUserCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Updates a codespace owned by the authenticated user. Currently only the codespace's machine type and recent folders can be modified using this endpoint.

If you specify a new machine type it will be applied the next time your codespace is started.

OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(CodespaceName);
            Options.Add(Machine);
            Options.Add(DisplayName);
            Options.Add(RecentFolders);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var codespaceName = parseResult.GetRequiredValue(CodespaceName);
            var machine = parseResult.GetRequiredValue(Machine);
            var displayName = parseResult.GetRequiredValue(DisplayName);
            var recentFolders = parseResult.GetRequiredValue(RecentFolders);

            Validate(
                parseResult: parseResult,
                codespaceName: codespaceName,
                machine: machine,
                displayName: displayName,
                recentFolders: recentFolders,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Codespaces.CodespacesUpdateForAuthenticatedUserAsync(
                codespaceName: codespaceName,
                machine: machine,
                displayName: displayName,
                recentFolders: recentFolders,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}