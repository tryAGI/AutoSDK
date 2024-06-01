//HintName: G.Models.WebhookIssuesDeletedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDeletedIssueAuthorAssociation
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
    public static class WebhookIssuesDeletedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesDeletedIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesDeletedIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesDeletedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesDeletedIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesDeletedIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesDeletedIssueAuthorAssociation.NONE => "NONE",
                WebhookIssuesDeletedIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesDeletedIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesDeletedIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesDeletedIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesDeletedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesDeletedIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesDeletedIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesDeletedIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssuesDeletedIssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}