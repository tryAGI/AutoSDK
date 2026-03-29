//HintName: G.Models.UserRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserRole
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
    public static class UserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserRole value)
        {
            return value switch
            {
                UserRole.Admin => "admin",
                UserRole.Member => "member",
                UserRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserRole.Admin,
                "member" => UserRole.Member,
                "owner" => UserRole.Owner,
                _ => null,
            };
        }
    }
}