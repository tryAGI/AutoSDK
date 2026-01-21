//HintName: G.Models.WebhookWorkflowJobQueuedWorkflowJobStepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobQueuedWorkflowJobStepConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
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
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Failure => "failure",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Skipped => "skipped",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Success => "success",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Cancelled => "cancelled",
                WebhookWorkflowJobQueuedWorkflowJobStepConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
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
                "failure" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Failure,
                "skipped" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Skipped,
                "success" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Success,
                "cancelled" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.Cancelled,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobQueuedWorkflowJobStepConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}