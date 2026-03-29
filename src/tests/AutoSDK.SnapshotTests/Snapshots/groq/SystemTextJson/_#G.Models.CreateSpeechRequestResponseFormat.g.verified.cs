//HintName: G.Models.CreateSpeechRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the generated audio. Supported formats are `flac, mp3, mulaw, ogg, wav`.<br/>
    /// Default Value: mp3
    /// </summary>
    public enum CreateSpeechRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        Ogg,
        /// <summary>
        /// 
        /// </summary>
        Wav,
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
                CreateSpeechRequestResponseFormat.Flac => "flac",
                CreateSpeechRequestResponseFormat.Mp3 => "mp3",
                CreateSpeechRequestResponseFormat.Mulaw => "mulaw",
                CreateSpeechRequestResponseFormat.Ogg => "ogg",
                CreateSpeechRequestResponseFormat.Wav => "wav",
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
                "flac" => CreateSpeechRequestResponseFormat.Flac,
                "mp3" => CreateSpeechRequestResponseFormat.Mp3,
                "mulaw" => CreateSpeechRequestResponseFormat.Mulaw,
                "ogg" => CreateSpeechRequestResponseFormat.Ogg,
                "wav" => CreateSpeechRequestResponseFormat.Wav,
                _ => null,
            };
        }
    }
}