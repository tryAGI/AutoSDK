//HintName: G.Commands.PullsCreateReviewCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PullsCreateReviewCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int pullNumber,
            string? commitId,
            string? body,
            global::G.PullsCreateReviewRequestEvent? @event,
            global::System.Collections.Generic.IList<global::G.PullsCreateReviewRequestComment>? comments,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PullRequestReview response,
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

        private global::System.CommandLine.Option<string?> CommitId { get; } = new(
            name: "commitId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PullsCreateReviewRequestEvent?> Event { get; } = new(
            name: "@event")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.PullsCreateReviewRequestComment>?> Comments { get; } = new(
            name: "comments")
        {
            Description = "",
        };
        public PullsCreateReviewCommand(G.IApi client) : base(
            name: "pulls",
            description: @"Creates a review on a specified pull request.

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see ""[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"" and ""[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).""

Pull request reviews created in the `PENDING` state are not submitted and therefore do not include the `submitted_at` property in the response. To create a pending review for a pull request, leave the `event` parameter blank. For more information about submitting a `PENDING` review, see ""[Submit a review for a pull request](https://docs.github.com/rest/pulls/reviews#submit-a-review-for-a-pull-request).""

> [!NOTE]
> To comment on a specific line in a file, you need to first determine the position of that line in the diff. To see a pull request diff, add the `application/vnd.github.v3.diff` media type to the `Accept` header of a call to the [Get a pull request](https://docs.github.com/rest/pulls/pulls#get-a-pull-request) endpoint.

The `position` value equals the number of lines down from the first ""@@"" hunk header in the file you want to add a comment. The line just below the ""@@"" line is position 1, the next line is position 2, and so on. The position in the diff continues to increase through lines of whitespace and additional hunks until the beginning of a new file.

This endpoint supports the following custom media types. For more information, see ""[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).""

- **`application/vnd.github-commitcomment.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.
- **`application/vnd.github-commitcomment.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.
- **`application/vnd.github-commitcomment.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.
- **`application/vnd.github-commitcomment.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(PullNumber);
            Options.Add(CommitId);
            Options.Add(Body);
            Options.Add(Event);
            Options.Add(Comments);

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
            var commitId = parseResult.GetRequiredValue(CommitId);
            var body = parseResult.GetRequiredValue(Body);
            var @event = parseResult.GetRequiredValue(Event);
            var comments = parseResult.GetRequiredValue(Comments);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                commitId: commitId,
                body: body,
                @event: @event,
                comments: comments,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Pulls.PullsCreateReviewAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                commitId: commitId,
                body: body,
                @event: @event,
                comments: comments,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}