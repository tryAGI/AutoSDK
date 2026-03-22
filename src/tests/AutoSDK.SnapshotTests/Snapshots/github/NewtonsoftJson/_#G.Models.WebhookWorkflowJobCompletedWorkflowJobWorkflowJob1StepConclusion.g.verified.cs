//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion
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
    public static class WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.Cancelled => "cancelled",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.Failure => "failure",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.Skipped => "skipped",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.Cancelled,
                "failure" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.Failure,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "skipped" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.Skipped,
                "success" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StepConclusion.Success,
                _ => null,
            };
        }
    }
}