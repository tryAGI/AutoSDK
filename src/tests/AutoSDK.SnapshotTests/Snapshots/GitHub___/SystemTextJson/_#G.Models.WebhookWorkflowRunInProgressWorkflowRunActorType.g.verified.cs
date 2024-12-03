//HintName: G.Models.WebhookWorkflowRunInProgressWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunInProgressWorkflowRunActorType
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
    public static class WebhookWorkflowRunInProgressWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunInProgressWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookWorkflowRunInProgressWorkflowRunActorType.Bot => "Bot",
                WebhookWorkflowRunInProgressWorkflowRunActorType.User => "User",
                WebhookWorkflowRunInProgressWorkflowRunActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunInProgressWorkflowRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunInProgressWorkflowRunActorType.Bot,
                "User" => WebhookWorkflowRunInProgressWorkflowRunActorType.User,
                "Organization" => WebhookWorkflowRunInProgressWorkflowRunActorType.Organization,
                _ => null,
            };
        }
    }
}