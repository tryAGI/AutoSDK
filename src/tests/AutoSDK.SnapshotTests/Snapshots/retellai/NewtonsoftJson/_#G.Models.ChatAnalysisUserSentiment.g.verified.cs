//HintName: G.Models.ChatAnalysisUserSentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sentiment of the user in the chat.<br/>
    /// Example: Positive
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatAnalysisUserSentiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Negative")]
        Negative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Positive")]
        Positive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatAnalysisUserSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatAnalysisUserSentiment value)
        {
            return value switch
            {
                ChatAnalysisUserSentiment.Negative => "Negative",
                ChatAnalysisUserSentiment.Neutral => "Neutral",
                ChatAnalysisUserSentiment.Positive => "Positive",
                ChatAnalysisUserSentiment.Unknown => "Unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatAnalysisUserSentiment? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => ChatAnalysisUserSentiment.Negative,
                "Neutral" => ChatAnalysisUserSentiment.Neutral,
                "Positive" => ChatAnalysisUserSentiment.Positive,
                "Unknown" => ChatAnalysisUserSentiment.Unknown,
                _ => null,
            };
        }
    }
}