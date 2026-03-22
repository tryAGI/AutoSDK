//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary status for all check runs that are part of the check suite. Can be `requested`, `in_progress`, or `completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteCompletedCheckSuiteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
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
                WebhookCheckSuiteCompletedCheckSuiteStatus.Completed => "completed",
                WebhookCheckSuiteCompletedCheckSuiteStatus.InProgress => "in_progress",
                WebhookCheckSuiteCompletedCheckSuiteStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCheckSuiteCompletedCheckSuiteStatus.Pending => "pending",
                WebhookCheckSuiteCompletedCheckSuiteStatus.Queued => "queued",
                WebhookCheckSuiteCompletedCheckSuiteStatus.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookCheckSuiteCompletedCheckSuiteStatus.Completed,
                "in_progress" => WebhookCheckSuiteCompletedCheckSuiteStatus.InProgress,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCheckSuiteCompletedCheckSuiteStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "pending" => WebhookCheckSuiteCompletedCheckSuiteStatus.Pending,
                "queued" => WebhookCheckSuiteCompletedCheckSuiteStatus.Queued,
                "requested" => WebhookCheckSuiteCompletedCheckSuiteStatus.Requested,
                _ => null,
            };
        }
    }
}