//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COLLABORATOR")]
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTRIBUTOR")]
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIMER")]
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIME_CONTRIBUTOR")]
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANNEQUIN")]
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        NONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
        OWNER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.NONE => "NONE",
                WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestReviewThreadResolvedThreadCommentsAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}