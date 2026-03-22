//HintName: G.Models.WebhookPullRequestDequeuedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestBaseUserType
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
    public static class WebhookPullRequestDequeuedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestBaseUserType.Organization => "Organization",
                WebhookPullRequestDequeuedPullRequestBaseUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestBaseUserType.Bot,
                "Organization" => WebhookPullRequestDequeuedPullRequestBaseUserType.Organization,
                "User" => WebhookPullRequestDequeuedPullRequestBaseUserType.User,
                _ => null,
            };
        }
    }
}