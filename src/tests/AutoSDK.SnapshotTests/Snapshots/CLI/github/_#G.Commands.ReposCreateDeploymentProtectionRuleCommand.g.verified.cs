//HintName: G.Commands.ReposCreateDeploymentProtectionRuleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateDeploymentProtectionRuleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string environmentName,
            string repo,
            string owner,
            int? integrationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentProtectionRule response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> EnvironmentName { get; } = new(
            name: "environmentName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> IntegrationId { get; } = new(
            name: "integrationId")
        {
            Description = "",
        };
        public ReposCreateDeploymentProtectionRuleCommand(G.IApi client) : base(
            name: "repos",
            description: @"Enable a custom deployment protection rule for an environment.

The authenticated user must have admin or owner permissions to the repository to use this endpoint.

For more information about the app that is providing this custom deployment rule, see the [documentation for the `GET /apps/{app_slug}` endpoint](https://docs.github.com/rest/apps/apps#get-an-app).

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(EnvironmentName);
            Arguments.Add(Repo);
            Arguments.Add(Owner);
            Options.Add(IntegrationId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var environmentName = parseResult.GetRequiredValue(EnvironmentName);
            var repo = parseResult.GetRequiredValue(Repo);
            var owner = parseResult.GetRequiredValue(Owner);
            var integrationId = parseResult.GetRequiredValue(IntegrationId);

            Validate(
                parseResult: parseResult,
                environmentName: environmentName,
                repo: repo,
                owner: owner,
                integrationId: integrationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateDeploymentProtectionRuleAsync(
                environmentName: environmentName,
                repo: repo,
                owner: owner,
                integrationId: integrationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}