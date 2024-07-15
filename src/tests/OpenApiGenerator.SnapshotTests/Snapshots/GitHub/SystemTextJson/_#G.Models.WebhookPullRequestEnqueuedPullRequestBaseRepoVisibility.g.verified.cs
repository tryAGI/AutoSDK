//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestEnqueuedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestEnqueuedPullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}