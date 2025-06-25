//HintName: G.Commands.ReposCreateOrUpdateEnvironmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateOrUpdateEnvironmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string environmentName,
            int? waitTimer,
            bool? preventSelfReview,
            global::System.Collections.Generic.IList<global::G.ReposCreateOrUpdateEnvironmentRequestReviewer>? reviewers,
            global::G.DeploymentBranchPolicySettings? deploymentBranchPolicy,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Environment response,
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

        private global::System.CommandLine.Argument<string> EnvironmentName { get; } = new(
            name: "environmentName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> WaitTimer { get; } = new(
            name: "waitTimer")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> PreventSelfReview { get; } = new(
            name: "preventSelfReview")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ReposCreateOrUpdateEnvironmentRequestReviewer>?> Reviewers { get; } = new(
            name: "reviewers")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.DeploymentBranchPolicySettings?> DeploymentBranchPolicy { get; } = new(
            name: "deploymentBranchPolicy")
        {
            Description = "",
        };
        public ReposCreateOrUpdateEnvironmentCommand(G.IApi client) : base(
            name: "repos",
            description: @"Create or update an environment with protection rules, such as required reviewers. For more information about environment protection rules, see ""[Environments](/actions/reference/environments#environment-protection-rules).""

> [!NOTE]
> To create or update name patterns that branches must match in order to deploy to this environment, see ""[Deployment branch policies](/rest/deployments/branch-policies).""

> [!NOTE]
> To create or update secrets for an environment, see ""[GitHub Actions secrets](/rest/actions/secrets).""

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(EnvironmentName);
            Options.Add(WaitTimer);
            Options.Add(PreventSelfReview);
            Options.Add(Reviewers);
            Options.Add(DeploymentBranchPolicy);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var environmentName = parseResult.GetRequiredValue(EnvironmentName);
            var waitTimer = parseResult.GetRequiredValue(WaitTimer);
            var preventSelfReview = parseResult.GetRequiredValue(PreventSelfReview);
            var reviewers = parseResult.GetRequiredValue(Reviewers);
            var deploymentBranchPolicy = parseResult.GetRequiredValue(DeploymentBranchPolicy);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                waitTimer: waitTimer,
                preventSelfReview: preventSelfReview,
                reviewers: reviewers,
                deploymentBranchPolicy: deploymentBranchPolicy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateOrUpdateEnvironmentAsync(
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                waitTimer: waitTimer,
                preventSelfReview: preventSelfReview,
                reviewers: reviewers,
                deploymentBranchPolicy: deploymentBranchPolicy,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}