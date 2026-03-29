//HintName: G.Models.OAuth2UserDataRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OAuth2UserDataRole
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
    public static class OAuth2UserDataRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuth2UserDataRole value)
        {
            return value switch
            {
                OAuth2UserDataRole.Admin => "ADMIN",
                OAuth2UserDataRole.Member => "MEMBER",
                OAuth2UserDataRole.System => "SYSTEM",
                OAuth2UserDataRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuth2UserDataRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => OAuth2UserDataRole.Admin,
                "MEMBER" => OAuth2UserDataRole.Member,
                "SYSTEM" => OAuth2UserDataRole.System,
                "VIEWER" => OAuth2UserDataRole.Viewer,
                _ => null,
            };
        }
    }
}