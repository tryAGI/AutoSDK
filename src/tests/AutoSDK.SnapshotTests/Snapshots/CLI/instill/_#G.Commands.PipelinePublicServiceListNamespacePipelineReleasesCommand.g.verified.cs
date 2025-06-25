//HintName: G.Commands.PipelinePublicServiceListNamespacePipelineReleasesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListNamespacePipelineReleasesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string pipelineId,
            int? pageSize,
            string? pageToken,
            global::G.PipelinePublicServiceListNamespacePipelineReleasesView? view,
            string? filter,
            bool? showDeleted,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListNamespacePipelineReleasesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"Namespace ID",
        };

        private global::System.CommandLine.Argument<string> PipelineId { get; } = new(
            name: "pipelineId")
        {
            Description = @"Pipeline ID",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The maximum number of releases to return. If this parameter is
unspecified, at most 10 pipelines will be returned. The cap value for this
parameter is 100 (i.e. any value above that will be coerced to 100).",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = @"Page token.",
        };

        private global::System.CommandLine.Option<global::G.PipelinePublicServiceListNamespacePipelineReleasesView?> View { get; } = new(
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
- Example: `create_time>timestamp(""2000-06-19T23:31:08.657Z"")`.",
        };

        private global::System.CommandLine.Option<bool?> ShowDeleted { get; } = new(
            name: "showDeleted")
        {
            Description = @"Include soft-deleted pipelines in the result.",
        };
        public PipelinePublicServiceListNamespacePipelineReleasesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Lists the commited versions of a pipeline, identified by its resource
name, which is formed by the parent namespace and ID of the pipeline.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(PipelineId);
            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(View);
            Options.Add(Filter);
            Options.Add(ShowDeleted);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var pipelineId = parseResult.GetRequiredValue(PipelineId);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var view = parseResult.GetRequiredValue(View);
            var filter = parseResult.GetRequiredValue(Filter);
            var showDeleted = parseResult.GetRequiredValue(ShowDeleted);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                filter: filter,
                showDeleted: showDeleted,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceListNamespacePipelineReleasesAsync(
                namespaceId: namespaceId,
                pipelineId: pipelineId,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                filter: filter,
                showDeleted: showDeleted,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}