//HintName: G.Commands.ActionsSetSelfHostedRunnersInGroupForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsSetSelfHostedRunnersInGroupForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int runnerGroupId,
            global::System.Collections.Generic.IList<int> runners,
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

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<int>> Runners { get; } = new(
            name: "runners")
        {
            Description = "",
        };

        public ActionsSetSelfHostedRunnersInGroupForOrgCommand(G.IApi client) : base(
            name: "actions",
            description: @"Replaces the list of self-hosted runners that are part of an organization runner group.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(RunnerGroupId);
            Arguments.Add(Runners);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var runnerGroupId = parseResult.GetRequiredValue(RunnerGroupId);
            var runners = parseResult.GetRequiredValue(Runners);

            Validate(
                parseResult: parseResult,
                org: org,
                runnerGroupId: runnerGroupId,
                runners: runners,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsSetSelfHostedRunnersInGroupForOrgAsync(
                org: org,
                runnerGroupId: runnerGroupId,
                runners: runners,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}