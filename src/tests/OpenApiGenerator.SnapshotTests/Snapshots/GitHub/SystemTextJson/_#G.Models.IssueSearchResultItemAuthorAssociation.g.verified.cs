//HintName: G.Models.IssueSearchResultItemAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum IssueSearchResultItemAuthorAssociation
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
    public static class IssueSearchResultItemAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueSearchResultItemAuthorAssociation value)
        {
            return value switch
            {
                IssueSearchResultItemAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                IssueSearchResultItemAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                IssueSearchResultItemAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                IssueSearchResultItemAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                IssueSearchResultItemAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                IssueSearchResultItemAuthorAssociation.MEMBER => "MEMBER",
                IssueSearchResultItemAuthorAssociation.NONE => "NONE",
                IssueSearchResultItemAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueSearchResultItemAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => IssueSearchResultItemAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => IssueSearchResultItemAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => IssueSearchResultItemAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => IssueSearchResultItemAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => IssueSearchResultItemAuthorAssociation.MANNEQUIN,
                "MEMBER" => IssueSearchResultItemAuthorAssociation.MEMBER,
                "NONE" => IssueSearchResultItemAuthorAssociation.NONE,
                "OWNER" => IssueSearchResultItemAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}