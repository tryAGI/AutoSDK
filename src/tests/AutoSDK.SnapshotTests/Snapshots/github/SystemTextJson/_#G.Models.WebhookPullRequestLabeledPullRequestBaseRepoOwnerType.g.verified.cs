//HintName: G.Models.WebhookPullRequestLabeledPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestLabeledPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestBaseRepoOwnerType.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestBaseRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestBaseRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestLabeledPullRequestBaseRepoOwnerType.Organization,
                "User" => WebhookPullRequestLabeledPullRequestBaseRepoOwnerType.User,
                _ => null,
            };
        }
    }
}