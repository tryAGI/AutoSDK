//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestUnlabeledPullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}