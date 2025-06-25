//HintName: G.Commands.GetConvaiMcpServersByMcpServerIdToolsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiMcpServersByMcpServerIdToolsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string mcpServerId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListMCPToolsResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> McpServerId { get; } = new(
            name: "mcpServerId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetConvaiMcpServersByMcpServerIdToolsCommand(G.IApi client) : base(
            name: "get",
            description: @"Retrieve all tools available for a specific MCP server configuration.")
        {
            _client = client;

            Arguments.Add(McpServerId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var mcpServerId = parseResult.GetRequiredValue(McpServerId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                mcpServerId: mcpServerId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.GetConvaiMcpServersByMcpServerIdToolsAsync(
                mcpServerId: mcpServerId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}