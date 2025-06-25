//HintName: G.Commands.CodeSecurityAttachConfigurationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeSecurityAttachConfigurationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int configurationId,
            global::G.CodeSecurityAttachConfigurationRequestScope scope,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds,
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

        private global::System.CommandLine.Argument<int> ConfigurationId { get; } = new(
            name: "configurationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.CodeSecurityAttachConfigurationRequestScope> Scope { get; } = new(
            name: "scope")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<int>?> SelectedRepositoryIds { get; } = new(
            name: "selectedRepositoryIds")
        {
            Description = "",
        };
        public CodeSecurityAttachConfigurationCommand(G.IApi client) : base(
            name: "code",
            description: @"Attach a code security configuration to a set of repositories. If the repositories specified are already attached to a configuration, they will be re-attached to the provided configuration.

If insufficient GHAS licenses are available to attach the configuration to a repository, only free features will be enabled.

The authenticated user must be an administrator or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(ConfigurationId);
            Arguments.Add(Scope);
            Options.Add(SelectedRepositoryIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var configurationId = parseResult.GetRequiredValue(ConfigurationId);
            var scope = parseResult.GetRequiredValue(Scope);
            var selectedRepositoryIds = parseResult.GetRequiredValue(SelectedRepositoryIds);

            Validate(
                parseResult: parseResult,
                org: org,
                configurationId: configurationId,
                scope: scope,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeSecurity.CodeSecurityAttachConfigurationAsync(
                org: org,
                configurationId: configurationId,
                scope: scope,
                selectedRepositoryIds: selectedRepositoryIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}