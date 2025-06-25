//HintName: G.Models.WebhooksPullRequest5HeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5HeadRepoVisibility
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
    public static class WebhooksPullRequest5HeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5HeadRepoVisibility value)
        {
            return value switch
            {
                WebhooksPullRequest5HeadRepoVisibility.Public => "public",
                WebhooksPullRequest5HeadRepoVisibility.Private => "private",
                WebhooksPullRequest5HeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5HeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhooksPullRequest5HeadRepoVisibility.Public,
                "private" => WebhooksPullRequest5HeadRepoVisibility.Private,
                "internal" => WebhooksPullRequest5HeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}