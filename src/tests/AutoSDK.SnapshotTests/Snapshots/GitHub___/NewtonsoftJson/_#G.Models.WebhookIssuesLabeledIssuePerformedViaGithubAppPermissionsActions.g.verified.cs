//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions
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
    public static class WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions.Read => "read",
                WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions.Read,
                "write" => WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions.Write,
                _ => null,
            };
        }
    }
}