//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewRequestedVariant1PullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}