//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
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
    public static class WebhookPullRequestReviewEditedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewEditedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestReviewEditedPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewEditedPullRequestUserType.Organization,
                "User" => WebhookPullRequestReviewEditedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}