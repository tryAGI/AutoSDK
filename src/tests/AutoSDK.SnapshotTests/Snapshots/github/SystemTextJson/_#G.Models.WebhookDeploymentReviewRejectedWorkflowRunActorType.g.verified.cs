//HintName: G.Models.WebhookDeploymentReviewRejectedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRejectedWorkflowRunActorType
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
    public static class WebhookDeploymentReviewRejectedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRejectedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRejectedWorkflowRunActorType.Bot => "Bot",
                WebhookDeploymentReviewRejectedWorkflowRunActorType.Organization => "Organization",
                WebhookDeploymentReviewRejectedWorkflowRunActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRejectedWorkflowRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewRejectedWorkflowRunActorType.Bot,
                "Organization" => WebhookDeploymentReviewRejectedWorkflowRunActorType.Organization,
                "User" => WebhookDeploymentReviewRejectedWorkflowRunActorType.User,
                _ => null,
            };
        }
    }
}