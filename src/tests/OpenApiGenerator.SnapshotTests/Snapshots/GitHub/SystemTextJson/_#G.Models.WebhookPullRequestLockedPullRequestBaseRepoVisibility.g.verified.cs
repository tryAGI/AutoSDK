//HintName: G.Models.WebhookPullRequestLockedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestLockedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestBaseRepoVisibility.Public => "public",
                WebhookPullRequestLockedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestLockedPullRequestBaseRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestLockedPullRequestBaseRepoVisibility.Public,
                "private" => WebhookPullRequestLockedPullRequestBaseRepoVisibility.Private,
                "internal" => WebhookPullRequestLockedPullRequestBaseRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}