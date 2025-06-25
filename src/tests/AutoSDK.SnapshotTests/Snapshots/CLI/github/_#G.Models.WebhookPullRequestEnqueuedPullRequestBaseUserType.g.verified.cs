//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestBaseUserType
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
    public static class WebhookPullRequestEnqueuedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestBaseUserType.User => "User",
                WebhookPullRequestEnqueuedPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestEnqueuedPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}