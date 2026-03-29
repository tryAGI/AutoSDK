//HintName: G.Models.OAuth2UserDataRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OAuth2UserDataRole
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