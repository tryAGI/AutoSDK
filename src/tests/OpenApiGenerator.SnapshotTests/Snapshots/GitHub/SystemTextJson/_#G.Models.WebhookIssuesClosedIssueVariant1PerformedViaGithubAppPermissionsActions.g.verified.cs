//HintName: G.Models.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsActions
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
    public static class WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsActions value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsActions.Read => "read",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsActions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsActions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsActions.Read,
                "write" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsActions.Write,
                _ => null,
            };
        }
    }
}