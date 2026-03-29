//HintName: G.Models.FeedsListSubscriptionHistoryResponseRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedsListSubscriptionHistoryResponseRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedsListSubscriptionHistoryResponseRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedsListSubscriptionHistoryResponseRunStatus value)
        {
            return value switch
            {
                FeedsListSubscriptionHistoryResponseRunStatus.Canceled => "canceled",
                FeedsListSubscriptionHistoryResponseRunStatus.Completed => "completed",
                FeedsListSubscriptionHistoryResponseRunStatus.Failed => "failed",
                FeedsListSubscriptionHistoryResponseRunStatus.Running => "running",
                FeedsListSubscriptionHistoryResponseRunStatus.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedsListSubscriptionHistoryResponseRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => FeedsListSubscriptionHistoryResponseRunStatus.Canceled,
                "completed" => FeedsListSubscriptionHistoryResponseRunStatus.Completed,
                "failed" => FeedsListSubscriptionHistoryResponseRunStatus.Failed,
                "running" => FeedsListSubscriptionHistoryResponseRunStatus.Running,
                "timed_out" => FeedsListSubscriptionHistoryResponseRunStatus.TimedOut,
                _ => null,
            };
        }
    }
}