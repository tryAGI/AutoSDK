//HintName: G.Models.WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}