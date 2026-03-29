//HintName: G.Models.FallbackOpenAITranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    public enum FallbackOpenAITranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oTranscribe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackOpenAITranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackOpenAITranscriberModel value)
        {
            return value switch
            {
                FallbackOpenAITranscriberModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                FallbackOpenAITranscriberModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackOpenAITranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-mini-transcribe" => FallbackOpenAITranscriberModel.Gpt4oMiniTranscribe,
                "gpt-4o-transcribe" => FallbackOpenAITranscriberModel.Gpt4oTranscribe,
                _ => null,
            };
        }
    }
}