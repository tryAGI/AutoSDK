//HintName: G.Commands.ModelPublicServiceListModelRunsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceListModelRunsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ModelId { get; } = new(
            name: "modelId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> OrderBy { get; } = new(
            name: "orderBy")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = "",
        };
        public ModelPublicServiceListModelRunsCommand(G.IApi client) : base(
            name: "model",
            description: @"Returns a paginated list of model runs.")
        {
            _client = client;

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