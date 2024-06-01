//HintName: G.Models.PullRequestSimpleAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum PullRequestSimpleAuthorAssociation
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
    public static class PullRequestSimpleAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestSimpleAuthorAssociation value)
        {
            return value switch
            {
                PullRequestSimpleAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                PullRequestSimpleAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                PullRequestSimpleAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                PullRequestSimpleAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                PullRequestSimpleAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                PullRequestSimpleAuthorAssociation.MEMBER => "MEMBER",
                PullRequestSimpleAuthorAssociation.NONE => "NONE",
                PullRequestSimpleAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestSimpleAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => PullRequestSimpleAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => PullRequestSimpleAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => PullRequestSimpleAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => PullRequestSimpleAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => PullRequestSimpleAuthorAssociation.MANNEQUIN,
                "MEMBER" => PullRequestSimpleAuthorAssociation.MEMBER,
                "NONE" => PullRequestSimpleAuthorAssociation.NONE,
                "OWNER" => PullRequestSimpleAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}