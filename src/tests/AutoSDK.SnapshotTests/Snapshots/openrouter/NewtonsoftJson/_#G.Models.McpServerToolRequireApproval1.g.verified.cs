//HintName: G.Models.McpServerToolRequireApproval1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpServerToolRequireApproval1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always")]
        Always,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerToolRequireApproval1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerToolRequireApproval1 value)
        {
            return value switch
            {
                McpServerToolRequireApproval1.Always => "always",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerToolRequireApproval1? ToEnum(string value)
        {
            return value switch
            {
                "always" => McpServerToolRequireApproval1.Always,
                _ => null,
            };
        }
    }
}