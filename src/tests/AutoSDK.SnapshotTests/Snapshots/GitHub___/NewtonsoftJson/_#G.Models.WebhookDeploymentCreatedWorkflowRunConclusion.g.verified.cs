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
                _ => null,
            };
        }
    }
}