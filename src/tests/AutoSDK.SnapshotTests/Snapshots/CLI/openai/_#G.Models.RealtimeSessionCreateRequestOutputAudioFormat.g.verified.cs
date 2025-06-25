//HintName: G.Models.RealtimeSessionCreateRequestOutputAudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
    /// For `pcm16`, output audio is sampled at a rate of 24kHz.<br/>
    /// Default Value: pcm16
    /// </summary>
    public enum RealtimeSessionCreateRequestOutputAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Pcm16,
        /// <summary>
        /// 
        /// </summary>
        G711Ulaw,
        /// <summary>
        /// 
        /// </summary>
        G711Alaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestOutputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestOutputAudioFormat value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestOutputAudioFormat.Pcm16 => "pcm16",
                RealtimeSessionCreateRequestOutputAudioFormat.G711Ulaw => "g711_ulaw",
                RealtimeSessionCreateRequestOutputAudioFormat.G711Alaw => "g711_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestOutputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => RealtimeSessionCreateRequestOutputAudioFormat.Pcm16,
                "g711_ulaw" => RealtimeSessionCreateRequestOutputAudioFormat.G711Ulaw,
                "g711_alaw" => RealtimeSessionCreateRequestOutputAudioFormat.G711Alaw,
                _ => null,
            };
        }
    }
}