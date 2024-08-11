//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEnvironments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEnvironments
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
    public static class WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEnvironmentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEnvironments value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEnvironments.Read => "read",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEnvironments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEnvironments? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEnvironments.Read,
                "write" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsEnvironments.Write,
                _ => null,
            };
        }
    }
}