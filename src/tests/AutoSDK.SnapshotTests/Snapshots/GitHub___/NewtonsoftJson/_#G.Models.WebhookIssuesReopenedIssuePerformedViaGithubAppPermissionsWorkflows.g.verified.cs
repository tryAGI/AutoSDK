//HintName: G.Models.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsWorkflows.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsWorkflows
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
    public static class WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsWorkflowsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsWorkflows value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsWorkflows.Read => "read",
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsWorkflows.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsWorkflows? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsWorkflows.Read,
                "write" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsWorkflows.Write,
                _ => null,
            };
        }
    }
}