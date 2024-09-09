//HintName: G.Models.AppPermissionsOrganizationPackages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for organization packages published to GitHub Packages.
    /// </summary>
    public enum AppPermissionsOrganizationPackages
    {
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
    public static class AppPermissionsOrganizationPackagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationPackages value)
        {
            return value switch
            {
                AppPermissionsOrganizationPackages.Read => "read",
                AppPermissionsOrganizationPackages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationPackages? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationPackages.Read,
                "write" => AppPermissionsOrganizationPackages.Write,
                _ => null,
            };
        }
    }
}