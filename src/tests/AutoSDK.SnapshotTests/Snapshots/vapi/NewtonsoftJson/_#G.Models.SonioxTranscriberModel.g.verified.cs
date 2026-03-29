//HintName: G.Models.SonioxTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Soniox model to use for transcription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SonioxTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stt-rt-v4")]
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