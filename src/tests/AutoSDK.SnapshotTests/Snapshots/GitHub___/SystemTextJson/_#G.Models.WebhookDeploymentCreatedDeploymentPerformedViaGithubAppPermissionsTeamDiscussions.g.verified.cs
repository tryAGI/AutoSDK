//HintName: G.Models.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussions
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
    public static class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussions value)
        {
            return value switch
            {
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussions.Read => "read",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussions.Read,
                "write" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussions.Write,
                _ => null,
            };
        }
    }
}