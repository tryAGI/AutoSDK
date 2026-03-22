//HintName: G.Models.WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestBaseRepoVisibility
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
    public static class WebhookPullRequestUnlockedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestUnlockedPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}