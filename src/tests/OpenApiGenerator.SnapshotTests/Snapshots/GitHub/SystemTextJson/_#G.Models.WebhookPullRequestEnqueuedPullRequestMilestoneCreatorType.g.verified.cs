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
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
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
                WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
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
                "User" => WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestEnqueuedPullRequestMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}