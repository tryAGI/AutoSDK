//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueIssue1AuthorAssociation
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
    public static class WebhookIssueCommentDeletedIssueIssue1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.Member => "MEMBER",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.None => "NONE",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.Member,
                "NONE" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.None,
                "OWNER" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}