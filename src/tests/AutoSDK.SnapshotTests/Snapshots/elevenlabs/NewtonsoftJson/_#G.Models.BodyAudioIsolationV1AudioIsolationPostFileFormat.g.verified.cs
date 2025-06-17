//HintName: G.Models.BodyAudioIsolationV1AudioIsolationPostFileFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
    /// Default Value: other<br/>
    /// Example: pcm_s16le_16
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyAudioIsolationV1AudioIsolationPostFileFormat
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
    public static class BodyAudioIsolationV1AudioIsolationPostFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAudioIsolationV1AudioIsolationPostFileFormat value)
        {
            return value switch
            {
                BodyAudioIsolationV1AudioIsolationPostFileFormat.PcmS16le16 => "pcm_s16le_16",
                BodyAudioIsolationV1AudioIsolationPostFileFormat.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAudioIsolationV1AudioIsolationPostFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm_s16le_16" => BodyAudioIsolationV1AudioIsolationPostFileFormat.PcmS16le16,
                "other" => BodyAudioIsolationV1AudioIsolationPostFileFormat.Other,
                _ => null,
            };
        }
    }
}