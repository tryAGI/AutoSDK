//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}