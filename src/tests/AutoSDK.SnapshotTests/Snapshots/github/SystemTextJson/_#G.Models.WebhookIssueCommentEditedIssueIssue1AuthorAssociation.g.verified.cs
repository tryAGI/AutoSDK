//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentEditedIssueIssue1AuthorAssociation
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
    public static class WebhookIssueCommentEditedIssueIssue1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.MEMBER => "MEMBER",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.NONE => "NONE",
                WebhookIssueCommentEditedIssueIssue1AuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.MEMBER,
                "NONE" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.NONE,
                "OWNER" => WebhookIssueCommentEditedIssueIssue1AuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}