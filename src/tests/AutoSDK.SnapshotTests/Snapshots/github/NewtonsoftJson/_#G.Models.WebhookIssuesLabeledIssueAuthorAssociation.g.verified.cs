//HintName: G.Models.WebhookIssuesLabeledIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLabeledIssueAuthorAssociation
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
    public static class WebhookIssuesLabeledIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesLabeledIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesLabeledIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesLabeledIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesLabeledIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesLabeledIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesLabeledIssueAuthorAssociation.None => "NONE",
                WebhookIssuesLabeledIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesLabeledIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesLabeledIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesLabeledIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesLabeledIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesLabeledIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesLabeledIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesLabeledIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesLabeledIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}