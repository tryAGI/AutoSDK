//HintName: G.Models.WebhookDeploymentReviewApprovedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentReviewApprovedWorkflowRunConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewApprovedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewApprovedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.Success => "success",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.Failure => "failure",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.Neutral => "neutral",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.TimedOut => "timed_out",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.Stale => "stale",
                WebhookDeploymentReviewApprovedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewApprovedWorkflowRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.Success,
                "failure" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.Failure,
                "neutral" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.Neutral,
                "cancelled" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.Cancelled,
                "timed_out" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.TimedOut,
                "action_required" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.ActionRequired,
                "stale" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.Stale,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookDeploymentReviewApprovedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}