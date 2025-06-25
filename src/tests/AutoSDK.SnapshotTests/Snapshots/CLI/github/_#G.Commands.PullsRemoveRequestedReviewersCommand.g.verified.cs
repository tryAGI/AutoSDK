//HintName: G.Commands.PullsRemoveRequestedReviewersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PullsRemoveRequestedReviewersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int pullNumber,
            global::System.Collections.Generic.IList<string> reviewers,
            global::System.Collections.Generic.IList<string>? teamReviewers,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PullRequestSimple response,
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

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Reviewers { get; } = new(
            name: "reviewers")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> TeamReviewers { get; } = new(
            name: "teamReviewers")
        {
            Description = "",
        };
        public PullsRemoveRequestedReviewersCommand(G.IApi client) : base(
            name: "pulls",
            description: @"Removes review requests from a pull request for a given set of users and/or teams.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(PullNumber);
            Arguments.Add(Reviewers);
            Options.Add(TeamReviewers);

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
            var reviewers = parseResult.GetRequiredValue(Reviewers);
            var teamReviewers = parseResult.GetRequiredValue(TeamReviewers);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                reviewers: reviewers,
                teamReviewers: teamReviewers,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Pulls.PullsRemoveRequestedReviewersAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                reviewers: reviewers,
                teamReviewers: teamReviewers,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}