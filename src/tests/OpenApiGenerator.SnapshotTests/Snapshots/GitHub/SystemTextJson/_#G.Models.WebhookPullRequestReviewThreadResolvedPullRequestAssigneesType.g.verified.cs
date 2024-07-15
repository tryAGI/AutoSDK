//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestAssigneesType
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewThreadResolvedPullRequestAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestAssigneesType.Organization,
                _ => null,
            };
        }
    }
}