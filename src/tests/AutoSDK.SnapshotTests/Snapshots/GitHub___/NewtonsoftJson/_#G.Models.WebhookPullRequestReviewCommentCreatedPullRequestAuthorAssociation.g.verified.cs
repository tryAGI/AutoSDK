//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.NONE => "NONE",
                WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestReviewCommentCreatedPullRequestAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}