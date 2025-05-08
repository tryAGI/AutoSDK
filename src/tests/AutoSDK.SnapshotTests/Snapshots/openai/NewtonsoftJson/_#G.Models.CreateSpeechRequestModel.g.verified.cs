//HintName: G.Models.CreateSpeechRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSpeechRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tts-1")]
        Tts1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tts-1-hd")]
        Tts1Hd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-tts")]
        Gpt4oMiniTts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestModel value)
        {
            return value switch
            {
                CreateSpeechRequestModel.Tts1 => "tts-1",
                CreateSpeechRequestModel.Tts1Hd => "tts-1-hd",
                CreateSpeechRequestModel.Gpt4oMiniTts => "gpt-4o-mini-tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "tts-1" => CreateSpeechRequestModel.Tts1,
                "tts-1-hd" => CreateSpeechRequestModel.Tts1Hd,
                "gpt-4o-mini-tts" => CreateSpeechRequestModel.Gpt4oMiniTts,
                _ => null,
            };
        }
    }
}