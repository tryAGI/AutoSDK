//HintName: G.Models.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSingleFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSingleFile
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
    public static class WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSingleFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSingleFile value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSingleFile.Read => "read",
                WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSingleFile.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSingleFile? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSingleFile.Read,
                "write" => WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSingleFile.Write,
                _ => null,
            };
        }
    }
}