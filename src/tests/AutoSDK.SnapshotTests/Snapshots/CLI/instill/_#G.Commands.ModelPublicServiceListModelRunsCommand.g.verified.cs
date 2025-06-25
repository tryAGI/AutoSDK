//HintName: G.Commands.ModelPublicServiceListModelRunsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceListModelRunsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string modelId,
            int? pageSize,
            int? page,
            string? orderBy,
            string? filter,
            string? instillRequesterUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListModelRunsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"Namespace ID.",
        };

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = @"Model ID.",
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
- Example: `create_time>timestamp(""2000-06-19T23:31:08.657Z"")`.
The filter can be applied to the following fields:
- `create_time`",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = @"Indicates the authenticated namespace is making the request on behalf of another entity, typically an organization they belong to",
        };
        public ModelPublicServiceListModelRunsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"Returns a paginated list of model runs.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(ModelId);
            Options.Add(PageSize);
            Options.Add(Page);
            Options.Add(OrderBy);
            Options.Add(Filter);
            Options.Add(InstillRequesterUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var page = parseResult.GetRequiredValue(Page);
            var orderBy = parseResult.GetRequiredValue(OrderBy);
            var filter = parseResult.GetRequiredValue(Filter);
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                modelId: modelId,
                pageSize: pageSize,
                page: page,
                orderBy: orderBy,
                filter: filter,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceListModelRunsAsync(
                namespaceId: namespaceId,
                modelId: modelId,
                pageSize: pageSize,
                page: page,
                orderBy: orderBy,
                filter: filter,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}