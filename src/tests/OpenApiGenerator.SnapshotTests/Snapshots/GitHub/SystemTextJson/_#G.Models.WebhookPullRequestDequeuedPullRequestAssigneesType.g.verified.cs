//HintName: G.Models.WebhookPullRequestDequeuedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestAssigneesType
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
    public static class WebhookPullRequestDequeuedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestAssigneesType.User => "User",
                WebhookPullRequestDequeuedPullRequestAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestDequeuedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestDequeuedPullRequestAssigneesType.Organization,
                _ => null,
            };
        }
    }
}