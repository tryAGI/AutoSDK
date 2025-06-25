﻿//HintName: G.Models.WebhookPullRequestReviewCommentCreatedCommentSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedCommentSide
    {
        /// <summary>
        /// 
        /// </summary>
        LEFT,
        /// <summary>
        /// 
        /// </summary>
        RIGHT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentCreatedCommentSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedCommentSide value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedCommentSide.LEFT => "LEFT",
                WebhookPullRequestReviewCommentCreatedCommentSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedCommentSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => WebhookPullRequestReviewCommentCreatedCommentSide.LEFT,
                "RIGHT" => WebhookPullRequestReviewCommentCreatedCommentSide.RIGHT,
                _ => null,
            };
        }
    }
}