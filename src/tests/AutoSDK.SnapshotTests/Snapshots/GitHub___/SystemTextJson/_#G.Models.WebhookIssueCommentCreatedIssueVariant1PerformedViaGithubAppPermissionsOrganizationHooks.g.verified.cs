//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsOrganizationHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsOrganizationHooks
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
    public static class WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsOrganizationHooksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsOrganizationHooks value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsOrganizationHooks.Read => "read",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsOrganizationHooks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsOrganizationHooks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsOrganizationHooks.Read,
                "write" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsOrganizationHooks.Write,
                _ => null,
            };
        }
    }
}