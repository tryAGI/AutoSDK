//HintName: G.Models.WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType
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
    public static class WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.Organization => "Organization",
                WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.Bot,
                "Organization" => WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.Organization,
                "User" => WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.User,
                _ => null,
            };
        }
    }
}