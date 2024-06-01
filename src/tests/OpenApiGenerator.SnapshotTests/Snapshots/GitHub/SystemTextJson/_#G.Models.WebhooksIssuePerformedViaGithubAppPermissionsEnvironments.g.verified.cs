//HintName: G.Models.WebhooksIssuePerformedViaGithubAppPermissionsEnvironments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssuePerformedViaGithubAppPermissionsEnvironments
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
    public static class WebhooksIssuePerformedViaGithubAppPermissionsEnvironmentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssuePerformedViaGithubAppPermissionsEnvironments value)
        {
            return value switch
            {
                WebhooksIssuePerformedViaGithubAppPermissionsEnvironments.Read => "read",
                WebhooksIssuePerformedViaGithubAppPermissionsEnvironments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssuePerformedViaGithubAppPermissionsEnvironments ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhooksIssuePerformedViaGithubAppPermissionsEnvironments.Read,
                "write" => WebhooksIssuePerformedViaGithubAppPermissionsEnvironments.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}