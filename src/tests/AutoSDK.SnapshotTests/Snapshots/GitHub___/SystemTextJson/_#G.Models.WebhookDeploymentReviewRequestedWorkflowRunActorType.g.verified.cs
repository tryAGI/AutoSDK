//HintName: G.Models.WebhookDeploymentReviewRequestedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentReviewRequestedWorkflowRunActorType
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
    public static class WebhookDeploymentReviewRequestedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentReviewRequestedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookDeploymentReviewRequestedWorkflowRunActorType.Bot => "Bot",
                WebhookDeploymentReviewRequestedWorkflowRunActorType.User => "User",
                WebhookDeploymentReviewRequestedWorkflowRunActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentReviewRequestedWorkflowRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentReviewRequestedWorkflowRunActorType.Bot,
                "User" => WebhookDeploymentReviewRequestedWorkflowRunActorType.User,
                "Organization" => WebhookDeploymentReviewRequestedWorkflowRunActorType.Organization,
                _ => null,
            };
        }
    }
}