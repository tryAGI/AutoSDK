//HintName: G.Models.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents
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
    public static class WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents.Read => "read",
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents.Read,
                "write" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents.Write,
                _ => null,
            };
        }
    }
}