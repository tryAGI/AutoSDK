//HintName: G.Models.PutAdminUsersRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutAdminUsersRequestRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutAdminUsersRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutAdminUsersRequestRole value)
        {
            return value switch
            {
                PutAdminUsersRequestRole.Admin => "admin",
                PutAdminUsersRequestRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutAdminUsersRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PutAdminUsersRequestRole.Admin,
                "member" => PutAdminUsersRequestRole.Member,
                _ => null,
            };
        }
    }
}