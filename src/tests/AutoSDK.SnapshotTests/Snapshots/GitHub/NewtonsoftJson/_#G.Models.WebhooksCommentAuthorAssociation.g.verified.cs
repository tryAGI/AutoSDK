//HintName: G.Models.WebhooksCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksCommentAuthorAssociation
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
    public static class WebhooksCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhooksCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksCommentAuthorAssociation.MEMBER => "MEMBER",
                WebhooksCommentAuthorAssociation.NONE => "NONE",
                WebhooksCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksCommentAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksCommentAuthorAssociation.MEMBER,
                "NONE" => WebhooksCommentAuthorAssociation.NONE,
                "OWNER" => WebhooksCommentAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}