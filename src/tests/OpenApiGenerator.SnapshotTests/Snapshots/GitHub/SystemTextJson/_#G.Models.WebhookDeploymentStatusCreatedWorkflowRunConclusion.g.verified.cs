//HintName: G.Models.WebhookDeploymentStatusCreatedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedWorkflowRunConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        Stale,
        /// <summary>
        /// 
        /// </summary>
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
        public static WebhookDeploymentStatusCreatedWorkflowRunConclusion ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}