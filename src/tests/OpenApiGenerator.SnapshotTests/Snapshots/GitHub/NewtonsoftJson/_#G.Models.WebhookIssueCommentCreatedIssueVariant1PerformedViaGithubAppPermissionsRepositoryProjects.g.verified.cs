//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjects
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjects.Read => "read",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjects.Write => "write",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjects.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjects? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjects.Read,
                "write" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjects.Write,
                "admin" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsRepositoryProjects.Admin,
                _ => null,
            };
        }
    }
}