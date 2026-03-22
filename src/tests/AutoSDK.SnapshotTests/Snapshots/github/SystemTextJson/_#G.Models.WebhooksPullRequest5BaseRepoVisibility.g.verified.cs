//HintName: G.Models.WebhooksPullRequest5BaseRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5BaseRepoVisibility
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
    public static class WebhooksPullRequest5BaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5BaseRepoVisibility value)
        {
            return value switch
            {
                WebhooksPullRequest5BaseRepoVisibility.Internal => "internal",
                WebhooksPullRequest5BaseRepoVisibility.Private => "private",
                WebhooksPullRequest5BaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5BaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhooksPullRequest5BaseRepoVisibility.Internal,
                "private" => WebhooksPullRequest5BaseRepoVisibility.Private,
                "public" => WebhooksPullRequest5BaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}