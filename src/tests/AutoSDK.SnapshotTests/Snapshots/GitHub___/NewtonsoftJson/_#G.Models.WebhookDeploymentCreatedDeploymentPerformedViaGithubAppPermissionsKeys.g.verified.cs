//HintName: G.Models.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeys
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
    public static class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeys value)
        {
            return value switch
            {
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeys.Read => "read",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeys.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeys? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeys.Read,
                "write" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeys.Write,
                _ => null,
            };
        }
    }
}