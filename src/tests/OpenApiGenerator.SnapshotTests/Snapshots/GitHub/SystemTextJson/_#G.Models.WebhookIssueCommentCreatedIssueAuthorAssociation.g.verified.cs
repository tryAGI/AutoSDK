//HintName: G.Models.WebhookIssueCommentCreatedIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueAuthorAssociation
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
        public static WebhookIssueCommentCreatedIssueAuthorAssociation ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}