//HintName: G.Models.WebhookIssuesDemilestonedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDemilestonedIssueAuthorAssociation
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
    public static class WebhookIssuesDemilestonedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssuesDemilestonedIssueAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssuesDemilestonedIssueAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssuesDemilestonedIssueAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesDemilestonedIssueAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssuesDemilestonedIssueAuthorAssociation.Member => "MEMBER",
                WebhookIssuesDemilestonedIssueAuthorAssociation.None => "NONE",
                WebhookIssuesDemilestonedIssueAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesDemilestonedIssueAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssuesDemilestonedIssueAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssuesDemilestonedIssueAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesDemilestonedIssueAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssuesDemilestonedIssueAuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssuesDemilestonedIssueAuthorAssociation.Member,
                "NONE" => WebhookIssuesDemilestonedIssueAuthorAssociation.None,
                "OWNER" => WebhookIssuesDemilestonedIssueAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}