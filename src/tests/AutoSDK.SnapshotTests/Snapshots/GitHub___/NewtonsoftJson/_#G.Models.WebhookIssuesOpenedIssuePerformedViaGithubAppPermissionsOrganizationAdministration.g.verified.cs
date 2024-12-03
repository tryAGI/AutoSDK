//HintName: G.Models.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministration
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
    public static class WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministration value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Read => "read",
                WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministration? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Read,
                "write" => WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministration.Write,
                _ => null,
            };
        }
    }
}