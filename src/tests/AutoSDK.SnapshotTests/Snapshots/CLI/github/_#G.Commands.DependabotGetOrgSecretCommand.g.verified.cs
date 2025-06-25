//HintName: G.Commands.DependabotGetOrgSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DependabotGetOrgSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OrganizationDependabotSecret response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> SecretName { get; } = new(
            name: "secretName")
        {
            Description = "",
        };

        public DependabotGetOrgSecretCommand(G.IApi client) : base(
            name: "dependabot",
            description: @"Gets a single organization secret without revealing its encrypted value.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(SecretName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var secretName = parseResult.GetRequiredValue(SecretName);

            Validate(
                parseResult: parseResult,
                org: org,
                secretName: secretName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dependabot.DependabotGetOrgSecretAsync(
                org: org,
                secretName: secretName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}