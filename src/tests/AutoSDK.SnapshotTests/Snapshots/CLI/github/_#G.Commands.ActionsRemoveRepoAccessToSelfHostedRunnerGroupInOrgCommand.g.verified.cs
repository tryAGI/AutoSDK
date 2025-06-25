//HintName: G.Commands.ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int runnerGroupId,
            int repositoryId,
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

        private global::System.CommandLine.Argument<int> RepositoryId { get; } = new(
            name: "repositoryId")
        {
            Description = "",
        };

        public ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrgCommand(G.IApi client) : base(
            name: "actions",
            description: @"Removes a repository from the list of selected repositories that can access a self-hosted runner group. The runner group must have `visibility` set to `selected`. For more information, see ""[Create a self-hosted runner group for an organization](#create-a-self-hosted-runner-group-for-an-organization).""

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(RunnerGroupId);
            Arguments.Add(RepositoryId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var runnerGroupId = parseResult.GetRequiredValue(RunnerGroupId);
            var repositoryId = parseResult.GetRequiredValue(RepositoryId);

            Validate(
                parseResult: parseResult,
                org: org,
                runnerGroupId: runnerGroupId,
                repositoryId: repositoryId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsRemoveRepoAccessToSelfHostedRunnerGroupInOrgAsync(
                org: org,
                runnerGroupId: runnerGroupId,
                repositoryId: repositoryId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}