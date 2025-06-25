//HintName: G.Models.BetaInputJsonContentBlockDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: input_json_delta
    /// </summary>
    public enum BetaInputJsonContentBlockDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        InputJsonDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputJsonContentBlockDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputJsonContentBlockDeltaType value)
        {
            return value switch
            {
                BetaInputJsonContentBlockDeltaType.InputJsonDelta => "input_json_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputJsonContentBlockDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "input_json_delta" => BetaInputJsonContentBlockDeltaType.InputJsonDelta,
                _ => null,
            };
        }
    }
}