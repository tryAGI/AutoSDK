//HintName: G.Models.WebhookDeploymentCreatedWorkflowRunTriggeringActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentCreatedWorkflowRunTriggeringActorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
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
                WebhookDeploymentCreatedWorkflowRunTriggeringActorType.Organization => "Organization",
                WebhookDeploymentCreatedWorkflowRunTriggeringActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedWorkflowRunTriggeringActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentCreatedWorkflowRunTriggeringActorType.Bot,
                "Organization" => WebhookDeploymentCreatedWorkflowRunTriggeringActorType.Organization,
                "User" => WebhookDeploymentCreatedWorkflowRunTriggeringActorType.User,
                _ => null,
            };
        }
    }
}