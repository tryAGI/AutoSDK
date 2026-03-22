//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
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
    public static class WebhookPullRequestEnqueuedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}