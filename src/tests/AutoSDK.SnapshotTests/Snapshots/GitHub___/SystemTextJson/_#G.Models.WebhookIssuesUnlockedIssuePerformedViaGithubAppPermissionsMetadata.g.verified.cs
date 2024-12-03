//HintName: G.Models.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMetadata
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
    public static class WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMetadata value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMetadata.Read => "read",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMetadata.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMetadata? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMetadata.Read,
                "write" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMetadata.Write,
                _ => null,
            };
        }
    }
}