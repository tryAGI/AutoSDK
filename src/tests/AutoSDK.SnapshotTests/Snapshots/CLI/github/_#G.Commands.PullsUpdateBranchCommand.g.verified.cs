//HintName: G.Commands.PullsUpdateBranchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PullsUpdateBranchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int pullNumber,
            string? expectedHeadSha,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PullsUpdateBranchResponse response,
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

        private global::System.CommandLine.Argument<int> PullNumber { get; } = new(
            name: "pullNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ExpectedHeadSha { get; } = new(
            name: "expectedHeadSha")
        {
            Description = "",
        };
        public PullsUpdateBranchCommand(G.IApi client) : base(
            name: "pulls",
            description: @"Updates the pull request branch with the latest upstream changes by merging HEAD from the base branch into the pull request branch.
Note: If making a request on behalf of a GitHub App you must also have permissions to write the contents of the head repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(PullNumber);
            Options.Add(ExpectedHeadSha);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var pullNumber = parseResult.GetRequiredValue(PullNumber);
            var expectedHeadSha = parseResult.GetRequiredValue(ExpectedHeadSha);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                expectedHeadSha: expectedHeadSha,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Pulls.PullsUpdateBranchAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                expectedHeadSha: expectedHeadSha,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}