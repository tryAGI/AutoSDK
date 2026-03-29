//HintName: G.Models.FallbackElevenLabsTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackElevenLabsTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        ScribeV1,
        /// <summary>
        /// 
        /// </summary>
        ScribeV2,
        /// <summary>
        /// 
        /// </summary>
        ScribeV2Realtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackElevenLabsTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackElevenLabsTranscriberModel value)
        {
            return value switch
            {
                FallbackElevenLabsTranscriberModel.ScribeV1 => "scribe_v1",
                FallbackElevenLabsTranscriberModel.ScribeV2 => "scribe_v2",
                FallbackElevenLabsTranscriberModel.ScribeV2Realtime => "scribe_v2_realtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackElevenLabsTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "scribe_v1" => FallbackElevenLabsTranscriberModel.ScribeV1,
                "scribe_v2" => FallbackElevenLabsTranscriberModel.ScribeV2,
                "scribe_v2_realtime" => FallbackElevenLabsTranscriberModel.ScribeV2Realtime,
                _ => null,
            };
        }
    }
}