//HintName: G.Models.WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSecurityEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSecurityEvents
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
    public static class WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSecurityEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSecurityEvents value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSecurityEvents.Read => "read",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSecurityEvents.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSecurityEvents ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSecurityEvents.Read,
                "write" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSecurityEvents.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}