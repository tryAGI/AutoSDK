//HintName: G.Models.ElevenLabsTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ElevenLabsTranscriberModel
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
    public static class ElevenLabsTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsTranscriberModel value)
        {
            return value switch
            {
                ElevenLabsTranscriberModel.ScribeV1 => "scribe_v1",
                ElevenLabsTranscriberModel.ScribeV2 => "scribe_v2",
                ElevenLabsTranscriberModel.ScribeV2Realtime => "scribe_v2_realtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "scribe_v1" => ElevenLabsTranscriberModel.ScribeV1,
                "scribe_v2" => ElevenLabsTranscriberModel.ScribeV2,
                "scribe_v2_realtime" => ElevenLabsTranscriberModel.ScribeV2Realtime,
                _ => null,
            };
        }
    }
}