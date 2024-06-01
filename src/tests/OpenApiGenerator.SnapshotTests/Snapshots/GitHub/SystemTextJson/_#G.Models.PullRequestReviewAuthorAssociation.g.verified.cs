//HintName: G.Models.PullRequestReviewAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum PullRequestReviewAuthorAssociation
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
    public static class PullRequestReviewAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestReviewAuthorAssociation value)
        {
            return value switch
            {
                PullRequestReviewAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                PullRequestReviewAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                PullRequestReviewAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                PullRequestReviewAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                PullRequestReviewAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                PullRequestReviewAuthorAssociation.MEMBER => "MEMBER",
                PullRequestReviewAuthorAssociation.NONE => "NONE",
                PullRequestReviewAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestReviewAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => PullRequestReviewAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => PullRequestReviewAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => PullRequestReviewAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => PullRequestReviewAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => PullRequestReviewAuthorAssociation.MANNEQUIN,
                "MEMBER" => PullRequestReviewAuthorAssociation.MEMBER,
                "NONE" => PullRequestReviewAuthorAssociation.NONE,
                "OWNER" => PullRequestReviewAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}