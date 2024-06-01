//HintName: G.Models.WebhookIssueCommentCreatedCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedCommentAuthorAssociation
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
    public static class WebhookIssueCommentCreatedCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssueCommentCreatedCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssueCommentCreatedCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssueCommentCreatedCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentCreatedCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssueCommentCreatedCommentAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssueCommentCreatedCommentAuthorAssociation.NONE => "NONE",
                WebhookIssueCommentCreatedCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentCreatedCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssueCommentCreatedCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssueCommentCreatedCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentCreatedCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssueCommentCreatedCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssueCommentCreatedCommentAuthorAssociation.MEMBER,
                "NONE" => WebhookIssueCommentCreatedCommentAuthorAssociation.NONE,
                "OWNER" => WebhookIssueCommentCreatedCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}