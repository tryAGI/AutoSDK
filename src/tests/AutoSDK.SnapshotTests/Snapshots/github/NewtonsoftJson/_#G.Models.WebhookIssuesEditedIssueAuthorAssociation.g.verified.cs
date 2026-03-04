//HintName: G.Models.WebhookIssuesEditedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesEditedIssueAuthorAssociation
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
    public static class WebhookIssuesEditedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesEditedIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesEditedIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesEditedIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesEditedIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesEditedIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesEditedIssueAuthorAssociation.None => "NONE",
                WebhookIssuesEditedIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesEditedIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesEditedIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesEditedIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesEditedIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesEditedIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesEditedIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesEditedIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesEditedIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}