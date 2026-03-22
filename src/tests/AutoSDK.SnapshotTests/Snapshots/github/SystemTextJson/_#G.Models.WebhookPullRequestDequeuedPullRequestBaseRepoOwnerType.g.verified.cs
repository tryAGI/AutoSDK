//HintName: G.Models.WebhookPullRequestDequeuedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestDequeuedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestBaseRepoOwnerType.Organization => "Organization",
                WebhookPullRequestDequeuedPullRequestBaseRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestBaseRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestDequeuedPullRequestBaseRepoOwnerType.Organization,
                "User" => WebhookPullRequestDequeuedPullRequestBaseRepoOwnerType.User,
                _ => null,
            };
        }
    }
}