//HintName: G.Models.WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsChecks
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
    public static class WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsChecks value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsChecks.Read => "read",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsChecks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsChecks ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsChecks.Read,
                "write" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsChecks.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}