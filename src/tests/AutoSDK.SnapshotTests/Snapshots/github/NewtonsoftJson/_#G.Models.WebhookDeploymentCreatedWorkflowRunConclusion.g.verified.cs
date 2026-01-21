//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentCreatedWorkflowRunConclusion
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
    public static class WebhookDeploymentCreatedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentCreatedWorkflowRunConclusion.Success => "success",
                WebhookDeploymentCreatedWorkflowRunConclusion.Failure => "failure",
                WebhookDeploymentCreatedWorkflowRunConclusion.Neutral => "neutral",
                WebhookDeploymentCreatedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentCreatedWorkflowRunConclusion.TimedOut => "timed_out",
                WebhookDeploymentCreatedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentCreatedWorkflowRunConclusion.Stale => "stale",
                WebhookDeploymentCreatedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedWorkflowRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookDeploymentCreatedWorkflowRunConclusion.Success,
                "failure" => WebhookDeploymentCreatedWorkflowRunConclusion.Failure,
                "neutral" => WebhookDeploymentCreatedWorkflowRunConclusion.Neutral,
                "cancelled" => WebhookDeploymentCreatedWorkflowRunConclusion.Cancelled,
                "timed_out" => WebhookDeploymentCreatedWorkflowRunConclusion.TimedOut,
                "action_required" => WebhookDeploymentCreatedWorkflowRunConclusion.ActionRequired,
                "stale" => WebhookDeploymentCreatedWorkflowRunConclusion.Stale,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookDeploymentCreatedWorkflowRunConclusion.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}