//HintName: G.Models.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsAdministration
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
    public static class WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsAdministration value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsAdministration.Read => "read",
                WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsAdministration? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsAdministration.Read,
                "write" => WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsAdministration.Write,
                _ => null,
            };
        }
    }
}