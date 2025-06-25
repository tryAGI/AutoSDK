//HintName: G.Commands.DeleteConvaiMcpServersByMcpServerIdToolApprovalsByToolNameCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteConvaiMcpServersByMcpServerIdToolApprovalsByToolNameCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string mcpServerId,
            string toolName,
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

        private global::System.CommandLine.Argument<string> ToolName { get; } = new(
            name: "toolName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public DeleteConvaiMcpServersByMcpServerIdToolApprovalsByToolNameCommand(G.IApi client) : base(
            name: "delete",
            description: @"Remove approval for a specific MCP tool when using per-tool approval mode.")
        {
            _client = client;

            Arguments.Add(McpServerId);
            Arguments.Add(ToolName);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var mcpServerId = parseResult.GetRequiredValue(McpServerId);
            var toolName = parseResult.GetRequiredValue(ToolName);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                mcpServerId: mcpServerId,
                toolName: toolName,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.DeleteConvaiMcpServersByMcpServerIdToolApprovalsByToolNameAsync(
                mcpServerId: mcpServerId,
                toolName: toolName,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}