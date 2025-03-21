//HintName: G.Models.RealtimeSessionOutputAudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
    /// For `pcm16`, output audio is sampled at a rate of 24kHz.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionOutputAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm16")]
        Pcm16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="g711_ulaw")]
        G711Ulaw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="g711_alaw")]
        G711Alaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionOutputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionOutputAudioFormat value)
        {
            return value switch
            {
                RealtimeSessionOutputAudioFormat.Pcm16 => "pcm16",
                RealtimeSessionOutputAudioFormat.G711Ulaw => "g711_ulaw",
                RealtimeSessionOutputAudioFormat.G711Alaw => "g711_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionOutputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => RealtimeSessionOutputAudioFormat.Pcm16,
                "g711_ulaw" => RealtimeSessionOutputAudioFormat.G711Ulaw,
                "g711_alaw" => RealtimeSessionOutputAudioFormat.G711Alaw,
                _ => null,
            };
        }
    }
}