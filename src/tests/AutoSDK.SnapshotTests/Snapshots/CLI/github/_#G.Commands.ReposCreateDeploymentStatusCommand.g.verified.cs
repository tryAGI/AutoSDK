//HintName: G.Commands.ReposCreateDeploymentStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateDeploymentStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int deploymentId,
            global::G.ReposCreateDeploymentStatusRequestState state,
            string? targetUrl,
            string? logUrl,
            string? description,
            string? environment,
            string? environmentUrl,
            bool? autoInactive,
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

        private global::System.CommandLine.Argument<global::G.ReposCreateDeploymentStatusRequestState> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TargetUrl { get; } = new(
            name: "targetUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> LogUrl { get; } = new(
            name: "logUrl")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Environment { get; } = new(
            name: "environment")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> EnvironmentUrl { get; } = new(
            name: "environmentUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AutoInactive { get; } = new(
            name: "autoInactive")
        {
            Description = "",
        };
        public ReposCreateDeploymentStatusCommand(G.IApi client) : base(
            name: "repos",
            description: @"Users with `push` access can create deployment statuses for a given deployment.

OAuth app tokens and personal access tokens (classic) need the `repo_deployment` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(DeploymentId);
            Arguments.Add(State);
            Options.Add(TargetUrl);
            Options.Add(LogUrl);
            Options.Add(Description);
            Options.Add(Environment);
            Options.Add(EnvironmentUrl);
            Options.Add(AutoInactive);

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
            var state = parseResult.GetRequiredValue(State);
            var targetUrl = parseResult.GetRequiredValue(TargetUrl);
            var logUrl = parseResult.GetRequiredValue(LogUrl);
            var description = parseResult.GetRequiredValue(Description);
            var environment = parseResult.GetRequiredValue(Environment);
            var environmentUrl = parseResult.GetRequiredValue(EnvironmentUrl);
            var autoInactive = parseResult.GetRequiredValue(AutoInactive);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                deploymentId: deploymentId,
                state: state,
                targetUrl: targetUrl,
                logUrl: logUrl,
                description: description,
                environment: environment,
                environmentUrl: environmentUrl,
                autoInactive: autoInactive,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateDeploymentStatusAsync(
                owner: owner,
                repo: repo,
                deploymentId: deploymentId,
                state: state,
                targetUrl: targetUrl,
                logUrl: logUrl,
                description: description,
                environment: environment,
                environmentUrl: environmentUrl,
                autoInactive: autoInactive,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}