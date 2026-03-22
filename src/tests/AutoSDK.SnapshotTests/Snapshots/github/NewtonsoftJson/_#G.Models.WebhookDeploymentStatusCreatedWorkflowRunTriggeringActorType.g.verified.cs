//HintName: G.Models.WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorType
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
    public static class WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorType value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorType.Bot => "Bot",
                WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorType.Organization => "Organization",
                WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorType.Bot,
                "Organization" => WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorType.Organization,
                "User" => WebhookDeploymentStatusCreatedWorkflowRunTriggeringActorType.User,
                _ => null,
            };
        }
    }
}