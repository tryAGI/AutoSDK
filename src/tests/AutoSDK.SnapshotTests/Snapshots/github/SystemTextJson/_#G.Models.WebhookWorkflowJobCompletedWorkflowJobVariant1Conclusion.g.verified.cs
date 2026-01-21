//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion
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
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
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
    public static class WebhookWorkflowJobCompletedWorkflowJobVariant1ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.Success => "success",
                WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.Failure => "failure",
                WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.Skipped => "skipped",
                WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.Cancelled => "cancelled",
                WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.ActionRequired => "action_required",
                WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.Neutral => "neutral",
                WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.Success,
                "failure" => WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.Failure,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                "skipped" => WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.Skipped,
                "cancelled" => WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.Cancelled,
                "action_required" => WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.ActionRequired,
                "neutral" => WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.Neutral,
                "timed_out" => WebhookWorkflowJobCompletedWorkflowJobVariant1Conclusion.TimedOut,
                _ => null,
            };
        }
    }
}