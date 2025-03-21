//HintName: G.Models.RealtimeResponseCreateParamsOutputAudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeResponseCreateParamsOutputAudioFormat
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
    public static class RealtimeResponseCreateParamsOutputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateParamsOutputAudioFormat value)
        {
            return value switch
            {
                RealtimeResponseCreateParamsOutputAudioFormat.Pcm16 => "pcm16",
                RealtimeResponseCreateParamsOutputAudioFormat.G711Ulaw => "g711_ulaw",
                RealtimeResponseCreateParamsOutputAudioFormat.G711Alaw => "g711_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateParamsOutputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => RealtimeResponseCreateParamsOutputAudioFormat.Pcm16,
                "g711_ulaw" => RealtimeResponseCreateParamsOutputAudioFormat.G711Ulaw,
                "g711_alaw" => RealtimeResponseCreateParamsOutputAudioFormat.G711Alaw,
                _ => null,
            };
        }
    }
}