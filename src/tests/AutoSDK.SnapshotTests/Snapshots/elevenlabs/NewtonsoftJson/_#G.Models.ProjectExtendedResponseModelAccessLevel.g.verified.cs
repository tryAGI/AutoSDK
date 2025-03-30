//HintName: G.Models.ProjectExtendedResponseModelAccessLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the project.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectExtendedResponseModelAccessLevel
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
    public static class ProjectExtendedResponseModelAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelAccessLevel value)
        {
            return value switch
            {
                ProjectExtendedResponseModelAccessLevel.Admin => "admin",
                ProjectExtendedResponseModelAccessLevel.Editor => "editor",
                ProjectExtendedResponseModelAccessLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ProjectExtendedResponseModelAccessLevel.Admin,
                "editor" => ProjectExtendedResponseModelAccessLevel.Editor,
                "viewer" => ProjectExtendedResponseModelAccessLevel.Viewer,
                _ => null,
            };
        }
    }
}