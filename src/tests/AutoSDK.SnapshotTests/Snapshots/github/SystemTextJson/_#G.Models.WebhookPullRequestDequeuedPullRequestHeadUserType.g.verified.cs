//HintName: G.Models.WebhookPullRequestDequeuedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestHeadUserType
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
    public static class WebhookPullRequestDequeuedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestHeadUserType.Organization => "Organization",
                WebhookPullRequestDequeuedPullRequestHeadUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestHeadUserType.Bot,
                "Organization" => WebhookPullRequestDequeuedPullRequestHeadUserType.Organization,
                "User" => WebhookPullRequestDequeuedPullRequestHeadUserType.User,
                _ => null,
            };
        }
    }
}