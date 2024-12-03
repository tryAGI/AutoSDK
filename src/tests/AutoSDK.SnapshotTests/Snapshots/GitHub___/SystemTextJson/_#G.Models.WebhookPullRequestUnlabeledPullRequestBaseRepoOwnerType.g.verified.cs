//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestUnlabeledPullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}