//HintName: G.Models.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets
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
    public static class WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets value)
        {
            return value switch
            {
                WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets.Read => "read",
                WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets.Read,
                "write" => WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSecrets.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}