//HintName: G.Commands.CodeSecurityGetRepositoriesForConfigurationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeSecurityGetRepositoriesForConfigurationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int configurationId,
            int? perPage,
            string? before,
            string? after,
            string? status,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.CodeSecurityConfigurationRepositories> response,
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

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };
        public CodeSecurityGetRepositoriesForConfigurationCommand(G.IApi client) : base(
            name: "code",
            description: @"Lists the repositories associated with a code security configuration in an organization.

The authenticated user must be an administrator or security manager for the organization to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(ConfigurationId);
            Options.Add(PerPage);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(Status);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var configurationId = parseResult.GetRequiredValue(ConfigurationId);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var status = parseResult.GetRequiredValue(Status);

            Validate(
                parseResult: parseResult,
                org: org,
                configurationId: configurationId,
                perPage: perPage,
                before: before,
                after: after,
                status: status,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeSecurity.CodeSecurityGetRepositoriesForConfigurationAsync(
                org: org,
                configurationId: configurationId,
                perPage: perPage,
                before: before,
                after: after,
                status: status,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}