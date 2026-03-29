//HintName: G.Models.McpApprovalResponseContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: mcp_approval_response
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpApprovalResponseContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_approval_response")]
        McpApprovalResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpApprovalResponseContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpApprovalResponseContentType value)
        {
            return value switch
            {
                McpApprovalResponseContentType.McpApprovalResponse => "mcp_approval_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpApprovalResponseContentType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_approval_response" => McpApprovalResponseContentType.McpApprovalResponse,
                _ => null,
            };
        }
    }
}