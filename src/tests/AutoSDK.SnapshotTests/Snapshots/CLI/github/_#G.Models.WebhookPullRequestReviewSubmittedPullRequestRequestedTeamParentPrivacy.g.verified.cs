﻿//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewSubmittedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}