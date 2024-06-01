//HintName: G.Models.ReviewCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReviewCommentAuthorAssociation
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
    public static class ReviewCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewCommentAuthorAssociation value)
        {
            return value switch
            {
                ReviewCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                ReviewCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                ReviewCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                ReviewCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                ReviewCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                ReviewCommentAuthorAssociation.MEMBER => "MEMBER",
                ReviewCommentAuthorAssociation.NONE => "NONE",
                ReviewCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => ReviewCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => ReviewCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => ReviewCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => ReviewCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => ReviewCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => ReviewCommentAuthorAssociation.MEMBER,
                "NONE" => ReviewCommentAuthorAssociation.NONE,
                "OWNER" => ReviewCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}