//HintName: G.Commands.ActionsGetSelfHostedRunnerGroupForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsGetSelfHostedRunnerGroupForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int runnerGroupId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RunnerGroupsOrg response,
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

        public ActionsGetSelfHostedRunnerGroupForOrgCommand(G.IApi client) : base(
            name: "actions",
            description: @"Gets a specific self-hosted runner group for an organization.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(RunnerGroupId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var runnerGroupId = parseResult.GetRequiredValue(RunnerGroupId);

            Validate(
                parseResult: parseResult,
                org: org,
                runnerGroupId: runnerGroupId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsGetSelfHostedRunnerGroupForOrgAsync(
                org: org,
                runnerGroupId: runnerGroupId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}