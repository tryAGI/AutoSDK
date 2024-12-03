//HintName: G.Models.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironments
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
    public static class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironmentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironments value)
        {
            return value switch
            {
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironments.Read => "read",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironments? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironments.Read,
                "write" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironments.Write,
                _ => null,
            };
        }
    }
}