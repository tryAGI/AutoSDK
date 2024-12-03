//HintName: G.Models.WebhookPullRequestLabeledPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestLabeledPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestLabeledPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestLabeledPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestLabeledPullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}