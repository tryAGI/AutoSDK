//HintName: G.Models.WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsDeployments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsDeployments
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
    public static class WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsDeployments value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsDeployments.Read => "read",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsDeployments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsDeployments ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsDeployments.Read,
                "write" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppPermissionsDeployments.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}