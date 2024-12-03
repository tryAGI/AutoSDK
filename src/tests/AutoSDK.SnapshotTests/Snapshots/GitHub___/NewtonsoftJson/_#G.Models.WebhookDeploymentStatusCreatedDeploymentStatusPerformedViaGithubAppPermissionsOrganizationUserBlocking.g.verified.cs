//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationUserBlocking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationUserBlocking
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationUserBlockingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationUserBlocking value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationUserBlocking.Read => "read",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationUserBlocking.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationUserBlocking? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationUserBlocking.Read,
                "write" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationUserBlocking.Write,
                _ => null,
            };
        }
    }
}