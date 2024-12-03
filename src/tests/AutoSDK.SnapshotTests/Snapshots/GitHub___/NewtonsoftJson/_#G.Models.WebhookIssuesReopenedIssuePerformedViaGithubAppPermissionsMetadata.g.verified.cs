//HintName: G.Models.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsMetadata
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
    public static class WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsMetadata value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsMetadata.Read => "read",
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsMetadata.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsMetadata? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsMetadata.Read,
                "write" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsMetadata.Write,
                _ => null,
            };
        }
    }
}