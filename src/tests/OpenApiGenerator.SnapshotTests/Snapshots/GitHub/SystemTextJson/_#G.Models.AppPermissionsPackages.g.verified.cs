//HintName: G.Models.AppPermissionsPackages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for packages published to GitHub Packages.
    /// </summary>
    public enum AppPermissionsPackages
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
    public static class AppPermissionsPackagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsPackages value)
        {
            return value switch
            {
                AppPermissionsPackages.Read => "read",
                AppPermissionsPackages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsPackages ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsPackages.Read,
                "write" => AppPermissionsPackages.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}