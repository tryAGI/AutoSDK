//HintName: G.Models.WebhooksReviewAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhooksReviewAuthorAssociation
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
    public static class WebhooksReviewAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewAuthorAssociation value)
        {
            return value switch
            {
                WebhooksReviewAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhooksReviewAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhooksReviewAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhooksReviewAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhooksReviewAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhooksReviewAuthorAssociation.MEMBER => "MEMBER",
                WebhooksReviewAuthorAssociation.NONE => "NONE",
                WebhooksReviewAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhooksReviewAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhooksReviewAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhooksReviewAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhooksReviewAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhooksReviewAuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhooksReviewAuthorAssociation.MEMBER,
                "NONE" => WebhooksReviewAuthorAssociation.NONE,
                "OWNER" => WebhooksReviewAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}