//HintName: G.Models.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks
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
    public static class WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks value)
        {
            return value switch
            {
                WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks.Read => "read",
                WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks.Read,
                "write" => WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationHooks.Write,
                _ => null,
            };
        }
    }
}