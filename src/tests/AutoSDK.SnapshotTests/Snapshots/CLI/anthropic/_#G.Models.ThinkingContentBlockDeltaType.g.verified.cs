//HintName: G.Models.ThinkingContentBlockDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: thinking_delta
    /// </summary>
    public enum ThinkingContentBlockDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ThinkingDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingContentBlockDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingContentBlockDeltaType value)
        {
            return value switch
            {
                ThinkingContentBlockDeltaType.ThinkingDelta => "thinking_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingContentBlockDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "thinking_delta" => ThinkingContentBlockDeltaType.ThinkingDelta,
                _ => null,
            };
        }
    }
}