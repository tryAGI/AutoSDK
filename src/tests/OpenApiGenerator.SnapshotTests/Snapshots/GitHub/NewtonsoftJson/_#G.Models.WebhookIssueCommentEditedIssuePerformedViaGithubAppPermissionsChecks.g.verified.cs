//HintName: G.Models.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsChecks
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
    public static class WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsChecks value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsChecks.Read => "read",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsChecks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsChecks ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsChecks.Read,
                "write" => WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsChecks.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}