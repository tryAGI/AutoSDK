//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.Organization => "Organization",
                WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.Organization,
                "User" => WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.User,
                _ => null,
            };
        }
    }
}