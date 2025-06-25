//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}