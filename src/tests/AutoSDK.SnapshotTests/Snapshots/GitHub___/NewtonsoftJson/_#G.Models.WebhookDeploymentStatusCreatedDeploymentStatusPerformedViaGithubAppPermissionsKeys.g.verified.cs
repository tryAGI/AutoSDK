//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsKeys
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
    public static class WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsKeys value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsKeys.Read => "read",
                WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsKeys.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsKeys? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsKeys.Read,
                "write" => WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsKeys.Write,
                _ => null,
            };
        }
    }
}