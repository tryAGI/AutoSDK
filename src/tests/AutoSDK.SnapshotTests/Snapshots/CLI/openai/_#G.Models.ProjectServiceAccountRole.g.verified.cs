//HintName: G.Models.ProjectServiceAccountRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `member`
    /// </summary>
    public enum ProjectServiceAccountRole
    {
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectServiceAccountRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectServiceAccountRole value)
        {
            return value switch
            {
                ProjectServiceAccountRole.Owner => "owner",
                ProjectServiceAccountRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectServiceAccountRole? ToEnum(string value)
        {
            return value switch
            {
                "owner" => ProjectServiceAccountRole.Owner,
                "member" => ProjectServiceAccountRole.Member,
                _ => null,
            };
        }
    }
}