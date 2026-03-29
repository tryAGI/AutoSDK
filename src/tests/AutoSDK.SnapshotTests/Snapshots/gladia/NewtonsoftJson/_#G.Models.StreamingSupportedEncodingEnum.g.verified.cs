//HintName: G.Models.StreamingSupportedEncodingEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The encoding format of the audio stream. Supported formats: <br/>
    /// - PCM: 8, 16, 24, and 32 bits <br/>
    /// - A-law: 8 bits <br/>
    /// - μ-law: 8 bits <br/>
    /// Note: No need to add WAV headers to raw audio as the API supports both formats.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamingSupportedEncodingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav/alaw")]
        WavAlaw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav/pcm")]
        WavPcm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav/ulaw")]
        WavUlaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingSupportedEncodingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingSupportedEncodingEnum value)
        {
            return value switch
            {
                StreamingSupportedEncodingEnum.WavAlaw => "wav/alaw",
                StreamingSupportedEncodingEnum.WavPcm => "wav/pcm",
                StreamingSupportedEncodingEnum.WavUlaw => "wav/ulaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingSupportedEncodingEnum? ToEnum(string value)
        {
            return value switch
            {
                "wav/alaw" => StreamingSupportedEncodingEnum.WavAlaw,
                "wav/pcm" => StreamingSupportedEncodingEnum.WavPcm,
                "wav/ulaw" => StreamingSupportedEncodingEnum.WavUlaw,
                _ => null,
            };
        }
    }
}