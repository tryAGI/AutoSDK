//HintName: G.Models.WebhookWorkflowRunInProgressWorkflowRunTriggeringActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunInProgressWorkflowRunTriggeringActorType
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
    public static class WebhookWorkflowRunInProgressWorkflowRunTriggeringActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunInProgressWorkflowRunTriggeringActorType value)
        {
            return value switch
            {
                WebhookWorkflowRunInProgressWorkflowRunTriggeringActorType.Bot => "Bot",
                WebhookWorkflowRunInProgressWorkflowRunTriggeringActorType.User => "User",
                WebhookWorkflowRunInProgressWorkflowRunTriggeringActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunInProgressWorkflowRunTriggeringActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunInProgressWorkflowRunTriggeringActorType.Bot,
                "User" => WebhookWorkflowRunInProgressWorkflowRunTriggeringActorType.User,
                "Organization" => WebhookWorkflowRunInProgressWorkflowRunTriggeringActorType.Organization,
                _ => null,
            };
        }
    }
}