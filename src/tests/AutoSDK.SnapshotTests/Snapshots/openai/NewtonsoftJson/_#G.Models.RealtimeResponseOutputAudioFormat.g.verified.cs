//HintName: G.Models.RealtimeResponseOutputAudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeResponseOutputAudioFormat
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
    public static class RealtimeResponseOutputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseOutputAudioFormat value)
        {
            return value switch
            {
                RealtimeResponseOutputAudioFormat.Pcm16 => "pcm16",
                RealtimeResponseOutputAudioFormat.G711Ulaw => "g711_ulaw",
                RealtimeResponseOutputAudioFormat.G711Alaw => "g711_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseOutputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => RealtimeResponseOutputAudioFormat.Pcm16,
                "g711_ulaw" => RealtimeResponseOutputAudioFormat.G711Ulaw,
                "g711_alaw" => RealtimeResponseOutputAudioFormat.G711Alaw,
                _ => null,
            };
        }
    }
}