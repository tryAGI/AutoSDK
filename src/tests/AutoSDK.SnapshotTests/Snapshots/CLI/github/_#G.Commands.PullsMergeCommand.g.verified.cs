//HintName: G.Commands.PullsMergeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PullsMergeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int pullNumber,
            string? commitTitle,
            string? commitMessage,
            string? sha,
            global::G.PullsMergeRequestMergeMethod? mergeMethod,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PullRequestMergeResult response,
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

        private global::System.CommandLine.Option<string?> CommitTitle { get; } = new(
            name: "commitTitle")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CommitMessage { get; } = new(
            name: "commitMessage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Sha { get; } = new(
            name: "sha")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PullsMergeRequestMergeMethod?> MergeMethod { get; } = new(
            name: "mergeMethod")
        {
            Description = "",
        };
        public PullsMergeCommand(G.IApi client) : base(
            name: "pulls",
            description: @"Merges a pull request into the base branch.
This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see ""[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"" and ""[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).""")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(PullNumber);
            Options.Add(CommitTitle);
            Options.Add(CommitMessage);
            Options.Add(Sha);
            Options.Add(MergeMethod);

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
            var commitTitle = parseResult.GetRequiredValue(CommitTitle);
            var commitMessage = parseResult.GetRequiredValue(CommitMessage);
            var sha = parseResult.GetRequiredValue(Sha);
            var mergeMethod = parseResult.GetRequiredValue(MergeMethod);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                commitTitle: commitTitle,
                commitMessage: commitMessage,
                sha: sha,
                mergeMethod: mergeMethod,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Pulls.PullsMergeAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                commitTitle: commitTitle,
                commitMessage: commitMessage,
                sha: sha,
                mergeMethod: mergeMethod,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}