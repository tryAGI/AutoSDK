//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsIssues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsIssues
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
    public static class WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsIssuesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsIssues value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsIssues.Read => "read",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsIssues.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsIssues? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsIssues.Read,
                "write" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsIssues.Write,
                _ => null,
            };
        }
    }
}