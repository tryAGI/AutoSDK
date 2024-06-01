//HintName: G.Models.WebhookIssueCommentDeletedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueAuthorAssociation
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
    public static class WebhookIssueCommentDeletedIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueAuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssueCommentDeletedIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssueCommentDeletedIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssueCommentDeletedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentDeletedIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssueCommentDeletedIssueAuthorAssociation.MEMBER => "MEMBER",
                WebhookIssueCommentDeletedIssueAuthorAssociation.NONE => "NONE",
                WebhookIssueCommentDeletedIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentDeletedIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssueCommentDeletedIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssueCommentDeletedIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentDeletedIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssueCommentDeletedIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssueCommentDeletedIssueAuthorAssociation.MEMBER,
                "NONE" => WebhookIssueCommentDeletedIssueAuthorAssociation.NONE,
                "OWNER" => WebhookIssueCommentDeletedIssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}