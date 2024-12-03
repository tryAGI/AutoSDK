//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata
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
    public static class WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata.Read => "read",
                WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata.Read,
                "write" => WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata.Write,
                _ => null,
            };
        }
    }
}