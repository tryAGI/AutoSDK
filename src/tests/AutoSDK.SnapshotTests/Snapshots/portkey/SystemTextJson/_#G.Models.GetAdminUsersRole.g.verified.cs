//HintName: G.Models.GetAdminUsersRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAdminUsersRole
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
    public static class GetAdminUsersRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAdminUsersRole value)
        {
            return value switch
            {
                GetAdminUsersRole.Admin => "admin",
                GetAdminUsersRole.Member => "member",
                GetAdminUsersRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAdminUsersRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetAdminUsersRole.Admin,
                "member" => GetAdminUsersRole.Member,
                "owner" => GetAdminUsersRole.Owner,
                _ => null,
            };
        }
    }
}