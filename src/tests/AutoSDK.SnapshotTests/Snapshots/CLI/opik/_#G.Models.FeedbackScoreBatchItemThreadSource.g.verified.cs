//HintName: G.Models.FeedbackScoreBatchItemThreadSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackScoreBatchItemThreadSource
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
    public static class FeedbackScoreBatchItemThreadSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackScoreBatchItemThreadSource value)
        {
            return value switch
            {
                FeedbackScoreBatchItemThreadSource.OnlineScoring => "online_scoring",
                FeedbackScoreBatchItemThreadSource.Sdk => "sdk",
                FeedbackScoreBatchItemThreadSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackScoreBatchItemThreadSource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => FeedbackScoreBatchItemThreadSource.OnlineScoring,
                "sdk" => FeedbackScoreBatchItemThreadSource.Sdk,
                "ui" => FeedbackScoreBatchItemThreadSource.Ui,
                _ => null,
            };
        }
    }
}