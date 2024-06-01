//HintName: G.Models.WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjects
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
    public static class WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjects value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Read => "read",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Write => "write",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjects ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Read,
                "write" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Write,
                "admin" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Admin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}