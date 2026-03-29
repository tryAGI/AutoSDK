//HintName: G.Models.FeedbackScoreSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackScoreSource
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
    public static class FeedbackScoreSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackScoreSource value)
        {
            return value switch
            {
                FeedbackScoreSource.OnlineScoring => "online_scoring",
                FeedbackScoreSource.Sdk => "sdk",
                FeedbackScoreSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackScoreSource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => FeedbackScoreSource.OnlineScoring,
                "sdk" => FeedbackScoreSource.Sdk,
                "ui" => FeedbackScoreSource.Ui,
                _ => null,
            };
        }
    }
}