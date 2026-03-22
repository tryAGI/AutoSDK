//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary status for all check runs that are part of the check suite. Can be `requested`, `in_progress`, or `completed`.
    /// </summary>
    public enum WebhookCheckSuiteRerequestedCheckSuiteStatus
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
    public static class WebhookCheckSuiteRerequestedCheckSuiteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteStatus value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteStatus.Completed => "completed",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.InProgress => "in_progress",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.Queued => "queued",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookCheckSuiteRerequestedCheckSuiteStatus.Completed,
                "in_progress" => WebhookCheckSuiteRerequestedCheckSuiteStatus.InProgress,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCheckSuiteRerequestedCheckSuiteStatus.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "queued" => WebhookCheckSuiteRerequestedCheckSuiteStatus.Queued,
                "requested" => WebhookCheckSuiteRerequestedCheckSuiteStatus.Requested,
                _ => null,
            };
        }
    }
}