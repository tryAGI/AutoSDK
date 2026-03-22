//HintName: G.Models.WebhookPullRequestDequeuedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestDequeuedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestDequeuedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestDequeuedPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestDequeuedPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestDequeuedPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestDequeuedPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}