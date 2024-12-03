//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.MEMBER => "MEMBER",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.NONE => "NONE",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.MEMBER,
                "NONE" => WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.NONE,
                "OWNER" => WebhookPullRequestReviewThreadUnresolvedPullRequestAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}