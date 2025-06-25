//HintName: G.Commands.SearchLabelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchLabelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int repositoryId,
            string q,
            global::G.SearchLabelsSort? sort,
            global::G.SearchLabelsOrder? order,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SearchLabelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> RepositoryId { get; } = new(
            name: "repositoryId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Q { get; } = new(
            name: "q")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SearchLabelsSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SearchLabelsOrder?> Order { get; } = new(
            name: "order")
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
        public SearchLabelsCommand(G.IApi client) : base(
            name: "search",
            description: @"Find labels in a repository with names or descriptions that match search keywords. Returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).

When searching for labels, you can get text match metadata for the label **name** and **description** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).

For example, if you want to find labels in the `linguist` repository that match `bug`, `defect`, or `enhancement`. Your query might look like this:

`q=bug+defect+enhancement&repository_id=64778136`

The labels that best match the query appear first in the search results.")
        {
            _client = client;

            Arguments.Add(RepositoryId);
            Arguments.Add(Q);
            Options.Add(Sort);
            Options.Add(Order);
            Options.Add(PerPage);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var repositoryId = parseResult.GetRequiredValue(RepositoryId);
            var q = parseResult.GetRequiredValue(Q);
            var sort = parseResult.GetRequiredValue(Sort);
            var order = parseResult.GetRequiredValue(Order);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                repositoryId: repositoryId,
                q: q,
                sort: sort,
                order: order,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Search.SearchLabelsAsync(
                repositoryId: repositoryId,
                q: q,
                sort: sort,
                order: order,
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