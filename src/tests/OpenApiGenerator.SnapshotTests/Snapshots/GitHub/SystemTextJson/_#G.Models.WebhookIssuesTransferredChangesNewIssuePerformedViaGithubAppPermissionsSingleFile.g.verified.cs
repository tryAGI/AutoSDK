//HintName: G.Models.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSingleFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSingleFile
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
    public static class WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSingleFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSingleFile value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSingleFile.Read => "read",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSingleFile.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSingleFile ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSingleFile.Read,
                "write" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsSingleFile.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}