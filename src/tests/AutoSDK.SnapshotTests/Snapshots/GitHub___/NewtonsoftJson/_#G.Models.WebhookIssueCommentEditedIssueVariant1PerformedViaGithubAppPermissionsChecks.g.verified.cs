//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsChecks
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
    public static class WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsChecks value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsChecks.Read => "read",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsChecks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsChecks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsChecks.Read,
                "write" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsChecks.Write,
                _ => null,
            };
        }
    }
}