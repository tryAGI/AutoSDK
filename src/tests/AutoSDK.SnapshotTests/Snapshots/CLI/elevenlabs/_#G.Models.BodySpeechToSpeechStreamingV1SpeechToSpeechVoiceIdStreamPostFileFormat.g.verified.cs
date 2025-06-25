//HintName: G.Models.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
    /// Default Value: other<br/>
    /// Example: pcm_s16le_16
    /// </summary>
    public enum BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat
    {
        /// <summary>
        /// 
        /// </summary>
        PcmS16le16,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat value)
        {
            return value switch
            {
                BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat.PcmS16le16 => "pcm_s16le_16",
                BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm_s16le_16" => BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat.PcmS16le16,
                "other" => BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat.Other,
                _ => null,
            };
        }
    }
}