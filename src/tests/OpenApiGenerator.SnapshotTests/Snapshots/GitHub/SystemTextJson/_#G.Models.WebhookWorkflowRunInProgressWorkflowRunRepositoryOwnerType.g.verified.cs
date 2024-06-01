//HintName: G.Models.WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType
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
    public static class WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.User => "User",
                WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.Bot,
                "User" => WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.User,
                "Organization" => WebhookWorkflowRunInProgressWorkflowRunRepositoryOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}