//HintName: G.Models.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjects
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
    public static class WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjects value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjects.Read => "read",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjects.Write => "write",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjects.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjects? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjects.Read,
                "write" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjects.Write,
                "admin" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationProjects.Admin,
                _ => null,
            };
        }
    }
}