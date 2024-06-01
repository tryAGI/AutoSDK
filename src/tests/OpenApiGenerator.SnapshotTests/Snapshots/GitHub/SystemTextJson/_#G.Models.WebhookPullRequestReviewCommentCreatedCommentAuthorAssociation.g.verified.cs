//HintName: G.Models.WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation
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
    public static class WebhookPullRequestReviewCommentCreatedCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.NONE => "NONE",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}