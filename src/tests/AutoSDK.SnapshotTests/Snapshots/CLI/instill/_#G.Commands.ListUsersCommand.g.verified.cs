//HintName: G.Commands.ListUsersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListUsersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? pageSize,
            string? pageToken,
            global::G.ListUsersView? view,
            string? filter,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListUsersResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The maximum number of users to return. If this parameter is unspecified,
at most 10 pipelines will be returned. The cap value for this parameter is
100 (i.e. any value above that will be coerced to 100).",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"Page token.",
        };

        private global::System.CommandLine.Option<global::G.ListUsersView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired resource view in the response.

 - VIEW_BASIC: Default view, only includes basic information.
 - VIEW_FULL: Full representation.",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Filter can hold an [AIP-160](https://google.aip.dev/160)-compliant filter
expression.
- Example: `create_time>timestamp(""2000-06-19T23:31:08.657Z"")`.",
        };
        public ListUsersCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Returns a paginated list of users.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(View);
            Options.Add(Filter);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var view = parseResult.GetRequiredValue(View);
            var filter = parseResult.GetRequiredValue(Filter);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                filter: filter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Namespace.ListUsersAsync(
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                filter: filter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}