//HintName: G.Models.RedactPiiAudioQuality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls the filetype of the audio created by redact_pii_audio. Currently supports mp3 (default) and wav. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
    /// Example: mp3
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RedactPiiAudioQuality
    {
        /// <summary>
        /// //www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
        /// <summary>
        /// //www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RedactPiiAudioQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RedactPiiAudioQuality value)
        {
            return value switch
            {
                RedactPiiAudioQuality.Mp3 => "mp3",
                RedactPiiAudioQuality.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RedactPiiAudioQuality? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => RedactPiiAudioQuality.Mp3,
                "wav" => RedactPiiAudioQuality.Wav,
                _ => null,
            };
        }
    }
}