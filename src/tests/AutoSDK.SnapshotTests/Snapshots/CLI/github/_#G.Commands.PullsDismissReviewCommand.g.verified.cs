//HintName: G.Commands.PullsDismissReviewCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PullsDismissReviewCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int pullNumber,
            int reviewId,
            string message,
            global::G.PullsDismissReviewRequestEvent? @event,
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

        private global::System.CommandLine.Argument<int> ReviewId { get; } = new(
            name: "reviewId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Message { get; } = new(
            name: "message")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PullsDismissReviewRequestEvent?> Event { get; } = new(
            name: "@event")
        {
            Description = "",
        };
        public PullsDismissReviewCommand(G.IApi client) : base(
            name: "pulls",
            description: @"Dismisses a specified review on a pull request.

> [!NOTE]
> To dismiss a pull request review on a [protected branch](https://docs.github.com/rest/branches/branch-protection), you must be a repository administrator or be included in the list of people or teams who can dismiss pull request reviews.

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
            Arguments.Add(ReviewId);
            Arguments.Add(Message);
            Options.Add(Event);

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
            var reviewId = parseResult.GetRequiredValue(ReviewId);
            var message = parseResult.GetRequiredValue(Message);
            var @event = parseResult.GetRequiredValue(Event);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                reviewId: reviewId,
                message: message,
                @event: @event,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Pulls.PullsDismissReviewAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                reviewId: reviewId,
                message: message,
                @event: @event,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}