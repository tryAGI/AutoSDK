//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsEnvironments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsEnvironments
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
    public static class WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsEnvironmentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsEnvironments value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsEnvironments.Read => "read",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsEnvironments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsEnvironments? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsEnvironments.Read,
                "write" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsEnvironments.Write,
                _ => null,
            };
        }
    }
}