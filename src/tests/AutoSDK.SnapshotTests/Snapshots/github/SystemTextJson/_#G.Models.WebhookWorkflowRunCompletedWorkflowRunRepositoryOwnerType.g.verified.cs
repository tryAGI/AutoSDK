//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType
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
    public static class WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.Organization => "Organization",
                WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.Bot,
                "Organization" => WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.Organization,
                "User" => WebhookWorkflowRunCompletedWorkflowRunRepositoryOwnerType.User,
                _ => null,
            };
        }
    }
}