//HintName: G.Models.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDeployments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDeployments
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
    public static class WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDeployments value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDeployments.Read => "read",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDeployments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDeployments? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDeployments.Read,
                "write" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDeployments.Write,
                _ => null,
            };
        }
    }
}