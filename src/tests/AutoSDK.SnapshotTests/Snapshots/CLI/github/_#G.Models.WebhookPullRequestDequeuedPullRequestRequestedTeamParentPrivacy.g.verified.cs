﻿//HintName: G.Models.WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestDequeuedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}