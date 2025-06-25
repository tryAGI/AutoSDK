//HintName: G.Commands.PipelinePublicServiceListComponentRunsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListComponentRunsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string pipelineRunId,
            int? page,
            int? pageSize,
            string? filter,
            string? orderBy,
            global::G.PipelinePublicServiceListComponentRunsView? view,
            string? instillRequesterUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListComponentRunsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> PipelineRunId { get; } = new(
            name: "pipelineRunId")
        {
            Description = @"The unique identifier of the pipeline run to list component runs for.",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"The page number to retrieve.",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The maximum number of items per page to return. The default and cap values
are 10 and 100, respectively.",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Filter can hold an [AIP-160](https://google.aip.dev/160)-compliant filter
expression.
- Example: `create_time>timestamp(""2000-06-19T23:31:08.657Z"")`.",
        };

        private global::System.CommandLine.Option<string?> OrderBy { get; } = new(
            name: "orderBy")
        {
            Description = @"Order by field, with options for ordering by `id`, `create_time` or `update_time`.
Format: `order_by=id` or `order_by=create_time desc`, default is `asc`.",
        };

        private global::System.CommandLine.Option<global::G.PipelinePublicServiceListComponentRunsView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired run view in the response.
The basic view excludes input / output data.

 - VIEW_BASIC: Default view, only includes basic information.
 - VIEW_FULL: Full representation.
 - VIEW_RECIPE: Contains the recipe of the resource.",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = @"Indicates the authenticated namespace is making the request on behalf of another entity, typically an organization they belong to",
        };
        public PipelinePublicServiceListComponentRunsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Returns the information of each component execution within a pipeline run.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(PipelineRunId);
            Options.Add(Page);
            Options.Add(PageSize);
            Options.Add(Filter);
            Options.Add(OrderBy);
            Options.Add(View);
            Options.Add(InstillRequesterUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pipelineRunId = parseResult.GetRequiredValue(PipelineRunId);
            var page = parseResult.GetRequiredValue(Page);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var filter = parseResult.GetRequiredValue(Filter);
            var orderBy = parseResult.GetRequiredValue(OrderBy);
            var view = parseResult.GetRequiredValue(View);
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);

            Validate(
                parseResult: parseResult,
                pipelineRunId: pipelineRunId,
                page: page,
                pageSize: pageSize,
                filter: filter,
                orderBy: orderBy,
                view: view,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceListComponentRunsAsync(
                pipelineRunId: pipelineRunId,
                page: page,
                pageSize: pageSize,
                filter: filter,
                orderBy: orderBy,
                view: view,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}