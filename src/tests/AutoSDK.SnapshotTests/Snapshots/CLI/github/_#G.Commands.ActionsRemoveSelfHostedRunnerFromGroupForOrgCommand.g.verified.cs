//HintName: G.Commands.ActionsRemoveSelfHostedRunnerFromGroupForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsRemoveSelfHostedRunnerFromGroupForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int runnerGroupId,
            int runnerId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> RunnerGroupId { get; } = new(
            name: "runnerGroupId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> RunnerId { get; } = new(
            name: "runnerId")
        {
            Description = "",
        };

        public ActionsRemoveSelfHostedRunnerFromGroupForOrgCommand(G.IApi client) : base(
            name: "actions",
            description: @"Removes a self-hosted runner from a group configured in an organization. The runner is then returned to the default group.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(RunnerGroupId);
            Arguments.Add(RunnerId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var runnerGroupId = parseResult.GetRequiredValue(RunnerGroupId);
            var runnerId = parseResult.GetRequiredValue(RunnerId);

            Validate(
                parseResult: parseResult,
                org: org,
                runnerGroupId: runnerGroupId,
                runnerId: runnerId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsRemoveSelfHostedRunnerFromGroupForOrgAsync(
                org: org,
                runnerGroupId: runnerGroupId,
                runnerId: runnerId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}