//HintName: G.Models.CreateSpeechRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.
    /// <br/>Default Value: mp3
    /// </summary>
    public enum CreateSpeechRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        Aac,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Wav,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestResponseFormat value)
        {
            return value switch
            {
                CreateSpeechRequestResponseFormat.Mp3 => "mp3",
                CreateSpeechRequestResponseFormat.Opus => "opus",
                CreateSpeechRequestResponseFormat.Aac => "aac",
                CreateSpeechRequestResponseFormat.Flac => "flac",
                CreateSpeechRequestResponseFormat.Wav => "wav",
                CreateSpeechRequestResponseFormat.Pcm => "pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => CreateSpeechRequestResponseFormat.Mp3,
                "opus" => CreateSpeechRequestResponseFormat.Opus,
                "aac" => CreateSpeechRequestResponseFormat.Aac,
                "flac" => CreateSpeechRequestResponseFormat.Flac,
                "wav" => CreateSpeechRequestResponseFormat.Wav,
                "pcm" => CreateSpeechRequestResponseFormat.Pcm,
                _ => null,
            };
        }
    }
}