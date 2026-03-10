//HintName: G.Models.BodySpeechToTextV1SpeechToTextPostModelId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ID of the model to use for transcription.
    /// </summary>
    public enum BodySpeechToTextV1SpeechToTextPostModelId
    {
        /// <summary>
        /// 
        /// </summary>
        ScribeV1,
        /// <summary>
        /// 
        /// </summary>
        ScribeV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySpeechToTextV1SpeechToTextPostModelIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySpeechToTextV1SpeechToTextPostModelId value)
        {
            return value switch
            {
                BodySpeechToTextV1SpeechToTextPostModelId.ScribeV1 => "scribe_v1",
                BodySpeechToTextV1SpeechToTextPostModelId.ScribeV2 => "scribe_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySpeechToTextV1SpeechToTextPostModelId? ToEnum(string value)
        {
            return value switch
            {
                "scribe_v1" => BodySpeechToTextV1SpeechToTextPostModelId.ScribeV1,
                "scribe_v2" => BodySpeechToTextV1SpeechToTextPostModelId.ScribeV2,
                _ => null,
            };
        }
    }
}