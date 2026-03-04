//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion
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
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
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
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Failure => "failure",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Skipped => "skipped",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Success => "success",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Cancelled => "cancelled",
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
                "failure" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Failure,
                "skipped" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Skipped,
                "success" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Success,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                "cancelled" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepConclusion.Cancelled,
                _ => null,
            };
        }
    }
}