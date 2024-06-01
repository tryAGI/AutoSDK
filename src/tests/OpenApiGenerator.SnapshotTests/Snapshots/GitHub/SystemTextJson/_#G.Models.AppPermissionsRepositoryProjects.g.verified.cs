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
    public static class AppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                AppPermissionsRepositoryProjects.Read => "read",
                AppPermissionsRepositoryProjects.Write => "write",
                AppPermissionsRepositoryProjects.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsRepositoryProjects ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsRepositoryProjects.Read,
                "write" => AppPermissionsRepositoryProjects.Write,
                "admin" => AppPermissionsRepositoryProjects.Admin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}