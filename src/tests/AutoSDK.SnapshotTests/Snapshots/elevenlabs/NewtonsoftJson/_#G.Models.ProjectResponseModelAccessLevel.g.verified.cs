//HintName: G.Models.ProjectResponseModelAccessLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the project.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectResponseModelAccessLevel
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
    public static class ProjectResponseModelAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelAccessLevel value)
        {
            return value switch
            {
                ProjectResponseModelAccessLevel.Admin => "admin",
                ProjectResponseModelAccessLevel.Editor => "editor",
                ProjectResponseModelAccessLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ProjectResponseModelAccessLevel.Admin,
                "editor" => ProjectResponseModelAccessLevel.Editor,
                "viewer" => ProjectResponseModelAccessLevel.Viewer,
                _ => null,
            };
        }
    }
}