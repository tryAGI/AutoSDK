//HintName: G.Models.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsOrganizationAdministration
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
    public static class WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsOrganizationAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsOrganizationAdministration value)
        {
            return value switch
            {
                WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Read => "read",
                WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsOrganizationAdministration ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Read,
                "write" => WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}