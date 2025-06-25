//HintName: G.Commands.PipelinePublicServiceListPipelineRunsByRequesterCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListPipelineRunsByRequesterCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? page,
            int? pageSize,
            string? filter,
            string? orderBy,
            global::System.DateTime? start,
            global::System.DateTime? stop,
            string requesterId,
            string? instillRequesterUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListPipelineRunsByRequesterResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> RequesterId { get; } = new(
            name: "requesterId")
        {
            Description = @"Requester ID.",
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
The following filters are supported:
- `status`
- `source`

**Example**: `status=""RUN_STATUS_COMPLETED""`.",
        };

        private global::System.CommandLine.Option<string?> OrderBy { get; } = new(
            name: "orderBy")
        {
            Description = @"Order by field, with options for ordering by `id`, `create_time` or `update_time`.
Format: `order_by=id` or `order_by=create_time desc`, default is `asc`.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Start { get; } = new(
            name: "start")
        {
            Description = @"Beginning of the time range from which the records will be fetched.
The default value is the beginning of the current day, in UTC.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"End of the time range from which the records will be fetched.
The default value is the current timestamp.",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = @"Indicates the authenticated namespace is making the request on behalf of another entity, typically an organization they belong to",
        };
        public PipelinePublicServiceListPipelineRunsByRequesterCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Returns a paginated list of runs for 1 or more pipelines. This is mainly used by dashboard.
The requester can view all the runs by the requester across different pipelines.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(RequesterId);
            Options.Add(Page);
            Options.Add(PageSize);
            Options.Add(Filter);
            Options.Add(OrderBy);
            Options.Add(Start);
            Options.Add(Stop);
            Options.Add(InstillRequesterUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var page = parseResult.GetRequiredValue(Page);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var filter = parseResult.GetRequiredValue(Filter);
            var orderBy = parseResult.GetRequiredValue(OrderBy);
            var start = parseResult.GetRequiredValue(Start);
            var stop = parseResult.GetRequiredValue(Stop);
            var requesterId = parseResult.GetRequiredValue(RequesterId);
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);

            Validate(
                parseResult: parseResult,
                page: page,
                pageSize: pageSize,
                filter: filter,
                orderBy: orderBy,
                start: start,
                stop: stop,
                requesterId: requesterId,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceListPipelineRunsByRequesterAsync(
                page: page,
                pageSize: pageSize,
                filter: filter,
                orderBy: orderBy,
                start: start,
                stop: stop,
                requesterId: requesterId,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}