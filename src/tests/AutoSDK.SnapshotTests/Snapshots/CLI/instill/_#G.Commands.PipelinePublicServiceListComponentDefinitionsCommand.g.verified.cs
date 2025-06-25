//HintName: G.Commands.PipelinePublicServiceListComponentDefinitionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListComponentDefinitionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.PipelinePublicServiceListComponentDefinitionsView?> View { get; } = new(
            name: "view")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"",
        };
        public PipelinePublicServiceListComponentDefinitionsCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Returns a paginated list of component definitions, regardless their type.
This offers a single source of truth, with pagination and filter
capabilities, for the components that might be used in a VDP pipeline.")
        {
            _client = client;

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