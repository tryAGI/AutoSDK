//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary status for all check runs that are part of the check suite. Can be `requested`, `in_progress`, or `completed`.
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Requested,
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
                WebhookCheckSuiteRequestedCheckSuiteStatus.Completed => "completed",
                WebhookCheckSuiteRequestedCheckSuiteStatus.InProgress => "in_progress",
                WebhookCheckSuiteRequestedCheckSuiteStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCheckSuiteRequestedCheckSuiteStatus.Queued => "queued",
                WebhookCheckSuiteRequestedCheckSuiteStatus.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookCheckSuiteRequestedCheckSuiteStatus.Completed,
                "in_progress" => WebhookCheckSuiteRequestedCheckSuiteStatus.InProgress,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCheckSuiteRequestedCheckSuiteStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "queued" => WebhookCheckSuiteRequestedCheckSuiteStatus.Queued,
                "requested" => WebhookCheckSuiteRequestedCheckSuiteStatus.Requested,
                _ => null,
            };
        }
    }
}