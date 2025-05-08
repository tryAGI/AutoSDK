//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestInputAudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
    /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate, <br/>
    /// single channel (mono), and little-endian byte order.<br/>
    /// Default Value: pcm16
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateRequestInputAudioFormat
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
    public static class RealtimeTranscriptionSessionCreateRequestInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestInputAudioFormat value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestInputAudioFormat.Pcm16 => "pcm16",
                RealtimeTranscriptionSessionCreateRequestInputAudioFormat.G711Ulaw => "g711_ulaw",
                RealtimeTranscriptionSessionCreateRequestInputAudioFormat.G711Alaw => "g711_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => RealtimeTranscriptionSessionCreateRequestInputAudioFormat.Pcm16,
                "g711_ulaw" => RealtimeTranscriptionSessionCreateRequestInputAudioFormat.G711Ulaw,
                "g711_alaw" => RealtimeTranscriptionSessionCreateRequestInputAudioFormat.G711Alaw,
                _ => null,
            };
        }
    }
}