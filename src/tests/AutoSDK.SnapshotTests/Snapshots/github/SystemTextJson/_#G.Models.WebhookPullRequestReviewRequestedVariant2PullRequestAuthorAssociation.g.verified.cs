//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewRequestedVariant2PullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}