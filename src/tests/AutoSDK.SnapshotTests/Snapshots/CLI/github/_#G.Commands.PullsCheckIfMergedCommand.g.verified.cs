//HintName: G.Commands.PullsCheckIfMergedCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PullsCheckIfMergedCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int pullNumber,
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

        private global::System.CommandLine.Argument<int> PullNumber { get; } = new(
            name: "pullNumber")
        {
            Description = "",
        };

        public PullsCheckIfMergedCommand(G.IApi client) : base(
            name: "pulls",
            description: @"Checks if a pull request has been merged into the base branch. The HTTP status of the response indicates whether or not the pull request has been merged; the response body is empty.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(PullNumber);

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

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Pulls.PullsCheckIfMergedAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}