//HintName: G.Commands.ActionsReviewPendingDeploymentsForRunCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsReviewPendingDeploymentsForRunCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int runId,
            global::System.Collections.Generic.IList<int> environmentIds,
            global::G.ActionsReviewPendingDeploymentsForRunRequestState state,
            string comment,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Deployment> response,
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

        private global::System.CommandLine.Argument<int> RunId { get; } = new(
            name: "runId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<int>> EnvironmentIds { get; } = new(
            name: "environmentIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.ActionsReviewPendingDeploymentsForRunRequestState> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Comment { get; } = new(
            name: "comment")
        {
            Description = "",
        };

        public ActionsReviewPendingDeploymentsForRunCommand(G.IApi client) : base(
            name: "actions",
            description: @"Approve or reject pending deployments that are waiting on approval by a required reviewer.

Required reviewers with read access to the repository contents and deployments can use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(RunId);
            Arguments.Add(EnvironmentIds);
            Arguments.Add(State);
            Arguments.Add(Comment);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var runId = parseResult.GetRequiredValue(RunId);
            var environmentIds = parseResult.GetRequiredValue(EnvironmentIds);
            var state = parseResult.GetRequiredValue(State);
            var comment = parseResult.GetRequiredValue(Comment);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                runId: runId,
                environmentIds: environmentIds,
                state: state,
                comment: comment,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsReviewPendingDeploymentsForRunAsync(
                owner: owner,
                repo: repo,
                runId: runId,
                environmentIds: environmentIds,
                state: state,
                comment: comment,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}