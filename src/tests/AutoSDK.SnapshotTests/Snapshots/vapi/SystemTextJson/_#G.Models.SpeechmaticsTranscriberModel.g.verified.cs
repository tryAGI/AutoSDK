//HintName: G.Models.SpeechmaticsTranscriberModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    public enum SpeechmaticsTranscriberModel
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechmaticsTranscriberModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechmaticsTranscriberModel value)
        {
            return value switch
            {
                SpeechmaticsTranscriberModel.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechmaticsTranscriberModel? ToEnum(string value)
        {
            return value switch
            {
                "default" => SpeechmaticsTranscriberModel.Default,
                _ => null,
            };
        }
    }
}