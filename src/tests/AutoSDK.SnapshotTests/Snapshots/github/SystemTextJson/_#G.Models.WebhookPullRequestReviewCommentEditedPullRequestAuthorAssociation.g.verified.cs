//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewCommentEditedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}