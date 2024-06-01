//HintName: G.Models.PullRequestSimpleAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullRequestSimpleAuthorAssociation
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
    public static class PullRequestSimpleAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestSimpleAuthorAssociation value)
        {
            return value switch
            {
                PullRequestSimpleAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                PullRequestSimpleAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                PullRequestSimpleAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                PullRequestSimpleAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                PullRequestSimpleAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                PullRequestSimpleAuthorAssociation.MEMBER => "MEMBER",
                PullRequestSimpleAuthorAssociation.NONE => "NONE",
                PullRequestSimpleAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestSimpleAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => PullRequestSimpleAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => PullRequestSimpleAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => PullRequestSimpleAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => PullRequestSimpleAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => PullRequestSimpleAuthorAssociation.MANNEQUIN,
                "MEMBER" => PullRequestSimpleAuthorAssociation.MEMBER,
                "NONE" => PullRequestSimpleAuthorAssociation.NONE,
                "OWNER" => PullRequestSimpleAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}