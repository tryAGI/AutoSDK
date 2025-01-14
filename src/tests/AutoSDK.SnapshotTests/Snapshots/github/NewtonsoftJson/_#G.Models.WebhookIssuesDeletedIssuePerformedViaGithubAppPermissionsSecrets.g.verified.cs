﻿//HintName: G.Models.WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecrets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecrets
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
    public static class WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecrets value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecrets.Read => "read",
                WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecrets.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecrets? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecrets.Read,
                "write" => WebhookIssuesDeletedIssuePerformedViaGithubAppPermissionsSecrets.Write,
                _ => null,
            };
        }
    }
}