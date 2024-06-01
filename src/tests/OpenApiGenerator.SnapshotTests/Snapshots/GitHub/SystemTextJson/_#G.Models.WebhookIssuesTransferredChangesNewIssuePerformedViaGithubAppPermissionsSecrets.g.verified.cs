//HintName: G.Models.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSecrets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSecrets
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
    public static class WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSecrets value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSecrets.Read => "read",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSecrets.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSecrets ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSecrets.Read,
                "write" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSecrets.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}