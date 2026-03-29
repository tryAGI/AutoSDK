//HintName: G.Models.FeedbackScoreCompareSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackScoreCompareSource
    {
        /// <summary>
        /// 
        /// </summary>
        OnlineScoring,
        /// <summary>
        /// 
        /// </summary>
        Sdk,
        /// <summary>
        /// 
        /// </summary>
        Ui,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackScoreCompareSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackScoreCompareSource value)
        {
            return value switch
            {
                FeedbackScoreCompareSource.OnlineScoring => "online_scoring",
                FeedbackScoreCompareSource.Sdk => "sdk",
                FeedbackScoreCompareSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackScoreCompareSource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => FeedbackScoreCompareSource.OnlineScoring,
                "sdk" => FeedbackScoreCompareSource.Sdk,
                "ui" => FeedbackScoreCompareSource.Ui,
                _ => null,
            };
        }
    }
}