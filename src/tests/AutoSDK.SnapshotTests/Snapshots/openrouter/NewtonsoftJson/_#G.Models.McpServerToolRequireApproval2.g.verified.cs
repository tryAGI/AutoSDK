//HintName: G.Models.McpServerToolRequireApproval2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpServerToolRequireApproval2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="never")]
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerToolRequireApproval2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerToolRequireApproval2 value)
        {
            return value switch
            {
                McpServerToolRequireApproval2.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerToolRequireApproval2? ToEnum(string value)
        {
            return value switch
            {
                "never" => McpServerToolRequireApproval2.Never,
                _ => null,
            };
        }
    }
}