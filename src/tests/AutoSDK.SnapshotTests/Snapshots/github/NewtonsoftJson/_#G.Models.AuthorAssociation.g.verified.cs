//HintName: G.Models.AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.<br/>
    /// Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuthorAssociation
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
    public static class AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorAssociation value)
        {
            return value switch
            {
                AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                AuthorAssociation.MEMBER => "MEMBER",
                AuthorAssociation.NONE => "NONE",
                AuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => AuthorAssociation.MANNEQUIN,
                "MEMBER" => AuthorAssociation.MEMBER,
                "NONE" => AuthorAssociation.NONE,
                "OWNER" => AuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}