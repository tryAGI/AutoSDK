//HintName: G.Models.LDAPUserDataRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LDAPUserDataRole
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