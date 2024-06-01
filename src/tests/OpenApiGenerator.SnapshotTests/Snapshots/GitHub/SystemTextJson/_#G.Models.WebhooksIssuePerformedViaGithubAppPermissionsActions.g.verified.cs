//HintName: G.Models.WebhooksIssuePerformedViaGithubAppPermissionsActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssuePerformedViaGithubAppPermissionsActions
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksIssuePerformedViaGithubAppPermissionsActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssuePerformedViaGithubAppPermissionsActions value)
        {
            return value switch
            {
                WebhooksIssuePerformedViaGithubAppPermissionsActions.Read => "read",
                WebhooksIssuePerformedViaGithubAppPermissionsActions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssuePerformedViaGithubAppPermissionsActions ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhooksIssuePerformedViaGithubAppPermissionsActions.Read,
                "write" => WebhooksIssuePerformedViaGithubAppPermissionsActions.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}