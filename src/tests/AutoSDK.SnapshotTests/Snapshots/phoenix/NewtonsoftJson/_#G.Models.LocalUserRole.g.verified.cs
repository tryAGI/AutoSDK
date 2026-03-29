//HintName: G.Models.LocalUserRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalUserRole
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