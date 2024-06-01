//HintName: G.Models.AppPermissionsOrganizationProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage organization projects and projects beta (where available).
    /// </summary>
    public enum AppPermissionsOrganizationProjects
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
    public static class AppPermissionsOrganizationProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationProjects value)
        {
            return value switch
            {
                AppPermissionsOrganizationProjects.Read => "read",
                AppPermissionsOrganizationProjects.Write => "write",
                AppPermissionsOrganizationProjects.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationProjects ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationProjects.Read,
                "write" => AppPermissionsOrganizationProjects.Write,
                "admin" => AppPermissionsOrganizationProjects.Admin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}