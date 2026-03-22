//HintName: G.Models.ProjectsUpdateRequestOrganizationPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The baseline permission that all organization members have on this project
    /// </summary>
    public enum ProjectsUpdateRequestOrganizationPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsUpdateRequestOrganizationPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsUpdateRequestOrganizationPermission value)
        {
            return value switch
            {
                ProjectsUpdateRequestOrganizationPermission.Admin => "admin",
                ProjectsUpdateRequestOrganizationPermission.None => "none",
                ProjectsUpdateRequestOrganizationPermission.Read => "read",
                ProjectsUpdateRequestOrganizationPermission.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsUpdateRequestOrganizationPermission? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ProjectsUpdateRequestOrganizationPermission.Admin,
                "none" => ProjectsUpdateRequestOrganizationPermission.None,
                "read" => ProjectsUpdateRequestOrganizationPermission.Read,
                "write" => ProjectsUpdateRequestOrganizationPermission.Write,
                _ => null,
            };
        }
    }
}