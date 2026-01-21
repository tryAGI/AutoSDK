//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion
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
    public static class WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Failure => "failure",
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Skipped => "skipped",
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Success => "success",
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Cancelled => "cancelled",
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion? ToEnum(string value)
        {
            return value switch
            {
                "failure" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Failure,
                "skipped" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Skipped,
                "success" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Success,
                "cancelled" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Cancelled,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}