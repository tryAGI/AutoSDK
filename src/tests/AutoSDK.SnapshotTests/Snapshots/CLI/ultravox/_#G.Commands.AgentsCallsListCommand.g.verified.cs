//HintName: G.Commands.AgentsCallsListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsCallsListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid agentId,
            string? cursor,
            int? pageSize,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PaginatedCallList response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> AgentId { get; } = new(
            name: "agentId")
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
        public AgentsCallsListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(AgentId);
            Options.Add(Cursor);
            Options.Add(PageSize);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var agentId = parseResult.GetRequiredValue(AgentId);
            var cursor = parseResult.GetRequiredValue(Cursor);
            var pageSize = parseResult.GetRequiredValue(PageSize);

            Validate(
                parseResult: parseResult,
                agentId: agentId,
                cursor: cursor,
                pageSize: pageSize,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsCallsListAsync(
                agentId: agentId,
                cursor: cursor,
                pageSize: pageSize,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}