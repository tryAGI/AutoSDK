//HintName: G.Commands.CodeSecurityDetachConfigurationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeSecurityDetachConfigurationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<int>?> SelectedRepositoryIds { get; } = new(
            name: "selectedRepositoryIds")
        {
            Description = "",
        };
        public CodeSecurityDetachConfigurationCommand(G.IApi client) : base(
            name: "code",
            description: @"Detach code security configuration(s) from a set of repositories.
Repositories will retain their settings but will no longer be associated with the configuration.

The authenticated user must be an administrator or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(SelectedRepositoryIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var selectedRepositoryIds = parseResult.GetRequiredValue(SelectedRepositoryIds);

            Validate(
                parseResult: parseResult,
                org: org,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.CodeSecurity.CodeSecurityDetachConfigurationAsync(
                org: org,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}