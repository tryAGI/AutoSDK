//HintName: G.Models.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration
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
    public static class WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration.Read => "read",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration.Read,
                "write" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration.Write,
                _ => null,
            };
        }
    }
}