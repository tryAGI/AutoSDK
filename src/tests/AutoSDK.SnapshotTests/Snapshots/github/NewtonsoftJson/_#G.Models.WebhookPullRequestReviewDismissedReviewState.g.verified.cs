﻿//HintName: G.Models.WebhookPullRequestReviewDismissedReviewState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewDismissedReviewState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approved")]
        Approved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="changes_requested")]
        ChangesRequested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewDismissedReviewStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedReviewState value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedReviewState.Dismissed => "dismissed",
                WebhookPullRequestReviewDismissedReviewState.Approved => "approved",
                WebhookPullRequestReviewDismissedReviewState.ChangesRequested => "changes_requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedReviewState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => WebhookPullRequestReviewDismissedReviewState.Dismissed,
                "approved" => WebhookPullRequestReviewDismissedReviewState.Approved,
                "changes_requested" => WebhookPullRequestReviewDismissedReviewState.ChangesRequested,
                _ => null,
            };
        }
    }
}