//HintName: G.Models.InviteUserDTORole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InviteUserDTORole
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