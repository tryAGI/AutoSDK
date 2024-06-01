//HintName: G.Models.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects
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
    public static class WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects.Read => "read",
                WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects.Read,
                "write" => WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}