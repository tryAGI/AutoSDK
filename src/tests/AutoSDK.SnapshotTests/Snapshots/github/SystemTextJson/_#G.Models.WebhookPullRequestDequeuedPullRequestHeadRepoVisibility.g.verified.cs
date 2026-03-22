//HintName: G.Models.WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.g.cs

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
    public static class WebhookPullRequestDequeuedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Public => "public",
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
                "internal" => WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestDequeuedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}