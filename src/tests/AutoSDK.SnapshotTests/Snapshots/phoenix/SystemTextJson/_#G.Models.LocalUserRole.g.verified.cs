//HintName: G.Models.LocalUserRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalUserRole
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
        System,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalUserRole value)
        {
            return value switch
            {
                LocalUserRole.Admin => "ADMIN",
                LocalUserRole.Member => "MEMBER",
                LocalUserRole.System => "SYSTEM",
                LocalUserRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalUserRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => LocalUserRole.Admin,
                "MEMBER" => LocalUserRole.Member,
                "SYSTEM" => LocalUserRole.System,
                "VIEWER" => LocalUserRole.Viewer,
                _ => null,
            };
        }
    }
}