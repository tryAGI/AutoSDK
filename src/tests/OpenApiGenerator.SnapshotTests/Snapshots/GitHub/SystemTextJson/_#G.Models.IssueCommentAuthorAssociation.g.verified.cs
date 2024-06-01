//HintName: G.Models.IssueCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum IssueCommentAuthorAssociation
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
    public static class IssueCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueCommentAuthorAssociation value)
        {
            return value switch
            {
                IssueCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                IssueCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                IssueCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                IssueCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                IssueCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                IssueCommentAuthorAssociation.MEMBER => "MEMBER",
                IssueCommentAuthorAssociation.NONE => "NONE",
                IssueCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => IssueCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => IssueCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => IssueCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => IssueCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => IssueCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => IssueCommentAuthorAssociation.MEMBER,
                "NONE" => IssueCommentAuthorAssociation.NONE,
                "OWNER" => IssueCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}