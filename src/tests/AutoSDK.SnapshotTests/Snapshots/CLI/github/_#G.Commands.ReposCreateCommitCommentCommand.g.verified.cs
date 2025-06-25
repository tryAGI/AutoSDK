//HintName: G.Commands.ReposCreateCommitCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateCommitCommentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string commitSha,
            string body,
            string? path,
            int? position,
            int? line,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CommitComment response,
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

        private global::System.CommandLine.Argument<string> CommitSha { get; } = new(
            name: "commitSha")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Path { get; } = new(
            name: "path")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Position { get; } = new(
            name: "position")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Line { get; } = new(
            name: "line")
        {
            Description = "",
        };
        public ReposCreateCommitCommentCommand(G.IApi client) : base(
            name: "repos",
            description: @"Create a comment for a commit using its `:commit_sha`.

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see ""[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"" and ""[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).""

This endpoint supports the following custom media types. For more information, see ""[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).""

- **`application/vnd.github-commitcomment.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.
- **`application/vnd.github-commitcomment.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.
- **`application/vnd.github-commitcomment.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.
- **`application/vnd.github-commitcomment.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(CommitSha);
            Arguments.Add(Body);
            Options.Add(Path);
            Options.Add(Position);
            Options.Add(Line);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var commitSha = parseResult.GetRequiredValue(CommitSha);
            var body = parseResult.GetRequiredValue(Body);
            var path = parseResult.GetRequiredValue(Path);
            var position = parseResult.GetRequiredValue(Position);
            var line = parseResult.GetRequiredValue(Line);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                commitSha: commitSha,
                body: body,
                path: path,
                position: position,
                line: line,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateCommitCommentAsync(
                owner: owner,
                repo: repo,
                commitSha: commitSha,
                body: body,
                path: path,
                position: position,
                line: line,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}