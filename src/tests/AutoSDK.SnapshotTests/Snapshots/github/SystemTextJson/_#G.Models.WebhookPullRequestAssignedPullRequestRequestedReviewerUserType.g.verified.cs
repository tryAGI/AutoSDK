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
                WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
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
                "User" => WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestAssignedPullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}