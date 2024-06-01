//HintName: G.Models.IssueCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssueCommentAuthorAssociation
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
    public static class IssueCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueCommentAuthorAssociation value)
        {
            return value switch
            {
                IssueCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                IssueCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                IssueCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                IssueCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                IssueCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                IssueCommentAuthorAssociation.MEMBER => "MEMBER",
                IssueCommentAuthorAssociation.NONE => "NONE",
                IssueCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => IssueCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => IssueCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => IssueCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => IssueCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => IssueCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => IssueCommentAuthorAssociation.MEMBER,
                "NONE" => IssueCommentAuthorAssociation.NONE,
                "OWNER" => IssueCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}