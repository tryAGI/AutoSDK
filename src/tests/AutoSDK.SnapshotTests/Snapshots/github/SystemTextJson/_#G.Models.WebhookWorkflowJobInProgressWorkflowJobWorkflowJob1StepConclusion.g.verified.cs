//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion
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
    public static class WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Cancelled => "cancelled",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Failure => "failure",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Skipped => "skipped",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Cancelled,
                "failure" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Failure,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Skipped,
                "success" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Success,
                _ => null,
            };
        }
    }
}