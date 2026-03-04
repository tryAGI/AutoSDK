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
    public static class WebhooksReviewAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewAuthorAssociation value)
        {
            return value switch
            {
                WebhooksReviewAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksReviewAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksReviewAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksReviewAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksReviewAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksReviewAuthorAssociation.Member => "MEMBER",
                WebhooksReviewAuthorAssociation.None => "NONE",
                WebhooksReviewAuthorAssociation.Owner => "OWNER",
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
                "COLLABORATOR" => WebhooksReviewAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksReviewAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksReviewAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksReviewAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksReviewAuthorAssociation.Mannequin,
                "MEMBER" => WebhooksReviewAuthorAssociation.Member,
                "NONE" => WebhooksReviewAuthorAssociation.None,
                "OWNER" => WebhooksReviewAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}