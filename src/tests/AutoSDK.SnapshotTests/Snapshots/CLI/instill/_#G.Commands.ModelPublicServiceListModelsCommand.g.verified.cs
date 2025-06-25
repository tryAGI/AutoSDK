//HintName: G.Commands.ModelPublicServiceListModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceListModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? pageSize,
            string? pageToken,
            global::G.ModelPublicServiceListModelsView? view,
            bool? showDeleted,
            string? filter,
            global::G.ModelPublicServiceListModelsVisibility? visibility,
            string? orderBy,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListModelsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The maximum number of models to return. If this parameter is unspecified,
at most 10 models will be returned. The cap value for this parameter is
100 (i.e. any value above that will be coerced to 100).",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"Page token.",
        };

        private global::System.CommandLine.Option<global::G.ModelPublicServiceListModelsView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired model view in the response.

 - VIEW_BASIC: Default view, only includes basic information (omits `model_spec`).
 - VIEW_FULL: Full representation.",
        };

        private global::System.CommandLine.Option<bool?> ShowDeleted { get; } = new(
            name: "showDeleted")
        {
            Description = @"Include soft-deleted models in the result.",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Filter can hold an [AIP-160](https://google.aip.dev/160)-compliant filter
expression.
- Example: `create_time>timestamp(""2000-06-19T23:31:08.657Z"")`.",
        };

        private global::System.CommandLine.Option<global::G.ModelPublicServiceListModelsVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = @"Limit results to pipelines with the specified visibility.

 - VISIBILITY_PRIVATE: Only the owner can see the model.
 - VISIBILITY_PUBLIC: Other users can see the model.",
        };

        private global::System.CommandLine.Option<string?> OrderBy { get; } = new(
            name: "orderBy")
        {
            Description = @"Order by field, with options for ordering by `id`, `create_time` or `update_time`.
Format: `order_by=id` or `order_by=create_time desc`, default is `asc`.",
        };
        public ModelPublicServiceListModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"Returns a paginated list of models.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(View);
            Options.Add(ShowDeleted);
            Options.Add(Filter);
            Options.Add(Visibility);
            Options.Add(OrderBy);

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
            var showDeleted = parseResult.GetRequiredValue(ShowDeleted);
            var filter = parseResult.GetRequiredValue(Filter);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var orderBy = parseResult.GetRequiredValue(OrderBy);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                showDeleted: showDeleted,
                filter: filter,
                visibility: visibility,
                orderBy: orderBy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceListModelsAsync(
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                showDeleted: showDeleted,
                filter: filter,
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