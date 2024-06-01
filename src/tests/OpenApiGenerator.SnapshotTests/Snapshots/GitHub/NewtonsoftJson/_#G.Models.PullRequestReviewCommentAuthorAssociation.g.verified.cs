//HintName: G.Models.PullRequestReviewCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullRequestReviewCommentAuthorAssociation
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
    public static class PullRequestReviewCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestReviewCommentAuthorAssociation value)
        {
            return value switch
            {
                PullRequestReviewCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                PullRequestReviewCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                PullRequestReviewCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                PullRequestReviewCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                PullRequestReviewCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                PullRequestReviewCommentAuthorAssociation.MEMBER => "MEMBER",
                PullRequestReviewCommentAuthorAssociation.NONE => "NONE",
                PullRequestReviewCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestReviewCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => PullRequestReviewCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => PullRequestReviewCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => PullRequestReviewCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => PullRequestReviewCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => PullRequestReviewCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => PullRequestReviewCommentAuthorAssociation.MEMBER,
                "NONE" => PullRequestReviewCommentAuthorAssociation.NONE,
                "OWNER" => PullRequestReviewCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}