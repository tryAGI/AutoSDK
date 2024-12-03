//HintName: G.Models.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsChecks
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
    public static class WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsChecks value)
        {
            return value switch
            {
                WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsChecks.Read => "read",
                WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsChecks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsChecks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsChecks.Read,
                "write" => WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsChecks.Write,
                _ => null,
            };
        }
    }
}