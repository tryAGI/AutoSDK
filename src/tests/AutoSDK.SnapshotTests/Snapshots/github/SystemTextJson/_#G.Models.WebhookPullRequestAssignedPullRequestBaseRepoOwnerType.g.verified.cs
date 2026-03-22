//HintName: G.Models.WebhookPullRequestAssignedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestAssignedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestBaseRepoOwnerType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestBaseRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestBaseRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestAssignedPullRequestBaseRepoOwnerType.Organization,
                "User" => WebhookPullRequestAssignedPullRequestBaseRepoOwnerType.User,
                _ => null,
            };
        }
    }
}