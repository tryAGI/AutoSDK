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
    public static class WebhookPullRequestReviewCommentCreatedCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}