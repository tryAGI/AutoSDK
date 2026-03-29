//HintName: G.Models.InputAudioInputAudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputAudioInputAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioInputAudioFormat value)
        {
            return value switch
            {
                InputAudioInputAudioFormat.Mp3 => "mp3",
                InputAudioInputAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => InputAudioInputAudioFormat.Mp3,
                "wav" => InputAudioInputAudioFormat.Wav,
                _ => null,
            };
        }
    }
}