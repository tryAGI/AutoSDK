//HintName: G.Models.WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSingleFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSingleFile
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
    public static class WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSingleFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSingleFile value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSingleFile.Read => "read",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSingleFile.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSingleFile? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSingleFile.Read,
                "write" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsSingleFile.Write,
                _ => null,
            };
        }
    }
}