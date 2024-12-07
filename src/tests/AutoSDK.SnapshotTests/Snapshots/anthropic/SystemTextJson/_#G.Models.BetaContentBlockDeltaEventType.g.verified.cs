//HintName: G.Models.BetaContentBlockDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: content_block_delta
    /// </summary>
    public enum BetaContentBlockDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentBlockDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContentBlockDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockDeltaEventType value)
        {
            return value switch
            {
                BetaContentBlockDeltaEventType.ContentBlockDelta => "content_block_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_delta" => BetaContentBlockDeltaEventType.ContentBlockDelta,
                _ => null,
            };
        }
    }
}