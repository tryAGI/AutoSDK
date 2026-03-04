//HintName: G.Models.WebhookPullRequestReviewDismissedReviewAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewDismissedReviewAuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COLLABORATOR")]
        Collaborator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTRIBUTOR")]
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIMER")]
        FirstTimer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIME_CONTRIBUTOR")]
        FirstTimeContributor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANNEQUIN")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewDismissedReviewAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedReviewAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewDismissedReviewAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedReviewAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewDismissedReviewAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}