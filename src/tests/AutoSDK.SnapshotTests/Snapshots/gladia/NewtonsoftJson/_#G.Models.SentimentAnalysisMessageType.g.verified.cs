//HintName: G.Models.SentimentAnalysisMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: sentiment_analysis<br/>
    /// Example: sentiment_analysis
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SentimentAnalysisMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sentiment_analysis")]
        SentimentAnalysis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentimentAnalysisMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentimentAnalysisMessageType value)
        {
            return value switch
            {
                SentimentAnalysisMessageType.SentimentAnalysis => "sentiment_analysis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentimentAnalysisMessageType? ToEnum(string value)
        {
            return value switch
            {
                "sentiment_analysis" => SentimentAnalysisMessageType.SentimentAnalysis,
                _ => null,
            };
        }
    }
}