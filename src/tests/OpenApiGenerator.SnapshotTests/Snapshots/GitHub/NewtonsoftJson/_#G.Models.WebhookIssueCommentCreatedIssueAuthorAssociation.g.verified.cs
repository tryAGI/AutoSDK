//HintName: G.Models.WebhookIssueCommentCreatedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueAuthorAssociation
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
    public static class WebhookIssueCommentCreatedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssueCommentCreatedIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssueCommentCreatedIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssueCommentCreatedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentCreatedIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssueCommentCreatedIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssueCommentCreatedIssueAuthorAssociation.NONE => "NONE",
                WebhookIssueCommentCreatedIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentCreatedIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssueCommentCreatedIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssueCommentCreatedIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentCreatedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssueCommentCreatedIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssueCommentCreatedIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssueCommentCreatedIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssueCommentCreatedIssueAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}