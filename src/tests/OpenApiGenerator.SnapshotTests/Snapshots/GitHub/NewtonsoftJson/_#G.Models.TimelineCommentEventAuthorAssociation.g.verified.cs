//HintName: G.Models.TimelineCommentEventAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TimelineCommentEventAuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COLLABORATOR")]
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTRIBUTOR")]
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIMER")]
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIME_CONTRIBUTOR")]
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANNEQUIN")]
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        NONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
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