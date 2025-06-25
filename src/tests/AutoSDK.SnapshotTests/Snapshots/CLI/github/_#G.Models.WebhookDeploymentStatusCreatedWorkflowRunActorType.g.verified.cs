//HintName: G.Models.WebhookDeploymentStatusCreatedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedWorkflowRunActorType
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
    public static class WebhookDeploymentStatusCreatedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedWorkflowRunActorType.Bot => "Bot",
                WebhookDeploymentStatusCreatedWorkflowRunActorType.User => "User",
                WebhookDeploymentStatusCreatedWorkflowRunActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedWorkflowRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentStatusCreatedWorkflowRunActorType.Bot,
                "User" => WebhookDeploymentStatusCreatedWorkflowRunActorType.User,
                "Organization" => WebhookDeploymentStatusCreatedWorkflowRunActorType.Organization,
                _ => null,
            };
        }
    }
}