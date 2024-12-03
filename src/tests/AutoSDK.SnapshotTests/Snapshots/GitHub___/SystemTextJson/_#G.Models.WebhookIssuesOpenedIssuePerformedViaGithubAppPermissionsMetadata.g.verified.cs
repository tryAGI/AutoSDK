//HintName: G.Models.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadata
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
    public static class WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadata value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadata.Read => "read",
                WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadata.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadata? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadata.Read,
                "write" => WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadata.Write,
                _ => null,
            };
        }
    }
}