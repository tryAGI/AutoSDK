//HintName: G.Models.ProjectUserUpdateRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `member`
    /// </summary>
    public enum ProjectUserUpdateRequestRole
    {
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUserUpdateRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUserUpdateRequestRole value)
        {
            return value switch
            {
                ProjectUserUpdateRequestRole.Member => "member",
                ProjectUserUpdateRequestRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUserUpdateRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => ProjectUserUpdateRequestRole.Member,
                "owner" => ProjectUserUpdateRequestRole.Owner,
                _ => null,
            };
        }
    }
}