//HintName: G.Models.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners
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
    public static class WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Read => "read",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Read,
                "write" => WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}