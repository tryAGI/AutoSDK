//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile
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
    public static class WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile.Read => "read",
                WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile.Read,
                "write" => WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile.Write,
                _ => null,
            };
        }
    }
}