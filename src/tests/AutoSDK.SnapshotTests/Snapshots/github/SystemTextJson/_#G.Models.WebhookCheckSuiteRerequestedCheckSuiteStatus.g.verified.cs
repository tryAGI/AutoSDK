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
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
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
                WebhookCheckSuiteRerequestedCheckSuiteStatus.Requested => "requested",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.InProgress => "in_progress",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.Completed => "completed",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.Queued => "queued",
                WebhookCheckSuiteRerequestedCheckSuiteStatus.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
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
                "requested" => WebhookCheckSuiteRerequestedCheckSuiteStatus.Requested,
                "in_progress" => WebhookCheckSuiteRerequestedCheckSuiteStatus.InProgress,
                "completed" => WebhookCheckSuiteRerequestedCheckSuiteStatus.Completed,
                "queued" => WebhookCheckSuiteRerequestedCheckSuiteStatus.Queued,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCheckSuiteRerequestedCheckSuiteStatus.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}