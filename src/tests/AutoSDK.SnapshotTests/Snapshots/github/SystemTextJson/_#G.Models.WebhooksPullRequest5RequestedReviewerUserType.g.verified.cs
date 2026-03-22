//HintName: G.Models.WebhooksPullRequest5RequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5RequestedReviewerUserType
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
    public static class WebhooksPullRequest5RequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedReviewerUserType value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedReviewerUserType.Bot => "Bot",
                WebhooksPullRequest5RequestedReviewerUserType.Organization => "Organization",
                WebhooksPullRequest5RequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5RequestedReviewerUserType.Bot,
                "Organization" => WebhooksPullRequest5RequestedReviewerUserType.Organization,
                "User" => WebhooksPullRequest5RequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}