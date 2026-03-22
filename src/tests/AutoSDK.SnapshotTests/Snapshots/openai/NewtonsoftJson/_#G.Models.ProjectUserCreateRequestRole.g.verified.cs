//HintName: G.Models.ProjectUserCreateRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `member`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectUserCreateRequestRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUserCreateRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUserCreateRequestRole value)
        {
            return value switch
            {
                ProjectUserCreateRequestRole.Member => "member",
                ProjectUserCreateRequestRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUserCreateRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => ProjectUserCreateRequestRole.Member,
                "owner" => ProjectUserCreateRequestRole.Owner,
                _ => null,
            };
        }
    }
}