//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedWorkflowRunConclusion
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
        public static WebhookDeploymentCreatedWorkflowRunConclusion ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}