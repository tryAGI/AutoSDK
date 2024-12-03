//HintName: G.Models.ProjectUserCreateRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `member`
    /// </summary>
    public enum ProjectUserCreateRequestRole
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
    public static class ProjectUserCreateRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUserCreateRequestRole value)
        {
            return value switch
            {
                ProjectUserCreateRequestRole.Owner => "owner",
                ProjectUserCreateRequestRole.Member => "member",
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
                "owner" => ProjectUserCreateRequestRole.Owner,
                "member" => ProjectUserCreateRequestRole.Member,
                _ => null,
            };
        }
    }
}