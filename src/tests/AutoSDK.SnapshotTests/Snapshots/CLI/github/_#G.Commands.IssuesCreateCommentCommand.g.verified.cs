//HintName: G.Commands.IssuesCreateCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesCreateCommentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int issueNumber,
            string body,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.IssueComment response,
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

        private global::System.CommandLine.Argument<int> IssueNumber { get; } = new(
            name: "issueNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        public IssuesCreateCommentCommand(G.IApi client) : base(
            name: "issues",
            description: @"You can use the REST API to create comments on issues and pull requests. Every pull request is an issue, but not every issue is a pull request.

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications).
Creating content too quickly using this endpoint may result in secondary rate limiting.
For more information, see ""[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)""
and ""[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).""

This endpoint supports the following custom media types. For more information, see ""[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).""

- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.
- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.
- **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.
- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(IssueNumber);
            Arguments.Add(Body);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var issueNumber = parseResult.GetRequiredValue(IssueNumber);
            var body = parseResult.GetRequiredValue(Body);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                body: body,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Issues.IssuesCreateCommentAsync(
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                body: body,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}