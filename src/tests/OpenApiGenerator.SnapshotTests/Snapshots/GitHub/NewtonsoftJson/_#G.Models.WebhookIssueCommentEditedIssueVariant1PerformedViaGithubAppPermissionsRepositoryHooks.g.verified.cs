//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks
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
    public static class WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks.Read => "read",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks.Read,
                "write" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsRepositoryHooks.Write,
                _ => null,
            };
        }
    }
}