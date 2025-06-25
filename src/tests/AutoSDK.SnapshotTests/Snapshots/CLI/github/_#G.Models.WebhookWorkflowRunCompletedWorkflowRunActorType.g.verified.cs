//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunCompletedWorkflowRunActorType
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
    public static class WebhookWorkflowRunCompletedWorkflowRunActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunCompletedWorkflowRunActorType value)
        {
            return value switch
            {
                WebhookWorkflowRunCompletedWorkflowRunActorType.Bot => "Bot",
                WebhookWorkflowRunCompletedWorkflowRunActorType.User => "User",
                WebhookWorkflowRunCompletedWorkflowRunActorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunCompletedWorkflowRunActorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunCompletedWorkflowRunActorType.Bot,
                "User" => WebhookWorkflowRunCompletedWorkflowRunActorType.User,
                "Organization" => WebhookWorkflowRunCompletedWorkflowRunActorType.Organization,
                _ => null,
            };
        }
    }
}