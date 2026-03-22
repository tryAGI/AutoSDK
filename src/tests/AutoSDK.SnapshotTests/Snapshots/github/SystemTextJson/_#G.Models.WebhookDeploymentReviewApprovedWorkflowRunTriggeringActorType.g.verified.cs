//HintName: G.Models.WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType value)
        {
            return value switch
            {
                WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.Bot => "Bot",
                WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.Organization => "Organization",
                WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.Bot,
                "Organization" => WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.Organization,
                "User" => WebhookDeploymentReviewApprovedWorkflowRunTriggeringActorType.User,
                _ => null,
            };
        }
    }
}