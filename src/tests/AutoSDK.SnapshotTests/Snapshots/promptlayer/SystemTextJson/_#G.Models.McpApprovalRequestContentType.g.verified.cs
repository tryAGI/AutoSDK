//HintName: G.Models.McpApprovalRequestContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: mcp_approval_request
    /// </summary>
    public enum McpApprovalRequestContentType
    {
        /// <summary>
        /// 
        /// </summary>
        McpApprovalRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpApprovalRequestContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpApprovalRequestContentType value)
        {
            return value switch
            {
                McpApprovalRequestContentType.McpApprovalRequest => "mcp_approval_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpApprovalRequestContentType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_request" => McpApprovalRequestContentType.McpApprovalRequest,
                _ => null,
            };
        }
    }
}