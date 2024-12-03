//HintName: G.Models.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationAdministration
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
    public static class WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationAdministration value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Read => "read",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationAdministration? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Read,
                "write" => WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Write,
                _ => null,
            };
        }
    }
}