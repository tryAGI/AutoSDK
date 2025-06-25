//HintName: G.Commands.SearchCodeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SearchCodeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string q,
            global::G.SearchCodeSort? sort,
            global::G.SearchCodeOrder? order,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SearchCodeResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Q { get; } = new(
            name: "q")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SearchCodeSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SearchCodeOrder?> Order { get; } = new(
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
        public SearchCodeCommand(G.IApi client) : base(
            name: "search",
            description: @"Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).

When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).

For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:

`q=addClass+in:file+language:js+repo:jquery/jquery`

This query searches for the keyword `addClass` within a file's contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.

Considerations for code search:

Due to the complexity of searching code, there are a few restrictions on how searches are performed:

*   Only the _default branch_ is considered. In most cases, this will be the `master` branch.
*   Only files smaller than 384 KB are searchable.
*   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&q=language%3Ago&type=Code) is not valid, while [`amazing
language:go`](https://github.com/search?utf8=%E2%9C%93&q=amazing+language%3Ago&type=Code) is.

This endpoint requires you to authenticate and limits you to 10 requests per minute.")
        {
            _client = client;

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
            var q = parseResult.GetRequiredValue(Q);
            var sort = parseResult.GetRequiredValue(Sort);
            var order = parseResult.GetRequiredValue(Order);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                q: q,
                sort: sort,
                order: order,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Search.SearchCodeAsync(
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