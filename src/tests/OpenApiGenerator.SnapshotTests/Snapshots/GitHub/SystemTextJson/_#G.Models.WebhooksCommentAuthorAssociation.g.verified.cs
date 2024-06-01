//HintName: G.Models.WebhooksCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhooksCommentAuthorAssociation
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
    public static class WebhooksCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksCommentAuthorAssociation value)
        {
            return value switch
            {
                WebhooksCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksCommentAuthorAssociation.MEMBER => "MEMBER",
                WebhooksCommentAuthorAssociation.NONE => "NONE",
                WebhooksCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksCommentAuthorAssociation.MEMBER,
                "NONE" => WebhooksCommentAuthorAssociation.NONE,
                "OWNER" => WebhooksCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}