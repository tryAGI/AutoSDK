//HintName: G.Commands.ActionsGenerateRunnerJitconfigForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsGenerateRunnerJitconfigForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string name,
            int runnerGroupId,
            global::System.Collections.Generic.IList<string> labels,
            string? workFolder,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActionsGenerateRunnerJitconfigForRepoResponse response,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> RunnerGroupId { get; } = new(
            name: "runnerGroupId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> WorkFolder { get; } = new(
            name: "workFolder")
        {
            Description = "",
        };
        public ActionsGenerateRunnerJitconfigForRepoCommand(G.IApi client) : base(
            name: "actions",
            description: @"Generates a configuration that can be passed to the runner application at startup.

The authenticated user must have admin access to the repository.

OAuth tokens and personal access tokens (classic) need the`repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Name);
            Arguments.Add(RunnerGroupId);
            Arguments.Add(Labels);
            Options.Add(WorkFolder);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var name = parseResult.GetRequiredValue(Name);
            var runnerGroupId = parseResult.GetRequiredValue(RunnerGroupId);
            var labels = parseResult.GetRequiredValue(Labels);
            var workFolder = parseResult.GetRequiredValue(WorkFolder);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                name: name,
                runnerGroupId: runnerGroupId,
                labels: labels,
                workFolder: workFolder,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsGenerateRunnerJitconfigForRepoAsync(
                owner: owner,
                repo: repo,
                name: name,
                runnerGroupId: runnerGroupId,
                labels: labels,
                workFolder: workFolder,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}