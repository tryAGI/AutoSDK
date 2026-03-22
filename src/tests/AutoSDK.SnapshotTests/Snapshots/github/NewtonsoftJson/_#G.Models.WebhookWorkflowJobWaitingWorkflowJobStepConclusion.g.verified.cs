//HintName: G.Models.WebhookWorkflowJobWaitingWorkflowJobStepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobWaitingWorkflowJobStepConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobWaitingWorkflowJobStepConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobWaitingWorkflowJobStepConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Cancelled => "cancelled",
                WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Failure => "failure",
                WebhookWorkflowJobWaitingWorkflowJobStepConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Skipped => "skipped",
                WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobWaitingWorkflowJobStepConclusion? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Cancelled,
                "failure" => WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Failure,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobWaitingWorkflowJobStepConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Skipped,
                "success" => WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Success,
                _ => null,
            };
        }
    }
}