//HintName: G.Commands.PipelinePublicServiceListNamespacePipelinesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListNamespacePipelinesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            int? pageSize,
            string? pageToken,
            global::G.PipelinePublicServiceListNamespacePipelinesView? view,
            string? filter,
            bool? showDeleted,
            global::G.PipelinePublicServiceListNamespacePipelinesVisibility? visibility,
            string? orderBy,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListNamespacePipelinesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"Namespace ID",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The maximum number of pipelines to return. If this parameter is
unspecified, at most 10 pipelines will be returned. The cap value for this
parameter is 100 (i.e. any value above that will be coerced to 100).",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"Page token.",
        };

        private global::System.CommandLine.Option<global::G.PipelinePublicServiceListNamespacePipelinesView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired pipeline view in the response.

 - VIEW_BASIC: Default view, only includes basic information.
 - VIEW_FULL: Full representation.
 - VIEW_RECIPE: Contains the recipe of the resource.",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Filter can hold an [AIP-160](https://google.aip.dev/160)-compliant filter
expression.
- Example: `create_time>timestamp(""2000-06-19T23:31:08.657Z"")`.
- Example:
`recipe.components.definition_name:""operator-definitions/2ac8be70-0f7a-4b61-a33d-098b8acfa6f3""`.",
        };

        private global::System.CommandLine.Option<bool?> ShowDeleted { get; } = new(
            name: "showDeleted")
        {
            Description = @"Include soft-deleted pipelines in the result.",
        };

        private global::System.CommandLine.Option<global::G.PipelinePublicServiceListNamespacePipelinesVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = @"Limit results to pipelines with the specified visibility.

 - VISIBILITY_PRIVATE: Only the user can see the pipeline.
 - VISIBILITY_PUBLIC: Other users can see the pipeline.",
        };

        private global::System.CommandLine.Option<string?> OrderBy { get; } = new(
            name: "orderBy")
        {
            Description = @"Order by field, with options for ordering by `id`, `create_time` or `update_time`.
Format: `order_by=id` or `order_by=create_time desc`, default is `asc`.",
        };
        public PipelinePublicServiceListNamespacePipelinesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Returns a paginated list of pipelines of a namespace")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(View);
            Options.Add(Filter);
            Options.Add(ShowDeleted);
            Options.Add(Visibility);
            Options.Add(OrderBy);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var view = parseResult.GetRequiredValue(View);
            var filter = parseResult.GetRequiredValue(Filter);
            var showDeleted = parseResult.GetRequiredValue(ShowDeleted);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var orderBy = parseResult.GetRequiredValue(OrderBy);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                filter: filter,
                showDeleted: showDeleted,
                visibility: visibility,
                orderBy: orderBy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceListNamespacePipelinesAsync(
                namespaceId: namespaceId,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                filter: filter,
                showDeleted: showDeleted,
                visibility: visibility,
                orderBy: orderBy,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}