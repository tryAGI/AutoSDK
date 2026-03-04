//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestReviewEditedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewEditedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewEditedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewEditedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewEditedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewEditedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewEditedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewEditedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewEditedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewEditedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewEditedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewEditedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewEditedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewEditedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewEditedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewEditedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}