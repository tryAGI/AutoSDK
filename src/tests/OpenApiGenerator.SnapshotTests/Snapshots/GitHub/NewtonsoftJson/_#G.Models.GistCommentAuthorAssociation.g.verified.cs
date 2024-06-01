//HintName: G.Models.GistCommentAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GistCommentAuthorAssociation
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
    public static class GistCommentAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GistCommentAuthorAssociation value)
        {
            return value switch
            {
                GistCommentAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                GistCommentAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                GistCommentAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                GistCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                GistCommentAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                GistCommentAuthorAssociation.MEMBER => "MEMBER",
                GistCommentAuthorAssociation.NONE => "NONE",
                GistCommentAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GistCommentAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => GistCommentAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => GistCommentAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => GistCommentAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => GistCommentAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => GistCommentAuthorAssociation.MANNEQUIN,
                "MEMBER" => GistCommentAuthorAssociation.MEMBER,
                "NONE" => GistCommentAuthorAssociation.NONE,
                "OWNER" => GistCommentAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}