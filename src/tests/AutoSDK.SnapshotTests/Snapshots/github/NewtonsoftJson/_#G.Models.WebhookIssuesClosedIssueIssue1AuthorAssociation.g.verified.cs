//HintName: G.Models.WebhookIssuesClosedIssueIssue1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueIssue1AuthorAssociation
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
    public static class WebhookIssuesClosedIssueIssue1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1AuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.Member => "MEMBER",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.None => "NONE",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesClosedIssueIssue1AuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesClosedIssueIssue1AuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesClosedIssueIssue1AuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesClosedIssueIssue1AuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesClosedIssueIssue1AuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesClosedIssueIssue1AuthorAssociation.Member,
                "NONE" => WebhookIssuesClosedIssueIssue1AuthorAssociation.None,
                "OWNER" => WebhookIssuesClosedIssueIssue1AuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}