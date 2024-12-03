//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSingleFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSingleFile
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
    public static class WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSingleFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSingleFile value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSingleFile.Read => "read",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSingleFile.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSingleFile? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSingleFile.Read,
                "write" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsSingleFile.Write,
                _ => null,
            };
        }
    }
}