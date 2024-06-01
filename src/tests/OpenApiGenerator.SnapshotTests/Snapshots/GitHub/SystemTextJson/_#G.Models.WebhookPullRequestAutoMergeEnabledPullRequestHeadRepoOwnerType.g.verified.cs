//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}