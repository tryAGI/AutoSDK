//HintName: G.Commands.IssuesListForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesListForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? milestone,
            global::G.IssuesListForRepoState? state,
            string? assignee,
            string? creator,
            string? mentioned,
            string? labels,
            global::G.IssuesListForRepoSort? sort,
            global::G.IssuesListForRepoDirection? direction,
            global::System.DateTime? since,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Issue> response,
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

        private global::System.CommandLine.Option<string?> Milestone { get; } = new(
            name: "milestone")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesListForRepoState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Assignee { get; } = new(
            name: "assignee")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Creator { get; } = new(
            name: "creator")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Mentioned { get; } = new(
            name: "mentioned")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesListForRepoSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesListForRepoDirection?> Direction { get; } = new(
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
        public IssuesListForRepoCommand(G.IApi client) : base(
            name: "issues",
            description: @"List issues in a repository. Only open issues will be listed.

> [!NOTE]
> GitHub's REST API considers every pull request an issue, but not every issue is a pull request. For this reason, ""Issues"" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from ""Issues"" endpoints will be an _issue id_. To find out the pull request id, use the ""[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)"" endpoint.

This endpoint supports the following custom media types. For more information, see ""[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).""

- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.
- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.
- **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.
- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Milestone);
            Options.Add(State);
            Options.Add(Assignee);
            Options.Add(Creator);
            Options.Add(Mentioned);
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
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var milestone = parseResult.GetRequiredValue(Milestone);
            var state = parseResult.GetRequiredValue(State);
            var assignee = parseResult.GetRequiredValue(Assignee);
            var creator = parseResult.GetRequiredValue(Creator);
            var mentioned = parseResult.GetRequiredValue(Mentioned);
            var labels = parseResult.GetRequiredValue(Labels);
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);
            var since = parseResult.GetRequiredValue(Since);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                milestone: milestone,
                state: state,
                assignee: assignee,
                creator: creator,
                mentioned: mentioned,
                labels: labels,
                sort: sort,
                direction: direction,
                since: since,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Issues.IssuesListForRepoAsync(
                owner: owner,
                repo: repo,
                milestone: milestone,
                state: state,
                assignee: assignee,
                creator: creator,
                mentioned: mentioned,
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