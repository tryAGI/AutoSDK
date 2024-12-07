//HintName: G.Models.BetaContentBlockDeltaEventDeltaDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaContentBlockDeltaEventDeltaDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputJsonDelta,
        /// <summary>
        /// 
        /// </summary>
        TextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContentBlockDeltaEventDeltaDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockDeltaEventDeltaDiscriminatorType value)
        {
            return value switch
            {
                BetaContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta => "input_json_delta",
                BetaContentBlockDeltaEventDeltaDiscriminatorType.TextDelta => "text_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockDeltaEventDeltaDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_json_delta" => BetaContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta,
                "text_delta" => BetaContentBlockDeltaEventDeltaDiscriminatorType.TextDelta,
                _ => null,
            };
        }
    }
}