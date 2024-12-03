//HintName: G.Models.WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects
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
    public static class WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects.Read => "read",
                WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects.Read,
                "write" => WebhooksIssue2PerformedViaGithubAppPermissionsRepositoryProjects.Write,
                _ => null,
            };
        }
    }
}