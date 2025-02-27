//HintName: G.Models.RequestRedactedThinkingBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestRedactedThinkingBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="redacted_thinking")]
        RedactedThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestRedactedThinkingBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestRedactedThinkingBlockType value)
        {
            return value switch
            {
                RequestRedactedThinkingBlockType.RedactedThinking => "redacted_thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestRedactedThinkingBlockType? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => RequestRedactedThinkingBlockType.RedactedThinking,
                _ => null,
            };
        }
    }
}