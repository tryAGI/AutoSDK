//HintName: G.Models.ProjectUserRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `member`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectUserRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUserRole value)
        {
            return value switch
            {
                ProjectUserRole.Owner => "owner",
                ProjectUserRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUserRole? ToEnum(string value)
        {
            return value switch
            {
                "owner" => ProjectUserRole.Owner,
                "member" => ProjectUserRole.Member,
                _ => null,
            };
        }
    }
}