//HintName: G.Models.WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorType.Bot => "Bot",
                WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorType.User => "User",
                WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorType.Bot,
                "User" => WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorType.User,
                "Organization" => WebhookDeploymentReviewRequestedWorkflowRunTriggeringActorType.Organization,
                _ => null,
            };
        }
    }
}