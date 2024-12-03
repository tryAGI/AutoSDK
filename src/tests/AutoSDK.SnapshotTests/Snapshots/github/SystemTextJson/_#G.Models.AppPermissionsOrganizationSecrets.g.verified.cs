//HintName: G.Models.AppPermissionsOrganizationSecrets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage organization secrets.
    /// </summary>
    public enum AppPermissionsOrganizationSecrets
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
    public static class AppPermissionsOrganizationSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationSecrets value)
        {
            return value switch
            {
                AppPermissionsOrganizationSecrets.Read => "read",
                AppPermissionsOrganizationSecrets.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationSecrets? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationSecrets.Read,
                "write" => AppPermissionsOrganizationSecrets.Write,
                _ => null,
            };
        }
    }
}