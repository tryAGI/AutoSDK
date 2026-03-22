//HintName: G.Models.WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestHeadRepoVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizePullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestSynchronizePullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}