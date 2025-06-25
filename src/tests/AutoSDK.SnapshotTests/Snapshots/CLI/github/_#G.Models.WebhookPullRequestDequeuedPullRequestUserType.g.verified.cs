//HintName: G.Models.WebhookPullRequestDequeuedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestUserType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestDequeuedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestUserType.User => "User",
                WebhookPullRequestDequeuedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestDequeuedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestUserType.Bot,
                "User" => WebhookPullRequestDequeuedPullRequestUserType.User,
                "Organization" => WebhookPullRequestDequeuedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestDequeuedPullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}