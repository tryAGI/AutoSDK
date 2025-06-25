//HintName: G.Commands.CodeSecuritySetConfigurationAsDefaultCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeSecuritySetConfigurationAsDefaultCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int configurationId,
            global::G.CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos? defaultForNewRepos,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodeSecuritySetConfigurationAsDefaultResponse response,
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

        private global::System.CommandLine.Option<global::G.CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos?> DefaultForNewRepos { get; } = new(
            name: "defaultForNewRepos")
        {
            Description = "",
        };
        public CodeSecuritySetConfigurationAsDefaultCommand(G.IApi client) : base(
            name: "code",
            description: @"Sets a code security configuration as a default to be applied to new repositories in your organization.

This configuration will be applied to the matching repository type (all, none, public, private and internal) by default when they are created.

The authenticated user must be an administrator or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(ConfigurationId);
            Options.Add(DefaultForNewRepos);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var configurationId = parseResult.GetRequiredValue(ConfigurationId);
            var defaultForNewRepos = parseResult.GetRequiredValue(DefaultForNewRepos);

            Validate(
                parseResult: parseResult,
                org: org,
                configurationId: configurationId,
                defaultForNewRepos: defaultForNewRepos,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeSecurity.CodeSecuritySetConfigurationAsDefaultAsync(
                org: org,
                configurationId: configurationId,
                defaultForNewRepos: defaultForNewRepos,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}