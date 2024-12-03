//HintName: G.Models.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeployments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeployments
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
    public static class WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeployments value)
        {
            return value switch
            {
                WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeployments.Read => "read",
                WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeployments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeployments? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeployments.Read,
                "write" => WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeployments.Write,
                _ => null,
            };
        }
    }
}