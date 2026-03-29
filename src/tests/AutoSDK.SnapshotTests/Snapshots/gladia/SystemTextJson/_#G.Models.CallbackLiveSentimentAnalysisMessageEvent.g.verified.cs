//HintName: G.Models.CallbackLiveSentimentAnalysisMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.sentiment_analysis<br/>
    /// Example: live.sentiment_analysis
    /// </summary>
    public enum CallbackLiveSentimentAnalysisMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        LiveSentimentAnalysis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveSentimentAnalysisMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveSentimentAnalysisMessageEvent value)
        {
            return value switch
            {
                CallbackLiveSentimentAnalysisMessageEvent.LiveSentimentAnalysis => "live.sentiment_analysis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveSentimentAnalysisMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.sentiment_analysis" => CallbackLiveSentimentAnalysisMessageEvent.LiveSentimentAnalysis,
                _ => null,
            };
        }
    }
}