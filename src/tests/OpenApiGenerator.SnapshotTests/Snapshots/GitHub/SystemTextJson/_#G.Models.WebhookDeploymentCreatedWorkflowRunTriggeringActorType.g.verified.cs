//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunTriggeringActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedWorkflowRunTriggeringActorType
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
    public static class WebhookDeploymentCreatedWorkflowRunTriggeringActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedWorkflowRunTriggeringActorType value)
        {
            return value switch
            {
                WebhookDeploymentCreatedWorkflowRunTriggeringActorType.Bot => "Bot",
                WebhookDeploymentCreatedWorkflowRunTriggeringActorType.User => "User",
                WebhookDeploymentCreatedWorkflowRunTriggeringActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedWorkflowRunTriggeringActorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentCreatedWorkflowRunTriggeringActorType.Bot,
                "User" => WebhookDeploymentCreatedWorkflowRunTriggeringActorType.User,
                "Organization" => WebhookDeploymentCreatedWorkflowRunTriggeringActorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}