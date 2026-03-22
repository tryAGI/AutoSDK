//HintName: G.Models.WebhookPullRequestUnassignedPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestMergedByType
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
    public static class WebhookPullRequestUnassignedPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestMergedByType.Mannequin => "Mannequin",
                WebhookPullRequestUnassignedPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestMergedByType.Bot,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestMergedByType.Mannequin,
                "Organization" => WebhookPullRequestUnassignedPullRequestMergedByType.Organization,
                "User" => WebhookPullRequestUnassignedPullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}