//HintName: G.Models.SonioxTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Soniox model to use for transcription.
    /// </summary>
    public enum SonioxTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        SttRtV4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SonioxTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SonioxTranscriberModel value)
        {
            return value switch
            {
                SonioxTranscriberModel.SttRtV4 => "stt-rt-v4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SonioxTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "stt-rt-v4" => SonioxTranscriberModel.SttRtV4,
                _ => null,
            };
        }
    }
}