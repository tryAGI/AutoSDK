//HintName: G.Models.SentimentAnalysisErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SentimentAnalysisErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        SentimentAnalysisFailed,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedLanguage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentimentAnalysisErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentimentAnalysisErrorType value)
        {
            return value switch
            {
                SentimentAnalysisErrorType.SentimentAnalysisFailed => "sentiment_analysis_failed",
                SentimentAnalysisErrorType.UnsupportedLanguage => "unsupported_language",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentimentAnalysisErrorType? ToEnum(string value)
        {
            return value switch
            {
                "sentiment_analysis_failed" => SentimentAnalysisErrorType.SentimentAnalysisFailed,
                "unsupported_language" => SentimentAnalysisErrorType.UnsupportedLanguage,
                _ => null,
            };
        }
    }
}