//HintName: G.Models.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects
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
    public static class WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Read => "read",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Write => "write",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Read,
                "write" => WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Write,
                "admin" => WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Admin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}