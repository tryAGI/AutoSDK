//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunRequestedWorkflowRunActorType
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
    public static class WebhookWorkflowRunRequestedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunRequestedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookWorkflowRunRequestedWorkflowRunActorType.Bot => "Bot",
                WebhookWorkflowRunRequestedWorkflowRunActorType.User => "User",
                WebhookWorkflowRunRequestedWorkflowRunActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunRequestedWorkflowRunActorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunRequestedWorkflowRunActorType.Bot,
                "User" => WebhookWorkflowRunRequestedWorkflowRunActorType.User,
                "Organization" => WebhookWorkflowRunRequestedWorkflowRunActorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}