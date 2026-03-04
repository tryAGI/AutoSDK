//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}