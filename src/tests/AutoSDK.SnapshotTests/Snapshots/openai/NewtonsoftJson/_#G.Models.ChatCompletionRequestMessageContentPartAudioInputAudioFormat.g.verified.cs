//HintName: G.Models.ChatCompletionRequestMessageContentPartAudioInputAudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the encoded audio data. Currently supports "wav" and "mp3".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestMessageContentPartAudioInputAudioFormat
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
    public static class ChatCompletionRequestMessageContentPartAudioInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageContentPartAudioInputAudioFormat value)
        {
            return value switch
            {
                ChatCompletionRequestMessageContentPartAudioInputAudioFormat.Mp3 => "mp3",
                ChatCompletionRequestMessageContentPartAudioInputAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageContentPartAudioInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => ChatCompletionRequestMessageContentPartAudioInputAudioFormat.Mp3,
                "wav" => ChatCompletionRequestMessageContentPartAudioInputAudioFormat.Wav,
                _ => null,
            };
        }
    }
}