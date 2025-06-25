//HintName: G.Commands.IssuesListForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesListForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::G.IssuesListForOrgFilter? filter,
            global::G.IssuesListForOrgState? state,
            string? labels,
            global::G.IssuesListForOrgSort? sort,
            global::G.IssuesListForOrgDirection? direction,
            global::System.DateTime? since,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Issue> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesListForOrgFilter?> Filter { get; } = new(
            name: "filter")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesListForOrgState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesListForOrgSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesListForOrgDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Since { get; } = new(
            name: "since")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };
        public IssuesListForOrgCommand(G.IApi client) : base(
            name: "issues",
            description: @"List issues in an organization assigned to the authenticated user.

> [!NOTE]
> GitHub's REST API considers every pull request an issue, but not every issue is a pull request. For this reason, ""Issues"" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from ""Issues"" endpoints will be an _issue id_. To find out the pull request id, use the ""[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)"" endpoint.

This endpoint supports the following custom media types. For more information, see ""[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).""

- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.
- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.
- **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.
- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(Filter);
            Options.Add(State);
            Options.Add(Labels);
            Options.Add(Sort);
            Options.Add(Direction);
            Options.Add(Since);
            Options.Add(PerPage);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var filter = parseResult.GetRequiredValue(Filter);
            var state = parseResult.GetRequiredValue(State);
            var labels = parseResult.GetRequiredValue(Labels);
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);
            var since = parseResult.GetRequiredValue(Since);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                org: org,
                filter: filter,
                state: state,
                labels: labels,
                sort: sort,
                direction: direction,
                since: since,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Issues.IssuesListForOrgAsync(
                org: org,
                filter: filter,
                state: state,
                labels: labels,
                sort: sort,
                direction: direction,
                since: since,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}