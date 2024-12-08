//HintName: G.Models.BetaResponseToolUseBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: tool_use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaResponseToolUseBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_use")]
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseToolUseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseToolUseBlockType value)
        {
            return value switch
            {
                BetaResponseToolUseBlockType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseToolUseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "tool_use" => BetaResponseToolUseBlockType.ToolUse,
                _ => null,
            };
        }
    }
}