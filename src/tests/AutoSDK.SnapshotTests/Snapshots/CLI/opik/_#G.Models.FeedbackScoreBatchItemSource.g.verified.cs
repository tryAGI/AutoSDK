//HintName: G.Models.FeedbackScoreBatchItemSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackScoreBatchItemSource
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
    public static class FeedbackScoreBatchItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackScoreBatchItemSource value)
        {
            return value switch
            {
                FeedbackScoreBatchItemSource.OnlineScoring => "online_scoring",
                FeedbackScoreBatchItemSource.Sdk => "sdk",
                FeedbackScoreBatchItemSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackScoreBatchItemSource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => FeedbackScoreBatchItemSource.OnlineScoring,
                "sdk" => FeedbackScoreBatchItemSource.Sdk,
                "ui" => FeedbackScoreBatchItemSource.Ui,
                _ => null,
            };
        }
    }
}