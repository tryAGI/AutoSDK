//HintName: G.Models.CreateAdminWorkspacesUsersRequestUserRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: member
    /// </summary>
    public enum CreateAdminWorkspacesUsersRequestUserRole
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
    public static class CreateAdminWorkspacesUsersRequestUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAdminWorkspacesUsersRequestUserRole value)
        {
            return value switch
            {
                CreateAdminWorkspacesUsersRequestUserRole.Admin => "admin",
                CreateAdminWorkspacesUsersRequestUserRole.Manager => "manager",
                CreateAdminWorkspacesUsersRequestUserRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAdminWorkspacesUsersRequestUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateAdminWorkspacesUsersRequestUserRole.Admin,
                "manager" => CreateAdminWorkspacesUsersRequestUserRole.Manager,
                "member" => CreateAdminWorkspacesUsersRequestUserRole.Member,
                _ => null,
            };
        }
    }
}