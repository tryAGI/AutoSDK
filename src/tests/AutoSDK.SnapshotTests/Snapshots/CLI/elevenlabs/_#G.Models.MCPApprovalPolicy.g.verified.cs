//HintName: G.Models.MCPApprovalPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the MCP server-level approval policy for tool execution.
    /// </summary>
    public enum MCPApprovalPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        AutoApproveAll,
        /// <summary>
        /// 
        /// </summary>
        RequireApprovalAll,
        /// <summary>
        /// 
        /// </summary>
        RequireApprovalPerTool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPApprovalPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPApprovalPolicy value)
        {
            return value switch
            {
                MCPApprovalPolicy.AutoApproveAll => "auto_approve_all",
                MCPApprovalPolicy.RequireApprovalAll => "require_approval_all",
                MCPApprovalPolicy.RequireApprovalPerTool => "require_approval_per_tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPApprovalPolicy? ToEnum(string value)
        {
            return value switch
            {
                "auto_approve_all" => MCPApprovalPolicy.AutoApproveAll,
                "require_approval_all" => MCPApprovalPolicy.RequireApprovalAll,
                "require_approval_per_tool" => MCPApprovalPolicy.RequireApprovalPerTool,
                _ => null,
            };
        }
    }
}