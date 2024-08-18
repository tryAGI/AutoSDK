﻿//HintName: G.Models.WebhookPullRequestLockedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLockedPullRequestRequestedTeamPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLockedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestLockedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestLockedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestLockedPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestLockedPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestLockedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}