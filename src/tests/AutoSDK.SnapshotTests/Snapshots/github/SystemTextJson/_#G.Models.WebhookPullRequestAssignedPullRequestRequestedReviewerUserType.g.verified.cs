//HintName: G.Models.WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestAssignedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.Bot,
                "Mannequin" => WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}