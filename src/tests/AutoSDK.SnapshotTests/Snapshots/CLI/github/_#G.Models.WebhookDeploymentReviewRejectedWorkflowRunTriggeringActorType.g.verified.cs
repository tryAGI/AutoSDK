//HintName: G.Models.WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorType
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
    public static class WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorType.Bot => "Bot",
                WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorType.User => "User",
                WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorType.Bot,
                "User" => WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorType.User,
                "Organization" => WebhookDeploymentReviewRejectedWorkflowRunTriggeringActorType.Organization,
                _ => null,
            };
        }
    }
}