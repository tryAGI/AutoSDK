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
    public static class WebhooksCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhooksCommentAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksCommentAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksCommentAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksCommentAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksCommentAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksCommentAuthorAssociation.Member => "MEMBER",
                WebhooksCommentAuthorAssociation.None => "NONE",
                WebhooksCommentAuthorAssociation.Owner => "OWNER",
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
                "COLLABORATOR" => WebhooksCommentAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksCommentAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksCommentAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksCommentAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksCommentAuthorAssociation.Mannequin,
                "MEMBER" => WebhooksCommentAuthorAssociation.Member,
                "NONE" => WebhooksCommentAuthorAssociation.None,
                "OWNER" => WebhooksCommentAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}