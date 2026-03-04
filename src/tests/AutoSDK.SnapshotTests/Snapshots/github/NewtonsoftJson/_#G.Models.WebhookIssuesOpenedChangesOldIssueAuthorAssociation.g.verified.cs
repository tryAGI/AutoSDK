//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedChangesOldIssueAuthorAssociation
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
    public static class WebhookIssuesOpenedChangesOldIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.None => "NONE",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}