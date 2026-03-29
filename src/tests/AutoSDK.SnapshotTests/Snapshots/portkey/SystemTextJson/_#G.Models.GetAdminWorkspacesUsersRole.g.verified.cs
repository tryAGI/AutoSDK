//HintName: G.Models.GetAdminWorkspacesUsersRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAdminWorkspacesUsersRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Manager,
        /// <summary>
        /// 
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAdminWorkspacesUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAdminWorkspacesUsersRole value)
        {
            return value switch
            {
                GetAdminWorkspacesUsersRole.Admin => "admin",
                GetAdminWorkspacesUsersRole.Manager => "manager",
                GetAdminWorkspacesUsersRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAdminWorkspacesUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetAdminWorkspacesUsersRole.Admin,
                "manager" => GetAdminWorkspacesUsersRole.Manager,
                "member" => GetAdminWorkspacesUsersRole.Member,
                _ => null,
            };
        }
    }
}