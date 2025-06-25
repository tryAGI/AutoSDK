//HintName: G.Commands.IssuesCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.OneOf<string, int?> title,
            string? body,
            string? assignee,
            global::G.OneOf<string, int?>? milestone,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.IssuesCreateRequestLabel>>? labels,
            global::System.Collections.Generic.IList<string>? assignees,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Issue response,
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

        private global::System.CommandLine.Argument<global::G.OneOf<string, int?>> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Assignee { get; } = new(
            name: "assignee")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<string, int?>?> Milestone { get; } = new(
            name: "milestone")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.IssuesCreateRequestLabel>>?> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Assignees { get; } = new(
            name: "assignees")
        {
            Description = "",
        };
        public IssuesCreateCommand(G.IApi client) : base(
            name: "issues",
            description: @"Any user with pull access to a repository can create an issue. If [issues are disabled in the repository](https://docs.github.com/articles/disabling-issues/), the API returns a `410 Gone` status.

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see ""[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)""
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
            Arguments.Add(Title);
            Options.Add(Body);
            Options.Add(Assignee);
            Options.Add(Milestone);
            Options.Add(Labels);
            Options.Add(Assignees);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var title = parseResult.GetRequiredValue(Title);
            var body = parseResult.GetRequiredValue(Body);
            var assignee = parseResult.GetRequiredValue(Assignee);
            var milestone = parseResult.GetRequiredValue(Milestone);
            var labels = parseResult.GetRequiredValue(Labels);
            var assignees = parseResult.GetRequiredValue(Assignees);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                title: title,
                body: body,
                assignee: assignee,
                milestone: milestone,
                labels: labels,
                assignees: assignees,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Issues.IssuesCreateAsync(
                owner: owner,
                repo: repo,
                title: title,
                body: body,
                assignee: assignee,
                milestone: milestone,
                labels: labels,
                assignees: assignees,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}