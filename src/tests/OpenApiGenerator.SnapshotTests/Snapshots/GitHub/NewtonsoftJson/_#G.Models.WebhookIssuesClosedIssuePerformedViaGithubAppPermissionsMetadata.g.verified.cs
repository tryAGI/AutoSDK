//HintName: G.Models.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsMetadata
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
    public static class WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsMetadata value)
        {
            return value switch
            {
                WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsMetadata.Read => "read",
                WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsMetadata.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsMetadata ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsMetadata.Read,
                "write" => WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsMetadata.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}