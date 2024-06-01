//HintName: G.Models.WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsWorkflows.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsWorkflows
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
    public static class WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsWorkflowsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsWorkflows value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsWorkflows.Read => "read",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsWorkflows.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsWorkflows ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsWorkflows.Read,
                "write" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsWorkflows.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}