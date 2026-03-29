//HintName: G.Models.CreateSpeechRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the generated audio. Supported formats are `flac, mp3, mulaw, ogg, wav`.<br/>
    /// Default Value: mp3
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSpeechRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flac")]
        Flac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mulaw")]
        Mulaw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ogg")]
        Ogg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
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