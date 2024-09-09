//HintName: G.Models.WebhooksReviewAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksReviewAuthorAssociation
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
    public static class WebhooksReviewAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewAuthorAssociation value)
        {
            return value switch
            {
                WebhooksReviewAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksReviewAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksReviewAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksReviewAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksReviewAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksReviewAuthorAssociation.MEMBER => "MEMBER",
                WebhooksReviewAuthorAssociation.NONE => "NONE",
                WebhooksReviewAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksReviewAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksReviewAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksReviewAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksReviewAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksReviewAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksReviewAuthorAssociation.MEMBER,
                "NONE" => WebhooksReviewAuthorAssociation.NONE,
                "OWNER" => WebhooksReviewAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}