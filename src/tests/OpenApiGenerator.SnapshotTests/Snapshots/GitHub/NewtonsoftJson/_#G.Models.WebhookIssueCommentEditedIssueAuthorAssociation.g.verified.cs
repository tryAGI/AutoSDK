//HintName: G.Models.WebhookIssueCommentEditedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueAuthorAssociation
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
    public static class WebhookIssueCommentEditedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssueCommentEditedIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssueCommentEditedIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssueCommentEditedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentEditedIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssueCommentEditedIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssueCommentEditedIssueAuthorAssociation.NONE => "NONE",
                WebhookIssueCommentEditedIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentEditedIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssueCommentEditedIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssueCommentEditedIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentEditedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssueCommentEditedIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssueCommentEditedIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssueCommentEditedIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssueCommentEditedIssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}