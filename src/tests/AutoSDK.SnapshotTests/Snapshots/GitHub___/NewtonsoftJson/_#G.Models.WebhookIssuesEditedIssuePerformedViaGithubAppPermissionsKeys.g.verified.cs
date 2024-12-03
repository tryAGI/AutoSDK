//HintName: G.Models.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsKeys
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
    public static class WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsKeys value)
        {
            return value switch
            {
                WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsKeys.Read => "read",
                WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsKeys.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsKeys? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsKeys.Read,
                "write" => WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsKeys.Write,
                _ => null,
            };
        }
    }
}