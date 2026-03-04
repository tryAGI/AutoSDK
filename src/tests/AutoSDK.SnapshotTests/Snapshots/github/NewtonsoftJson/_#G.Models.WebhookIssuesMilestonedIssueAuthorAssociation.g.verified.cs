//HintName: G.Models.WebhookIssuesMilestonedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesMilestonedIssueAuthorAssociation
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
    public static class WebhookIssuesMilestonedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesMilestonedIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesMilestonedIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesMilestonedIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesMilestonedIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesMilestonedIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesMilestonedIssueAuthorAssociation.None => "NONE",
                WebhookIssuesMilestonedIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesMilestonedIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesMilestonedIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesMilestonedIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesMilestonedIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesMilestonedIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesMilestonedIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesMilestonedIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesMilestonedIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}