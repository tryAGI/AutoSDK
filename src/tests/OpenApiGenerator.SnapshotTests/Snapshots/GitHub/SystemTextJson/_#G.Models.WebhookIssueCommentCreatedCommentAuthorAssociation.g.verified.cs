//HintName: G.Models.WebhookIssueCommentCreatedCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentCreatedCommentAuthorAssociation
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