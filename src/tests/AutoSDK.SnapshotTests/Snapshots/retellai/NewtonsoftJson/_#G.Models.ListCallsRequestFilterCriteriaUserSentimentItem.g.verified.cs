//HintName: G.Models.ListCallsRequestFilterCriteriaUserSentimentItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListCallsRequestFilterCriteriaUserSentimentItem
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
    public static class ListCallsRequestFilterCriteriaUserSentimentItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCallsRequestFilterCriteriaUserSentimentItem value)
        {
            return value switch
            {
                ListCallsRequestFilterCriteriaUserSentimentItem.Negative => "Negative",
                ListCallsRequestFilterCriteriaUserSentimentItem.Neutral => "Neutral",
                ListCallsRequestFilterCriteriaUserSentimentItem.Positive => "Positive",
                ListCallsRequestFilterCriteriaUserSentimentItem.Unknown => "Unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCallsRequestFilterCriteriaUserSentimentItem? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => ListCallsRequestFilterCriteriaUserSentimentItem.Negative,
                "Neutral" => ListCallsRequestFilterCriteriaUserSentimentItem.Neutral,
                "Positive" => ListCallsRequestFilterCriteriaUserSentimentItem.Positive,
                "Unknown" => ListCallsRequestFilterCriteriaUserSentimentItem.Unknown,
                _ => null,
            };
        }
    }
}