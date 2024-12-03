//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects
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
    public static class WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects.Read => "read",
                WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects.Read,
                "write" => WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects.Write,
                _ => null,
            };
        }
    }
}