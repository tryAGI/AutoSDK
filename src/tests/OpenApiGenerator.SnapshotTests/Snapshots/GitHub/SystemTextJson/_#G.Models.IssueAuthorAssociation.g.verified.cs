//HintName: G.Models.IssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum IssueAuthorAssociation
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
    public static class IssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueAuthorAssociation value)
        {
            return value switch
            {
                IssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                IssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                IssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                IssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                IssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                IssueAuthorAssociation.MEMBER => "MEMBER",
                IssueAuthorAssociation.NONE => "NONE",
                IssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => IssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => IssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => IssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => IssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => IssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => IssueAuthorAssociation.MEMBER,
                "NONE" => IssueAuthorAssociation.NONE,
                "OWNER" => IssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}