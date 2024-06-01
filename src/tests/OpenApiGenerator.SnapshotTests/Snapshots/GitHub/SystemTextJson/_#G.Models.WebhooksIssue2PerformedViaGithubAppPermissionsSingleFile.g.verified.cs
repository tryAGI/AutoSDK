//HintName: G.Models.WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile
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
    public static class WebhooksIssue2PerformedViaGithubAppPermissionsSingleFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile value)
        {
            return value switch
            {
                WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile.Read => "read",
                WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile.Read,
                "write" => WebhooksIssue2PerformedViaGithubAppPermissionsSingleFile.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}