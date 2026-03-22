//HintName: G.Models.WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestUnassignedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.Organization,
                "User" => WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.User,
                _ => null,
            };
        }
    }
}