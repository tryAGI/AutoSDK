//HintName: G.Models.MCPApprovalResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the item. Always `mcp_approval_response`.
    /// </summary>
    public enum MCPApprovalResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        McpApprovalResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPApprovalResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPApprovalResponseType value)
        {
            return value switch
            {
                MCPApprovalResponseType.McpApprovalResponse => "mcp_approval_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPApprovalResponseType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_response" => MCPApprovalResponseType.McpApprovalResponse,
                _ => null,
            };
        }
    }
}