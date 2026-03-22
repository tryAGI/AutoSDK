//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestMergedByType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
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
    public static class WebhookPullRequestUnlabeledPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestMergedByType.Bot,
                "Organization" => WebhookPullRequestUnlabeledPullRequestMergedByType.Organization,
                "User" => WebhookPullRequestUnlabeledPullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}