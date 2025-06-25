//HintName: G.Commands.ActionsReRunJobForWorkflowRunCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsReRunJobForWorkflowRunCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int jobId,
            bool? enableDebugLogging,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmptyObject response,
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

        private global::System.CommandLine.Argument<int> JobId { get; } = new(
            name: "jobId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> EnableDebugLogging { get; } = new(
            name: "enableDebugLogging")
        {
            Description = "",
        };
        public ActionsReRunJobForWorkflowRunCommand(G.IApi client) : base(
            name: "actions",
            description: @"Re-run a job and its dependent jobs in a workflow run.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(JobId);
            Options.Add(EnableDebugLogging);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var jobId = parseResult.GetRequiredValue(JobId);
            var enableDebugLogging = parseResult.GetRequiredValue(EnableDebugLogging);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                jobId: jobId,
                enableDebugLogging: enableDebugLogging,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsReRunJobForWorkflowRunAsync(
                owner: owner,
                repo: repo,
                jobId: jobId,
                enableDebugLogging: enableDebugLogging,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}