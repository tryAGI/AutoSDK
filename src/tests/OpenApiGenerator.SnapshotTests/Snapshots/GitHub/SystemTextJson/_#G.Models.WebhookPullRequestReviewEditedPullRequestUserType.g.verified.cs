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
                WebhookPullRequestReviewEditedPullRequestUserType.User => "User",
                WebhookPullRequestReviewEditedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewEditedPullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewEditedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewEditedPullRequestUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}