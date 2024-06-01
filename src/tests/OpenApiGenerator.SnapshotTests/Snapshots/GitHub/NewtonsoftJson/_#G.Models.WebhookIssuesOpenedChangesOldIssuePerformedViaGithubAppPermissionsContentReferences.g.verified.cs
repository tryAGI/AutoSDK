//HintName: G.Models.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsContentReferences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsContentReferences
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
    public static class WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsContentReferencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsContentReferences value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsContentReferences.Read => "read",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsContentReferences.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsContentReferences ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsContentReferences.Read,
                "write" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsContentReferences.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}