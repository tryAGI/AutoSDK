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
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTRIBUTOR")]
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIMER")]
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIME_CONTRIBUTOR")]
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANNEQUIN")]
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        NONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
        OWNER,
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
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.NONE => "NONE",
                WebhookIssuesOpenedChangesOldIssueAuthorAssociation.OWNER => "OWNER",
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
                "COLLABORATOR" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssuesOpenedChangesOldIssueAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}