//HintName: G.Models.WebhooksPullRequest5HeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5HeadUserType
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
    public static class WebhooksPullRequest5HeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5HeadUserType value)
        {
            return value switch
            {
                WebhooksPullRequest5HeadUserType.Bot => "Bot",
                WebhooksPullRequest5HeadUserType.User => "User",
                WebhooksPullRequest5HeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5HeadUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5HeadUserType.Bot,
                "User" => WebhooksPullRequest5HeadUserType.User,
                "Organization" => WebhooksPullRequest5HeadUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}