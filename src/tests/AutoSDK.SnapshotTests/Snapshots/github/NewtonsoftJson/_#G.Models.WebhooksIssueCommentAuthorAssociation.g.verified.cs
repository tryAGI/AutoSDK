//HintName: G.Models.WebhooksIssueCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssueCommentAuthorAssociation
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
    public static class WebhooksIssueCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhooksIssueCommentAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhooksIssueCommentAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhooksIssueCommentAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhooksIssueCommentAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhooksIssueCommentAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhooksIssueCommentAuthorAssociation.Member => "MEMBER",
                WebhooksIssueCommentAuthorAssociation.None => "NONE",
                WebhooksIssueCommentAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueCommentAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksIssueCommentAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhooksIssueCommentAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhooksIssueCommentAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksIssueCommentAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhooksIssueCommentAuthorAssociation.Mannequin,
                "MEMBER" => WebhooksIssueCommentAuthorAssociation.Member,
                "NONE" => WebhooksIssueCommentAuthorAssociation.None,
                "OWNER" => WebhooksIssueCommentAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}