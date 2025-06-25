//HintName: G.Commands.PipelinePublicServiceListPipelineIDsByConnectionIDCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PipelinePublicServiceListPipelineIDsByConnectionIDCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string connectionId,
            int? pageSize,
            string? pageToken,
            string? filter,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListPipelineIDsByConnectionIDResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ConnectionId { get; } = new(
            name: "connectionId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> PageToken { get; } = new(
            name: "pageToken")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Filter { get; } = new(
            name: "filter")
        {
            Description = "",
        };
        public PipelinePublicServiceListPipelineIDsByConnectionIDCommand(G.IApi client) : base(
            name: "pipeline",
            description: @"Returns a paginated list with the IDs of the pipelines that reference a
given connection. All the pipelines will belong to the same namespace as
the connection.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(ConnectionId);
            Options.Add(PageSize);
            Options.Add(PageToken);
            Options.Add(Filter);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var connectionId = parseResult.GetRequiredValue(ConnectionId);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var pageToken = parseResult.GetRequiredValue(PageToken);
            var filter = parseResult.GetRequiredValue(Filter);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                connectionId: connectionId,
                pageSize: pageSize,
                pageToken: pageToken,
                filter: filter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.VDP.PipelinePublicServiceListPipelineIDsByConnectionIDAsync(
                namespaceId: namespaceId,
                connectionId: connectionId,
                pageSize: pageSize,
                pageToken: pageToken,
                filter: filter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}