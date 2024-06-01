//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary status for all check runs that are part of the check suite. Can be `requested`, `in_progress`, or `completed`.
    /// </summary>
    public enum WebhookCheckSuiteCompletedCheckSuiteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Requested,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteCompletedCheckSuiteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteStatus value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteStatus.Requested => "requested",
                WebhookCheckSuiteCompletedCheckSuiteStatus.InProgress => "in_progress",
                WebhookCheckSuiteCompletedCheckSuiteStatus.Completed => "completed",
                WebhookCheckSuiteCompletedCheckSuiteStatus.Queued => "queued",
                WebhookCheckSuiteCompletedCheckSuiteStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteStatus ToEnum(string value)
        {
            return value switch
            {
                "requested" => WebhookCheckSuiteCompletedCheckSuiteStatus.Requested,
                "in_progress" => WebhookCheckSuiteCompletedCheckSuiteStatus.InProgress,
                "completed" => WebhookCheckSuiteCompletedCheckSuiteStatus.Completed,
                "queued" => WebhookCheckSuiteCompletedCheckSuiteStatus.Queued,
                "pending" => WebhookCheckSuiteCompletedCheckSuiteStatus.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}