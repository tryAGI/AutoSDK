//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.Success => "success",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.Failure => "failure",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.Skipped => "skipped",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.Cancelled => "cancelled",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.ActionRequired => "action_required",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.Neutral => "neutral",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.Success,
                "failure" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.Failure,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.Skipped,
                "cancelled" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.Cancelled,
                "action_required" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.ActionRequired,
                "neutral" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.Neutral,
                "timed_out" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Conclusion.TimedOut,
                _ => null,
            };
        }
    }
}