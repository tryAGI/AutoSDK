﻿//HintName: G.Models.WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestHeadRepoVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestDequeuedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}