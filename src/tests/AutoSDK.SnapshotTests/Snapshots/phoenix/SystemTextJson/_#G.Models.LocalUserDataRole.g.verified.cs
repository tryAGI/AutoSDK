//HintName: G.Models.LocalUserDataRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalUserDataRole
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
    public static class LocalUserDataRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalUserDataRole value)
        {
            return value switch
            {
                LocalUserDataRole.Admin => "ADMIN",
                LocalUserDataRole.Member => "MEMBER",
                LocalUserDataRole.System => "SYSTEM",
                LocalUserDataRole.Viewer => "VIEWER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalUserDataRole? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => LocalUserDataRole.Admin,
                "MEMBER" => LocalUserDataRole.Member,
                "SYSTEM" => LocalUserDataRole.System,
                "VIEWER" => LocalUserDataRole.Viewer,
                _ => null,
            };
        }
    }
}