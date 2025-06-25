//HintName: G.Commands.EditConvaiMcpServersByMcpServerIdApprovalPolicyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EditConvaiMcpServersByMcpServerIdApprovalPolicyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string mcpServerId,
            string? xiApiKey,
            global::G.MCPApprovalPolicy approvalPolicy,
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

        private global::System.CommandLine.Argument<global::G.MCPApprovalPolicy> ApprovalPolicy { get; } = new(
            name: "approvalPolicy")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public EditConvaiMcpServersByMcpServerIdApprovalPolicyCommand(G.IApi client) : base(
            name: "edit",
            description: @"Update the approval policy configuration for an MCP server.")
        {
            _client = client;

            Arguments.Add(McpServerId);
            Arguments.Add(ApprovalPolicy);
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
            var approvalPolicy = parseResult.GetRequiredValue(ApprovalPolicy);

            Validate(
                parseResult: parseResult,
                mcpServerId: mcpServerId,
                xiApiKey: xiApiKey,
                approvalPolicy: approvalPolicy,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.EditConvaiMcpServersByMcpServerIdApprovalPolicyAsync(
                mcpServerId: mcpServerId,
                xiApiKey: xiApiKey,
                approvalPolicy: approvalPolicy,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}