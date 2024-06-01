//HintName: G.Models.ProjectsAddCollaboratorRequestPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permission to grant the collaborator.
    /// <br/>Default Value: write
    /// <br/>Example: write
    /// </summary>
    public enum ProjectsAddCollaboratorRequestPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Admin,
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
                ProjectsAddCollaboratorRequestPermission.Read => "read",
                ProjectsAddCollaboratorRequestPermission.Write => "write",
                ProjectsAddCollaboratorRequestPermission.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsAddCollaboratorRequestPermission ToEnum(string value)
        {
            return value switch
            {
                "read" => ProjectsAddCollaboratorRequestPermission.Read,
                "write" => ProjectsAddCollaboratorRequestPermission.Write,
                "admin" => ProjectsAddCollaboratorRequestPermission.Admin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}