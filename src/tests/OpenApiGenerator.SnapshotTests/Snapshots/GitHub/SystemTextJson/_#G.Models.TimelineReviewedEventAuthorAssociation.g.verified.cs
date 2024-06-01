//HintName: G.Models.TimelineReviewedEventAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    public enum TimelineReviewedEventAuthorAssociation
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
    public static class TimelineReviewedEventAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimelineReviewedEventAuthorAssociation value)
        {
            return value switch
            {
                TimelineReviewedEventAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                TimelineReviewedEventAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                TimelineReviewedEventAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                TimelineReviewedEventAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                TimelineReviewedEventAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                TimelineReviewedEventAuthorAssociation.MEMBER => "MEMBER",
                TimelineReviewedEventAuthorAssociation.NONE => "NONE",
                TimelineReviewedEventAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimelineReviewedEventAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => TimelineReviewedEventAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => TimelineReviewedEventAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => TimelineReviewedEventAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => TimelineReviewedEventAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => TimelineReviewedEventAuthorAssociation.MANNEQUIN,
                "MEMBER" => TimelineReviewedEventAuthorAssociation.MEMBER,
                "NONE" => TimelineReviewedEventAuthorAssociation.NONE,
                "OWNER" => TimelineReviewedEventAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}