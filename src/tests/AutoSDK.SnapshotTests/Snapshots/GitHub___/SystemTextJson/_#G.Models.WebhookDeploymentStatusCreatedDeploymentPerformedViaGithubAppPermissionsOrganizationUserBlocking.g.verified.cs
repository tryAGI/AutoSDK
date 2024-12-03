//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlocking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlocking
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
    public static class WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlockingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlocking value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlocking.Read => "read",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlocking.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlocking? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlocking.Read,
                "write" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlocking.Write,
                _ => null,
            };
        }
    }
}