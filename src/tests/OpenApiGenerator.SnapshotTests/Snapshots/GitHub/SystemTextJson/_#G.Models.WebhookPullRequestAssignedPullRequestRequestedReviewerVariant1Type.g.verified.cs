//HintName: G.Models.WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestAssignedPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}