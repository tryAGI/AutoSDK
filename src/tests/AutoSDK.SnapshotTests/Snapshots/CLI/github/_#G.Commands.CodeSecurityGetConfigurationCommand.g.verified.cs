//HintName: G.Commands.CodeSecurityGetConfigurationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeSecurityGetConfigurationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int configurationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodeSecurityConfiguration response,
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

        public CodeSecurityGetConfigurationCommand(G.IApi client) : base(
            name: "code",
            description: @"Gets a code security configuration available in an organization.

The authenticated user must be an administrator or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(ConfigurationId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var configurationId = parseResult.GetRequiredValue(ConfigurationId);

            Validate(
                parseResult: parseResult,
                org: org,
                configurationId: configurationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeSecurity.CodeSecurityGetConfigurationAsync(
                org: org,
                configurationId: configurationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}