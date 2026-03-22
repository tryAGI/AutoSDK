//HintName: G.Models.WebhookWorkflowJobQueuedWorkflowJobStepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobQueuedWorkflowJobStepConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobQueuedWorkflowJobStepConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobQueuedWorkflowJobStepConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Cancelled => "cancelled",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Failure => "failure",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Skipped => "skipped",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobQueuedWorkflowJobStepConclusion? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Cancelled,
                "failure" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Failure,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Skipped,
                "success" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Success,
                _ => null,
            };
        }
    }
}