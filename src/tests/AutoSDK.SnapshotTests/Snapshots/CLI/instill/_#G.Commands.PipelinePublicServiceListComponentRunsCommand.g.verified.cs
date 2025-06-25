//HintName: G.Commands.PipelinePublicServiceListComponentRunsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListComponentRunsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string pipelineRunId,
            int? page,
            int? pageSize,
            string? filter,
            string? orderBy,
            global::G.PipelinePublicServiceListComponentRunsView? view,
            string? instillRequesterUid,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListComponentRunsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> PipelineRunId { get; } = new(
            name: "pipelineRunId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> OrderBy { get; } = new(
            name: "orderBy")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PipelinePublicServiceListComponentRunsView?> View { get; } = new(
            name: "view")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> InstillRequesterUid { get; } = new(
            name: "instillRequesterUid")
        {
            Description = "",
        };
        public PipelinePublicServiceListComponentRunsCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Returns the information of each component execution within a pipeline run.")
        {
            _client = client;

            Arguments.Add(PipelineRunId);
            Options.Add(Page);
            Options.Add(PageSize);
            Options.Add(Filter);
            Options.Add(OrderBy);
            Options.Add(View);
            Options.Add(InstillRequesterUid);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var pipelineRunId = parseResult.GetRequiredValue(PipelineRunId);
            var page = parseResult.GetRequiredValue(Page);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var filter = parseResult.GetRequiredValue(Filter);
            var orderBy = parseResult.GetRequiredValue(OrderBy);
            var view = parseResult.GetRequiredValue(View);
            var instillRequesterUid = parseResult.GetRequiredValue(InstillRequesterUid);

            Validate(
                parseResult: parseResult,
                pipelineRunId: pipelineRunId,
                page: page,
                pageSize: pageSize,
                filter: filter,
                orderBy: orderBy,
                view: view,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceListComponentRunsAsync(
                pipelineRunId: pipelineRunId,
                page: page,
                pageSize: pageSize,
                filter: filter,
                orderBy: orderBy,
                view: view,
                instillRequesterUid: instillRequesterUid,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}