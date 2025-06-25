//HintName: G.Commands.ActionsCreateWorkflowDispatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsCreateWorkflowDispatchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.OneOf<int?, string> workflowId,
            string @ref,
            object? inputs,
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

        private global::System.CommandLine.Argument<global::G.OneOf<int?, string>> WorkflowId { get; } = new(
            name: "workflowId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> Inputs { get; } = new(
            name: "inputs")
        {
            Description = "",
        };
        public ActionsCreateWorkflowDispatchCommand(G.IApi client) : base(
            name: "actions",
            description: @"You can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.

You must configure your GitHub Actions workflow to run when the [`workflow_dispatch` webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The `inputs` are configured in the workflow file. For more information about how to configure the `workflow_dispatch` event in the workflow file, see ""[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch).""

OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(WorkflowId);
            Arguments.Add(Ref);
            Options.Add(Inputs);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var workflowId = parseResult.GetRequiredValue(WorkflowId);
            var @ref = parseResult.GetRequiredValue(Ref);
            var inputs = parseResult.GetRequiredValue(Inputs);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                workflowId: workflowId,
                @ref: @ref,
                inputs: inputs,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsCreateWorkflowDispatchAsync(
                owner: owner,
                repo: repo,
                workflowId: workflowId,
                @ref: @ref,
                inputs: inputs,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}