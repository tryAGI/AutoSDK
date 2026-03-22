//HintName: G.Models.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The granularity of the timestamps in the transcription. 'word' provides word-level timestamps and 'character' provides character-level timestamps per word.<br/>
    /// Default Value: word
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodySpeechToTextV1SpeechToTextPostTimestampsGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="character")]
        Character,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="word")]
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySpeechToTextV1SpeechToTextPostTimestampsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySpeechToTextV1SpeechToTextPostTimestampsGranularity value)
        {
            return value switch
            {
                BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.Character => "character",
                BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.None => "none",
                BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "character" => BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.Character,
                "none" => BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.None,
                "word" => BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.Word,
                _ => null,
            };
        }
    }
}