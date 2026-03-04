//HintName: G.Models.WebhookIssuesUnlockedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesUnlockedIssueAuthorAssociation
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
    public static class WebhookIssuesUnlockedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesUnlockedIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesUnlockedIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesUnlockedIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesUnlockedIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesUnlockedIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesUnlockedIssueAuthorAssociation.None => "NONE",
                WebhookIssuesUnlockedIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesUnlockedIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesUnlockedIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesUnlockedIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesUnlockedIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesUnlockedIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesUnlockedIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesUnlockedIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesUnlockedIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}