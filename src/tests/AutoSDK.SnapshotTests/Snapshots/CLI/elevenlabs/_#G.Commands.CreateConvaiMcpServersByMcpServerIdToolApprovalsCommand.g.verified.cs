//HintName: G.Commands.CreateConvaiMcpServersByMcpServerIdToolApprovalsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiMcpServersByMcpServerIdToolApprovalsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string mcpServerId,
            string? xiApiKey,
            string toolName,
            string toolDescription,
            object? inputSchema,
            global::G.MCPToolApprovalPolicy? approvalPolicy,
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

        private global::System.CommandLine.Argument<string> ToolDescription { get; } = new(
            name: "toolDescription")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> InputSchema { get; } = new(
            name: "inputSchema")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.MCPToolApprovalPolicy?> ApprovalPolicy { get; } = new(
            name: "approvalPolicy")
        {
            Description = "",
        };
        public CreateConvaiMcpServersByMcpServerIdToolApprovalsCommand(G.IApi client) : base(
            name: "create",
            description: @"Add approval for a specific MCP tool when using per-tool approval mode.")
        {
            _client = client;

            Arguments.Add(McpServerId);
            Arguments.Add(ToolName);
            Arguments.Add(ToolDescription);
            Options.Add(XiApiKey);
            Options.Add(InputSchema);
            Options.Add(ApprovalPolicy);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var mcpServerId = parseResult.GetRequiredValue(McpServerId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var toolName = parseResult.GetRequiredValue(ToolName);
            var toolDescription = parseResult.GetRequiredValue(ToolDescription);
            var inputSchema = parseResult.GetRequiredValue(InputSchema);
            var approvalPolicy = parseResult.GetRequiredValue(ApprovalPolicy);

            Validate(
                parseResult: parseResult,
                mcpServerId: mcpServerId,
                xiApiKey: xiApiKey,
                toolName: toolName,
                toolDescription: toolDescription,
                inputSchema: inputSchema,
                approvalPolicy: approvalPolicy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiMcpServersByMcpServerIdToolApprovalsAsync(
                mcpServerId: mcpServerId,
                xiApiKey: xiApiKey,
                toolName: toolName,
                toolDescription: toolDescription,
                inputSchema: inputSchema,
                approvalPolicy: approvalPolicy,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}