//HintName: G.Commands.ToolsListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ToolsListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? cursor,
            string? ownership,
            int? pageSize,
            string? search,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PaginatedToolList response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Cursor { get; } = new(
            name: "cursor")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Ownership { get; } = new(
            name: "ownership")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Search { get; } = new(
            name: "search")
        {
            Description = "",
        };
        public ToolsListCommand(G.IApi client) : base(
            name: "tools",
            description: @"List all tools in your account.")
        {
            _client = client;

            Options.Add(Cursor);
            Options.Add(Ownership);
            Options.Add(PageSize);
            Options.Add(Search);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cursor = parseResult.GetRequiredValue(Cursor);
            var ownership = parseResult.GetRequiredValue(Ownership);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var search = parseResult.GetRequiredValue(Search);

            Validate(
                parseResult: parseResult,
                cursor: cursor,
                ownership: ownership,
                pageSize: pageSize,
                search: search,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Tools.ToolsListAsync(
                cursor: cursor,
                ownership: ownership,
                pageSize: pageSize,
                search: search,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}