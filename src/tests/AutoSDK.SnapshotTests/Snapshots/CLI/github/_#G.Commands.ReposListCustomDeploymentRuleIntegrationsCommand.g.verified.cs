//HintName: G.Commands.ReposListCustomDeploymentRuleIntegrationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposListCustomDeploymentRuleIntegrationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string environmentName,
            string repo,
            string owner,
            int? page,
            int? perPage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ReposListCustomDeploymentRuleIntegrationsResponse response,
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

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };
        public ReposListCustomDeploymentRuleIntegrationsCommand(G.IApi client) : base(
            name: "repos",
            description: @"Gets all custom deployment protection rule integrations that are available for an environment.

The authenticated user must have admin or owner permissions to the repository to use this endpoint.

For more information about environments, see ""[Using environments for deployment](https://docs.github.com/actions/deployment/targeting-different-environments/using-environments-for-deployment).""

For more information about the app that is providing this custom deployment rule, see ""[GET an app](https://docs.github.com/rest/apps/apps#get-an-app)"".

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.")
        {
            _client = client;

            Arguments.Add(EnvironmentName);
            Arguments.Add(Repo);
            Arguments.Add(Owner);
            Options.Add(Page);
            Options.Add(PerPage);

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
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);

            Validate(
                parseResult: parseResult,
                environmentName: environmentName,
                repo: repo,
                owner: owner,
                page: page,
                perPage: perPage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposListCustomDeploymentRuleIntegrationsAsync(
                environmentName: environmentName,
                repo: repo,
                owner: owner,
                page: page,
                perPage: perPage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}