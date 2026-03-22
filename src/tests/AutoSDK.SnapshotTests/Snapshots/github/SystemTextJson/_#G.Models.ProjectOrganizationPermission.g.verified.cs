//HintName: G.Models.ProjectOrganizationPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The baseline permission that all organization members have on this project. Only present if owner is an organization.
    /// </summary>
    public enum ProjectOrganizationPermission
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
    public static class ProjectOrganizationPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectOrganizationPermission value)
        {
            return value switch
            {
                ProjectOrganizationPermission.Admin => "admin",
                ProjectOrganizationPermission.None => "none",
                ProjectOrganizationPermission.Read => "read",
                ProjectOrganizationPermission.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectOrganizationPermission? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ProjectOrganizationPermission.Admin,
                "none" => ProjectOrganizationPermission.None,
                "read" => ProjectOrganizationPermission.Read,
                "write" => ProjectOrganizationPermission.Write,
                _ => null,
            };
        }
    }
}