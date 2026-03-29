//HintName: G.Models.UpdateUserRoleDTORole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateUserRoleDTORole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="editor")]
        Editor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="viewer")]
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