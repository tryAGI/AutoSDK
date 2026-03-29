//HintName: G.Models.UpdateUserRoleDTORole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateUserRoleDTORole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Editor,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateUserRoleDTORoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateUserRoleDTORole value)
        {
            return value switch
            {
                UpdateUserRoleDTORole.Admin => "admin",
                UpdateUserRoleDTORole.Editor => "editor",
                UpdateUserRoleDTORole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateUserRoleDTORole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UpdateUserRoleDTORole.Admin,
                "editor" => UpdateUserRoleDTORole.Editor,
                "viewer" => UpdateUserRoleDTORole.Viewer,
                _ => null,
            };
        }
    }
}