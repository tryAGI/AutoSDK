//HintName: G.Models.AppPermissionsRepositoryProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage repository projects, columns, and cards.
    /// </summary>
    public enum AppPermissionsRepositoryProjects
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
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
    public static class AppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                AppPermissionsRepositoryProjects.Admin => "admin",
                AppPermissionsRepositoryProjects.Read => "read",
                AppPermissionsRepositoryProjects.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsRepositoryProjects? ToEnum(string value)
        {
            return value switch
            {
                "admin" => AppPermissionsRepositoryProjects.Admin,
                "read" => AppPermissionsRepositoryProjects.Read,
                "write" => AppPermissionsRepositoryProjects.Write,
                _ => null,
            };
        }
    }
}