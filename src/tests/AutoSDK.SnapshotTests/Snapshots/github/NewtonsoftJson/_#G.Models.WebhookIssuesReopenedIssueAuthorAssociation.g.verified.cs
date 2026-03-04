//HintName: G.Models.WebhookIssuesReopenedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesReopenedIssueAuthorAssociation
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
    public static class WebhookIssuesReopenedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesReopenedIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesReopenedIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesReopenedIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesReopenedIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesReopenedIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesReopenedIssueAuthorAssociation.None => "NONE",
                WebhookIssuesReopenedIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesReopenedIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesReopenedIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesReopenedIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesReopenedIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesReopenedIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesReopenedIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesReopenedIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesReopenedIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}