//HintName: G.Models.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPackages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPackages
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
    public static class WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPackagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPackages value)
        {
            return value switch
            {
                WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPackages.Read => "read",
                WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPackages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPackages ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPackages.Read,
                "write" => WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsPackages.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}