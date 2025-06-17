//HintName: G.Models.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
    /// Default Value: other<br/>
    /// Example: pcm_s16le_16
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pcm_s16le_16")]
        PcmS16le16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat value)
        {
            return value switch
            {
                BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat.PcmS16le16 => "pcm_s16le_16",
                BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm_s16le_16" => BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat.PcmS16le16,
                "other" => BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat.Other,
                _ => null,
            };
        }
    }
}