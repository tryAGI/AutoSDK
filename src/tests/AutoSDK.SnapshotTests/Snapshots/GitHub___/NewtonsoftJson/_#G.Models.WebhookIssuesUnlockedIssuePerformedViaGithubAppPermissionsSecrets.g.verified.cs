//HintName: G.Models.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsSecrets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsSecrets
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
    public static class WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsSecrets value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsSecrets.Read => "read",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsSecrets.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsSecrets? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsSecrets.Read,
                "write" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsSecrets.Write,
                _ => null,
            };
        }
    }
}