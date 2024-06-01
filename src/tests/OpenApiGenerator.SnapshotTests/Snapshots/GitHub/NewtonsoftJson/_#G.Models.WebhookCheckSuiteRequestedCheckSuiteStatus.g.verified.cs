//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary status for all check runs that are part of the check suite. Can be `requested`, `in_progress`, or `completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteRequestedCheckSuiteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRequestedCheckSuiteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteStatus value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteStatus.Requested => "requested",
                WebhookCheckSuiteRequestedCheckSuiteStatus.InProgress => "in_progress",
                WebhookCheckSuiteRequestedCheckSuiteStatus.Completed => "completed",
                WebhookCheckSuiteRequestedCheckSuiteStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteStatus ToEnum(string value)
        {
            return value switch
            {
                "requested" => WebhookCheckSuiteRequestedCheckSuiteStatus.Requested,
                "in_progress" => WebhookCheckSuiteRequestedCheckSuiteStatus.InProgress,
                "completed" => WebhookCheckSuiteRequestedCheckSuiteStatus.Completed,
                "queued" => WebhookCheckSuiteRequestedCheckSuiteStatus.Queued,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}