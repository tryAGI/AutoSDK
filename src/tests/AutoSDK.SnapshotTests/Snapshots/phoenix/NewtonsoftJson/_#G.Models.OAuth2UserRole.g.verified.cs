//HintName: G.Models.OAuth2UserRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OAuth2UserRole
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
    public static class OAuth2UserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuth2UserRole value)
        {
            return value switch
            {
                OAuth2UserRole.Admin => "ADMIN",
                OAuth2UserRole.Member => "MEMBER",
                OAuth2UserRole.System => "SYSTEM",
                OAuth2UserRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuth2UserRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => OAuth2UserRole.Admin,
                "MEMBER" => OAuth2UserRole.Member,
                "SYSTEM" => OAuth2UserRole.System,
                "VIEWER" => OAuth2UserRole.Viewer,
                _ => null,
            };
        }
    }
}