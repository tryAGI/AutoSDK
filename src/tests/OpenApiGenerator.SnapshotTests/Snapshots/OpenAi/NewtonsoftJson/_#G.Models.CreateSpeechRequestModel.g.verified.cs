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
    }

    public static class CreateSpeechRequestModelExtensions
    {
        public static string ToValueString(this CreateSpeechRequestModel value)
        {
            return value switch
            {
                CreateSpeechRequestModel.Tts1 => "tts-1",
                CreateSpeechRequestModel.Tts1Hd => "tts-1-hd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateSpeechRequestModel ToEnum(string value)
        {
            return value switch
            {
                "tts-1" => CreateSpeechRequestModel.Tts1,
                "tts-1-hd" => CreateSpeechRequestModel.Tts1Hd,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateSpeechRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateSpeechRequestModel.Tts1,
                1 => CreateSpeechRequestModel.Tts1Hd,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}