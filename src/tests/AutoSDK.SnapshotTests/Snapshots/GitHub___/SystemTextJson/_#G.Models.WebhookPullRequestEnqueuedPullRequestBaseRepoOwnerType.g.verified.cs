//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}