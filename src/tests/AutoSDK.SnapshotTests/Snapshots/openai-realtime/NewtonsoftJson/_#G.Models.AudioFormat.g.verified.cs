//HintName: G.Models.AudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of input/output audio.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="g711_alaw")]
        G711Alaw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="g711_ulaw")]
        G711Ulaw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm16")]
        Pcm16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioFormat value)
        {
            return value switch
            {
                AudioFormat.G711Alaw => "g711_alaw",
                AudioFormat.G711Ulaw => "g711_ulaw",
                AudioFormat.Pcm16 => "pcm16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "g711_alaw" => AudioFormat.G711Alaw,
                "g711_ulaw" => AudioFormat.G711Ulaw,
                "pcm16" => AudioFormat.Pcm16,
                _ => null,
            };
        }
    }
}