//HintName: G.Models.WebhooksReviewCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhooksReviewCommentAuthorAssociation
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
    public static class WebhooksReviewCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhooksReviewCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksReviewCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksReviewCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksReviewCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksReviewCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksReviewCommentAuthorAssociation.MEMBER => "MEMBER",
                WebhooksReviewCommentAuthorAssociation.NONE => "NONE",
                WebhooksReviewCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksReviewCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksReviewCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksReviewCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksReviewCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksReviewCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksReviewCommentAuthorAssociation.MEMBER,
                "NONE" => WebhooksReviewCommentAuthorAssociation.NONE,
                "OWNER" => WebhooksReviewCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}