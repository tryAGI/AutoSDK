//HintName: G.Models.FallbackSonioxTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Soniox model to use for transcription.
    /// </summary>
    public enum FallbackSonioxTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        SttRtV4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackSonioxTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSonioxTranscriberModel value)
        {
            return value switch
            {
                FallbackSonioxTranscriberModel.SttRtV4 => "stt-rt-v4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSonioxTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "stt-rt-v4" => FallbackSonioxTranscriberModel.SttRtV4,
                _ => null,
            };
        }
    }
}