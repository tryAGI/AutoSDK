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
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.Owner => "OWNER",
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
                "COLLABORATOR" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}