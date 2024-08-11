//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueVariant1AuthorAssociation
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
    public static class WebhookIssueCommentDeletedIssueVariant1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.MEMBER => "MEMBER",
                WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.NONE => "NONE",
                WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.MEMBER,
                "NONE" => WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.NONE,
                "OWNER" => WebhookIssueCommentDeletedIssueVariant1AuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}