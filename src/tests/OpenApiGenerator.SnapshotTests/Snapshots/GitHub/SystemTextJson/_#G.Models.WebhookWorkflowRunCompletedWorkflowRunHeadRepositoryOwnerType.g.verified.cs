//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType
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
    public static class WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.User => "User",
                WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.Bot,
                "User" => WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.User,
                "Organization" => WebhookWorkflowRunCompletedWorkflowRunHeadRepositoryOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}