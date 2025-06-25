//HintName: G.Commands.ActionsAddCustomLabelsToSelfHostedRunnerForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsAddCustomLabelsToSelfHostedRunnerForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int runnerId,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActionsAddCustomLabelsToSelfHostedRunnerForRepoResponse response,
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

        private global::System.CommandLine.Argument<int> RunnerId { get; } = new(
            name: "runnerId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };

        public ActionsAddCustomLabelsToSelfHostedRunnerForRepoCommand(G.IApi client) : base(
            name: "actions",
            description: @"Adds custom labels to a self-hosted runner configured in a repository.

Authenticated users must have admin access to the organization to use this endpoint.

OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(RunnerId);
            Arguments.Add(Labels);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var runnerId = parseResult.GetRequiredValue(RunnerId);
            var labels = parseResult.GetRequiredValue(Labels);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                runnerId: runnerId,
                labels: labels,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsAddCustomLabelsToSelfHostedRunnerForRepoAsync(
                owner: owner,
                repo: repo,
                runnerId: runnerId,
                labels: labels,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}