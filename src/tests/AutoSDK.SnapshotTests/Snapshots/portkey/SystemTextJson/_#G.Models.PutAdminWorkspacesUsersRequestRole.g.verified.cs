//HintName: G.Models.PutAdminWorkspacesUsersRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutAdminWorkspacesUsersRequestRole
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
    public static class PutAdminWorkspacesUsersRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutAdminWorkspacesUsersRequestRole value)
        {
            return value switch
            {
                PutAdminWorkspacesUsersRequestRole.Admin => "admin",
                PutAdminWorkspacesUsersRequestRole.Manager => "manager",
                PutAdminWorkspacesUsersRequestRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutAdminWorkspacesUsersRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PutAdminWorkspacesUsersRequestRole.Admin,
                "manager" => PutAdminWorkspacesUsersRequestRole.Manager,
                "member" => PutAdminWorkspacesUsersRequestRole.Member,
                _ => null,
            };
        }
    }
}