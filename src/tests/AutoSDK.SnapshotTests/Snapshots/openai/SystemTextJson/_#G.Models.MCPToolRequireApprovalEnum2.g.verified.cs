//HintName: G.Models.MCPToolRequireApprovalEnum2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify a single approval policy for all tools. One of `always` or <br/>
    /// `never`. When set to `always`, all tools will require approval. When <br/>
    /// set to `never`, all tools will not require approval.
    /// </summary>
    public enum MCPToolRequireApprovalEnum2
    {
        /// <summary>
        /// 
        /// </summary>
        Always,
        /// <summary>
        /// 
        /// </summary>
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolRequireApprovalEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolRequireApprovalEnum2 value)
        {
            return value switch
            {
                MCPToolRequireApprovalEnum2.Always => "always",
                MCPToolRequireApprovalEnum2.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolRequireApprovalEnum2? ToEnum(string value)
        {
            return value switch
            {
                "always" => MCPToolRequireApprovalEnum2.Always,
                "never" => MCPToolRequireApprovalEnum2.Never,
                _ => null,
            };
        }
    }
}