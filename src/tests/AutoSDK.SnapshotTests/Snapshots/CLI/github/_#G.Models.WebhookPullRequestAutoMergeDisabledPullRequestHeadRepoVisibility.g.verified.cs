﻿//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestAutoMergeDisabledPullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}