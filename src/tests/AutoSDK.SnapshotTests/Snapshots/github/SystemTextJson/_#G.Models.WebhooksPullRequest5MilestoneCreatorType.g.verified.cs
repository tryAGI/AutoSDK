//HintName: G.Models.WebhooksPullRequest5MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5MilestoneCreatorType
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
    public static class WebhooksPullRequest5MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5MilestoneCreatorType value)
        {
            return value switch
            {
                WebhooksPullRequest5MilestoneCreatorType.Bot => "Bot",
                WebhooksPullRequest5MilestoneCreatorType.Mannequin => "Mannequin",
                WebhooksPullRequest5MilestoneCreatorType.Organization => "Organization",
                WebhooksPullRequest5MilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5MilestoneCreatorType.Bot,
                "Mannequin" => WebhooksPullRequest5MilestoneCreatorType.Mannequin,
                "Organization" => WebhooksPullRequest5MilestoneCreatorType.Organization,
                "User" => WebhooksPullRequest5MilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}