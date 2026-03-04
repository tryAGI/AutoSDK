//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}