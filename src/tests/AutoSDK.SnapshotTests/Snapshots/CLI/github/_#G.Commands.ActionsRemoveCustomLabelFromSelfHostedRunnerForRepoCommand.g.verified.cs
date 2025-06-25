//HintName: G.Commands.ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int runnerId,
            string name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoResponse response,
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

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        public ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoCommand(G.IApi client) : base(
            name: "actions",
            description: @"Remove a custom label from a self-hosted runner configured
in a repository. Returns the remaining labels from the runner.

This endpoint returns a `404 Not Found` status if the custom label is not
present on the runner.

Authenticated users must have admin access to the repository to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(RunnerId);
            Arguments.Add(Name);

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
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                runnerId: runnerId,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsRemoveCustomLabelFromSelfHostedRunnerForRepoAsync(
                owner: owner,
                repo: repo,
                runnerId: runnerId,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}