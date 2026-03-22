//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestUnlabeledPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestUnlabeledPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}