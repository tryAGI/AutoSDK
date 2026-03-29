//HintName: G.Models.BashToolWithToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "bash" for Bash tool.
    /// </summary>
    public enum BashToolWithToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BashToolWithToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BashToolWithToolCallType value)
        {
            return value switch
            {
                BashToolWithToolCallType.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BashToolWithToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "bash" => BashToolWithToolCallType.Bash,
                _ => null,
            };
        }
    }
}