//HintName: G.Models.ReviewCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum ReviewCommentAuthorAssociation
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
    public static class ReviewCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewCommentAuthorAssociation value)
        {
            return value switch
            {
                ReviewCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                ReviewCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                ReviewCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                ReviewCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                ReviewCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                ReviewCommentAuthorAssociation.MEMBER => "MEMBER",
                ReviewCommentAuthorAssociation.NONE => "NONE",
                ReviewCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => ReviewCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => ReviewCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => ReviewCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => ReviewCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => ReviewCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => ReviewCommentAuthorAssociation.MEMBER,
                "NONE" => ReviewCommentAuthorAssociation.NONE,
                "OWNER" => ReviewCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}