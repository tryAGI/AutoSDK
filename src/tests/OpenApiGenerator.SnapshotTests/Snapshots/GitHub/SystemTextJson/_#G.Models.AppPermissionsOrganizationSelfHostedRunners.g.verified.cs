//HintName: G.Models.AppPermissionsOrganizationSelfHostedRunners.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.
    /// </summary>
    public enum AppPermissionsOrganizationSelfHostedRunners
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
    public static class AppPermissionsOrganizationSelfHostedRunnersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationSelfHostedRunners value)
        {
            return value switch
            {
                AppPermissionsOrganizationSelfHostedRunners.Read => "read",
                AppPermissionsOrganizationSelfHostedRunners.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationSelfHostedRunners ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationSelfHostedRunners.Read,
                "write" => AppPermissionsOrganizationSelfHostedRunners.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}