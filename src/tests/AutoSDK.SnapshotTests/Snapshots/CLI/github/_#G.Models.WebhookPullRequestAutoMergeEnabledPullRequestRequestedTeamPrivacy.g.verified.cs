﻿//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}