//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners
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
    public static class WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Read => "read",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Read,
                "write" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Write,
                _ => null,
            };
        }
    }
}