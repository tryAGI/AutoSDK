//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.Organization => "Organization",
                WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.Bot,
                "Organization" => WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.Organization,
                "User" => WebhookWorkflowRunRequestedWorkflowRunHeadRepositoryOwnerType.User,
                _ => null,
            };
        }
    }
}