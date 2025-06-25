//HintName: G.Commands.GetConvaiMcpServersByMcpServerIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiMcpServersByMcpServerIdCommand : global::System.CommandLine.Command
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
            global::G.MCPServerResponseModel response,
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
        public GetConvaiMcpServersByMcpServerIdCommand(G.IApi client) : base(
            name: "get",
            description: @"Retrieve a specific MCP server configuration from the workspace.")
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
            var response = await _client.ConversationalAI.GetConvaiMcpServersByMcpServerIdAsync(
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