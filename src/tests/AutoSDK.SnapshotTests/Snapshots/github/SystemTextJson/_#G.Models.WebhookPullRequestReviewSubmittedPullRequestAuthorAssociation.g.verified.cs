//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestReviewSubmittedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewSubmittedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}