//HintName: G.Models.WebhookPullRequestLabeledPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestLabeledPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestLabeledPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestLabeledPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestLabeledPullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestLabeledPullRequestMilestoneCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}