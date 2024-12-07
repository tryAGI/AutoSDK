//HintName: G.Models.BetaTextContentBlockDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: text_delta
    /// </summary>
    public enum BetaTextContentBlockDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        TextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTextContentBlockDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextContentBlockDeltaType value)
        {
            return value switch
            {
                BetaTextContentBlockDeltaType.TextDelta => "text_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextContentBlockDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "text_delta" => BetaTextContentBlockDeltaType.TextDelta,
                _ => null,
            };
        }
    }
}