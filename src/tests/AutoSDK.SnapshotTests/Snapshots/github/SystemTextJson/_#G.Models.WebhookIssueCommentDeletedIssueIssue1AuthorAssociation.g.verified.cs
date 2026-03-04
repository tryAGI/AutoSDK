//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueIssue1AuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        NONE,
        /// <summary>
        /// 
        /// </summary>
        OWNER,
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
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.MEMBER => "MEMBER",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.NONE => "NONE",
                WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.OWNER => "OWNER",
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
                "COLLABORATOR" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.MEMBER,
                "NONE" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.NONE,
                "OWNER" => WebhookIssueCommentDeletedIssueIssue1AuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}