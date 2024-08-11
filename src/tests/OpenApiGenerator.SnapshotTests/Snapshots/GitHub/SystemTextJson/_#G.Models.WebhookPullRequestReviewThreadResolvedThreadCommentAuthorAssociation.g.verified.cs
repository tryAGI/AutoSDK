//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation
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
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.NONE => "NONE",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}