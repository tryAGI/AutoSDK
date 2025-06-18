//HintName: G.Models.MCPApprovalRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the item. Always `mcp_approval_request`.
    /// </summary>
    public enum MCPApprovalRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        McpApprovalRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPApprovalRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPApprovalRequestType value)
        {
            return value switch
            {
                MCPApprovalRequestType.McpApprovalRequest => "mcp_approval_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPApprovalRequestType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_request" => MCPApprovalRequestType.McpApprovalRequest,
                _ => null,
            };
        }
    }
}