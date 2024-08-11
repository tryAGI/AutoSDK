//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsPages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsPages
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
    public static class WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsPagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsPages value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsPages.Read => "read",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsPages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsPages? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsPages.Read,
                "write" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsPages.Write,
                _ => null,
            };
        }
    }
}