//HintName: G.Models.AppPermissionsOrganizationCustomProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for custom property management.
    /// </summary>
    public enum AppPermissionsOrganizationCustomProperties
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
    public static class AppPermissionsOrganizationCustomPropertiesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationCustomProperties value)
        {
            return value switch
            {
                AppPermissionsOrganizationCustomProperties.Read => "read",
                AppPermissionsOrganizationCustomProperties.Write => "write",
                AppPermissionsOrganizationCustomProperties.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationCustomProperties? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationCustomProperties.Read,
                "write" => AppPermissionsOrganizationCustomProperties.Write,
                "admin" => AppPermissionsOrganizationCustomProperties.Admin,
                _ => null,
            };
        }
    }
}