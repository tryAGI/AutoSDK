//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation
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
    public static class WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.None => "NONE",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.Member,
                "NONE" => WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.None,
                "OWNER" => WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}