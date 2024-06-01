//HintName: G.Models.NullableIssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum NullableIssueAuthorAssociation
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
    public static class NullableIssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableIssueAuthorAssociation value)
        {
            return value switch
            {
                NullableIssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                NullableIssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                NullableIssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                NullableIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                NullableIssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                NullableIssueAuthorAssociation.MEMBER => "MEMBER",
                NullableIssueAuthorAssociation.NONE => "NONE",
                NullableIssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableIssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => NullableIssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => NullableIssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => NullableIssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => NullableIssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => NullableIssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => NullableIssueAuthorAssociation.MEMBER,
                "NONE" => NullableIssueAuthorAssociation.NONE,
                "OWNER" => NullableIssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}