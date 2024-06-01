//HintName: G.Models.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjects
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
    public static class WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjects.Read => "read",
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjects.Write => "write",
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjects.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjects ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjects.Read,
                "write" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjects.Write,
                "admin" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsRepositoryProjects.Admin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}