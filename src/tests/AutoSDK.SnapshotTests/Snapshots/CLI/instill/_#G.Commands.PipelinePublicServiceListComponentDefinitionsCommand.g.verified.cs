//HintName: G.Commands.PipelinePublicServiceListComponentDefinitionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListComponentDefinitionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? pageSize,
            global::G.PipelinePublicServiceListComponentDefinitionsView? view,
            string? filter,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListComponentDefinitionsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"The maximum number of component definitions to return. If this parameter
is unspecified, at most 10 definitions will be returned. The cap value for
this parameter is 100 (i.e. any value above that will be coerced to 100).",
        };

        private global::System.CommandLine.Option<global::G.PipelinePublicServiceListComponentDefinitionsView?> View { get; } = new(
            name: "view")
        {
            Description = @"View allows clients to specify the desired resource view in the response.

 - VIEW_BASIC: Default view, only includes basic information (removes the `spec`
field).
 - VIEW_FULL: Full representation.",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"Filter can hold an [AIP-160](https://google.aip.dev/160)-compliant filter
expression.
- Example: `component_type=""COMPONENT_TYPE_AI""`.
- Example: `tasks:""TASK_TEXT_GENERATION""`.",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"Page number.",
        };
        public PipelinePublicServiceListComponentDefinitionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pipeline",
            description: @"Returns a paginated list of component definitions, regardless their type.
This offers a single source of truth, with pagination and filter
capabilities, for the components that might be used in a VDP pipeline.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(PageSize);
            Options.Add(View);
            Options.Add(Filter);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var view = parseResult.GetRequiredValue(View);
            var filter = parseResult.GetRequiredValue(Filter);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                pageSize: pageSize,
                view: view,
                filter: filter,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceListComponentDefinitionsAsync(
                pageSize: pageSize,
                view: view,
                filter: filter,
                page: page,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}