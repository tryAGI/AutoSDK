//HintName: G.Models.WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestDequeuedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}