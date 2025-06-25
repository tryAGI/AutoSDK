//HintName: G.Commands.ActionsReRunWorkflowCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsReRunWorkflowCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int runId,
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

        private global::System.CommandLine.Argument<int> RunId { get; } = new(
            name: "runId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> EnableDebugLogging { get; } = new(
            name: "enableDebugLogging")
        {
            Description = "",
        };
        public ActionsReRunWorkflowCommand(G.IApi client) : base(
            name: "actions",
            description: @"Re-runs your workflow run using its `id`.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(RunId);
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
            var runId = parseResult.GetRequiredValue(RunId);
            var enableDebugLogging = parseResult.GetRequiredValue(EnableDebugLogging);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                runId: runId,
                enableDebugLogging: enableDebugLogging,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsReRunWorkflowAsync(
                owner: owner,
                repo: repo,
                runId: runId,
                enableDebugLogging: enableDebugLogging,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}