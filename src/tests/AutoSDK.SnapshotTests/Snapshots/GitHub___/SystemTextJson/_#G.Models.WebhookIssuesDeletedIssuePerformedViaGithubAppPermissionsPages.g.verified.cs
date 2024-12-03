//HintName: G.Models.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsPages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsPages
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
    public static class WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsPagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsPages value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsPages.Read => "read",
                WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsPages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsPages? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsPages.Read,
                "write" => WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsPages.Write,
                _ => null,
            };
        }
    }
}