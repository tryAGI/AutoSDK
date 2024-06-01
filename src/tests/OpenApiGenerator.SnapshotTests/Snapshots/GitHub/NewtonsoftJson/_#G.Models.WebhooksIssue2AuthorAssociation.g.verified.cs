//HintName: G.Models.WebhooksIssue2AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssue2AuthorAssociation
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
    public static class WebhooksIssue2AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2AuthorAssociation value)
        {
            return value switch
            {
                WebhooksIssue2AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksIssue2AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksIssue2AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksIssue2AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksIssue2AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksIssue2AuthorAssociation.MEMBER => "MEMBER",
                WebhooksIssue2AuthorAssociation.NONE => "NONE",
                WebhooksIssue2AuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2AuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksIssue2AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksIssue2AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksIssue2AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksIssue2AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksIssue2AuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksIssue2AuthorAssociation.MEMBER,
                "NONE" => WebhooksIssue2AuthorAssociation.NONE,
                "OWNER" => WebhooksIssue2AuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}