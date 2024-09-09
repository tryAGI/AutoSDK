//HintName: G.Models.WebhookDeploymentStatusCreatedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedWorkflowRunConclusion
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
        [global::System.Runtime.Serialization.EnumMember(Value="startup_failure")]
        StartupFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentStatusCreatedWorkflowRunConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedWorkflowRunConclusion value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.Success => "success",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.Failure => "failure",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.Neutral => "neutral",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.Cancelled => "cancelled",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.TimedOut => "timed_out",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.ActionRequired => "action_required",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.Stale => "stale",
                WebhookDeploymentStatusCreatedWorkflowRunConclusion.StartupFailure => "startup_failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedWorkflowRunConclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.Success,
                "failure" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.Failure,
                "neutral" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.Neutral,
                "cancelled" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.Cancelled,
                "timed_out" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.TimedOut,
                "action_required" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.ActionRequired,
                "stale" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.Stale,
                "startup_failure" => WebhookDeploymentStatusCreatedWorkflowRunConclusion.StartupFailure,
                _ => null,
            };
        }
    }
}