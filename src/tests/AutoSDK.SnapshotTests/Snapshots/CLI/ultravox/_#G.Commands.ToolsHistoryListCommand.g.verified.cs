//HintName: G.Commands.ToolsHistoryListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsHistoryListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? cursor,
            int? pageSize,
            global::System.Guid toolId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PaginatedToolHistoryList response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ToolId { get; } = new(
            name: "toolId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Cursor { get; } = new(
            name: "cursor")
        {
            Description = @"The pagination cursor value.",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = @"Number of results to return per page.",
        };
        public ToolsHistoryListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "tools",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ToolId);
            Options.Add(Cursor);
            Options.Add(PageSize);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cursor = parseResult.GetRequiredValue(Cursor);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var toolId = parseResult.GetRequiredValue(ToolId);

            Validate(
                parseResult: parseResult,
                cursor: cursor,
                pageSize: pageSize,
                toolId: toolId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Tools.ToolsHistoryListAsync(
                cursor: cursor,
                pageSize: pageSize,
                toolId: toolId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}