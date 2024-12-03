//HintName: G.Models.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooks
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
    public static class WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooks value)
        {
            return value switch
            {
                WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooks.Read => "read",
                WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooks.Read,
                "write" => WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooks.Write,
                _ => null,
            };
        }
    }
}