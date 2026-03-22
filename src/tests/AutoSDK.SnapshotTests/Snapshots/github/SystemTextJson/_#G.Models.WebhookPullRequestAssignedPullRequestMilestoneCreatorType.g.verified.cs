//HintName: G.Models.WebhookPullRequestAssignedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestAssignedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestAssignedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestAssignedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}