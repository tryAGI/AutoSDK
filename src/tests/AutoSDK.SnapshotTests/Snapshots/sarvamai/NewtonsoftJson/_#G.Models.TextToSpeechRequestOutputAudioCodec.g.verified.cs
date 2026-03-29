//HintName: G.Models.TextToSpeechRequestOutputAudioCodec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output audio format
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextToSpeechRequestOutputAudioCodec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aac")]
        Aac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alaw")]
        Alaw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flac")]
        Flac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="linear16")]
        Linear16,
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
        [global::System.Runtime.Serialization.EnumMember(Value="opus")]
        Opus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechRequestOutputAudioCodecExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechRequestOutputAudioCodec value)
        {
            return value switch
            {
                TextToSpeechRequestOutputAudioCodec.Aac => "aac",
                TextToSpeechRequestOutputAudioCodec.Alaw => "alaw",
                TextToSpeechRequestOutputAudioCodec.Flac => "flac",
                TextToSpeechRequestOutputAudioCodec.Linear16 => "linear16",
                TextToSpeechRequestOutputAudioCodec.Mp3 => "mp3",
                TextToSpeechRequestOutputAudioCodec.Mulaw => "mulaw",
                TextToSpeechRequestOutputAudioCodec.Opus => "opus",
                TextToSpeechRequestOutputAudioCodec.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechRequestOutputAudioCodec? ToEnum(string value)
        {
            return value switch
            {
                "aac" => TextToSpeechRequestOutputAudioCodec.Aac,
                "alaw" => TextToSpeechRequestOutputAudioCodec.Alaw,
                "flac" => TextToSpeechRequestOutputAudioCodec.Flac,
                "linear16" => TextToSpeechRequestOutputAudioCodec.Linear16,
                "mp3" => TextToSpeechRequestOutputAudioCodec.Mp3,
                "mulaw" => TextToSpeechRequestOutputAudioCodec.Mulaw,
                "opus" => TextToSpeechRequestOutputAudioCodec.Opus,
                "wav" => TextToSpeechRequestOutputAudioCodec.Wav,
                _ => null,
            };
        }
    }
}