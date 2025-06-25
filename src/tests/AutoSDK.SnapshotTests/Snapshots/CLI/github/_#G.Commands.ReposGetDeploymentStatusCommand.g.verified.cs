//HintName: G.Commands.ReposGetDeploymentStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGetDeploymentStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int deploymentId,
            int statusId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentStatus response,
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

        private global::System.CommandLine.Argument<int> StatusId { get; } = new(
            name: "statusId")
        {
            Description = "",
        };

        public ReposGetDeploymentStatusCommand(G.IApi client) : base(
            name: "repos",
            description: @"Users with pull access can view a deployment status for a deployment:")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(DeploymentId);
            Arguments.Add(StatusId);

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
            var statusId = parseResult.GetRequiredValue(StatusId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                deploymentId: deploymentId,
                statusId: statusId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposGetDeploymentStatusAsync(
                owner: owner,
                repo: repo,
                deploymentId: deploymentId,
                statusId: statusId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}