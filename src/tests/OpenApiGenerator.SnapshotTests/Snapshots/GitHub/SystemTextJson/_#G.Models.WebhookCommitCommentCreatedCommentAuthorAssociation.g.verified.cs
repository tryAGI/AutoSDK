//HintName: G.Models.WebhookCommitCommentCreatedCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookCommitCommentCreatedCommentAuthorAssociation
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
    public static class WebhookCommitCommentCreatedCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCommitCommentCreatedCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhookCommitCommentCreatedCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookCommitCommentCreatedCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookCommitCommentCreatedCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookCommitCommentCreatedCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookCommitCommentCreatedCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookCommitCommentCreatedCommentAuthorAssociation.MEMBER => "MEMBER",
                WebhookCommitCommentCreatedCommentAuthorAssociation.NONE => "NONE",
                WebhookCommitCommentCreatedCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCommitCommentCreatedCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookCommitCommentCreatedCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookCommitCommentCreatedCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookCommitCommentCreatedCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookCommitCommentCreatedCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookCommitCommentCreatedCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookCommitCommentCreatedCommentAuthorAssociation.MEMBER,
                "NONE" => WebhookCommitCommentCreatedCommentAuthorAssociation.NONE,
                "OWNER" => WebhookCommitCommentCreatedCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}