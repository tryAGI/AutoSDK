//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewThreadResolvedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}