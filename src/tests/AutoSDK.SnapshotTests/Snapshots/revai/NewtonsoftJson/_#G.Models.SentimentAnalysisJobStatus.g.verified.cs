//HintName: G.Models.SentimentAnalysisJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the job
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SentimentAnalysisJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentimentAnalysisJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentimentAnalysisJobStatus value)
        {
            return value switch
            {
                SentimentAnalysisJobStatus.Completed => "completed",
                SentimentAnalysisJobStatus.Failed => "failed",
                SentimentAnalysisJobStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentimentAnalysisJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => SentimentAnalysisJobStatus.Completed,
                "failed" => SentimentAnalysisJobStatus.Failed,
                "in_progress" => SentimentAnalysisJobStatus.InProgress,
                _ => null,
            };
        }
    }
}