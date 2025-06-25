﻿//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestUnlabeledPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestUnlabeledPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestUnlabeledPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestUnlabeledPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestUnlabeledPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestUnlabeledPullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}