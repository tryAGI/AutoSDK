//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestAssigneesType
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
    public static class WebhookPullRequestReviewEditedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewEditedPullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewEditedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewEditedPullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestReviewEditedPullRequestAssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}