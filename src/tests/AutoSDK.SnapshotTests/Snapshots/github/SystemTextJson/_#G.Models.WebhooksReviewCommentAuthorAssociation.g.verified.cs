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
        Collaborator,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        FirstTimer,
        /// <summary>
        /// 
        /// </summary>
        FirstTimeContributor,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Owner,
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
                WebhooksReviewCommentAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksReviewCommentAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksReviewCommentAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksReviewCommentAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksReviewCommentAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksReviewCommentAuthorAssociation.Member => "MEMBER",
                WebhooksReviewCommentAuthorAssociation.None => "NONE",
                WebhooksReviewCommentAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewCommentAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksReviewCommentAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksReviewCommentAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksReviewCommentAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksReviewCommentAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksReviewCommentAuthorAssociation.Mannequin,
                "MEMBER" => WebhooksReviewCommentAuthorAssociation.Member,
                "NONE" => WebhooksReviewCommentAuthorAssociation.None,
                "OWNER" => WebhooksReviewCommentAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}