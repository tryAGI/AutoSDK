//HintName: G.Commands.PipelinePublicServiceListPipelineRunsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListPipelineRunsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            int? page,
            int? pageSize,
            string? filter,
            string? orderBy,
            string? instillRequesterUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListPipelineRunsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"The ID of the owner of the pipeline.",
        };

        private global::System.CommandLine.Argument<string> PipelineId { get; } = new(
            name: "pipelineId")
        {
            Description = @"The ID of the pipeline for which the runs will be listed.",
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

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = @"Indicates the authenticated namespace is making the request on behalf of another entity, typically an organization they belong to",
        };
        public PipelinePublicServiceListPipelineRunsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Returns a paginated list of runs for a given pipeline. When the requester
is the owner of the pipeline, they will be able to all the pipeline runs,
regardless the requester. Other requesters will only be able to see the
runs requested by themselves.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Options.Add(Page);
            Options.Add(PageSize);
            Options.Add(Filter);
            Options.Add(OrderBy);
            Options.Add(InstillRequesterUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pipelineId = parseResult.GetRequiredValue(PipelineId);
            var page = parseResult.GetRequiredValue(Page);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var filter = parseResult.GetRequiredValue(Filter);
            var orderBy = parseResult.GetRequiredValue(OrderBy);
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                page: page,
                pageSize: pageSize,
                filter: filter,
                orderBy: orderBy,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceListPipelineRunsAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                page: page,
                pageSize: pageSize,
                filter: filter,
                orderBy: orderBy,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}