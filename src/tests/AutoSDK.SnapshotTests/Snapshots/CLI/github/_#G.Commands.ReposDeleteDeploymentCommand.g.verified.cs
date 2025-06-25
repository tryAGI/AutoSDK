//HintName: G.Commands.ReposDeleteDeploymentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDeleteDeploymentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int deploymentId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> DeploymentId { get; } = new(
            name: "deploymentId")
        {
            Description = "",
        };

        public ReposDeleteDeploymentCommand(G.IApi client) : base(
            name: "repos",
            description: @"If the repository only has one deployment, you can delete the deployment regardless of its status. If the repository has more than one deployment, you can only delete inactive deployments. This ensures that repositories with multiple deployments will always have an active deployment.

To set a deployment as inactive, you must:

*   Create a new deployment that is active so that the system has a record of the current state, then delete the previously active deployment.
*   Mark the active deployment as inactive by adding any non-successful deployment status.

For more information, see ""[Create a deployment](https://docs.github.com/rest/deployments/deployments/#create-a-deployment)"" and ""[Create a deployment status](https://docs.github.com/rest/deployments/statuses#create-a-deployment-status).""

OAuth app tokens and personal access tokens (classic) need the `repo` or `repo_deployment` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(DeploymentId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var deploymentId = parseResult.GetRequiredValue(DeploymentId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                deploymentId: deploymentId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposDeleteDeploymentAsync(
                owner: owner,
                repo: repo,
                deploymentId: deploymentId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}