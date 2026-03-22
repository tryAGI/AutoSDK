//HintName: G.Models.WebhookPullRequestLabeledPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestMergedByType
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
    public static class WebhookPullRequestLabeledPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestMergedByType.Mannequin => "Mannequin",
                WebhookPullRequestLabeledPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestMergedByType.Bot,
                "Mannequin" => WebhookPullRequestLabeledPullRequestMergedByType.Mannequin,
                "Organization" => WebhookPullRequestLabeledPullRequestMergedByType.Organization,
                "User" => WebhookPullRequestLabeledPullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}