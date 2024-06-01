//HintName: G.Models.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPages
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
    public static class WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPages value)
        {
            return value switch
            {
                WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPages.Read => "read",
                WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPages ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPages.Read,
                "write" => WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPages.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}