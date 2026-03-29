//HintName: G.Models.FeedbackScoreExperimentItemBulkWriteViewSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackScoreExperimentItemBulkWriteViewSource
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
    public static class FeedbackScoreExperimentItemBulkWriteViewSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackScoreExperimentItemBulkWriteViewSource value)
        {
            return value switch
            {
                FeedbackScoreExperimentItemBulkWriteViewSource.OnlineScoring => "online_scoring",
                FeedbackScoreExperimentItemBulkWriteViewSource.Sdk => "sdk",
                FeedbackScoreExperimentItemBulkWriteViewSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackScoreExperimentItemBulkWriteViewSource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => FeedbackScoreExperimentItemBulkWriteViewSource.OnlineScoring,
                "sdk" => FeedbackScoreExperimentItemBulkWriteViewSource.Sdk,
                "ui" => FeedbackScoreExperimentItemBulkWriteViewSource.Ui,
                _ => null,
            };
        }
    }
}