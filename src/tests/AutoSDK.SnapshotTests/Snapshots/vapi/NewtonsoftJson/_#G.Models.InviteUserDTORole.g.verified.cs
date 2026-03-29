//HintName: G.Models.InviteUserDTORole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InviteUserDTORole
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
    public static class InviteUserDTORoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteUserDTORole value)
        {
            return value switch
            {
                InviteUserDTORole.Admin => "admin",
                InviteUserDTORole.Editor => "editor",
                InviteUserDTORole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteUserDTORole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => InviteUserDTORole.Admin,
                "editor" => InviteUserDTORole.Editor,
                "viewer" => InviteUserDTORole.Viewer,
                _ => null,
            };
        }
    }
}