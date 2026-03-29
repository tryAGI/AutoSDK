//HintName: G.Models.WorkspaceRoleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkspaceRoleType
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
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
    public static class WorkspaceRoleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceRoleType value)
        {
            return value switch
            {
                WorkspaceRoleType.Admin => "admin",
                WorkspaceRoleType.Member => "member",
                WorkspaceRoleType.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceRoleType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => WorkspaceRoleType.Admin,
                "member" => WorkspaceRoleType.Member,
                "owner" => WorkspaceRoleType.Owner,
                _ => null,
            };
        }
    }
}