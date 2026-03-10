//HintName: G.Models.DefaultSharingGroupResponseModelPermissionLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission level to grant to the group
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DefaultSharingGroupResponseModelPermissionLevel
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
    public static class DefaultSharingGroupResponseModelPermissionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DefaultSharingGroupResponseModelPermissionLevel value)
        {
            return value switch
            {
                DefaultSharingGroupResponseModelPermissionLevel.Admin => "admin",
                DefaultSharingGroupResponseModelPermissionLevel.Editor => "editor",
                DefaultSharingGroupResponseModelPermissionLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DefaultSharingGroupResponseModelPermissionLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => DefaultSharingGroupResponseModelPermissionLevel.Admin,
                "editor" => DefaultSharingGroupResponseModelPermissionLevel.Editor,
                "viewer" => DefaultSharingGroupResponseModelPermissionLevel.Viewer,
                _ => null,
            };
        }
    }
}