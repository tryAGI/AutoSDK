//HintName: G.Commands.IssuesListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.IssuesListFilter? filter,
            global::G.IssuesListState? state,
            string? labels,
            global::G.IssuesListSort? sort,
            global::G.IssuesListDirection? direction,
            global::System.DateTime? since,
            bool? collab,
            bool? orgs,
            bool? owned,
            bool? pulls,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Issue> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.IssuesListFilter?> Filter { get; } = new(
            name: "filter")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesListState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesListSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesListDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Since { get; } = new(
            name: "since")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Collab { get; } = new(
            name: "collab")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Orgs { get; } = new(
            name: "orgs")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Owned { get; } = new(
            name: "owned")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Pulls { get; } = new(
            name: "pulls")
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
        public IssuesListCommand(G.IApi client) : base(
            name: "issues",
            description: @"List issues assigned to the authenticated user across all visible repositories including owned repositories, member
repositories, and organization repositories. You can use the `filter` query parameter to fetch issues that are not
necessarily assigned to you.

> [!NOTE]
> GitHub's REST API considers every pull request an issue, but not every issue is a pull request. For this reason, ""Issues"" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from ""Issues"" endpoints will be an _issue id_. To find out the pull request id, use the ""[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)"" endpoint.

This endpoint supports the following custom media types. For more information, see ""[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).""

- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.
- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.
- **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.
- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.")
        {
            _client = client;

            Options.Add(Filter);
            Options.Add(State);
            Options.Add(Labels);
            Options.Add(Sort);
            Options.Add(Direction);
            Options.Add(Since);
            Options.Add(Collab);
            Options.Add(Orgs);
            Options.Add(Owned);
            Options.Add(Pulls);
            Options.Add(PerPage);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var filter = parseResult.GetRequiredValue(Filter);
            var state = parseResult.GetRequiredValue(State);
            var labels = parseResult.GetRequiredValue(Labels);
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);
            var since = parseResult.GetRequiredValue(Since);
            var collab = parseResult.GetRequiredValue(Collab);
            var orgs = parseResult.GetRequiredValue(Orgs);
            var owned = parseResult.GetRequiredValue(Owned);
            var pulls = parseResult.GetRequiredValue(Pulls);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                filter: filter,
                state: state,
                labels: labels,
                sort: sort,
                direction: direction,
                since: since,
                collab: collab,
                orgs: orgs,
                owned: owned,
                pulls: pulls,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Issues.IssuesListAsync(
                filter: filter,
                state: state,
                labels: labels,
                sort: sort,
                direction: direction,
                since: since,
                collab: collab,
                orgs: orgs,
                owned: owned,
                pulls: pulls,
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