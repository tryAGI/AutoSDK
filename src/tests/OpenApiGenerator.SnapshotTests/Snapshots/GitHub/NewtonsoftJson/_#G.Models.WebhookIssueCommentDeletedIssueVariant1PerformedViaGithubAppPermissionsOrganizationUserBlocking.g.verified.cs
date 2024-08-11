//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsOrganizationUserBlocking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsOrganizationUserBlocking
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
    public static class WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsOrganizationUserBlockingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsOrganizationUserBlocking value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsOrganizationUserBlocking.Read => "read",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsOrganizationUserBlocking.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsOrganizationUserBlocking? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsOrganizationUserBlocking.Read,
                "write" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsOrganizationUserBlocking.Write,
                _ => null,
            };
        }
    }
}