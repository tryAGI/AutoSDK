//HintName: G.Commands.ActionsGetWorkflowRunAttemptCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsGetWorkflowRunAttemptCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int runId,
            int attemptNumber,
            bool? excludePullRequests,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.WorkflowRun response,
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

        private global::System.CommandLine.Argument<int> AttemptNumber { get; } = new(
            name: "attemptNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ExcludePullRequests { get; } = new(
            name: "excludePullRequests")
        {
            Description = "",
        };
        public ActionsGetWorkflowRunAttemptCommand(G.IApi client) : base(
            name: "actions",
            description: @"Gets a specific workflow run attempt.

Anyone with read access to the repository can use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(RunId);
            Arguments.Add(AttemptNumber);
            Options.Add(ExcludePullRequests);

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
            var attemptNumber = parseResult.GetRequiredValue(AttemptNumber);
            var excludePullRequests = parseResult.GetRequiredValue(ExcludePullRequests);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                runId: runId,
                attemptNumber: attemptNumber,
                excludePullRequests: excludePullRequests,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsGetWorkflowRunAttemptAsync(
                owner: owner,
                repo: repo,
                runId: runId,
                attemptNumber: attemptNumber,
                excludePullRequests: excludePullRequests,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}