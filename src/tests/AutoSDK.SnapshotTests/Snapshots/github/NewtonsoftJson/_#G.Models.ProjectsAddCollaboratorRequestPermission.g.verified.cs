//HintName: G.Models.ProjectsAddCollaboratorRequestPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission to grant the collaborator.<br/>
    /// Default Value: write<br/>
    /// Example: write
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectsAddCollaboratorRequestPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsAddCollaboratorRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsAddCollaboratorRequestPermission value)
        {
            return value switch
            {
                ProjectsAddCollaboratorRequestPermission.Admin => "admin",
                ProjectsAddCollaboratorRequestPermission.Read => "read",
                ProjectsAddCollaboratorRequestPermission.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsAddCollaboratorRequestPermission? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ProjectsAddCollaboratorRequestPermission.Admin,
                "read" => ProjectsAddCollaboratorRequestPermission.Read,
                "write" => ProjectsAddCollaboratorRequestPermission.Write,
                _ => null,
            };
        }
    }
}