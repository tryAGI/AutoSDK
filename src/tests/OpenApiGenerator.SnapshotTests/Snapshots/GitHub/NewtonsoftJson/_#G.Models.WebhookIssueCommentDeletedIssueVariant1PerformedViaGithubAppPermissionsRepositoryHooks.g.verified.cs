//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks
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
    public static class WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks.Read => "read",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks.Read,
                "write" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks.Write,
                _ => null,
            };
        }
    }
}