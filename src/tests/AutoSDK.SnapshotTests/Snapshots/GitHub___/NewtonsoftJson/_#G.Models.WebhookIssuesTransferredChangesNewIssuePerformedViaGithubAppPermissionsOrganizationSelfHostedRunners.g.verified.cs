//HintName: G.Models.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners
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
    public static class WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Read => "read",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Read,
                "write" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Write,
                _ => null,
            };
        }
    }
}