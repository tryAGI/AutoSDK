//HintName: G.Models.FallbackSpeechmaticsTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    public enum FallbackSpeechmaticsTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackSpeechmaticsTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSpeechmaticsTranscriberModel value)
        {
            return value switch
            {
                FallbackSpeechmaticsTranscriberModel.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSpeechmaticsTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "default" => FallbackSpeechmaticsTranscriberModel.Default,
                _ => null,
            };
        }
    }
}