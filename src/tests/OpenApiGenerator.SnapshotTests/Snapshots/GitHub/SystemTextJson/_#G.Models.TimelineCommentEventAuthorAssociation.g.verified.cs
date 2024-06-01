//HintName: G.Models.TimelineCommentEventAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum TimelineCommentEventAuthorAssociation
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
    public static class TimelineCommentEventAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimelineCommentEventAuthorAssociation value)
        {
            return value switch
            {
                TimelineCommentEventAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                TimelineCommentEventAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                TimelineCommentEventAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                TimelineCommentEventAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                TimelineCommentEventAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                TimelineCommentEventAuthorAssociation.MEMBER => "MEMBER",
                TimelineCommentEventAuthorAssociation.NONE => "NONE",
                TimelineCommentEventAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimelineCommentEventAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => TimelineCommentEventAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => TimelineCommentEventAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => TimelineCommentEventAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => TimelineCommentEventAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => TimelineCommentEventAuthorAssociation.MANNEQUIN,
                "MEMBER" => TimelineCommentEventAuthorAssociation.MEMBER,
                "NONE" => TimelineCommentEventAuthorAssociation.NONE,
                "OWNER" => TimelineCommentEventAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}