//HintName: G.Models.CommitCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum CommitCommentAuthorAssociation
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
    public static class CommitCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommitCommentAuthorAssociation value)
        {
            return value switch
            {
                CommitCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                CommitCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                CommitCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                CommitCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                CommitCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                CommitCommentAuthorAssociation.MEMBER => "MEMBER",
                CommitCommentAuthorAssociation.NONE => "NONE",
                CommitCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommitCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => CommitCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => CommitCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => CommitCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => CommitCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => CommitCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => CommitCommentAuthorAssociation.MEMBER,
                "NONE" => CommitCommentAuthorAssociation.NONE,
                "OWNER" => CommitCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}