//HintName: G.Models.PullRequestReviewAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullRequestReviewAuthorAssociation
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