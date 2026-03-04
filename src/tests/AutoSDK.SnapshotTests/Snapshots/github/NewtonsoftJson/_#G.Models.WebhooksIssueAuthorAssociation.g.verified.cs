//HintName: G.Models.WebhooksIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssueAuthorAssociation
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
    public static class WebhooksIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhooksIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksIssueAuthorAssociation.Member => "MEMBER",
                WebhooksIssueAuthorAssociation.None => "NONE",
                WebhooksIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhooksIssueAuthorAssociation.Member,
                "NONE" => WebhooksIssueAuthorAssociation.None,
                "OWNER" => WebhooksIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}