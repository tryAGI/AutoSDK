//HintName: G.Models.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages
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
    public static class WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages value)
        {
            return value switch
            {
                WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages.Read => "read",
                WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages.Read,
                "write" => WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages.Write,
                _ => null,
            };
        }
    }
}