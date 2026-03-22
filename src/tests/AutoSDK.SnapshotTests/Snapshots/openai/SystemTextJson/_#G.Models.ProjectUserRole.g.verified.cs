//HintName: G.Models.ProjectUserRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `member`
    /// </summary>
    public enum ProjectUserRole
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
    public static class ProjectUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUserRole value)
        {
            return value switch
            {
                ProjectUserRole.Member => "member",
                ProjectUserRole.Owner => "owner",
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
                "member" => ProjectUserRole.Member,
                "owner" => ProjectUserRole.Owner,
                _ => null,
            };
        }
    }
}