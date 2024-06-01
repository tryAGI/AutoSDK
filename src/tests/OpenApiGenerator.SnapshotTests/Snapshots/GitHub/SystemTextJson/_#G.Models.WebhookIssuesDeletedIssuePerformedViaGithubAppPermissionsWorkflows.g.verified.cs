//HintName: G.Models.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsWorkflows.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsWorkflows
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
    public static class WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsWorkflowsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsWorkflows value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsWorkflows.Read => "read",
                WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsWorkflows.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsWorkflows ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsWorkflows.Read,
                "write" => WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsWorkflows.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}