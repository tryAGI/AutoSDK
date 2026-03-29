//HintName: G.Models.CallAnalysisUserSentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sentiment of the user in the call.<br/>
    /// Example: Positive
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallAnalysisUserSentiment
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
    public static class CallAnalysisUserSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallAnalysisUserSentiment value)
        {
            return value switch
            {
                CallAnalysisUserSentiment.Negative => "Negative",
                CallAnalysisUserSentiment.Neutral => "Neutral",
                CallAnalysisUserSentiment.Positive => "Positive",
                CallAnalysisUserSentiment.Unknown => "Unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallAnalysisUserSentiment? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => CallAnalysisUserSentiment.Negative,
                "Neutral" => CallAnalysisUserSentiment.Neutral,
                "Positive" => CallAnalysisUserSentiment.Positive,
                "Unknown" => CallAnalysisUserSentiment.Unknown,
                _ => null,
            };
        }
    }
}