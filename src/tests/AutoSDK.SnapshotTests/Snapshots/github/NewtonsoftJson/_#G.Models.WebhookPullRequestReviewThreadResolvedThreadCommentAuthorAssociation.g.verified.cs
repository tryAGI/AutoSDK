//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentAuthorAssociation
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