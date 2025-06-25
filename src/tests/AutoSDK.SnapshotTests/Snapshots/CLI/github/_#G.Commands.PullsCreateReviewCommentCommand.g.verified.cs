//HintName: G.Commands.PullsCreateReviewCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PullsCreateReviewCommentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int pullNumber,
            string body,
            string commitId,
            string path,
            int? position,
            global::G.PullsCreateReviewCommentRequestSide? side,
            int? line,
            int? startLine,
            global::G.PullsCreateReviewCommentRequestStartSide? startSide,
            int? inReplyTo,
            global::G.PullsCreateReviewCommentRequestSubjectType? subjectType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PullRequestReviewComment response,
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

        private global::System.CommandLine.Argument<string> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> CommitId { get; } = new(
            name: "commitId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Path { get; } = new(
            name: "path")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Position { get; } = new(
            name: "position")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PullsCreateReviewCommentRequestSide?> Side { get; } = new(
            name: "side")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Line { get; } = new(
            name: "line")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> StartLine { get; } = new(
            name: "startLine")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PullsCreateReviewCommentRequestStartSide?> StartSide { get; } = new(
            name: "startSide")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> InReplyTo { get; } = new(
            name: "inReplyTo")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PullsCreateReviewCommentRequestSubjectType?> SubjectType { get; } = new(
            name: "subjectType")
        {
            Description = "",
        };
        public PullsCreateReviewCommentCommand(G.IApi client) : base(
            name: "pulls",
            description: @"Creates a review comment on the diff of a specified pull request. To add a regular comment to a pull request timeline, see ""[Create an issue comment](https://docs.github.com/rest/issues/comments#create-an-issue-comment).""

If your comment applies to more than one line in the pull request diff, you should use the parameters `line`, `side`, and optionally `start_line` and `start_side` in your request.

The `position` parameter is deprecated. If you use `position`, the `line`, `side`, `start_line`, and `start_side` parameters are not required.

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see ""[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)""
and ""[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).""

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
            Arguments.Add(Body);
            Arguments.Add(CommitId);
            Arguments.Add(Path);
            Options.Add(Position);
            Options.Add(Side);
            Options.Add(Line);
            Options.Add(StartLine);
            Options.Add(StartSide);
            Options.Add(InReplyTo);
            Options.Add(SubjectType);

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
            var body = parseResult.GetRequiredValue(Body);
            var commitId = parseResult.GetRequiredValue(CommitId);
            var path = parseResult.GetRequiredValue(Path);
            var position = parseResult.GetRequiredValue(Position);
            var side = parseResult.GetRequiredValue(Side);
            var line = parseResult.GetRequiredValue(Line);
            var startLine = parseResult.GetRequiredValue(StartLine);
            var startSide = parseResult.GetRequiredValue(StartSide);
            var inReplyTo = parseResult.GetRequiredValue(InReplyTo);
            var subjectType = parseResult.GetRequiredValue(SubjectType);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                body: body,
                commitId: commitId,
                path: path,
                position: position,
                side: side,
                line: line,
                startLine: startLine,
                startSide: startSide,
                inReplyTo: inReplyTo,
                subjectType: subjectType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Pulls.PullsCreateReviewCommentAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                body: body,
                commitId: commitId,
                path: path,
                position: position,
                side: side,
                line: line,
                startLine: startLine,
                startSide: startSide,
                inReplyTo: inReplyTo,
                subjectType: subjectType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}