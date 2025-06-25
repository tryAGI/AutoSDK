﻿//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}