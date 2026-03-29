//HintName: G.Models.LDAPUserRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LDAPUserRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ADMIN")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SYSTEM")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEWER")]
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LDAPUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LDAPUserRole value)
        {
            return value switch
            {
                LDAPUserRole.Admin => "ADMIN",
                LDAPUserRole.Member => "MEMBER",
                LDAPUserRole.System => "SYSTEM",
                LDAPUserRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LDAPUserRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => LDAPUserRole.Admin,
                "MEMBER" => LDAPUserRole.Member,
                "SYSTEM" => LDAPUserRole.System,
                "VIEWER" => LDAPUserRole.Viewer,
                _ => null,
            };
        }
    }
}