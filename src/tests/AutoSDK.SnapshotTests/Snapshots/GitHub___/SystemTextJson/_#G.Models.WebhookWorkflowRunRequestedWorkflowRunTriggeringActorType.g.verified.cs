//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType
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
    public static class WebhookWorkflowRunRequestedWorkflowRunTriggeringActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType value)
        {
            return value switch
            {
                WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType.Bot => "Bot",
                WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType.User => "User",
                WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType.Bot,
                "User" => WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType.User,
                "Organization" => WebhookWorkflowRunRequestedWorkflowRunTriggeringActorType.Organization,
                _ => null,
            };
        }
    }
}