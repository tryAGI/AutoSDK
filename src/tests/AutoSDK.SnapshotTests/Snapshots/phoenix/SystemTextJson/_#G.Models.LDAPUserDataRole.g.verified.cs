//HintName: G.Models.LDAPUserDataRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LDAPUserDataRole
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
    public static class LDAPUserDataRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LDAPUserDataRole value)
        {
            return value switch
            {
                LDAPUserDataRole.Admin => "ADMIN",
                LDAPUserDataRole.Member => "MEMBER",
                LDAPUserDataRole.System => "SYSTEM",
                LDAPUserDataRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LDAPUserDataRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => LDAPUserDataRole.Admin,
                "MEMBER" => LDAPUserDataRole.Member,
                "SYSTEM" => LDAPUserDataRole.System,
                "VIEWER" => LDAPUserDataRole.Viewer,
                _ => null,
            };
        }
    }
}