//HintName: G.Models.PullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum PullRequestAuthorAssociation
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
    public static class PullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestAuthorAssociation value)
        {
            return value switch
            {
                PullRequestAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                PullRequestAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                PullRequestAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                PullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                PullRequestAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                PullRequestAuthorAssociation.MEMBER => "MEMBER",
                PullRequestAuthorAssociation.NONE => "NONE",
                PullRequestAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => PullRequestAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => PullRequestAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => PullRequestAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => PullRequestAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => PullRequestAuthorAssociation.MANNEQUIN,
                "MEMBER" => PullRequestAuthorAssociation.MEMBER,
                "NONE" => PullRequestAuthorAssociation.NONE,
                "OWNER" => PullRequestAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}