//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestUnlabeledPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Public => "public",
                WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Public,
                "private" => WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Private,
                "internal" => WebhookPullRequestUnlabeledPullRequestHeadRepoVisibility.Internal,
                _ => null,
            };
        }
    }
}