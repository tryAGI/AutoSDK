//HintName: G.Commands.ModelPublicServiceListModelRunsByRequesterCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceListModelRunsByRequesterCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? pageSize,
            int? page,
            string? orderBy,
            string? filter,
            global::System.DateTime? start,
            global::System.DateTime? stop,
            string requesterId,
            string? instillRequesterUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListModelRunsByRequesterResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> RequesterId { get; } = new(
            name: "requesterId")
        {
            Description = @"Requester ID.",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The maximum number of runs to return. The default and cap values are 10
and 100, respectively.",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"Page number.",
        };

        private global::System.CommandLine.Option<string?> OrderBy { get; } = new(
            name: "orderBy")
        {
            Description = @"Sort the results by the given expression.
Format: `field [ASC | DESC], where `field` can be:
- `create_time`
- `update_time`
By default, results are sorted by descending creation time.",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Filter can hold an [AIP-160](https://google.aip.dev/160)-compliant filter
expression.
- Example: `status=""RUN_STATUS_COMPLETED""`.
The filter can be applied to the following fields:
- `status`
- `source`",
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
        public ModelPublicServiceListModelRunsByRequesterCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"Returns a paginated list of runs for 1 or more models. This is mainly used by dashboard.
The requester can view all the runs by the requester across different models.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(RequesterId);
            Options.Add(PageSize);
            Options.Add(Page);
            Options.Add(OrderBy);
            Options.Add(Filter);
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
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var page = parseResult.GetRequiredValue(Page);
            var orderBy = parseResult.GetRequiredValue(OrderBy);
            var filter = parseResult.GetRequiredValue(Filter);
            var start = parseResult.GetRequiredValue(Start);
            var stop = parseResult.GetRequiredValue(Stop);
            var requesterId = parseResult.GetRequiredValue(RequesterId);
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                page: page,
                orderBy: orderBy,
                filter: filter,
                start: start,
                stop: stop,
                requesterId: requesterId,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceListModelRunsByRequesterAsync(
                pageSize: pageSize,
                page: page,
                orderBy: orderBy,
                filter: filter,
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