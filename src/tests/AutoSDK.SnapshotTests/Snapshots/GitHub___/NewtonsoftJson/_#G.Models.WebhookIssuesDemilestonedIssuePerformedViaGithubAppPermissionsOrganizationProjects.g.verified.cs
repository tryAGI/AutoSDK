//HintName: G.Models.WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Read => "read",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Write => "write",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Read,
                "write" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Write,
                "admin" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsOrganizationProjects.Admin,
                _ => null,
            };
        }
    }
}