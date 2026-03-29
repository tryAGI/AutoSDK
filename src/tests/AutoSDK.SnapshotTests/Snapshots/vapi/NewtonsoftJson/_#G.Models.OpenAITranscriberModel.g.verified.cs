//HintName: G.Models.OpenAITranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAITranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-transcribe")]
        Gpt4oMiniTranscribe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-transcribe")]
        Gpt4oTranscribe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAITranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAITranscriberModel value)
        {
            return value switch
            {
                OpenAITranscriberModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                OpenAITranscriberModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAITranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-mini-transcribe" => OpenAITranscriberModel.Gpt4oMiniTranscribe,
                "gpt-4o-transcribe" => OpenAITranscriberModel.Gpt4oTranscribe,
                _ => null,
            };
        }
    }
}