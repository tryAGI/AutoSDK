//HintName: G.Models.PermissionRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Required. The role granted by this permission.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PermissionRole
    {
        /// <summary>
        /// Owner can use, update, share and delete the resource.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
        Owner,
        /// <summary>
        /// Reader can use the resource.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="READER")]
        Reader,
        /// <summary>
        /// The default value. This value is unused.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ROLE_UNSPECIFIED")]
        RoleUnspecified,
        /// <summary>
        /// Writer can use, update and share the resource.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WRITER")]
        Writer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionRole value)
        {
            return value switch
            {
                PermissionRole.Owner => "OWNER",
                PermissionRole.Reader => "READER",
                PermissionRole.RoleUnspecified => "ROLE_UNSPECIFIED",
                PermissionRole.Writer => "WRITER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionRole? ToEnum(string value)
        {
            return value switch
            {
                "OWNER" => PermissionRole.Owner,
                "READER" => PermissionRole.Reader,
                "ROLE_UNSPECIFIED" => PermissionRole.RoleUnspecified,
                "WRITER" => PermissionRole.Writer,
                _ => null,
            };
        }
    }
}