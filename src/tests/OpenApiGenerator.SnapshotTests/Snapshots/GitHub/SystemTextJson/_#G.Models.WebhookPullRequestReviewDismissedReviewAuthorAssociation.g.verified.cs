//HintName: G.Models.WebhookPullRequestReviewDismissedReviewAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestReviewDismissedReviewAuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        NONE,
        /// <summary>
        /// 
        /// </summary>
        OWNER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewDismissedReviewAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedReviewAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.NONE => "NONE",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedReviewAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}